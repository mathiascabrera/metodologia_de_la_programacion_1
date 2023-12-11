using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;
using Practica2_2.Iterator;

namespace Practica2_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			//--------    Metodología de la Programación 1   --------
			
			//                    Práctica 2
			
			//  Alumno : Mathias Cabrera.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			// EJERCICIO 1
			
			
			
			//Implemente cuatro estrategias de comparación para la clase Alumno definida en la práctica anterior. Realice una estrategia para que compare alumnos
			//por nombre, otra para que compare por DNI, otra para que compare por promedio y una última estrategia que compare por legajo.
			
			
			
			
			
			//Estrategias de comparación creadas.
			
			
			//Ejercicio 1 Realizado.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//EJERCICIO 2
			
			
			//Modifique el ejercicio 16 de la clase anterior para crear alumnos con alguna estrategia implementada en el ejercicio anterior.
			
			//Use el método main del ejercicio 17 de la clase anterior para comprobar el funcionamiento correcto de la estrategia seleccionada. Note que este método main NO debería ser modificado.
			
			
			
			// A considerar = Ejercicio 16 ( Practica 1 ) : Implemente una función llenaAlumnos que reciba un Coleccionable y que le agregue 20 alumnos elegidos al azar.
			
			
			
			// Ejericio 17 (Practica 1) Implementar lo siguiente:
			
			Console.WriteLine("Ejercicio 2 :\n");

			Coleccionable pila = new Pila();
			Coleccionable cola = new Cola();

			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);
			
			Console.WriteLine("\nPresione cualquier tecla para avanzar a la siguiebte actividad: ");
			Console.ReadKey();
			Console.Clear();
