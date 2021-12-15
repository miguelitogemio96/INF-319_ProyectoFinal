object Bisiesto {
  def main(args: Array[String]): Unit = {
    print("\n________________Bisiesto________________\n")
    print("Introduzca el año: ")
    val año : Int = scala.io.StdIn.readLine.toInt
    print(esBisiesto(año))
  }

  def esBisiesto(x:Int) = {
    if((x%4==0 && x%100 != 0) || x % 400 ==0) "Es Bisiesto" else "No es Bisiesto"
  }
}