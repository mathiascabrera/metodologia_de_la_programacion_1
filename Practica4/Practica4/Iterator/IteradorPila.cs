using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;

namespace Practica2.Iterator
{
	public class IteradorPila : Iterador
	{
		List<Comparable> elems;
		int indice;
		
		public IteradorPila(List<Comparable> a)
		{
			elems=a;
		}
		
		public void primero(){
			indice=0;
		}
		public void siguiente(){
			indice ++;
		}
		public Comparable actual(){
			return elems[indice];
		}
		public bool fin(){
			return indice >= elems.Count;
		}
		
		
	}
}
