using System;
using Practica1___Mathias_Cabrera;

namespace Practica2_2
{
	public class porLegajo:Strategy
	{
		// EJERCICIO 1
		
		public porLegajo()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if ( a1.getLegajo == b1.getLegajo) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getLegajo > b1.getLegajo) {
				return true;
			}else{
				return false;
			}
			
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getLegajo > b1.getLegajo) {
				return false;
			}else{
				return true;
			}
			
		}
		
	}
}
