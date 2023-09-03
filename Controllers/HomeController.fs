namespace DevToolsTrainer.Controllers

open System
open System.IO
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Diagnostics

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

open DevToolsTrainer.Models
open DevToolsTrainer.Services.QuestionAnswersService

type HomeController (logger : ILogger<HomeController>) =
    inherit Controller()

    member this.Index () =
        this.View()

    member this.Subjects (subject: string) =
        match subject |> selectTopic with
        | Some topics -> this.View(SubjectsViewModel.Create subject topics)
        | None -> this.Error()

    [<ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)>]
    member this.Error () =
        let reqId = 
            if isNull Activity.Current then
                this.HttpContext.TraceIdentifier
            else
                Activity.Current.Id

        this.View({ RequestId = reqId })
