using System;

namespace Practica1___Mathias_Cabrera
{
	public class Numero:Comparable
	{
		/*Ejercicio 2 : Implemente la clase Numero:
         Que posea una variable del tipo entero llamada "valor".
        A su vez, un constructor que reciba una variable y lo almacene en la variable "valor".
        Implementar getValor que retorne la variable "valor".
        Además, esta clase debe implementar la interface Comparable.*/
		
		int valor;
        
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
        
        //Primera modificacion en el trabajo:
        public override string ToString()
        {
        	return this.valor.ToString();
        }
	}
}
