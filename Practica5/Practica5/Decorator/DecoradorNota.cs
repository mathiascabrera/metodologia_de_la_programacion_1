using System;
using Practica4.Adapter;

namespace Practica4.Decorator
{
	public class DecoradorNota:Decorador
	{
		public DecoradorNota(IAlumno a, int numero1):base(a,numero1)
		{
		}
		
		public override string mostrarCalificacion(){
			string nota="";
			switch(this.getUltCalif()){
				case 1:
					nota="UNO";
					break;
				case 2:
					nota="DOS";
					break;
				case 3:
					nota="TRES";
					break;
				case 4:
					nota="CUATRO";
					break;
				case 5:
					nota="CINCO";
					break;
				case 6:
					nota="SEIS";
					break;
				case 7:
					nota="SIETE";
					break;
				case 8:
					nota="OCHO";
					break;
				case 9:
					nota="NUEVE";
					break;
				case 10:
					nota="DIEZ";
					break;
			}
			
			string s = base.mostrarCalificacion();
			s=s+" "+"("+nota+")";
			
			
			return s;
		}
	}
}
