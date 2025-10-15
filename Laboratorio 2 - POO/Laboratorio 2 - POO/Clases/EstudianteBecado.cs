
public class EstudianteBecado : ClaseEstudiante
{
    private double porcentajeBeca;

    public double PorcentajeBeca
    {
        get => porcentajeBeca;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Porcentaje de beca debe estar entre 0 y 100");
            porcentajeBeca = value;
        }
    }

    public EstudianteBecado(string nombre, string id, string carrera, double porcentajeBeca)
        : base(nombre, id, carrera)
    {
        PorcentajeBeca = porcentajeBeca;
    }

    public double CalcularMatriculaConDescuento(double matriculaBase)
    {
        return matriculaBase * (1 - (PorcentajeBeca / 100.0));
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Beca: {PorcentajeBeca}%");
        Console.WriteLine("------------------------------------------");
    }
}