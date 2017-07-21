module ast
type Operator = Add | Sub | Mul | Div
type Expr = 
    Binop of Expr * Operator * Expr
    |Int of int 
    |Seq of Expr * Expr
    |Asn of int * Expr
    |Var of int