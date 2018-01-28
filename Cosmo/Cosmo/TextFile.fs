module TextFile

open System
open System.IO

/// Writes a string to a file
let writeAllTest (filename : string) (text : string) =
    File.WriteAllText(filename, text)

/// Writes a sequence of lines to a file
let writeAllLines (filename : string) (lines : seq<string>) =
    File.WriteAllLines(filename, lines)

/// Reads a file as a single string
let readAllText (filename : string) =
    File.ReadAllText(filename)

/// Reads all the lines of a text file in one go
let readAllLines (filename : string) =
    File.ReadAllLines(filename)

/// Appends text to a file if it exists, or creates the file and writes the text
let appendAllText (filename : string) (text : string) =
    File.AppendAllText(filename, text)

/// Appends lines to a file if it exists, or creates the file and writes the lines
let appendAllLines (filename : string) (lines : seq<string>) =
    File.AppendAllLines(filename, lines)

/// Binds a function to a filename for reading
let openRead (f : System.IO.TextReader -> 'U option) filename =
    try
        use stream = File.OpenRead(filename)
        use reader = new StreamReader(stream)
        f(reader)
    with
        | _ -> None

/// Opens or creates a file for writing to
let openWrite (f : System.IO.TextWriter -> unit ) filename =
    use stream = File.OpenWrite(filename)
    use writer = new StreamWriter(stream)
    f(writer)