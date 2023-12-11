using System;
using System.Collections.Generic;
using Practica2.Iterator;
using Practica5.Command;

namespace Practica1___Mathias_Cabrera
{
	public class Cola:Coleccionable, Iterable, Ordenable
	{
		List <Comparable> elems;
		
		OrdenEnAula1 ordenIncio, ordenAuLlena;
		OrdenEnAula2 ordenLlAlum;
		
		public Cola()
		{
			elems=new List <Comparable>();
		}
		
		public void encolar(Comparable a){
			
			elems.Add(a);
			
			if (cuantos()==1) {
				ordenIncio.ejecutar();
			}
			
			if (cuantos()==40) {
				ordenAuLlena.ejecutar();
			}
			
			ordenLlAlum.ejecutar(a);
		}
		
		public Comparable descencolar(){
			
			return elems[0];
			
		}
		
		
		public int cuantos(){
			
			return elems.Count;
			
		}
		
		
		public Comparable minimo(){
			
			Comparable a = elems[0];
			
			for (int i = 0; i < elems.Count; i++) {
				
				if (a.sosMenor(elems[i])) {
					a=elems[i];
				}
				
			}
			return a;
			
		}
		
		public Comparable maximo(){
			
			Comparable a = elems[0];
			
			for (int i = 0; i < elems.Count; i++) {
				
				if (a.sosMayor(elems[i])) {
					a=elems[i];
				}
				
			}
			return a;
			
		}
		public void agregar(Comparable a){
			
			encolar(a);
			
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
