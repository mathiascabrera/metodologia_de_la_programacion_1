using System;

namespace Practica1___Mathias_Cabrera
{
	public class ColeccionMultiple:Coleccionable
	{
		
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
		
		public void agregar(Comparable a){
			
			Console.WriteLine("\nIngrese 1 para agregar el Comparable en la Pila, o 2 para agregarlo en la Cola: ");
			int opcion = int.Parse(Console.ReadLine());
			
			if(opcion ==1){
				pila.agregar(a);
			}else if (opcion ==2) {
				cola.agregar(a);
			}else{
				Console.WriteLine("\nValor ingresado no válido.\n");
			}
		}
		
		public bool contiene(Comparable a){

			if ( pila.contiene(a) || cola.contiene(a) ) {

				return true;

			}else{
				return false;
			}

		}
	}
}
