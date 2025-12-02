using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONA__Problema_4._4_
{
    internal class Persona
    {
        //ATRIBUTOS
        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        //PROPIEDADES 
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
        public double Peso { get {return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }

        //CONSTRUCTOR sin PARAMETROS 
        public Persona()
        { 
        }


        //METODO OVERRIDE STRING TOSTRING
        public override string ToString()
        {
            return
                $"Nombre: {Nombre}" + "\n" +
                $"Edad: {Edad}" + "\n" +
                $"Sexo: {Sexo}" + "\n" +
                $"Peso: {Peso}" + "\n" +
                $"Altura: {Altura}";
        }

        //--------------------------METODOS PARA RESOLVER EL EJERCICIO------------------------------//
        //calcular el peso ideal
        public double CalcularIMC(double a , double b)
        {
            double pesoIdeal = a / Math.Pow(b, 2);

            if (pesoIdeal < 20)
            {
                return -1;
            }
            else if (pesoIdeal >= 20 && pesoIdeal <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //conocer si es mayor o menor de edad
        public string EsMayorDeEdad(int a)
        {
            if (a >= 21)
            { return "Es mayor de edad"; }
            else
            { return "No es mayor de edad"; }
        }
    }
}
