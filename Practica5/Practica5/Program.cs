using System;
using Practica1___Mathias_Cabrera;
using Practica_3.FactoryMethod.Comparables;
using Practica4;
using Practica4.Adapter;
using MetodologíasDeProgramaciónI;
using Practica5.Command;
using Practica5.Proxy;

namespace Practica5
{
	class Program
	{
		public static void Main(string[] args)
		{
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			//--------    Metodología de la Programación 1   --------
			
			//                    Práctica 5
			
			//  Alumno : Mathias Cabrera.
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Actividad 1
			
			//Implemente con el patrón Proxy un proxy para cualquier Alumno. Este proxy debería actuar como tal para almacenar y devolver todos los datos de un Alumno.
			//El proxy debe crear al alumno real (Alumno o AlumnoMuyEstudioso) al momento de responder una pregunta (método responderPregunta)
			
//			ProxyAlumno a = new ProxyAlumno("Mathias",3);
//			Console.WriteLine(a.getNombre());
//			Console.WriteLine(a.getLegajo());
//			Console.WriteLine(a.getPromedio());
//			Console.WriteLine(a.getUltCalif());
//			Console.WriteLine(a.responderPregunta(30));
//			a.establecerCalificacion(8);
//			Console.WriteLine(a.getUltCalif());
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			
			
			//Ejercicio 2
			//Ejecute la función main del ejercicio 8 de la práctica 4 para comprobar el correcto funcionamiento.
			//Nota: puede imprimir un mensaje por consola al momento de crear la instancia de Alumno o  AlumnoMuyEstudioso dentro del proxy,
			//para corroborar el momento en que se generan las instancias (Cuando el Teacher toma el examen).
			
			
			Console.WriteLine("Ejercicio 2.\n");

			Teacher teacher2 = new Teacher();
			
			IAlumno student1;
			IAlumno student2;
			
			for (int i = 0; i < 10; i++) {
				
				//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor), 5(AlumnoMuyEstudioso), 6(StudentsFactory), 7(SmartStudentsFactory), 8(FabricaDecoradosAlum), 9(FabricaDecoradosAlumEst)
			
				
				student1 = new ProxyAlumno("Mateo",8);
				AlumnoAdaptador aa = new AlumnoAdaptador((IAlumno)student1);
				teacher2.goToClass(aa);
				
				student2 = new ProxyAlumno("Rebeca",9);
				AlumnoAdaptador bb = new AlumnoAdaptador((IAlumno)student2);
				teacher2.goToClass(bb);
			}

			teacher2.teachingAClass();
			
			
			
			
			Console.Write("\nPresione alguna tecla para avanzar a la siguiente actividad: \n");
			Console.ReadKey();Console.Clear();
			
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 3
			
			//Implemente la clase Aula
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 4
			
			//Implemente la interface OrdenEnAula1:
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 5
			
			//Usando el patrón Command implemente dos órdenes con la interface OrdenEnAula1, donde las órdenes trabajaran con un Aula como receptor:

			//OrdenInicio: envía el mensaje comenzar al aula.
			//OrdenAulaLlena: envía el mensaje claseLista al aula.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 6
			//Implemente la interface OrdenEnAula2
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 7
			//Usando el patrón Command implemente una orden con la interface OrdenEnAula2, donde la orden trabajará con un Aula como receptor:

			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 8
			//Implemente la interface Ordenable
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 9
			//Modifique las clases Pila, Cola, Conjunto y Diccionario para que implementen la interface Ordenable y puedan trabajar con las tres órdenes
			//implementadas en los ejercicios anteriores.

			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 10
			//Implemente una función main que instancie un Aula y una instancia de cada una de las tres órdenes con el aula como receptor.
			//Instancie una Pila/Cola/Conjunto/Diccionario y seteele las tres órdenes.
			//Luego llame a la función llenar (práctica 3, ejercicio 6) para agregar 20 instancias de Alumno y 20 instancias de AlumnoMuyEstudioso.
			
			Console.WriteLine("Ejercicio 10.\n");
			
			Cola cola = new Cola();
			Aula a = new Aula();
			
			cola.setOrdenInicio(new OrdenInicio(a));
			cola.setOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
			cola.setOrdenAulaLlena(new OrdenAulaLlena(a));
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor), 5(AlumnoMuyEstudioso), 6(StudentsFactory), 7(SmartStudentsFactory), 8(FabricaDecoradosAlum), 9(FabricaDecoradosAlumEst)
			llenar(cola,8);//Students
			llenar(cola,9);//SmartStudent
			
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			Console.Write("Fin de la Práctica 5. Por favor presione cualquier tecla para cerrar la ventana: ");
			Console.ReadKey(true);
		}
		
		public static void llenar(Coleccionable a, int opcion){
			
			int numero = 20;
			
			Comparable student1;
			
			while(numero >0){
				
				student1 = new ProxyAlumno("Mateo",opcion);
				a.agregar(student1);
				numero --;
			}
			
		}
	}
}