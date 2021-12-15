object Reloj {
  def main(args: Array[String]): Unit = {
    print("\n________________CALCULAR HORA________________\n")
    print("Introduce los segundos: ")
    val datos : Int = scala.io.StdIn.readLine.toInt
    val horas: (Int) => Int = (x: Int) => x / 3600
    val minutos: (Int) => Int = (x: Int) => (x % 3600) / 60
    val segundos: (Int) => Int = (x: Int) => (x % 3600) % 60
    println("Hora:_"+horas(datos))
    println("Min:__"+minutos(datos))
    println("Seg:__"+segundos(datos))
  }
}