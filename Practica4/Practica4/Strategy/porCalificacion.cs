using System;
using Practica2;
using Practica1___Mathias_Cabrera;

namespace Practica2
{
	public class porCalificacion : Strategy
	{
		public porCalificacion()
		{
		}
		public bool sosIgual(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if ( a1.getUltCalif() == b1.getUltCalif()) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if (a1.getUltCalif()> b1.getUltCalif()) {
				return true;
			}else{
				return false;
			}
			
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			Alumno a1 = (Alumno) a;
			
			Alumno b1 = (Alumno) b;
			
			if ( a1.getUltCalif() > b1.getUltCalif()) {
				return false;
			}else{
				return true;
			}
			
		}
	}
}
