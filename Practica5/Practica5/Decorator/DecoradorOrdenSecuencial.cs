using System;
using Practica4.Adapter;

namespace Practica4.Decorator
{
	public class DecoradorOrdenSecuencial:Decorador
	{
		public DecoradorOrdenSecuencial(IAlumno a, int numero1):base(a,numero1)
		{
		}
		
		public override string mostrarCalificacion(){
			
			string s = base.mostrarCalificacion();
			
			s=this.numero+") "+s;
			return s;
		}
	}
}
