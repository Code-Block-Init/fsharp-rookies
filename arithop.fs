// Program for developing arithmethic operations
module arithop
open System
open System.Collections.Generic

[<Category("Arithmetic");
Title("Arithmetic Operations");
Description("This is an arithmetic operations program")>]
let arithop()=
let x=5+3+2
let y=2*3+5-1
let w=x%5
printfn "w=%d,x=%d,y=%d,z=%d" w x y z
