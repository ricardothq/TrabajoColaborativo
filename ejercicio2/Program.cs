using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string sexo;
            float altura;
            Console.WriteLine("Digite su edad: ");
            edad=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su sexo: ");
            sexo=Console.ReadLine();
            Console.WriteLine("Digite su altura: ");
            altura=float.Parse(Console.ReadLine());
            
            Console.WriteLine("Datos de la persona:");
            Console.WriteLine("Edad: "+ edad);
            Console.WriteLine("Sexo: "+ sexo);
            Console.WriteLine("Altura: "+ altura+ "cm");
            
            

        }
    }
}
