using System;

namespace Practica_3
{
	public class LectorDeDatos
	{
		private int num;
		private string str;
		
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado(){
			return (this.num = Convert.ToInt32(Console.ReadLine()));
		}
		
		public string stringPorTeclado(){
			return(this.str = Console.ReadLine());
		}
	}
}
