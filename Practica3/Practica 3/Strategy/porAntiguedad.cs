using System;
using Practica1___Mathias_Cabrera;
using Practica_3;
//using Practica2;

namespace Practica2
{
	public class porAntiguedad:Strategy
	{
		public porAntiguedad()
		{
		}
		
		public bool sosIgual(Comparable a, Comparable b){
			
			Profesor a1 = (Profesor) a;
			
			Profesor b1 = (Profesor) b;
			
			if ( a1.getAntiguedad == b1.getAntiguedad) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a, Comparable b){
			
			Profesor a1 = (Profesor) a;
			
			Profesor b1 = (Profesor) b;
			
			if (a1.getAntiguedad > b1.getAntiguedad) {
				return true;
			}else{
				return false;
			}
			
		}
		
		public bool sosMayor(Comparable a, Comparable b){
			
			Profesor a1 = (Profesor) a;
			
			Profesor b1 = (Profesor) b;
			
			if (a1.getAntiguedad > b1.getAntiguedad) {
				return false;
			}else{
				return true;
			}
			
		}
	}
}
