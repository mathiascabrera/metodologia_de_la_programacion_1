using System;

namespace Practica5.Command
{
	public class OrdenAulaLlena:OrdenEnAula1
	{
		Aula a;
		
		public OrdenAulaLlena(Aula a)
		{
			this.a=a;
		}
		public void ejecutar(){
			a.claseLista();
		}
	}
}
