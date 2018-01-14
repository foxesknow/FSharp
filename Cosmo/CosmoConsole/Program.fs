// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Cosmo;
open FSharp.Core;

[<EntryPoint>]
let main argv = 
    [ "hello"; "world"] |> TextFile.WriteAllLines "f:\\code\\test.txt"
    0 // return an integer exit code
