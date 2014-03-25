// F# program for implementing floating point operations

module floatarith
open System
open System.Collections.Generic

[<Category("Floating");
Title("Floating point");
Description("Floating point mathematical operations program")>]

let floatarith()=
let a=5.23+0.78-1.01
let b=5.30+1.70-2*4/10
printfn "a=%g,b=%g" a b
