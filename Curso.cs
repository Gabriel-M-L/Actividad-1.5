
namespace TP1_Martinez_Waserman{
    public class Curso
    {
        private Dictionary <int, Alumno> alumnos;

        public Curso()
        {
            this.alumnos = new Dictionary<int, Alumno>();
        }

        public bool agregarAlumno(int dni, string name) //gabi casi rompe todas las variables :/
        {
            bool seAgrego = false;
            if(!alumnos.ContainsKey(dni))
            {
                alumnos.Add(dni, new Alumno(name));
                seAgrego = true;
            }
            return seAgrego;
        }

        public Alumno buscarAlumno(int dni)
        {
            Alumno alumno = null;
            if(alumnos.ContainsKey(dni))
            {
                alumno = alumnos[dni];
            }
            return alumno;
        }

        public Dictionary <int, Alumno> alumnosInscriptos(){
            return alumnos;
        }

        public void cambiarFalta(int dni, Alumno alumno)
        {
            alumnos[dni] = alumno;
        }
    }
}