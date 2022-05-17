// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.
//YURIKA MACUSAYA AGUILAR CI:13846755LP PREGUNTA 6
// Define a function to construct a message to print
open System
let from whom =
    sprintf "from %s" whom
let sampleSum x y =  x + y
let sampleDif x y =  x - y
let samplePro x y =  x * y
let sampleDiv x y =  x / y

[<EntryPoint>]

let main argv =
    let message = from "F#" // Call the function
    Console.WriteLine("introduzca 2 numeros : ")
    let a  = Convert.ToInt32(Console.ReadLine()) 
    let b  = Convert.ToInt32(Console.ReadLine())
    let sum  = sampleSum a b
    let dif = sampleDif a b 
    let pro = samplePro a b
    let div = sampleDiv a b

    printfn "result of sum     : %d" (sum)
    printfn "result of rest    : %d" (dif)
    printfn "result of product : %d" (pro)
    printfn "result of div     : %d" (div)
    
    let tecla = Console.ReadKey()
    0 // return an integer exit code
    
