using System;
using Practica1___Mathias_Cabrera;
using Practica2;
using Practica4.FactoryMethod.Comparables;
using Practica5.FactoryMethod.Comparables;

namespace Practica_3.FactoryMethod.Comparables
{
	abstract public class FabricaComparables
	{
		
		
		public static Comparable crearAleatorio(int p){
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor), 5(AlumnoMuyEstudioso), 6(StudentsFactory), 7(SmartStudentsFactory), 8(FabricaDecoradosAlum), 9(FabricaDecoradosAlumEst)
			
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
				case 5:
					f=new FabricaAlumnoMuyEstudioso();
					break;
				case 6:
					f=new StudentsFactory();
					break;
				case 7:
					f=new SmartStudentFactory();
					break;
				case 8:
					f=new FabricaDecoradosAlum();
					break;
				case 9:
					f=new FabricaDecoradosAlumEst();
					break;
				default:
					return null;
			}
			return f.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int p){
			
			FabricaComparables f = null;
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor), 5(AlumnoMuyEstudioso), 6(StudentsFactory), 7(SmartStudentsFactory), 8(FabricaDecoradosAlum), 9(FabricaDecoradosAlumEst)
			
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
				case 5:
					f=new FabricaAlumnoMuyEstudioso();
					break;
				case 6:
					f=new StudentsFactory();
					break;
				case 7:
					f=new SmartStudentFactory();
					break;
				case 8:
					f=new FabricaDecoradosAlum();
					break;
				case 9:
					f=new FabricaDecoradosAlumEst();
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
