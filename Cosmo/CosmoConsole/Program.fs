// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Cosmo;
open FSharp.Core;

let processFile filename =  
    filename |> TextFile.openRead (fun reader ->
        let rec readLoop reader =
            match TextReader.readLine reader with
            | Some line ->
                printfn "%s" line
                readLoop reader
            | None -> None

        readLoop reader
    )

let prinfFile filename =
    filename |> TextFile.readAllText |> printfn "%s"

let writeSomeText =
    "f:\\code\\test2.txt"
    |> TextFile.openWrite (fun writer ->
            writer
            |> TextWriter.writeLine "hello"
            |> TextWriter.writeLine "world"
            |> ignore
       )

[<EntryPoint>]
let main argv = 
    //[ "hello"; "world"] |> TextFile.writeAllLines "f:\\code\\test.txt"
    //let values = Array.zeroCreate<char>(10)
    //processFile "f:\\code\\test.txt" |> ignore
    writeSomeText
    0 // return an integer exit code
