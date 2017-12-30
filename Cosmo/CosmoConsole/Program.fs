// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Cosmo.String;

[<EntryPoint>]
let main argv = 
    let greeting = [| "hello"; "world    "|] |> Join "," |> Trim
    printfn "%A" greeting
    0 // return an integer exit code
