using System;
using Practica1___Mathias_Cabrera;


namespace Practica2_2
{
	public class porDni : Strategy
	{
		// EJERCICIO 1
		
		public porDni()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if ( a1.getDNI == b1.getDNI) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getDNI > b1.getDNI) {
				return true;
			}else{
				return false;
			}
			
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getDNI > b1.getDNI) {
				return false;
			}else{
				return true;
			}
			
		}
		
	}
}
