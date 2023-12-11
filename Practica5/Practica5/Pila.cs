using System;
using System.Collections.Generic;
using Practica2.Iterator;
using Practica5.Command;

namespace Practica1___Mathias_Cabrera
{

	public class Pila:Coleccionable, Iterable, Ordenable
	{
		
		private List <Comparable> elems;
		
		OrdenEnAula1 ordenIncio, ordenAuLlena;
		OrdenEnAula2 ordenLlAlum;
		
		public Pila()
		{
			elems=new List <Comparable>();
		}
		
		
		public void push(Comparable a){
			
			elems.Add(a);
			
			if (cuantos()==1) {
				ordenIncio.ejecutar();
			}
			
			if (cuantos()==40) {
				ordenAuLlena.ejecutar();
			}
			
			ordenLlAlum.ejecutar(a);
			
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
		
		//Implemento el método del Iterable
		public Iterador crearIterador(){
			
			return new IteradorPila(elems);
		}
		
		public void setOrdenInicio(OrdenEnAula1 a){
			this.ordenIncio = a;
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 a){
			this.ordenLlAlum=a;
		}
		public void setOrdenAulaLlena(OrdenEnAula1 a){
			this.ordenAuLlena=a;
		}
	}
}
