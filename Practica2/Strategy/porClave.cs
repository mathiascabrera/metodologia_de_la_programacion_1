using System;
using Practica1___Mathias_Cabrera;

namespace Practica2_2
{
	public class porClave: Strategy
	{
		public porClave()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			ClaveValor a1 = (ClaveValor) a;
			
			ClaveValor b1 = (ClaveValor) b;
			
			return a1.clave.sosIgual(b1.clave);
		}
        
		public bool sosMenor(Comparable a, Comparable b){
			
			ClaveValor a1 = (ClaveValor) a;
			
			ClaveValor b1 = (ClaveValor) b;
			
			return a1.clave.sosMenor(b1.clave);
		}
        
		public bool sosMayor(Comparable a, Comparable b){
			
			ClaveValor a1 = (ClaveValor) a;
			
			ClaveValor b1 = (ClaveValor) b;
			
			return a1.clave.sosMayor(b1.clave);
		}
	}
}
