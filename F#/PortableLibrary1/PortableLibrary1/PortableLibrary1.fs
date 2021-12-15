namespace PortableLibrary1

type Class1() = 
    member this.X = "F#"


module mimodulo=
    let suma10 x = x + 10
    let suma2 x y = x + y

module ejercicio1 = 
    let sumar (numeros : string array) = ( Array.get numeros 0 |> int) + ( Array.get numeros 1 |> int)
    let sumPares (lista : string array) = 
        let res = [| for i in 0 .. lista.Length - 1 -> sumar ((Array.get lista i).Split [|' '|]) |]
        res


module ejercicio2 = 
    let inversa (lista : string array) = 
        let res = [| for i in 0 .. lista.Length - 1 -> (Array.get lista (lista.Length - 1 - i)) |]
        res
        
module ejercicio3 =
    let horas seg = seg / 3600
    let minutos seg = (seg % 3600) / 60
    let segundos seg = (seg % 3600) % 60

module ejercicio4 =
    let esBiciesto anio = 
        if (anio % 4 = 0) && ((anio % 100 <> 0) || (anio % 400 = 0)) then "Es Bisiesto"
        else "No es Bisiesto"