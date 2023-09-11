namespace DevToolsTrainer.Services

open System.IO
open FSharp.Json
open DevToolsTrainer.QuestionAnswers

module QuestionAnswersService =

    type JsonString = string

    let selectTopic: string -> Option<List<string>> = fun (selection: string) ->
        match selection with
        | "docker" -> Some ["docker file"; "image build"; "image repository"; "image info"; "container info"; "containers"; "networking"; "storage"; "docker compose"; "docker compose yaml";  "swarm"]
        | "git" -> Some ["create repository"; "git info"; "branch"; "commit"; "remote"]
        | "bash" -> None
        | "powershell" -> None
        | "vim" -> None
        | "nginx" -> Some ["nginx directives"; "nginx commands"]
        | _ -> None

    let getSubjectQA: string -> Option<string> = fun (subject: string) ->
        match subject with
        | "container info" -> Some containerInfo
        | "containers" -> Some containers
        | "image build" -> Some imageBuild
        | "image repository" -> Some imageRepository
        | "image info" -> Some imageInfo
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
        | "nginx basic directives" -> Some nginxBasicDirectives
        | "nginx commands" -> Some nginxCommands
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


