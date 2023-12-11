using System;
using System.Collections.Generic;
using Practica2_2.Iterator;

namespace Practica1___Mathias_Cabrera
{
	public class Cola:Coleccionable, Iterable
	{
		List <Comparable> elems;
		
		public Cola()
		{
			elems=new List <Comparable>();
		}
		
		public void encolar(Comparable a){
			
			elems.Add(a);
			
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
		
//		public override string ToString()
//        {
//			string retornar=null;
//			
//			foreach (var element in elems) {
//				retornar = retornar + element.ToString()+"\n";
//			}
//			return retornar;
//        }
	}
}
