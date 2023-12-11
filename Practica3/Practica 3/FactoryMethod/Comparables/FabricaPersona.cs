using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;

namespace Practica_3.FactoryMethod.Comparables
{
	public class FabricaPersona:FabricaComparables
	{
		protected List<string> nombresVariados = new List<string>
		{
			"Mathias","Marianela","Jose","Josefina","Rocio",
			"Robert","Alan","Pablo","Walter","Nahuel"
		};
		
		protected string nombre;
		protected int dni;
		
		public FabricaPersona(){
			
		}
		
		
		public override Comparable crearAleatorio(){
			
			//Persona(string nombre, int dni)
			return new Persona(nombresVariados[new Random().Next(0,nombresVariados.Count)],new Random().Next(30000000,55000000));
		}
		
		public override Comparable crearPorTeclado(){
			//Persona(string nombre, int dni)
			Console.WriteLine("Introduzca el nombre: ");
			nombre =Console.ReadLine();
			
			Console.WriteLine("Ingrese el numero de dni sin puntos: ");
			dni = int.Parse(Console.ReadLine());
			
			while (dni<30000000 || dni>55000000){
			       	
			       	Console.WriteLine("\nValor ingresado no válido, por favor vuelva a intentarlo.\n");
			       	
			       	Console.WriteLine("\nIngrese el numero de dni sin puntos (Valores entre 30000000 y 55000000): ");
					dni = int.Parse(Console.ReadLine());
			}
			
			return new Persona(nombre,dni);
		}
	}
}
