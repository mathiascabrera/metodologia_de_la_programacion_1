using System;

namespace Practica1___Mathias_Cabrera
{
	
	public class Alumno : Persona , Comparable
	{
		//Ejercicio 15 = Implemente la clase Alumno que sea subclase de Persona
		
		private int legajo;
		private double promedio;
		
		public Alumno(string n, int d, int l, double p):base(n,d)
		{
			this.legajo = l;
			this.promedio=p;
		}
		public int getLegajo{
			get{
				return this.legajo;
			}
		}
		public double getPromedio{
			get{
				return this.promedio;
			}
		}
		
		//Implementacion para el ejercicio 18
		public bool sosIgual(Comparable a){
			
			Alumno b = (Alumno) a;
			
			if (this.legajo == b.getLegajo) {
				return true;
			}else{
				return false;
			}
		}
		
		//Implementacion para el ejercicio 18
		public bool sosMenor(Comparable a){
			
			Alumno c = (Alumno) a;
			
			if (this.legajo > c.getLegajo) {
				return true;
			}else{
				return false;
			}
		}
		
		//Implementacion para el ejercicio 18
		public bool sosMayor(Comparable a){
			
			Alumno c = (Alumno)a;
			
			if (this.legajo > c.getLegajo) {
				return false;
			}else{
				return true;
			}			
		}
		
		//Implementacion para el ejercicio 18
		public override string ToString()
        {
			return "Nombre: "+ this.getNombre.ToString()+" .Dni: "+this.getDNI.ToString()+" . Legajo: "+this.legajo.ToString()+" . Promedio: "+this.promedio.ToString();
        }
		
	}
}
