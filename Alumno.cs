namespace TP1_Martinez_Waserman
{
    public class Alumno
    {
        private string name;
        private double cantFaltas;

        public Alumno (string name)
        {
            this.name = name;
            this.cantFaltas = 0;
        } 

        public string toString(){
            return "Nombre: " + name + ".\n Cantidad de faltas: " + cantFaltas + ".";
        }

        public void sumarFalta(double falta){
            cantFaltas += falta;
        }

        public bool estoyLibre(){
            return cantFaltas>15;
        }
    }
}