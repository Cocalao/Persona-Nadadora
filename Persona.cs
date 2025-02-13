using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPersona3554568
{
    public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo) 
        {
            this.Ojos=ojos;
            this.Altura=altura;
            this.Peso=peso;
            this.Sexo=sexo;
        }
        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;

        //Acciones
        public void Hablar(string texto)
        {
            //Se muestra la conversación a decir
            Console.WriteLine("Voy a decir:" + texto);
        }
        public void Comer(double calorias)
        {
            //Se indican las calorias que gana al comer
            Console.WriteLine("Ganando" + calorias + "calorias");
            this.Peso += calorias / 1000;
        }
        public void Correr(double calorias)
        {
            //Se indica las calorias que se pierde al comer
            Console.WriteLine("Perdiendo" + calorias + "calorias");
            this.Peso = Convert.ToString(calorias / 1000);
        }
    }
}
