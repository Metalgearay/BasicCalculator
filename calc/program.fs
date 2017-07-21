module program
open ast
open Microsoft.FSharp.Text.Lexing
let array1 : int array= Array.zeroCreate 10

let rec eval = function
Int(x) -> x
|Var(v) -> array1.[v]
|Asn (v,e) -> array1.[v] <- eval e; array1.[v]
|Seq(e1,e2) -> ignore (eval e1); eval e2
|Binop(e1,op,e2) ->
        match op with
        Add -> eval e1+eval e2
        |Sub -> eval e1-eval e2
        |Mul -> eval e1*eval e2
        |Div -> eval e1/eval e2            
in
let _ =
        let lexbuf = LexBuffer<char>.FromString(System.Console.ReadLine())
        let expr = Parser.Expr lexer.token lexbuf
        let result = eval expr in
        System.Console.WriteLine(result.ToString())

       

   

  