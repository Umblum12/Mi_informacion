using System;

namespace Mi_informacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarado de variables
            string nombre;
            string apellido_paterno;
            string apellido_materno;
            int edad;
            string sexo;

            //Colocar el procedimiento
            nombre = "Abelardo";
            apellido_paterno = "Cruz";
            apellido_materno = "Leos";
            sexo = "Masculino";
            edad = 19;
            //Imprimir en pantalla el resultado
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Tu nombre completo es: " + nombre + " " + apellido_paterno + " " + apellido_materno);
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu apellido paterno es: " + apellido_paterno);
            Console.WriteLine("Tu apellido materno es: " + apellido_materno);
            Console.WriteLine("Tu sexo es: " + sexo);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey(true);
        }
    }
}
