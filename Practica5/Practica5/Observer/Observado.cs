using System;
using System.Collections.Generic;

namespace Practica_3.Observer
{
	abstract public class Observado
	{
		List<IObservador> observadores = new List<IObservador>();
		public Observado()
		{
		}
		public void agregarObservador(IObservador o){
			observadores.Add(o);
		}
		public void quitarObservador(IObservador o){
			observadores.Remove(o);
		}
		public void notificar(bool a){
			foreach (IObservador element in observadores) {
				element.actualizar(a);
			}
		}
	}
}
