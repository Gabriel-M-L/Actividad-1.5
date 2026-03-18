// See https://aka.ms/new-console-template for more information
namespace TP1_Martinez_Waserman;
//nunca confiar en un comando de gabi 
//nunca
class Program
{
    static Curso curso = new Curso();
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

                int dni;
                string name; //gabi no me dejaba q este en ingles
                double falta;
                Alumno alumno;
                switch(nElegido)
                {
                    
                    case 1:
                    dni = ingresarInt("Ingrese el DNI del nuevo alumno: ");
                    name = ingresarString("Ingrese el nombre del nuevo alumno: ");
                    if (curso.agregarAlumno(dni, name)){
                        Console.WriteLine("Se agrego el alumno correctamente.");
                    }
                    else {
                        Console.WriteLine("Ese alumno ya exite.");
                    }
                    break;

                    case 2:
                    dni = ingresarInt("Ingrese el DNI del alumno que esta buscando: ");
                    alumno = curso.buscarAlumno(dni);
                    if (alumno != null){
                        Console.WriteLine(alumno.toString());
                    }
                    else{
                        Console.WriteLine("Ese alumno no existe.");
                    }
                    break;

                    case 3:
                    dni = ingresarInt("Ingrese el DNI del alumno que falto: ");
                    alumno = curso.buscarAlumno(dni);
                    if(alumno != null){
                        falta = ingresarDouble("Ingrese la cantidad de faltas(1 o 0,5): ", 1, 0.5);
                        alumno.sumarFalta(falta);
                        curso.cambiarFalta(alumno);
                        Console.WriteLine("Se sumaron las faltas correctamente.");
                    }
                    else{
                        Console.WriteLine("Ese alumno no existe.");
                    }
                    break;

                    case 4:  
                    foreach(Alumno alumno0 in curso.alumnosInscriptos()){
                        Console.WriteLine(alumno0.toString());
                    }           
                    break;

                    case 5:
                    foreach(Alumno alumno0 in curso.alumnosInscriptos()){
                        if(alumno0.estoyLibre()){
                            Console.WriteLine(alumno0.toString());
                        }
                    } 
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
         private static double ingresarDouble(string v, double n1, double n2)
        {
            Console.Write(v);
            double numero = double.Parse(Console.ReadLine());
            while(numero != n1 && numero != n2){
                Console.WriteLine("ingrese los datos correctamente");
                Console.Write(v);
                numero = double.Parse(Console.ReadLine());
            }
            return numero;
        }
        private static string ingresarString(string v)
        {
            Console.Write(v);
            string texto = Console.ReadLine().ToUpper();
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
//probablemente tambien deberia poner el resto de variables en ingles pero bueno