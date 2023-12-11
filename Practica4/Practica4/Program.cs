using System;
using Practica_3.FactoryMethod.Comparables;
using Practica1___Mathias_Cabrera;
using MetodologíasDeProgramaciónI;
using Practica4.Adapter;
using Practica4.Decorator;

namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//--------    Metodología de la Programación 1   --------
			
			//                    Práctica 4
			
			//  Alumno : Mathias Cabrera.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			// Ejercicio 1 
			
			// Modifique la clase Alumno de prácticas anteriores para agregarle una variable de instancia denominada calificación con sus correspondientes getter y setter que representa la última
			// calificación obtenida.
			
			
			
			//Agregue a la clase los métodos: responderPregunta(int pregunta) y mostrarCalificacion()
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			// Ejercicio 2
			
			//Haga una subclase de Alumno, llamada AlumnoMuyEstudioso que reimplemente el método responderPregunta y que devuelva la respuesta correcta a la pregunta formulada:
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 3
			
			//El sistema MDPI, provisto por la cátedra, simula una clase de Metodologías de Programación I, donde un profesor (clase Teacher) da una clase (método teachingAClass) la cual consiste en
			//pasar lista a los alumnos, tomarles un examen y publicar los resultados ordenados por la calificación obtenida.
			
			//Implemente con el patrón Adapter, un adaptador para la clase Alumno desarrollada en el ejercicio 1 y que pueda comportarse como un Student.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 4
			
			// Implemente una función main que instancie un Teacher, haga llegar a 20 Students con el método goToClass. Los Student son instancias del adaptador implementado en el ejercicio
			// anterior, 10 de ellos adaptaran a una instancia de la clase Alumno, mientras que los otros 10 adaptarán a una instancia de AlumnoMuyEstudioso. 
			// Luego invoque al método teachingAClass de Teacher para comprobar el correcto funcionamiento del sistema.
			
			Console.WriteLine("Ejercicio 4.\n");
			
			Teacher teacher = new Teacher();
			
			Comparable alum;
			AlumnoAdaptador alumAdaptador;
			AlumnoAdaptador alumAdapEst;
			
			for (int i = 0; i < 10; i++) {
				
				//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor), 5(AlumnoMuyEstudioso)
				
				//Adaptacion Clase Alumno
				alum = FabricaComparables.crearAleatorio(3);
				alumAdaptador = new AlumnoAdaptador((Alumno)alum);
				teacher.goToClass(alumAdaptador);
				
				//Adaptacion Clase AlumnoMuyEstudioso
				alum = FabricaComparables.crearAleatorio(5);
				alumAdapEst = new AlumnoAdaptador((AlumnoMuyEstudioso)alum);
				teacher.goToClass(alumAdapEst);
			}
			
			//Ejecucion del método de Teacher
			teacher.teachingAClass();
			
			
			Console.Write("\nPresione alguna tecla para avanzar a la siguiente actividad: \n");
			Console.ReadKey();Console.Clear();
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------

			//Ejercicio 5
			
			//Opcional: Implemente una estrategia para que el listado de calificaciones quede ordenado de mayor a menor por la última calificación.
			
			
			//Realizado, se comparan por Calificaciones.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 6:
			//Implemente con el patrón Decorator distintos decorados para mostrar las calificaciones de los alumnos.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			

			//Ejercicio 7:
			//Arme los Students con todos los decorados implementado en el ejercicio anterior.


			//Opcional: Haga una subclase de FabricaDeAlumnos, llamada StudentsFactory que instancie los alumnos decorados y adaptados.

			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			//Ejercicio 8:
			//Ejecute la función main del ejercicio 4 y compruebe la correcta impresión del listado de calificaciones.
			
			Console.WriteLine("Ejercicio 8.\n");

			Teacher teacher2 = new Teacher();
			
			Comparable student1;
			Comparable student2;
			for (int i = 0; i < 10; i++) {
				
				student1 = FabricaComparables.crearAleatorio(6);
				teacher2.goToClass((AlumnoAdaptador)student1);
				
				student2 = FabricaComparables.crearAleatorio(7);
				teacher2.goToClass((AlumnoAdaptador)student2);
			}

			teacher2.teachingAClass();
			


			//-----------------------------------------------------------------------------------------------------------------------------------------------

			
			
			Console.Write("Fin de la Práctica 3. Por favor presione cualquier tecla para cerrar la ventana: ");
			Console.ReadKey(true);
		}
	}
}