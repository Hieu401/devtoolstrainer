namespace DevToolsTrainer.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open DevToolsTrainer.Services.QuestionAnswersService
open DevToolsTrainer.Models

type TrainingController (logger : ILogger<TrainingController>) =
    inherit Controller()

    member this.Trainer (subject: string, [<FromQuery>] topics: string) =
        let questionanswers: string = "," |> topics.Split |> Seq.toList |> getSubjectQAJson
        this.View(TrainerViewModel.Create subject questionanswers)
