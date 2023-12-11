using System;
using Practica1___Mathias_Cabrera;
using Practica2;

namespace Practica_3.FactoryMethod.Comparables
{
	abstract public class FabricaComparables
	{
		
		
		public static Comparable crearAleatorio(int p){
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor)
			
			FabricaComparables f = null;
			
			
			switch(p){
				case 1:
					f=new FabricaNumero();
					break;
				case 2:
					f=new FabricaPersona();
					break;
				case 3:
					f=new FabricaAlumno();
					break;
				case 4:
					f=new FabricaProfesor();
					break;
				default:
					return null;
			}
			return f.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int p){
			
			FabricaComparables f = null;
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor)
			
			switch(p){
				case 1:
					f=new FabricaNumero();
					break;
				case 2:
					f=new FabricaPersona();
					break;
				case 3:
					f=new FabricaAlumno();
					break;
				case 4:
					f=new FabricaProfesor();
					break;
				default:
					return null;
			}
			return f.crearPorTeclado();
		}
		
		abstract public Comparable crearAleatorio();
		
		abstract public Comparable crearPorTeclado();
	}
}
