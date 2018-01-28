module TextWriter

open System
open System.IO

/// Writes a value
let inline write (value : ^a) (writer : System.IO.TextWriter) =
    writer.Write(value);
    writer

/// Writes a value followed by a newline
let inline writeLine (value : ^a) (writer : System.IO.TextWriter) =
    writer.WriteLine(value);
    writer

/// Writes a newline
let newline (writer : System.IO.TextWriter) =
    writer.WriteLine();
    writer

