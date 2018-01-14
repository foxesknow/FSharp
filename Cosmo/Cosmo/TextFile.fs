module TextFile

open System
open System.IO

/// Writes a string to a file
let Write (filename : string) (text : string) =
    File.WriteAllText(filename, text)

/// Writes a sequence of lines to a file
let WriteAllLines (filename : string) (lines : seq<string>) =
    File.WriteAllLines(filename, lines)

/// Reads a file as a single string
let Read (filename : string) =
    File.ReadAllText(filename)

/// Reads all the lines of a text file in one go
let ReadAllLines (filename : string) =
    File.ReadAllLines(filename)

/// Appends text to a file if it exists, or creates the file and writes the text
let Append (filename : string) (text : string) =
    File.AppendAllText(filename, text)

/// Appends lines to a file if it exists, or creates the file and writes the lines
let AppendAllLines (filename : string) (lines : seq<string>) =
    File.AppendAllLines(filename, lines)