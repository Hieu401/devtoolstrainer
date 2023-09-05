namespace DevToolsTrainer

#nowarn "20"


open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.HttpOverrides;
open Microsoft.Extensions.Hosting

module Program =

    type routeDefault = { controller: string; action: string }

    let exitCode = 0

    [<EntryPoint>]
    let main args =
        let builder = WebApplication.CreateBuilder(args)

        builder
            .Services
            .AddControllersWithViews()
            .AddRazorRuntimeCompilation()

        builder.Services.AddRazorPages()
        builder.Services.Configure<ForwardedHeadersOptions>(
            fun (options: ForwardedHeadersOptions) -> 
                options.ForwardedHeaders <- ForwardedHeaders.XForwardedFor ||| ForwardedHeaders.XForwardedProto
        )

        let app = builder.Build()

        if not (builder.Environment.IsDevelopment()) then
            app.UseForwardedHeaders()
            app.UseExceptionHandler("/Home/Error")
            app.UseHsts() |> ignore // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

        app.UseForwardedHeaders()    

        app.UseHttpsRedirection()

        app.UseStaticFiles()
        app.UseRouting()
        app.UseAuthorization()

        app.MapControllerRoute(name = "default", pattern = "{controller=Home}/{action=Index}/{subject?}")

        app.MapRazorPages()

        app.Run()

        exitCode
