using System;

namespace Practica5.Command
{
	public class OrdenInicio:OrdenEnAula1
	{
		Aula a;
		
		public OrdenInicio(Aula a)
		{
			this.a=a;
		}
		public void ejecutar(){
			a.comenzar();
		}
	}
}
