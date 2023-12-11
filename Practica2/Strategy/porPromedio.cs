using System;
using Practica1___Mathias_Cabrera;


namespace Practica2_2
{
	public class porPromedio : Strategy
	{
		
		// EJERCICIO 1
		
		public porPromedio()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if ( a1.getPromedio == b1.getPromedio) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getPromedio > b1.getPromedio) {
				return true;
			}else{
				return false;
			}
			
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getPromedio > b1.getPromedio) {
				return false;
			}else{
				return true;
			}
			
		}
	}
}
