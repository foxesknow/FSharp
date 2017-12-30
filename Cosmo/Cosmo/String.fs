module Cosmo.String

open System.Text

/// Spit a string
let Split (separator : char) (text : string) =
    text.Split [| separator |] |> Array.toList 

/// Join a sequence of strings
let Join (separator : string) (strings : string seq) =
    System.String.Join (separator, Seq.toArray strings)

/// Determines if a string is null or empty
let IsNullOrEmpty text =
    System.String.IsNullOrEmpty text

/// Determines if a string is null or whitespace
let IsNullOrWhiteSpace text =
    System.String.IsNullOrWhiteSpace text

/// Converts a string to lower case
let ToLower (text : string) =
    text.ToLower()

/// Converts a string to upper case
let ToUpper (text : string) =
    text.ToUpper()

/// Trims excess whitespace
let Trim (text : string) =
    text.Trim()