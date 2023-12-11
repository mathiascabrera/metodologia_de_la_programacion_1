using System;
using System.Collections.Generic;
namespace Practica1___Mathias_Cabrera
{
	public class Pila:Coleccionable
	{
		/*Ejercicio 4: Implemente las clases Pila y Cola (vistas en Algoritmos y Programación)
	 	* y haga que las dos clases la implementacion de la interface Coleccionable.*/
	
		List <Comparable> elems;
		
		
		public Pila()
		{
			elems=new List <Comparable>();
		}
		
		
		public void push(Comparable a){
			elems.Add(a);
		}
		
		public Comparable pop(){
			
			Comparable b = elems[elems.Count - 1];
			elems.Remove(b);
			return b;
		}
		
		public int cuantos(){
			
			return elems.Count;
		}
		
		public Comparable minimo(){
			
			Comparable menor = elems[0];
			
			for (int i = 0; i < elems.Count; i++) {
				
				if ( menor.sosMenor(elems[i]) ) {
					
					menor=elems[i];
					
				}
			}
			return menor;
			
		}
		
		public Comparable maximo(){
			
			Comparable mayor = null;
			
			int cantidad =0;
			
			while (elems.Count >= cantidad) {
				
				mayor = elems[0];
				
				for (int i = 0; i < elems.Count; i++) {
					
					cantidad++;
					
					if ( mayor.sosMayor(elems[i])) {
						
						mayor=elems[i];
						
					}
				}
			}
			
			return mayor;
			
		}
		public void agregar(Comparable a){
			
			push(a);
			
		}
		

		
		public bool contiene(Comparable a){
			
			for (int i = 0; i < elems.Count; i++) {
				
				if (elems[i].sosIgual(a)) {
					
					return true;
					
				}
			}
			
			return false;
			
		}
	}
}
