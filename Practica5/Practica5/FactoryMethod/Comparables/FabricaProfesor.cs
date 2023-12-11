using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;

namespace Practica_3.FactoryMethod.Comparables
{
	public class FabricaProfesor:FabricaPersona
	{
		private int antiguedad;
		
		public FabricaProfesor()
		{
		}
		
		
		public override Comparable crearAleatorio(){
			
			//Profesor(string nombre, int dni, int antiguedad)
			
			return new Profesor(nombresVariados[new Random().Next(0,nombresVariados.Count)],new Random().Next(30000000, 55000000),new Random().Next(0,71));
		}
		
		
		public override Comparable crearPorTeclado(){
			
			Console.WriteLine("\nIngrese el nombre: ");
			nombre = Console.ReadLine();
			
			Console.WriteLine("\nIngrese el numero de dni sin puntos: ");
			dni = int.Parse(Console.ReadLine());
			
			while (dni<30000000 || dni>55000000){
			       	
			       	Console.WriteLine("\nValor ingresado no válido, por favor vuelva a intentarlo.\n");
			       	
			       	Console.WriteLine("\nIngrese el numero de dni sin puntos (Valores entre 30000000 y 55000000): ");
					dni = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("\nIntroduzca los años de antiguedad: ");
			antiguedad = int.Parse(Console.ReadLine());
			
			while(antiguedad<0 || antiguedad>70){
				
				Console.WriteLine("\nValor ingresado no válido, por favor vuelva a intentarlo.\n");
				
				Console.WriteLine("\nIntroduzca los años de antiguedad: ");
				antiguedad = int.Parse(Console.ReadLine());
			}
			
			return new Profesor(nombre,dni,antiguedad);
			
		}
	}
}
