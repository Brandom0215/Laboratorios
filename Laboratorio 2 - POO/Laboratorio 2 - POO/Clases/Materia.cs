
public class Materia : IMostrable
{
    private string nombre;
    private string codigo;
    private int creditos;
    private int cupos;
    private int inscritos;

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentException("EL nombre no puede ser nulo");
    }

    public string Codigo
    {
        get => codigo;
        set => codigo = value ?? throw new ArgumentException("El c�digo no puede ser nulo");
    }

    public int Creditos
    {
        get => creditos;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Los cr�ditos deben ser mayores que 0");
            creditos = value;
        }
    }

    public int Cupos
    {
        get => cupos;
        set
        {
            if (value < 0)
                throw new ArgumentException("Los cupos no pueden ser negativos");
            cupos = value;
        }
    }

    public int Inscritos
    {
        get => inscritos;
        set
        {
            if (value < 0 || value > Cupos)
                throw new ArgumentException("Los inscritos debe ser >=0 y <= Cupos");
            inscritos = value;
        }
    }

    public Materia(string nombre, string codigo, int creditos, int cupos = 0, int inscritos = 0)
    {
        Nombre = nombre;
        Codigo = codigo;
        Creditos = creditos;
        Cupos = cupos;
        Inscritos = inscritos;
    }

    public int CalcularCargaSemanal(int horasPorCredito)
    {
        return Creditos * horasPorCredito;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"\nMateria: {Nombre} ({Codigo})");
        Console.WriteLine($"Cr�ditos: {Creditos} | Cupos: {Cupos} | Inscritos: {Inscritos}");

    }
}