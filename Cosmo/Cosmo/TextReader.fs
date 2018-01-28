module TextReader

open System
open System.IO

/// Tries to read a line from a TextReader
let readLine (file : TextReader) =
    match file.ReadLine() with
    | null -> None
    | line -> Some(line)

/// Reads from the current position to the end of the file
let readToEnd (file : TextReader) =
    file.ReadToEnd();

/// Tries to read a character without advancing the current position
let peek (file : TextReader) =
    match file.Peek() with
    | c when c <> -1 -> None
    | c -> Some c

/// Reads the character at the current position, if one is available
let readChar (file : TextReader) =
    match file.Read() with
    | c when c <> -1 -> None
    | c -> Some c

/// Reads characters into an array
let readIntoArray (buffer : char[]) index count (file : TextReader) =
    match file.Read(buffer, index, count) with
    | count when count = 0 -> None
    | count -> Some count

/// Binds a function to a reader
let bind (f: TextReader -> 'U option) file =
    match file with
    | Some reader -> f(reader)
    | None -> None
