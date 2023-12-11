using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;
using Practica2_2.Iterator;

namespace Practica2_2
{
	public class Conjunto :Coleccionable, Iterable
	{
		
		// EJERCICIO 3
		
		private List<Comparable> elementos;
		
		public Conjunto(){
			elementos = new List<Comparable>();
		}
		
		public void agregar(Comparable e){
			
			if (elementos.Count == 0) {
				elementos.Add(e);
			}else{
				if (!elementos.Contains(e)) {
					elementos.Add(e);
				}
			}
			
//			if (elementos.Count == 0) {
//				elementos.Add(e);
//			}else{
//				for (int i = 0; i < elementos.Count; i++) {
//					
//					if (!elementos[i].sosIgual(e)) {
//						elementos.Add(e);
//						break;
//					}
//					
//				}
//			}
		}
		
		public bool pertenece(Comparable e){
			return this.contiene(e);
		}
		
		
		public bool contiene(Comparable e){
			
			for (int i = 0; i < elementos.Count; i++) {
				
				if (elementos[i].sosIgual(e)) {
					return true;
				}
			}
			return false;
		}
		
		
		//Metodos de Coleccionable
		public int cuantos(){
			return elementos.Count;
		}
		
		public Comparable minimo(){
			
			Comparable menor = elementos[0];
			
			for (int i = 0; i < elementos.Count; i++) {
				
				if (menor.sosMenor(elementos[i])) {
					
					menor = elementos[i];
				}
			}
			return menor;
		}
		
		
		public Comparable maximo(){
			
			Comparable mayor = null;
			
			int cantidad =0;
			
			while (elementos.Count >= cantidad) {
				
				mayor = elementos[0];
				
				for (int i = 0; i < elementos.Count; i++) {
					
					cantidad++;
					
					if ( mayor.sosMayor(elementos[i])) {
						
						mayor=elementos[i];
						
					}
				}
			}
			return mayor;
		}
		
		//Implemento el método del Iterable
		public Iterador crearIterador(){
			
			return new IteradorPila(elementos);
		}
		
		
//		public override string ToString()
//        {
//			string retornar=null;
//			
//			foreach (var element in elementos) {
//				retornar = retornar + element.ToString()+"\n";
//			}
//			return retornar;
//        }
	}
}
