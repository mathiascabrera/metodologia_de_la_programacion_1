using System;
using System.Text;

namespace Practica_3
{
	public class GeneradorDeDatosAleatorios
	{
		private int num {get ; set;}
		private string pal {get ; set;}
		
		public GeneradorDeDatosAleatorios()
		{
			num = 0;
			pal=" ";
		}
		
		public int numeroAleatorio(int max){
			return this.num=new Random().Next(0,max);
		}
		
		public string stringAleatorio(int cant){
			
			const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			StringBuilder a = new StringBuilder();
			
			for (int i = 0; i < cant; i++) {
				num = new Random().Next(caracteres.Length);
				a.Append(caracteres[num]);
			}
			return a.ToString();
		}
		
	}
}
