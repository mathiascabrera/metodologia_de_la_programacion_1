using System;
using System.Collections.Generic;

namespace Practica1___Mathias_Cabrera
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			//--------    Metodología de la Programación 1   --------
			
			//                    Práctica 1
			
			//  Alumno : Mathias Cabrera.
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			//Ejercicio 1 : Implementación de una interface que representa cualquier objeto que sabe compararse con otro objeto de su "mismo tipo".
			
			//Interface Comparable Creada.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			// Ejercicio 2 : Implemente la clase Numero: Que posea una variable del tipo entero llamada "valor".
			//A su vez, un constructor que reciba una variable y lo almacene en la variable "valor".
			//Implementar getValor que retorne la variable "valor".
			//Además, esta clase debe implementar la interface Comparable.*/
			
			// Clase Numero creada.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			/* Ejercicio 3 : Implemente la interface Coleccionable que represente objetos que almacenan comparables
			 * Debe contener los siguientes metodos :
			 * "cuantos" que devuelve la cantidad de elementos comaparables que tiene el coleccionable.
			 * "mínimo" que devuelve el elemento de menor valor de la coleccion.
			 * "maximo" que devuelve el elemento de mayor valor de la coleccion.
			 * "agregar (Comparable)" que agrega el comparable recibido por parametro a la coleccion que recibe el mensaje.
			 * "contiene (Comparable)" que devuelve verdadero si el comparable recibido por parámetro está incluído en la colección y falso en caso contrario. */
			
			// Interface Coleccionable creada.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			/*Ejercicio 4: Implemente las clases Pila y Cola (vistas en Algoritmos y Programación)
			 * y haga que las dos clases implementen la interface Coleccionable.*/
			
			//Clases Pila y Cola creadas.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			// Ejericio 5 : Implemente una función llenar que reciba un Coleccionable y que le agregue 20 comparables elegidos al azar.
			
			// Función llenar creada.

			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//Ejercicio 6 : Implemente una función informar que reciba un Coleccionable e imprima por consola la cantidad
			//de elementos que tiene el coleccionable recibido por parámetro, el elemento
			//mínimo, el máximo y si contiene, o no, como elemento un valor leído por teclado.
			
			//Funcion informar creada.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			//Ejercicio 7 : Implemente un modulo main que cree una Pila y una Cola, que las llene y que invoque la funcion
			//informar con la pila y cola creadas.
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			llenar(pila);
//			llenar(cola);
//			
//			informar(pila);
//			informar(cola);
			
			
			//Ejercicio 7 resuelto.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//Ejercicio 8 : Cree la clase ColeccionMultiple. Haga que la clase ColeccionMultiple implemente la interface Coleccionable.
		
			//Clase ColeccionMultiple creada.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			//Ejercicio 9 : Modifique el modulo main para crear una ColeccionMultiple e informe con esta coleccion
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			
//			Coleccionable multiple = new ColeccionMultiple(pila,cola);
//			
//			llenar(pila);
//			llenar(cola);
//			
//			informar(pila);
//			informar(cola);
//			informar(multiple);
			
			
			//Ejercicio 9 resuelto.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			//Ejercicio 10 : Para reflexionar. Además de la creacion de la nueva clase ColeccionMultiple y la adaptación del
			//módulo main, responda ¿Qué tuve que modificar de lo realizado en los primeros seis ejercicios?.
			
			
			//Además de la creación de la nueva ColeccionMultiple y la adaptacion del módulo main, modifiqué la clase Número
			//añadiendole el método ToString para retornar el valor que contiene. De esta manera al ejecutar, desde el Main,
			//la función 'informar' no va a imprimir 'Practica1.Numero' sino su valor numérico. ");

			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			
			//Ejercicio 7 : Implemente la clase Persona que implemente la interface Comparable y se compare por nombre o por dni.
			
			//Clase Persona que implemente la interface Comaparable Creada. Compara por DNI.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			//Ejercicio 12 : Implemente una función llenarPersonas que reciba un Coleccionable y que le agregue 20 personas elegidos al azar. 
			
			//Funcion llenarPersonas creada.
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			
			//Ejercicio 13 : Mofifique el módulo main para crear una ColeccionMultiple de personas e informe con esta coleccion.
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			
//			Coleccionable multiple = new ColeccionMultiple(pila,cola);
//			
//			llenarPersonas(pila);
//			llenarPersonas(cola);
//			informar(multiple);
			
			
			//Ejercicio 13 resuelto.
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 14 : Para reflexionar. Además de la creación de la nueva clase Persona, la creación de la función llenarPersonas y
			//la adaptación del módulo main, responda ¿qué tuvo que modificar de lo realizado en los ejercicios 1 a 6 y el 8?.
			
			//Además de la creación de la nueva clase Persona, la creación de la función llenarPersonas y la adaptación del módulo main,
			//agregué el método ToString a la clase Persona y modifiqué la función informar para que tome un Comparable Persona.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 15: Implemente la clase Alumno que sea subclase de Persona
			
			//Clase Creada.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			// Ejercicio 16 : Implemente una función llenaAlumnos que reciba un Coleccionable y que le agregue 20 alumnos elegidos al azar. 
			
			
			// Función Creada.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//Ejercicio 17 : Modifique el módulo Main
			
			
