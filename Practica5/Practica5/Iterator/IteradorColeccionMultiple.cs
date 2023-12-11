using System;
using Practica1___Mathias_Cabrera;
using Practica2.Iterator;

namespace Practica_3.Iterator
{
	public class IteradorColeccionMultiple:Iterador2
	{
		Coleccionable pila;
		Coleccionable cola;
		int indice;
		
		public IteradorColeccionMultiple(Coleccionable p, Coleccionable c)
		{
			this.pila=p;
			this.cola=c;
		}
		public void primero(){
			indice=0;
		}
		
		public void siguiente(){
			indice ++;
		}
		
		public Coleccionable actual(){
			if (indice ==0) {
				return pila;
			}else{
				return cola;
			}
		}
		
		public bool fin(){
			return indice < 2;
		}
	}
}
