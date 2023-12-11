using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;
using Practica2;

namespace Practica_3.FactoryMethod.Comparables
{
	public class FabricaAlumno:FabricaPersona
	{
		private int legajo;
		private double promedio;
		
		public FabricaAlumno(){
			
		}
		
		public override Comparable crearAleatorio(){
			
			//Alumno(string nombre, int dni, int legajo, double promedio)
			
			return new Alumno(nombresVariados[new Random().Next(0,nombresVariados.Count)],new Random().Next(30000000, 55000000),new Random().Next(1453,3200),(new Random().NextDouble())*10);
		}
		
		public override Comparable crearPorTeclado(){
			//Alumno(string nombre, int dni, int legajo, double promedio)
			
			Console.WriteLine("Ingrese el nombre: ");
			nombre = Console.ReadLine();

			Console.WriteLine("Ingrese el numero de dni sin puntos: ");
			dni = int.Parse(Console.ReadLine());
			
			while (dni<30000000 || dni>55000000){
			       	
			       	Console.WriteLine("\nValor ingresado no válido, por favor vuelva a intentarlo.\n");
			       	
			       	Console.WriteLine("\nIngrese el numero de dni sin puntos (Valores entre 30000000 y 55000000): ");
					dni = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Introduzca el número del legajo: ");
			legajo = int.Parse(Console.ReadLine());

			Console.WriteLine("Introduzca el promedio: ");
			promedio = double.Parse(Console.ReadLine());

			return new Alumno(nombre,dni,legajo,promedio);

		}
	}
}