//			Coleccionable pila = new Pila();
//			Coleccionable cola = new Cola();
//			
//			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
//			
//			llenarAlumnos(pila);
//			llenarAlumnos(cola);
//			informar(multiple);
			
			
			//Responda ¿Funcionó? ¿Fue necesario decir explícitamente que Alumno tiene que implementar
			//la interface Comparable? ¿Cuál fue el criterio por el cual se comparó a los alumnos? ¿Por qué?
			
			//Las funciones funcionaron correctamente. No fué necesario decir explícitamente que Alumno tiene que implementar la interface Comparable, ya que
			//Persona la implementa y Alumno hereda de Persona todas sus cualidades.
			//El criterio por el cual se comparó a los alumnos fué por Dni, ya que Persona se compara así, y Alumno también hereda esta cualidad.
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------

			
			
			//Ejercicio 18: Reimplemente los métodos de comparable en Alumno para que se compare por legajo o promedio, a elección.
			
			Coleccionable pila = new Pila();
			Coleccionable cola = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);
			
			
			//Ejercicio 18 realizado.
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			
			
			//Ejercicio 19 : Para reflexionar. Responda ¿Podría haber hecho esto mismo sin interfaces? ¿A qué costo?.
			
			//La respuesta es sí, pero mediante un alto costo.
			//En caso de no haber utilizado las interfaces perdemos la posibilidad de reutilizar código (por ejemplo utilizar varios ifs y elses en cada clase), y en caso de surgir alguna modificación/actualización
			// tendríamos que corroborar en varias partes del programa, aumentando así las probabilidades de errores.	
			
			
			
			
			
			
			
			
			//-----------------------------------------------------------------------------------------------------------------------------------------------
			
			Console.WriteLine("Presione cualquier tecla para finalizar: ");

			Console.ReadKey(true);
		}
		
		// Ejericio 5 : Implemente una función llenar que reciba un Coleccionable y que le agregue 20 comparables elegidos al azar.
		public static void llenar(Coleccionable a){
			
			Random random = new Random();
			Comparable numero;
			
			for (int i = 0; i < 20; i++) {
				numero=new Numero(random.Next(1,1000));
				a.agregar(numero);
			}
		}
		
		
		//Ejercicio 6 : Implemente una función informar que reciba un Coleccionable e imprima por consola la cantidad de elementos que tiene el coleccionable recibido por parámetro, el elemento
		//mínimo, el máximo y si contiene, o no, como elemento un valor leído por teclado.
		
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
			
			
			//Porcion descartado para el correcto funcionamiento del ejercicio 18 donde los Alumnos se comparan por Legajo y ya no mas por DNI.
			
			//Porción del código modificado para el funcionamiento correcto del ejercicio número 13.
			
//			Console.WriteLine("Por favor ingrese un valor númerico (veremos si lo encontramos en el coleccionble): ");
//			Comparable prueba = new Persona(" ",Convert.ToInt32(Console.ReadLine()));
//			
//			if (a.contiene(prueba)) {
//				Console.WriteLine("-- El elemento leído está en la coleccion. --\n\n");
//			}else{
//				Console.WriteLine("-- El elemento leído no está en la colección. --\n\n");
//			}
//		}
			
			
			//Porción del código descartado para el buen funcionamiento del ejercicio número 13.
			
//			Console.WriteLine("Por favor ingrese un valor númerico (veremos si lo encontramos en el coleccionble): ");
//			Comparable buscarNumero = new Numero(Convert.ToInt32(Console.ReadLine()));
//			
//			if (a.contiene(buscarNumero)) {
//				Console.WriteLine("-- El elemento leído está en la coleccion. --\n\n");
//			}else{
//				Console.WriteLine("-- El elemento leído no está en la colección. --\n\n");
//			}
//		}
		
		
		//Ejercicio 12 : Implemente una función llenarPersonas que reciba un Coleccionable y que le agregue 20 personas elegidos al azar. 
		
		public static void llenarPersonas(Coleccionable a){
			
			List<string> nombresVariados = new List<string>
			{
				"Mathias","Marianela","Jose","Josefina","Rocio",
				"Robert","Alan","Pablo","Walter","Nahuel","Francisco","Raquel"
			};
			
			Random randomNom = new Random();
			Random randomDni = new Random();
			
			
			Comparable c;
			
			for (int i = 0; i < 20; i++) {
				c = new Persona(nombresVariados[randomNom.Next(0,nombresVariados.Count)],randomDni.Next(30000000, 55000000));
				a.agregar(c);
			}
		}
		
		
		
		// Ejercicio 16 : Implemente una función llenaAlumnos que reciba un Coleccionable y que le agregue 20 alumnos elegidos al azar. 
		
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
	}
}