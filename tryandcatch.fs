//F# program for implementing try and catch statements

module tryandcatch
open System
open System.Collections.Generic

[<Category("TryCatch");
Title("TryCatch statements");
Description("Implementing try and catch statements")>]

let tryandcatch()=
try
printfn "About to punch her face..."
failwith "Wow"
with
Failure msg ->
printfn "Punched her face!, msg='%s'" msg
