using System;
using Practica4.Adapter;

namespace Practica4.Decorator
{
	public class DecoradorPromocion:Decorador
	{
		public DecoradorPromocion(IAlumno a, int numero1):base(a,numero1)
		{
		}
		public override string mostrarCalificacion(){
			string estado="";
			
			int nota = this.getUltCalif();
			
			if (nota >= 7) {
				estado = "PROMOCIÓN";
			}else if(nota >= 4){
				estado = "APROBADO";
			}else{
				estado= "DESAPROBADO";
			}
			
			
			string s = base.mostrarCalificacion();
			s=s+" "+"("+estado+")";
			
			return s;
		}
	}
}
