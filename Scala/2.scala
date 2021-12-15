object ListaInversa {
  def main(args: Array[String]): Unit = {
    print("\n______________Lista de Pares________________\n")
    print("Introduce la lista en formato: '1,2,3,4,5,6,7,8'\n> ")
    val cad : String = scala.io.StdIn.readLine
    val alist : Array[String] = cad.split(',')
    var res : Array[Int] = Array()
    for ( m1 <-alist )
        {
            res = m1.toInt +: res
        }
    print("[ ")
    for ( x <- res ) 
    {
      print(x+" ")
    }
    print("]")


  }
}