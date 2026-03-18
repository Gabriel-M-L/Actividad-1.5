namespace TP1_Martinez_Waserman
{
    public class Alumno
    {
        private int dni;
        private string name;
        private double cantFaltas;

        public Alumno (int dni, string name)
        {
            this.dni = dni;
            this.name = name;
            this.cantFaltas = 0;
        } 
        public bool compDni(int dni){
            return this.dni == dni;
        }

        public string toString(){
            return "Nombre: " + name + ".\n DNI: " + dni + ". \n Cantidad de faltas: " + cantFaltas + ".";
        }

        public void sumarFalta(double falta){
            cantFaltas += falta;
        }

        public bool estoyLibre(){
            return cantFaltas>15;
        }

        public int getDni()
        {
            return dni;
        }

    }
}