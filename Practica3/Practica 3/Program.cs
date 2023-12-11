using System;
using Practica2.Iterator;
using Practica_3.FactoryMethod.Coleccionables;
using Practica_3.FactoryMethod.Comparables;
using Practica1___Mathias_Cabrera;

namespace Practica_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//--------    Metodología de la Programación 1   --------
			
			//                    Práctica 3
			
			//  Alumno : Mathias Cabrera.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//EJERCICIO 1
			
			//Recordamos: ¿Cuál es la única diferencia entre los métodos llenar, llenarPersonas y llenarAlumnos implementados en la práctica 1 (ejercicios 5, 12 y 16)? ¿Qué tuvo que hacer con
			//el método informar (ejercicio 6) a medida que ejecutaba los métodos main (ejercicios 13 y 17)?
			//¿Qué sucedería con todos estos métodos si apareciera una nueva clase Profesor, la cual se desea comparar por antigüedad?
			
			
			
			//La única diferencia entre los métodos llenar, llenarPersonas y LlenarAlumnos implementados en la primera práctica, es el objeto que se almacena en el coleccionable pasado por parámetro.
			//Para el método llenar se almacenan objetos del tipo Numero, en el método llenarPersonas almacena objetos del tipo Persona en el coleccionable y en LlenarAlumnos se almacenan objetos
			//del tipo Alumno.

			//En cuanto al método informar de la práctica 1, para el ejercicio 6, trabajaba específicamente para objetos del tipo Número.
			//Para realizar el enunciado 13, de la primera práctica, el método fué modificado para trabajar con objetos del tipo Persona.
			//En el ejercicio 17 de la misma práctica, el método también sufrió una modificación para trabajar con onjetos del tipo Alumno.
			
			//En caso de que apareciera la clase Profesor, los métodos mencionados deberían ser modificados nuevamente para trabajar específicamente con Profesor.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 2
			
			//Implemente la clase GeneradorDeDatosAleatorios
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 3
			
			//Implemente la clase LectorDeDatos.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------

			
			
			//Ejercicio 5
			
			//Implemente con el patrón Factory Method la capacidad de crear instancias de comparables (sólo las clases Numero y Alumno). Implemente las fábricas concretas
			//FabricaDeNumeros y FabricaDeAlumnos.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------

			
			
			//Ejercicio 6
			
			//Implemente una única función llenar (práctica 1, ejercicios 5 y 16) y una única función informar (práctica 1, ejercicios 6 y 17) que reciban una opción por parámetro
			//que indique que comparable instanciar.
			
			Console.WriteLine("Ejercicio 6.\n");
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno)
			
			Console.WriteLine("Opciones de Comparables: 1(Numero), 2(Persona), 3(Alumno).\n");
			
			Console.Write("Ingrese el numero de Comparable que desea crear: ");
			int opcion = Convert.ToInt32(Console.ReadLine());
			
			Coleccionable pila = new Pila();
			llenar(pila,opcion);
			informar(pila,opcion);
			
			
			Console.Write("Presione alguna tecla para avanzar a la siguiente actividad: ");
			Console.ReadKey();Console.Clear();
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 7
			
			//Para reflexionar. ¿Qué debería hacer si se quiere tener en el método main la opción de  almacenar los comparables en una pila, en una cola, en una colección múltiple, en un conjunto 
			//o en un diccionario?
			
			//Opcional. Implemente la solución propuesta
			
			//Si se quiere tener en el método main la opción de almacenar los comparables en una pila, en una cola, en una coleccion múltiple, en un conjunto o en un diccionario
			//deberíamos crear FábricaDeColeccionables y por cada tipo de colección una subclase.
			
			//Implementacion:
			
			Console.WriteLine("Ejercicio 7.\n");
			
			//Opciones = 1(Pila), 2(Cola), 3(ColeccionMultiple), 4(Conjunto), 5(Diccionario)
			
			Console.WriteLine("Opciones de Coleccion : 1(Pila), 2(Cola), 3(ColeccionMultiple), 4(Conjunto), 5(Diccionario).\n");
			
			Console.Write("Ingrese un numero entre 1 y 5: ");
			opcion = Convert.ToInt32(Console.ReadLine());
			
			
			Coleccionable coleccion = FabricaColeccionable.crear(opcion);
			
			
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno)
			
			Console.WriteLine("\nOpciones de Comparables: 1(Numero), 2(Persona), 3(Alumno).\n");
			
			Console.Write("Ingrese el numero de Comparable que desea crear: ");
			opcion = Convert.ToInt32(Console.ReadLine());
			
			
			llenar(coleccion,opcion);
			informar(coleccion,opcion);
			
			
			Console.Write("Presione alguna tecla para avanzar a la siguiente actividad: ");
			Console.ReadKey();Console.Clear();
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 8
			
			// Implemente la clase Profesor que sea subclase de Persona.
			
			//Realizado.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 9
			
			
			
			//Implemente una fábrica concreta para la clase Profesor y compruebe el correcto funcionamiento del método main del ejercicio 6.
			//Compare a los profesores por el campo antigüedad.
			
			Console.WriteLine("Ejercicio 9.\n");
			
			Console.WriteLine("Comprobacion funcionamiento correcta de los objetos del tipo Profesor.\n");
			
			
			//Opciones = 1(Pila), 2(Cola), 3(ColeccionMultiple), 4(Conjunto), 5(Diccionario)
			Coleccionable coleccion1 = FabricaColeccionable.crear(1);
			
			//opcion : 1(Numero), 2(Persona), 3(Alumno), 4(Profesor)
			llenar(coleccion1,4);
			informar(coleccion1,4);
			
			Console.Write("\nPresione alguna tecla para avanzar a la siguiente actividad: \n");
			Console.ReadKey();Console.Clear();
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			// Ejercicio 10
			
			//Para reflexionar. ¿Qué tienen en común las fábricas de la clase Profesor y de la clase Alumno? ¿Podría ampliarse la jerarquía de clases de las fábricas? ¿Cómo?
			
			//Las fábricas de la clase Profesor y de la Clase Alumno tienen en común las variables de nombre y dni, además de la lista de nombres que utilizo para crear los objetos
			//al azar. Esta Lista, antes de aplicar la herencia de fábricas, estaba en las fábricas de la clase Persona, Alumno y Profesor; por lo que realicé la herencia a partir de la
			//FábricaPersona. De esta manera, la FabricaAlumno y la FabricaProfesor heredan los estados y comportamientos de la FabricaPersona.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			// Ejercicio 11 :
			
			//Agregue a la clase Alumno los siguientes métodos: prestarAtencion() y distraerse().
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			


			// Ejercicio 12 :
			
			//Implemente el patrón Observer haciendo que el profesor sea el observable y los alumnos los observadores del profesor. Los alumnos deberían prestar atención cada vez que el profesor les
			//habla y distraerse cada vez que éste escribe en el pizarrón.
		
			
			Console.WriteLine("Ejercicio 12.\n");
			
			Console.WriteLine("\nPrueba funcionamiento Patron Observer.\n");
			
			Profesor p = ((Profesor) FabricaComparables.crearAleatorio(4));
			
			Alumno a1 = ((Alumno) FabricaComparables.crearAleatorio(3));
			Alumno a2 = ((Alumno) FabricaComparables.crearAleatorio(3));
			
			p.agregarObservador(a1);
			p.agregarObservador(a2);
			
			Console.WriteLine("\n--------------- Profe habla a la clase ---------------\n");
			p.hablarALaClase();
			
			Console.WriteLine("\n--------------- Profe escribe en el pizarron ---------------\n");
			p.escribirEnElPizarron();
			
			
			Console.Write("\nPresione alguna tecla para avanzar a la siguiente actividad: \n");
			Console.ReadKey();Console.Clear();
			

			//-----------------------------------------------------------------------------------------------------------------------------------------------


			//Ejercicio 13
			
			//Implemente la función dictadoDeClases.


			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			//Ejercicio 14
			
			//Implementacion en el main
			
			
			Console.WriteLine("Ejercicio 14.\n");
			
			
			Profesor prof = ((Profesor) FabricaComparables.crearAleatorio(4));
			
			
			Pila pila1 = new Pila();
			llenar(pila1,3);
			cargaDeObservadores(pila1,prof);
			dictadoDeClases(prof);
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------

			
			
			Console.Write("Fin de la Práctica 3. Por favor presione cualquier tecla para cerrar la ventana: ");
			Console.ReadKey(true);
		}
		public static void llenar(Coleccionable a, int opcion){
			
			int numero = 20;
			
			while(numero >0){
				
				Comparable com = FabricaComparables.crearAleatorio(opcion);
				a.agregar(com);
				numero --;
			}
			
		}
		
		
		//Creo un un nuevo llenar para el ejercicio 7. Podría modificar el que ya está hecho, pero quiero mostrar todos los ejercicios hechos por consola,
		//Por lo que si quiero que el ejercicio 6 compile debería pasar un parametro mas al invocar la funcion llenar y eso no está contemplado en el enunciado de la práctica.

		
		
		
		public static void informar(Coleccionable a, int opcion){
			Console.WriteLine("\nLa cantidad de elementos que posee el coleccionable es :"+ a.cuantos());
			Console.WriteLine("");
			Console.WriteLine("El elemento mínimo que posee el coleccionable es :\n"+a.minimo());
			Console.WriteLine("");
			Console.WriteLine("El elemento máximo que posee el coleccionable es :\n"+ a.maximo());
			Console.WriteLine("");
			
			Comparable com = FabricaComparables.crearPorTeclado(opcion);
			
			if (a.contiene(com)) {
				Console.WriteLine("-- El elemento leído está en la coleccion. --\n\n");
			}else{
				Console.WriteLine("-- El elemento leído no está en la colección. --\n\n");
			}
		}
		
		//Ejercicio 13
		public static void dictadoDeClases(Profesor profesor){
			for (int i = 0; i < 5; i++) {
				profesor.hablarALaClase();
				profesor.escribirEnElPizarron();
			}
		}
		
		
		//Funcion auxiliar
		public static void cargaDeObservadores(Coleccionable a, Profesor prof){
			Iterador prueba = ((Iterable)a).crearIterador();
			prueba.primero();
			while(!prueba.fin()){
				Alumno b = (Alumno) prueba.actual();
				prueba.siguiente();
				prof.agregarObservador(b);
			}
		}
	}
}