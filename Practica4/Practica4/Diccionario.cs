using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;
using Practica2.Iterator;

namespace Practica2
{
	public class Diccionario : Coleccionable, Iterable
	{
		List<Comparable> elems;
		
		int clave;
		
		public Diccionario()
		{
			elems = new List<Comparable>();
			clave = 0;
		}
		
		internal void agregar(Comparable clave,Comparable valor){
			
			bool comprobacion = false;
			
			for (int i = 0; i < elems.Count; i++) {
				
				if ( ( (Comparable) ((ClaveValor) elems[i]).clave).sosIgual(clave)) {
					
					((ClaveValor)elems[i]).valor=valor;
					comprobacion = true;
				}
				
			}
			
			if(!comprobacion){
				elems.Add(new ClaveValor(clave,valor));
			}
		}
		
		public Comparable valorDe(Comparable clave){
			
			//Realizo de esta forma la comparacion para no setear la estrategia y alterar la referencia establecida para los métodos de Coleccionable
			//Ya que todos los metodos de la interface Coleccionable se van a comparar por Valor,
			//Mientras que los métodos de "agregar(clave, valor)" y "valorDe(clave)" funcionan en base a la clave.
			for (int i = 0; i < elems.Count; i++) {
				if ( ( (Comparable) ((ClaveValor) elems[i]).clave).sosIgual(clave)) {
					return ( (ClaveValor)elems[i]).valor;
				}
			}
			
			return null;
			
		}
		
		//Metodos de Coleccionable
		public int cuantos(){
			return this.elems.Count;
		}
		
		public Comparable minimo(){
			
			Comparable menor = elems[0];
			
			for (int i = 0; i < elems.Count; i++) {
//				((ClaveValor)elems[i]).setEstrategia(new porValor());
				
				if (elems[i].sosMenor(menor)) {
					
					menor = elems[i];
				}
			}
			return menor;
			
		}
		
		
		public Comparable maximo(){
			
			Comparable mayor = elems[0];
			
			for (int i = 0; i < elems.Count; i++) {
//				((ClaveValor)elems[i]).setEstrategia(new porValor());
				
				if (elems[i].sosMayor(mayor)) {
					
					mayor = elems[i];
				}
			}
			return mayor;	
		}
		
		
		
		public void agregar(Comparable a){
			
			clave=clave+1;
			
			this.agregar(new Numero(clave),a);
			
//			elems.Add(new ClaveValor(a,new Numero(clave)));
			
		}
		
		
		public bool contiene(Comparable a){
			
			Comparable aux = new ClaveValor(new Numero(new Random().Next(0,999999)),a);
			
			for (int i = 0; i < elems.Count; i++) {
				
//				((ClaveValor)elems[i]).setEstrategia(new porValor());
				
				if (elems[i].sosIgual(aux)) {
					
					return true;
					
				}
			}
			
			return false;
		}
		
		
		//Iterable
		public Iterador crearIterador(){
			return new IteradorDiccionario(this.elems);
		}
		
		
		
		
	}
}
