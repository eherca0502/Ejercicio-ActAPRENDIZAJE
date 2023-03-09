using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    class Alumno
    {
        public string nombre, apellido, carnet;
        public double nota1,nota2,nota3;
        public double ObtenerPromedio(double n1,double n2,double n3) // Tres parametros que se nos indican
        {
            return (n1 + n2 + n3) / 3;
        }
        public string NombreCompleto(string nom, string ape)
        {
            return nom + " " + ape;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("\nSu nombre completo es: " + NombreCompleto(nombre, apellido));
            Console.WriteLine("\nSu carnet:" + carnet);
            Console.WriteLine("\nPrimer nota:" + nota1);
            Console.WriteLine("\nSegunda nota:" + nota2);
            Console.WriteLine("\nTercer nota:" + nota3);
            Console.WriteLine("\nPromedio:" + ObtenerPromedio(nota1,nota2,nota3));
        }
        public Alumno()
        {
            try
            {
                Console.WriteLine("Creacion del primer objeto");
                Console.WriteLine("Ingresa tu nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu apellido:");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingresa el carnet:");
                carnet = Console.ReadLine();
                Console.WriteLine("Ingresa la primer nota:");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa la segunda nota:");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa la tercer nota:");
                nota3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
        }
        public Alumno (string nomb,string apelli,string carn,double n1,double n2,double n3)
        {
            nombre = nomb;
            apellido = apelli;
            carnet = carn;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
        }

    }
}
