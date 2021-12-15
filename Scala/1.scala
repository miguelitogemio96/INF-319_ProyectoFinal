object ListaPares {
  def main(args: Array[String]): Unit = {
    print("\n______________Lista de Pares________________\n")
    print("Introduce la lista en formato: '1 2,3 4,5 6,7 8'\n> ")
    val cad : String = scala.io.StdIn.readLine
    val alist : Array[String] = cad.split(',')
    var res : Array[Int] = Array()
    var a : Int = 0
    var b : Int = 0
    for ( m1 <-alist )
        {
            var num = m1.split(' ')
            a = num(0).toInt
            b = num(1).toInt
            res = res :+ (a+b)
        }
    print("[ ")
    for ( x <- res ) 
    {
      print(x+" ")
    }
    print("]")

  }
}