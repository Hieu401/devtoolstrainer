namespace DevToolsTrainer.Models

type TrainerViewModel = 
    {
        Subject: string
        Questions: string
    } with
    static member Create: string -> string -> TrainerViewModel = 
        fun (subject: string) (questions: string) -> { Subject = subject; Questions = questions }