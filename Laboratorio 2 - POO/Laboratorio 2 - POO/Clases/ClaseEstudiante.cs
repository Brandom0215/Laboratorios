
public class ClaseEstudiante : IMostrable
    {
    private string nombre;
    private string id;
    private string carrera;
    private List<Calificacion> calificaciones = new List<Calificacion>();

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentException("EL ombre no puede ser nulo");
    }

    public string Id
    {
        get => id;
        set => id = value ?? throw new ArgumentException("El id no puede ser nulo");
    }

    public string Carrera
    {
        get => carrera;
        set => carrera = value ?? throw new ArgumentException("La carrera no puede ser nula");
    }

    public List<Calificacion> Calificaciones => calificaciones;

    public ClaseEstudiante(string nombre, string id, string carrera)
    {
        Nombre = nombre;
        Id = id;
        Carrera = carrera;
    }

    public ClaseEstudiante() { }

    public double CalcularPromedio()
    {
        if (Calificaciones.Count == 0)
            return 0;

        double sumaPonderada = 0;
        int sumaCreditos = 0;

        foreach (var c in Calificaciones)
        {
            sumaPonderada += c.Nota * c.Materia.Creditos;
            sumaCreditos += c.Materia.Creditos;
        }

        return sumaCreditos == 0 ? 0 : sumaPonderada / sumaCreditos;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"\nEstudiante: {Nombre} | ID: {Id} | Carrera: {Carrera}");
        Console.WriteLine($"Promedio: {CalcularPromedio():F2}");

    }

}

