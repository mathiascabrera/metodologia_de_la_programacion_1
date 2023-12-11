using System;

namespace Practica1___Mathias_Cabrera
{
	public interface Coleccionable
	{
		/* Ejercicio 3 : Implemente la interface Coleccionable que represente objetos que almacenan comparables
		* Debe contener los siguientes metodos :
		* "cuantos" que devuelve la cantidad de elementos comaparables que tiene el coleccionable.
		* "mínimo" que devuelve el elemento de menor valor de la coleccion.
		* "maximo" que devuelve el elemento de mayor valor de la coleccion.
		* "agregar (Comparable)" que agrega el comparable recibido por parametro a la coleccion que recibe el mensaje.
		* "contiene (Comparable)" que devuelve verdadero si el comparable recibido por parámetro está incluído en la colección y falso en caso contrario. */
		
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable a);
		bool contiene(Comparable a);
	}
}
