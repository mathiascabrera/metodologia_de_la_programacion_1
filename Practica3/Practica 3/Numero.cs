using System;

namespace Practica1___Mathias_Cabrera
{
	public class Numero:Comparable
	{
		
		private int valor;
        
        public Numero(int numero) {
            this.valor = numero;
        }
		public int getValor(){
			return valor;
		 }

        public bool sosIgual(Comparable a)
        {
            Numero n = (Numero)a;

            if (valor ==   Convert.ToInt32(n.getValor())) {return true; }
            else { return false; }
        }
        public bool sosMenor(Comparable a)
        {
            Numero n = (Numero)a;

            if (valor > Convert.ToInt32(n.getValor())) { return true; }
            else { return false; }
        }
        public bool sosMayor (Comparable a)
        {
            Numero n = (Numero) a;
            return valor < Convert.ToInt32(n.getValor());
        }
        
        public override string ToString()
        {
        	return this.valor.ToString();
        }
	}
}
