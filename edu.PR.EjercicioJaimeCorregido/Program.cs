namespace Ejercicio_Carlos_Mejias.controladores
{

    class Program
    {
        public static void Main(string[] args)
        {

            long[,] matriz = new long[5, 10];

            Random aleatorio = new Random();

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 31);


                }

            }
            //realizar un vector de rango 2 con 10 columas = 1 puntos.
            // introducir numeros aleatorios del 1 al 30 = 2,5 puntos.
            //No se ha mostrado por pantalla.

            List<long> listaValores = new List<long>();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    listaValores.Add(matriz[i, j]);
                }
            }
             
            // Recorrer lista con metodo for pero no mostrar por pantalla= 0,5 puntos
            
            listaValores.Sort();
            // Ordenar ascendentemente = 0,5 puntos
           
            Console.WriteLine("\nValores de la matriz ordenados de forma ascendente:");
            foreach (var valor in listaValores)
            {
                Console.Write(valor + "\t");
            }
            // Recorrer lista una vez ordenada ascendentemente con foreach = 0,5

        }

        // NOTA: 5 PUNTOS
    }
}
