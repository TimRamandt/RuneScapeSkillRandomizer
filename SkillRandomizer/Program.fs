﻿open System

// Learn more about F# at http://fsharp.org

//F# try-outs, references to later course
//open System

//let Greeting greeting name = greeting + " from " + name

//[<EntryPoint>]
//let main argv =
//    Greeting "Hello" "Tim" |> printfn "%s"

//    Console.ReadKey()
//    0 // return an integer exit code

[<EntryPoint>]
let main argv = 
    printfn "Bored on RuneScape? This commandline app will determine what skill you should train next."
    Console.ReadKey()
    0
