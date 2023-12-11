using System;
using Practica1___Mathias_Cabrera;

namespace Practica2
{
	public class ClaveValor: Comparable {
		
		internal Comparable clave {get ; set;}//Numero
		internal Comparable valor {get;set;}//Cualquier otro Comparable
		internal Strategy estrategia;
		
		public ClaveValor(Comparable clave, Comparable valor)
		{
			this.clave=clave;
			this.valor=valor;
			estrategia = new porValor();
			
		}
		
		public bool sosIgual(Comparable a){
			
			return estrategia.sosIgual(this,a);
		}
        
		public bool sosMenor(Comparable a){
			
			return estrategia.sosMenor(this,a);
		}
        
		public bool sosMayor(Comparable a){
			
			return estrategia.sosMayor(this,a);
			
		}
		
		public void setEstrategia(Strategy a){
			estrategia = a;
		}
		
		public override string ToString()
        {
			return "Clave: "+ this.clave.ToString()+" .Valor: "+this.valor.ToString();
        }
	}
}
