public class Program
{
    public static void Main()
    {
        // Materias
        var M1 = new Materia("Programación", "INF101", 4, 30, 25);
        var M2 = new Materia("Matemáticas", "MAT202", 3, 40, 35);
        var M3 = new Materia("Física", "FIS303", 2, 25, 20);

        // Estudiantes
        var E1 = new Estudiante("Carlos Pérez", "E001", "Ingeniería");
        var E2= new Estudiante("Ana Torres", "E002", "Matemáticas");
        var EB1 = new EstudianteBecado("Lucía Gómez", "E003", "Física", 50);

        //Calificaciones
        var C1 = new Calificacion(E1, M1, 90);
        var C2 = new Calificacion(E1, M2, 80);
        var C3 = new Calificacion(EB1, M3, 95);

        // Asignacion de las calificaciones a los estudiantes
        e1.Calificaciones.AddRange(new[] { C1, C2 });
        eb1.Calificaciones.Add(C3);

        // Polimorfismo
        List<IMostrable> items = new List<IMostrable>
        {
            E1, E2, EB1,
            M1, M2, M3,
            C1, C2, C3
        };

        Console.WriteLine("Polimorfismo");
        foreach (IMostrable i in items)
            i.MostrarDatos();

        Console.WriteLine("Operaciones Aritmeticas");

        double promedio = E1.CalcularPromedio();
        Console.WriteLine($"Promedio de {E1.Nombre}: {promedio:F2}");

        int cargaSemanal = M1.CalcularCargaSemanal(3);
        Console.WriteLine($"Carga semanal de {M1.Nombre}: {cargaSemanal} horas");

        double puntos = C1.CalcularPuntos();
        Console.WriteLine($"Puntos obtenidos por {C1.Estudiante.Nombre} en {C1.Materia.Nombre}: {puntos:F2}");

        double matriculaDescuento = EB1.CalcularMatriculaConDescuento(2000);
        Console.WriteLine($"Matrícula con descuento ({EB1.PorcentajeBeca}%): {matriculaDescuento:F2}");
    }
}