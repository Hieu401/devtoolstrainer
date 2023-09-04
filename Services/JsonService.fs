namespace DevToolsTrainer.Services

open System.IO
open FSharp.Json
open DevToolsTrainer.QuestionAnswers

module QuestionAnswersService =

    type JsonString = string

    let selectTopic: string -> Option<List<string>> = fun (selection: string) ->
        match selection with
        | "docker" -> Some ["container info"; "containers"; "images"; "networking"; "storage"; "docker compose"; "docker compose yaml"; "docker file"; "swarm"]
        | "git" -> Some ["create repository"; "git info"; "branch"; "commit"; "remote"]
        | "bash" -> None
        | "powershell" -> None
        | "vim" -> None
        | _ -> None

    let getSubjectQA: string -> Option<string> = fun (subject: string) ->
        match subject with
        | "container info" -> Some containerInfo
        | "containers" -> Some containers
        | "images" -> Some images
        | "networking" -> Some networking
        | "docker compose" -> Some dockerCompose
        | "docker compose yaml" -> Some dockerComposeYaml
        | "docker file" -> Some dockerFile
        | "swarm" -> Some swarm
        | "storage" -> Some storage
        | "create repository" -> Some createrepo
        | "git info" -> Some gitInfo
        | "branch" -> Some branch
        | "commit" -> Some commit
        | "remote" -> Some remote
        | _ -> None

    let getSubjectQAs: List<string> -> List<Option<string>> =
        (List.map getSubjectQA)

    let unwrapOptionFilter: List<Option<'a>> -> List<'a> =
        List.fold (fun (s: List<'a>) (e: Option<'a>) -> 
            match e with
            | Some element -> element::s
            | None -> s    
        ) []

    let deserializeSubjectQAs: List<string> -> List<List<obj>> = 
        let config = JsonConfig.create(allowUntyped = true) 
        List.map (Json.deserializeEx config)

    let composeSubjectQAs: List<List<obj>> -> List<obj> =
        (List.fold (fun (s: List<obj>) (e: List<obj>) -> e @ s) [])

    let getSubjectQAJson: List<string> -> string =
        getSubjectQAs >> unwrapOptionFilter >> deserializeSubjectQAs >> composeSubjectQAs >> Json.serialize


