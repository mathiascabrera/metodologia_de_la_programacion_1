using System;
using Practica4.Adapter;
namespace Practica4.Decorator
{
	public class DecoradoAsteriscos:Decorador
	{
		public DecoradoAsteriscos(IAlumno a, int numero1):base(a,numero1)
		{
		}
		public override string mostrarCalificacion(){
			
			string s = base.mostrarCalificacion();
			
			string asterisco = null;
			
			for (int i = 0; i < s.Length+2; i++) {
				asterisco = asterisco +"*";	
			}
			
			s=asterisco+"\n"+"*"+s+"*"+"\n"+asterisco;
			
			return s;
		}
	}
}
