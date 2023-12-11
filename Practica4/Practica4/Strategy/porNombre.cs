using System;
using Practica1___Mathias_Cabrera;

namespace Practica2
{
	
	public class porNombre : Strategy
	{
		// EJERCICIO 1
		
		public porNombre()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if ( a1.getNombre() == b1.getNombre()) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			
			// Utilizamos el método CompareTo para comparar las primeras letras de los nombres.
			int comparacion = a1.getNombre()[0].ToString().CompareTo(b1.getNombre()[0].ToString());

			// Si comparación es menor que cero, significa que a1 es "menor" que b1 alfabéticamente.
    		// Si comparación es mayor que cero, significa que a1 es "mayor" que b1 alfabéticamente.
    		// Si comparación es igual a cero, significa que a1 y b1 tienen la misma primera letra.

			
			if (comparacion > 0)
			{
				return true; // a1 es "mayor" que b1
			}
			else
			{
				return false; // a1 no es "mayor" que b1
			}
			
			
//			if (a1.getNombre.Length > b1.getNombre.Length) {
//				return true;
//			}else{
//				return false;
//			}
			
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			
			// Utilizamos el método CompareTo para comparar las primeras letras de los nombres.
			int comparacion = a1.getNombre()[0].ToString().CompareTo(b1.getNombre()[0].ToString());

			// Si comparación es menor que cero, significa que a1 es "menor" que b1 alfabéticamente.
    		// Si comparación es mayor que cero, significa que a1 es "mayor" que b1 alfabéticamente.
    		// Si comparación es igual a cero, significa que a1 y b1 tienen la misma primera letra.

			
			if (comparacion < 0)
			{
				return true; // b1 es "mayor" que a1
			}
			else
			{
				return false; // a1 es "mayor" que b1
			}
			
//			if (a1.getNombre.Length > b1.getNombre.Length) {
//				return false;
//			}else{
//				return true;
//			}
			
		}
	}
}
