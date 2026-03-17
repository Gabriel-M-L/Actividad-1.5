// See https://aka.ms/new-console-template for more information
namespace tp0;

class Program
{
    static void Main(string[] args)
    {
        List<string> opciones = new List<string>(){"Agregar alumno.", "Buscar alumno por su DNI.", "Agregar falta.", "Mostrar alumnos.", "Mostrar alumons libres", "Salir."};
        int cantidadOpciones = opciones.Count;
            int opcionElegida;
            int nSeleccionado = 0;
        
            do
            {
                
                MostrarMenu(opciones, nSeleccionado, "");
                opcionElegida = PedirOpcionNum(cantidadOpciones, "Seleccione una opción: ");
                ejecutarOpcion(opciones, opcionElegida, cantidadOpciones); 
            }while(opcionElegida != cantidadOpciones);
    }
    private static void ejecutarOpcion(List<string> opciones, int nElegido, int cantidadOpciones)
        {
            if (nElegido != cantidadOpciones)
            {
                Console.WriteLine("\nla opcion elegida fue " + opciones[nElegido - 1]);

                int ID;
                switch(nElegido)
                {
                    
                    case 1:
                    
                    break;

                    case 2:
                    break;

                    case 3:
                    break;

                    case 4:             
                    break;

                    case 5:
                    break;
                }
            }
        }
    private static int PedirOpcionNum(int cantidadOpciones, string v)
        {
            int numero = ingresarInt(v);
            while (numero < 1 || numero>cantidadOpciones) 
            {
                Console.WriteLine("Ingrese los datos correctamente.");
                numero = ingresarInt(v);
            }
            return numero;
        }
    private static int ingresarInt(string v)
        {
            Console.Write(v);
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
         private static double ingresarDouble(string v)
        {
            Console.Write(v);
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }
        private static string ingresarString(string v)
        {
            Console.Write(v);
            string texto = Console.ReadLine().ToLower();
            while(texto != "bicicleta" && texto!="monopatin")
            {
                Console.WriteLine("Ingrese los datos correctamente.");
                Console.WriteLine(v);
                texto = Console.ReadLine().ToLower();
            }
            return texto;
        }
     private static void MostrarMenu(List<string> opciones, int nSeleccionado, string v)
        {
            Console.WriteLine();
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine((i + 1)+ ".   " + opciones[i]);
            }
            Console.WriteLine(v);
        }
}
