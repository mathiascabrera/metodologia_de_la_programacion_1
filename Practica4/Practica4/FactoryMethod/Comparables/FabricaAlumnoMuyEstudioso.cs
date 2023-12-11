using System;
using Practica1___Mathias_Cabrera;
using Practica_3.FactoryMethod.Comparables;

namespace Practica4.FactoryMethod.Comparables
{
	public class FabricaAlumnoMuyEstudioso:FabricaAlumno
	{
		public FabricaAlumnoMuyEstudioso()
		{
		}
		
		public override Comparable crearAleatorio(){
			//Alumno(string n, string ape,int d, int l, double p, int ultimaCalificacion)
			
			return new AlumnoMuyEstudioso(nombresVariados[new Random().Next(0,nombresVariados.Count)],apellidosVariados[new Random().Next(0,apellidosVariados.Count)] ,new Random().Next(30000000, 55000000),new Random().Next(1453,3200),(new Random().NextDouble())*10,new Random().Next(0,11));
		}
		public override Comparable crearPorTeclado(){
			//Alumno(string n, string ape,int d, int l, double p, int ultimaCalificacion)
			
			Console.WriteLine("Ingrese el nombre: ");
			nombre = Console.ReadLine();
			
			Console.WriteLine("Ingrese el apellido: ");
			apellido = Console.ReadLine();

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
			
			Console.WriteLine("Introduzca la ultima calificacion obtenida: ");
			ultimaCalificacion = int.Parse(Console.ReadLine());
			
			while (ultimaCalificacion<0 || ultimaCalificacion>10){
				
				Console.WriteLine("\nValor ingresado no válido, por favor vuelva a intentarlo.\n");
				
				Console.WriteLine("Introduzca la ultima calificacion obtenida (en un rango de 0 a 10 inclusive): ");
				ultimaCalificacion = int.Parse(Console.ReadLine());
			}

			return new AlumnoMuyEstudioso(nombre,apellido,dni,legajo,promedio,ultimaCalificacion);
		}
	}
}
