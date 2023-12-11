using System;
using Practica4.Adapter;

namespace Practica4.Decorator
{
	public class DecoradorLegajo:Decorador
	{
		public DecoradorLegajo(IAlumno a, int numero1):base(a,numero1)
		{
		}
		public override string mostrarCalificacion(){
			
			string s = base.mostrarCalificacion();
			s=s+" "+this.getLegajo();
			
			return s;
		}
	}
}
