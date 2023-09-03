namespace DevToolsTrainer.Models

type SubjectsViewModel = 
    {
        Subject: string
        Topics: List<string>
    } with
    static member Create: string -> List<string> -> SubjectsViewModel = 
        fun (subject: string) (topics: List<string>) -> { Subject = subject; Topics = topics }