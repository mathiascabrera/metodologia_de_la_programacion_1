using System;
using Practica1___Mathias_Cabrera;

namespace Practica2_2
{
	public interface Strategy
	{
		
		// EJERCICIO 1
		
		//Implemente cuatro estrategias de comparación para la clase Alumno definida en la práctica anterior. Realice una estrategia para que compare alumnos
		//por nombre, otra para que compare por DNI, otra para que compare por promedio y una última estrategia que compare por legajo.
		
		bool sosIgual(Comparable a, Comparable b);
		
		bool sosMenor(Comparable a, Comparable b);
		
		bool sosMayor(Comparable a, Comparable b);
		
	}
}
