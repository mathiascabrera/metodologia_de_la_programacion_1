using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;

namespace Practica2_2.Iterator
{
	public class IteradorDiccionario:Iterador
	{
		List<Comparable> elems;
		int indice;
		
		public IteradorDiccionario(List<Comparable> a)
		{
			elems = a;
		}
		
		public void primero(){
			indice=0;
		}
		
		public void siguiente(){
			indice ++;
		}
		
		public Comparable actual(){
			return ( (ClaveValor)elems[indice]).valor;
		}
		
		public bool fin(){
			return indice >= elems.Count;
		}
	}
}
