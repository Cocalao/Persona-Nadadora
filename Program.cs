using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPersona3554568
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            //Instanciar a persona nadadora
            PersonaNadadora persona1 = new PersonaNadadora("Verdes", "187", "85", "V");
            Console.WriteLine("Descripción de la persona: ");
            Console.WriteLine("Ojos: " + persona1.Ojos);
            Console.WriteLine("Altura: "+persona1.Altura);
            Console.WriteLine("Peso: "+persona1.Peso);
            Console.WriteLine("Sexo: "+persona1.Sexo);
            persona1.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: "+persona1.Ojos);
            persona1.Comer(1000);
            Console.WriteLine("Mi peso actual es: " + persona1.Peso);
            persona1.Nadar();
            Console.WriteLine("Tras nadar peso: "+ persona1.Peso);


            Console.ReadKey();
        }
    }
}
