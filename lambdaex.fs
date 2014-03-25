// F# program for using Lambda expressions

module lambdaex
open System
open System.Collections.Generic

[<Category("lamda");
Title("Lambda expressions";
Description("Lambda Expression problem")>]

let lambdaex()=
let open a = printfn "open %d" a
let close b = printfn "close %d" b
let choose x y z a = if x a then y a else z a
for i = 0 to 10 do
choose(fun n -> n%2 = 0) open close i
