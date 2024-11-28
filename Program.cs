namespace CalculadoraDescuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;
            while (continuar)
            {

                decimal precioOriginal = 0;
                decimal porcentajeDescuento = 0;


                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el precio original del producto: ");
                        precioOriginal = Convert.ToDecimal(Console.ReadLine());
                        if (precioOriginal <= 0)
                        {

                            throw new Exception("El precio debe ser mayor a 0");
                        }
                        break;

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }


                while (true)
                {

                    try
                    {

                        Console.WriteLine("Ingrese el porcentaje de descuento: ");
                        porcentajeDescuento = Convert.ToDecimal(Console.ReadLine());
                        if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                        {
                            throw new Exception("El porcentaje debe estar entre 0 y 100");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }


                //Cálcular el monto del descuento y precio final
                decimal montoDescuento = (precioOriginal * porcentajeDescuento) / 100;
                decimal precioFinal = precioOriginal - montoDescuento;


                //Mostrar el precio final y el monto de descuento
                Console.WriteLine($"Monto del descuento: {montoDescuento}E");
                Console.WriteLine($"Precio final después del descuento: {precioFinal}E");


                //Válidad si quiere continuar con otro producto
                Console.WriteLine("Quieres cálcular el descuento para otro producto? (s/n)");
                string respuesta = Console.ReadLine().ToLower();
                continuar = respuesta == "s";


            }






        }
    }
}
