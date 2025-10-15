public class Calificacion : IMostrable
{
    private ClaseEstudiante estudiante;
    private Materia materia;
    private double nota;

    public ClaseEstudiante Estudiante
    {
        get => estudiante;
        set => estudiante = value ?? throw new ArgumentException("Estudiante no puede ser nulo");
    }

    public Materia Materia
    {
        get => materia;
        set => materia = value ?? throw new ArgumentException("Materia no puede ser nula");
    }

    public double Nota
    {
        get => nota;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Nota debe estar entre 0 y 100");
            nota = value;
        }
    }

    public Calificacion(ClaseEstudiante estudiante, Materia materia, double nota)
    {
        Estudiante = estudiante;
        Materia = materia;
        Nota = nota;
    }

    public double CalcularPuntos()
    {
        return Nota * Materia.Creditos;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Calificación -> Estudiante: {Estudiante.Nombre}, Materia: {Materia.Nombre}, Nota: {Nota}");
        Console.WriteLine("------------------------------------------");
    }
}