//
			
			//Método del main (informar) del ejercicio 17 de la Practica 1 modificado para buscar a un alumno por medio del legajo.
			
			
			
			//EJERCICIO 2 REALIZADO.

			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			
			// EJERCICIO 3
			
			//Implemente la clase Conjunto. Un Conjunto es una colección que almacena elementos sin repetición. Es decir, si se intenta almacenar un elemento que ya está en el conjunto, éste
			//elemento no se almacena ya que sino estaría repetido.
			
			//Esta clase debe contar con los métodos:
			
			// - Agregar (elemento) el cual agrega el elemento al conjunto si es que este no existe.
			
			// - Pertenece (elemento) el cual devuelve true si el elemento recibido por parametro ya esta dentro del conjunto, o false en caso contrario.
			
			
			
			//EJERCICIO 3 REALIZADO.
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			// EJERCICIO 4
			
			// Implemente la clase Diccionario. Un Diccionario es una colección que almacena elementos, donde cada elemento tiene una clave asociada. Las claves no pueden repetirse.
			
			// Esta clase debe contar con los metodos:
			
			// - agregar (clave, valor) el cual agrega la asociación clave-valor al diccionario si es que la clave no existe en el diccionario.
			//   Si la clave existe, entonces reemplaza el valor asociado.
			
			
			// - valorDe (clave) devuelve el valor asociado a la clave recibida por parametro o null si la clave no existe.
			
			
			
			
			
			//Sugerencia: implemente una clase auxiliar ClaveValor que lo único que hace es almacenar una clave (que puede ser cualquier Comparable) y un valor asociado (que puede ser cualquier otro
			// objeto). Luego puede usar la clase Conjunto para que un diccionario almacene instancias de la clase ClaveValor, las cuales son creadas en el método agregar y valorDe.

			
			
			// Clase ClaveValor, Conjunto y Diccionario creados.
			
			
			
			
			//Ejercicio 4 REALIZADO
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// EJERCICIO 5
			
			
			// Haga que las clases Conjunto y Diccionario implementen la interface Coleccionable.
			
			// En el caso de Diccionario, los métodos minimo, máximo y contiene deben hacer referencia a los valores asociados, no a las claves. En el método agregar puede usar una clave única por
			// defecto, que maneja el propio diccionario para ir agregando los valores asociados a esas claves únicas.

			
			// Conjunto y Diccionario implementan la interface Coleccionable.
			
			// El Diccionario informa de los minimos, maximos y valores que contiene por medio de los valores.
			
			
			
			
			
			
			
			// Ejercicio 5 Realizado
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 6
			
			
			// Haga que las clases Pila, Cola, Conjunto y Diccionario implementen la interface Iterable vista en teoría.

			

			// Las clases Pila Cola, Conjunto y Diccionario implementan la interface Iterable.

			
			// Ejercicio 6 Realizado.


			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			// Ejercicio 7
			
			
			
			// Implemente una función imprimirElementos que reciba un coleccionable y usando el iterador del coleccionable imprima todos los elementos del coleccionable
			
			
			//Ejercicio 7 Realizado.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//Ejercicio 8
			
			//Implemente un módulo main para crear una pila, una cola, un conjunto y un diccionario de alumnos y luego invoque la función imprimirElementos para cada coleccionable.
			
			Console.WriteLine("Ejercicio 8 :\n");

			Coleccionable pila1 = new Pila();
			Coleccionable cola1 = new Cola();
			Coleccionable conjunto1 = new Conjunto();
			Coleccionable diccionario1 = new Diccionario();

			llenarAlumnos(pila1);
			llenarAlumnos(cola1);
			llenarAlumnos(conjunto1);
			llenarAlumnos(diccionario1);

			Console.WriteLine("\nElementos de la Pila :\n");
			imprimirElementos(pila1);
			
			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("\nElementos de la Cola :\n");
			imprimirElementos(cola1);

			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("\nElementos del Conjunto :\n");
			imprimirElementos(conjunto1);

			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("\nElementos del Diccionario :\n");
			imprimirElementos(diccionario1);
			
			Console.ReadKey();
			Console.Clear();
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			//Ejercicio 9
			
			
			//Implemente una función cambiarEstrategia que reciba un coleccionable y una estrategia de comparación (implementada en el ejercicio 1) y asigne esa estrategia a todos los elementos del
			//coleccionable
			
			
			
			// Ejercicio 9 Realizado.
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			
			
			//Ejercicio 10
			
			//Modifique el módulo main para que cambie la estrategia de comparación a los elementos de un coleccionable e informe minimo y máximo elemento:
			
			Console.WriteLine("Ejercicio 10 :\n");
			
			Console.WriteLine("Elementos de la Pila que se comparan por Nombres: \n");
			
			Coleccionable pila2 = new Pila();
			llenarAlumnos(pila2);
			cambiarEstrategia(pila2,new porNombre());
			informar(pila2);
			
			Console.WriteLine("\n\nElementos de la Pila que se comparan por Legajos: \n");
			
			cambiarEstrategia(pila2,new porLegajo());
			informar(pila2);
			
			Console.WriteLine("\n\nElementos de la Pila que se comparan por Promedios: \n");
			
			cambiarEstrategia(pila2,new porPromedio());
			informar(pila2);
			
			Console.WriteLine("\n\nElementos de la Pila que se comparan por Dni: \n");
			
			cambiarEstrategia(pila2,new porDni());
			informar(pila2);
			
			Console.WriteLine("Presione cualquier tecla para avanzar a las comparaciones de la coleccion Cola: ");
			Console.ReadKey();
			Console.Clear();
			
			
			
			
			
			
			Console.WriteLine("Elementos de la Cola que se comparan por Nombres: \n");

			Coleccionable cola2 = new Cola();
			llenarAlumnos(cola2);
			cambiarEstrategia(cola2,new porNombre());
			informar(cola2);
			
			Console.WriteLine("\n\nElementos de la Cola que se comparan por Legajos: \n");
			
			cambiarEstrategia(cola2,new porLegajo());
			informar(cola2);
			
			Console.WriteLine("\n\nElementos de la Cola que se comparan por Promedios: \n");
			
			cambiarEstrategia(cola2,new porPromedio());
			informar(cola2);
			
			Console.WriteLine("\n\nElementos de la Cola que se comparan por Dni: \n");
			
			cambiarEstrategia(cola2,new porDni());
			informar(cola2);
			
			Console.WriteLine("Presione cualquier tecla para avanzar a las comparaciones de la coleccion Conjunto: ");
			Console.ReadKey();
			Console.Clear();
			
			
			
			
			
			
			Console.WriteLine("Elementos del Conjunto que se comparan por Nombres: \n");

			Coleccionable conjunto2 = new Conjunto();
			llenarAlumnos(conjunto2);
			cambiarEstrategia(conjunto2,new porNombre());
			informar(conjunto2);
			
			Console.WriteLine("\n\nElementos del Conjunto que se comparan por Legajos: \n");
			
			cambiarEstrategia(conjunto2,new porLegajo());
			informar(conjunto2);
			
			Console.WriteLine("\n\nElementos del Conjunto que se comparan por Promedios: \n");
			
			cambiarEstrategia(conjunto2,new porPromedio());
			informar(conjunto2);
			
			Console.WriteLine("\n\nElementos del Conjunto que se comparan por Dni: \n");
			
			cambiarEstrategia(conjunto2,new porDni());
			informar(conjunto2);
			
			Console.WriteLine("Presione cualquier tecla para avanzar a las comparaciones de la coleccion Diccionario: ");
			Console.ReadKey();
			Console.Clear();
			
			
			
			
			
			
			Console.WriteLine("Elementos del Diccionario que se comparan por Nombres: \n");

			Coleccionable diccionario2 = new Diccionario();
			llenarAlumnos(diccionario2);
			cambiarEstrategia(diccionario2,new porNombre());
			informar(diccionario2);
			
			Console.WriteLine("\n\nElementos del Diccionario que se comparan por Legajos: \n");
			
			cambiarEstrategia(diccionario2,new porLegajo());
			informar(diccionario2);
			
			Console.WriteLine("\n\nElementos del Diccionario que se comparan por Promedios: \n");
			
			cambiarEstrategia(diccionario2,new porPromedio());
			informar(diccionario2);
			
			Console.WriteLine("\n\nElementos del Diccionario que se comparan por Dni: \n");
			
			cambiarEstrategia(diccionario2,new porDni());
			informar(diccionario2);
			
			
			
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			Console.WriteLine("Fin del programa. Por favor presione cualquier tecla para salir.");
			
			Console.ReadKey(true);
		}
		
		
		public static void informar(Coleccionable a){
			
			Console.WriteLine("La cantidad de elementos que posee el coleccionable es :"+ a.cuantos());
			Console.WriteLine("");
			Console.WriteLine("El elemento mínimo que posee el coleccionable es :\n"+a.minimo());
			Console.WriteLine("");
			Console.WriteLine("El elemento máximo que posee el coleccionable es :\n"+ a.maximo());
			Console.WriteLine("");
			
			//Porcion modificada para el correcto funcionamiento del ejercicio 18 donde los Alumnos se comparan por Legajo y ya no mas por DNI.
			Console.WriteLine("Por favor ingrese un legajo: ");
			Comparable prueba = new Alumno(" ",000,Convert.ToInt32(Console.ReadLine()),0000);
			
			if (a.contiene(prueba)) {
				Console.WriteLine("-- El elemento leído está en la coleccion. --\n\n");
			}else{
				Console.WriteLine("-- El elemento leído no está en la colección. --\n\n");
			}
		}
		
		
		
		public static void llenarAlumnos(Coleccionable a){
			
			//Alumno(string n, int d, int l, double p)
			
			List<string> nombresVariados = new List<string>
			{
				"Mathias","Marianela","Jose","Josefina","Rocio",
				"Robert","Alan","Pablo","Walter","Nahuel"
			};
			
			Random nombre = new Random();
			Random dni = new Random();
			Random legajo = new Random();
			Random promedio = new Random();
			
			Comparable alumno;
			
			for (int i = 0; i < 20; i++) {
				
				alumno = new Alumno(nombresVariados[nombre.Next(0,nombresVariados.Count)],dni.Next(30000000, 55000000),legajo.Next(1453,3200),(promedio.NextDouble())*10);
				
				a.agregar(alumno);
			}
		}
		
		
		
		
		public static void imprimirElementos(Coleccionable a){
			
			Iterador prueba = ((Iterable)a).crearIterador();
			prueba.primero();
			while(!prueba.fin()){
				Alumno b = (Alumno) prueba.actual();
				prueba.siguiente();
				Console.WriteLine(b);
			}
		}
		
		
		public static void cambiarEstrategia(Coleccionable a, Strategy b){
			
			Iterador ite = ( (Iterable)a ).crearIterador();
			
			ite.primero();
			
			while(!ite.fin()){
				Alumno c = (Alumno) ite.actual();
				ite.siguiente();
				c.cambiarEstrategia(b);
				
			}
			
		}
	}
}