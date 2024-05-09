namespace CalcularNumerosSumaProducto.Clase
{

    public class CuatroNumerosSumaProducto
    {
        public void NumerosSumaProducto()
        {

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            decimal suma = 0;
            decimal producto = 0;

            try
            {
                Console.WriteLine("Ingrese su primer numero aqui: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su segundo numero aqui: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su tercer numero aqui: ");
                num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su cuarto numero aqui: ");
                num4 = int.Parse(Console.ReadLine());

                suma = (num1 + num2);
                producto = (num3 * num4);

                Console.WriteLine($"El resultado de la suma de su primer y segundo numero es: {suma}");
                Console.WriteLine($"El producto de su tercer y cuarto numero es: {producto}");

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido un error inesperado {ex.Message}");
            }



        }
    }
}

