namespace TP1_Martinez_Waserman{
    public class Curso
    {
        List<Alumno> alumnos;

        public Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public bool agregarAlumno(int dni, string name) //gabi casi rompe todas las variables :/
        {
            bool seAgrego = false;
            Alumno alumno = buscarAlumno(dni);
            if(alumno == null)
            {
                alumnos.Add(new Alumno(dni, name));
                seAgrego = true;
            }
            return seAgrego;
        }
        
        public Alumno buscarAlumno(int dni)
        {
            Alumno alumno = null;
            int i = 0;
            while (i < alumnos.Count && !alumnos[i].compDni(dni))
            {
                i++;
            }
            if (i < alumnos.Count)
                alumno = alumnos[i];
            return alumno;
        }
    }
}