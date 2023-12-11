using System;
using Practica1___Mathias_Cabrera;

namespace Practica2
{
	public class porValor : Strategy
	{
		public porValor()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			ClaveValor a1 = (ClaveValor) a;
			
			ClaveValor b1 = (ClaveValor) b;;
			
			return a1.valor.sosIgual(b1.valor);
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			ClaveValor a1 = (ClaveValor) a;
			
			ClaveValor b1 = (ClaveValor) b;
			
			return a1.valor.sosMenor(b1.valor);
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			ClaveValor a1 = (ClaveValor) a;
			
			ClaveValor b1 = (ClaveValor) b;
			
			return a1.valor.sosMayor(b1.valor);
		}
	}
	
}
