using System;
/*Hacer un programa que genere una estructura con datos del alumno
      (Matricula, nombre, apellido paterno, apellido materno, carrera,
      semestre y grupo). Declarar una variable tipo alumno, que solicite la
       información de un alumno y posteriormente la muestre.*/
public class Program
{
    public struct Alumno
    {
        public int matricula;
        public string nombre;
        public string aPaterno;
        public string aMaterno;
        public string carrera;
        public byte semestre;
        public byte grupo;

    }
    public static void Main()
    {
        Alumno al = new Alumno();
        //eNTRADA
        PedirDatosAlumno(ref al);
        //Salida
        MostrarDatosAlumno(al);
        //Pausa
        Console.WriteLine("Presiona cualquier tecla");
        Console.ReadKey();

    }
    static void PedirDatosAlumno(ref Alumno al)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("Ingresa la matricula");
        al.matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el nombre del alumno");
        al.nombre = Console.ReadLine();
        Console.WriteLine("Ingresa tu apellido paterno");
        al.aPaterno = Console.ReadLine();
        Console.WriteLine("Ingresa tu apellido materno");
        al.aMaterno = Console.ReadLine();
        Console.WriteLine("Ingresa la carrera");
        al.carrera = Console.ReadLine();
        Console.WriteLine("Ingresa el semestre");
        al.semestre = byte.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el Grupo");
        al.grupo = byte.Parse(Console.ReadLine());

    }
    static void MostrarDatosAlumno(Alumno al)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("Matricula:{0}", al.matricula);
        Console.WriteLine("Nombre:{0}", al.nombre);
        Console.WriteLine("Apellido Paterno{0} Apellido materno{1}", al.aPaterno, al.aMaterno);
        Console.WriteLine("Carrera:{0}, Semestre{1},Grupo{2}", al.carrera, al.semestre, al.grupo);

    }

}
