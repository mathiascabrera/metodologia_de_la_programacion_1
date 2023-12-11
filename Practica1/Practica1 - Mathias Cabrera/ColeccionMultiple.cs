using System;

namespace Practica1___Mathias_Cabrera
{
	public class ColeccionMultiple:Coleccionable
	{
		//Ejercicio 8 : Cree la clase ColeccionMultiple. Haga que la clase ColeccionMultiple implemente la interface Coleccionable.
		
		private Coleccionable pila;
		private Coleccionable cola;
		
		public ColeccionMultiple(Coleccionable p, Coleccionable c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		
		//Devuelve la cantidad de elementos de ambos coleccionables
		public int cuantos(){
			return ((pila.cuantos()) + (cola.cuantos()));
		}
		
		// Devuelve el elemento de menor valor entre ambos coleccionables
		public Comparable minimo(){
			
			Comparable cPila = pila.minimo();
			Comparable cCola = cola.minimo();
			
			if (cPila.sosMenor(cCola)) {
				return cCola;
			}else{
				return cPila;
			}
		}
		
		// Devuelve el elemento de mayor valor entre ambos coleccionables
		public Comparable maximo(){
			
			Comparable cPila = pila.maximo();
			Comparable cCola = cola.maximo();
			
			if (cPila.sosMayor(cCola)) {
				return cCola;
			}else{
				return cPila;
			}
			
		}
		
		//no hace nada
		public void agregar(Comparable a){
			
		}
		
		public bool contiene(Comparable a){

			if ( (pila.contiene(a) && cola.contiene(a)) || (pila.contiene(a) || cola.contiene(a)) ) {

				return true;

			}else{
				return false;
			}

		}
	}
}
