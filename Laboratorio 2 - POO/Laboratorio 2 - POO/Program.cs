
public class Program 
{
    public static void Main()
    {
        // Crear materias
        var m1 = new Materia("Programación", "INF101", 4, 30, 25);
        var m2 = new Materia("Matemáticas", "MAT202", 3, 40, 35);
        var m3 = new Materia("Física", "FIS303", 2, 25, 20);

        // Crear estudiantes
        var e1 = new ClaseEstudiante("Carlos Pérez", "E001", "Ingeniería");
        var e2 = new ClaseEstudiante("Ana Torres", "E002", "Matemáticas");
        var eb1 = new EstudianteBecado("Lucía Gómez", "E003", "Física", 50);

        // Crear calificaciones
        var c1 = new Calificacion(e1, m1, 90);
        var c2 = new Calificacion(e1, m2, 80);
        var c3 = new Calificacion(eb1, m3, 95);

        // Asignar calificaciones a estudiantes
        e1.Calificaciones.AddRange(new[] { c1, c2 });
        eb1.Calificaciones.Add(c3);

        // Polimorfismo
        List<IMostrable> items = new List<IMostrable>
        {
            e1, e2, eb1,
            m1, m2, m3,
            c1, c2, c3
        };

        Console.WriteLine("===== DEMOSTRACIÓN POLIMORFISMO =====");
        foreach (IMostrable i in items)
            i.MostrarDatos();

        Console.WriteLine("===== OPERACIONES ARITMÉTICAS =====");

        double promedio = e1.CalcularPromedio();
        Console.WriteLine($"Promedio de {e1.Nombre}: {promedio:F2}");

        int cargaSemanal = m1.CalcularCargaSemanal(3);
        Console.WriteLine($"Carga semanal de {m1.Nombre}: {cargaSemanal} horas");

        double puntos = c1.CalcularPuntos();
        Console.WriteLine($"Puntos obtenidos por {c1.Estudiante.Nombre} en {c1.Materia.Nombre}: {puntos:F2}");

        double matriculaDescuento = eb1.CalcularMatriculaConDescuento(2000);
        Console.WriteLine($"Matrícula con descuento ({eb1.PorcentajeBeca}%): {matriculaDescuento:F2}");
    }
}