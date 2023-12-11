using System;

namespace Practica1___Mathias_Cabrera
{
	public interface Comparable
	{
		//Ejercicio 1 : Implementación de una interface que representa cualquier objeto que sabe compararse con otro objeto de su "mismo tipo".
		
        bool sosIgual(Comparable a);
        
        bool sosMenor(Comparable a);
        
        bool sosMayor(Comparable a);
        
        /* Asumiremos que el elemento que recibe el mensaje y el objeto recibido por parámetro son del “mismo tipo” */

	}
}
