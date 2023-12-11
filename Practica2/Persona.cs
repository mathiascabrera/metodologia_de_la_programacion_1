using System;

namespace Practica1___Mathias_Cabrera
{
	public class Persona:Comparable
	{

		protected string nombre;
		protected int dni;
		
		public Persona(string n, int d)
		{
			this.nombre=n;
			this.dni=d;
		}
		
		public string getNombre{
			get{
				return this.nombre;
			}
		}
		
		public int getDNI{
			get{
				return dni;
			}
		}
		
		public bool sosIgual(Comparable a){
			
			Persona b = (Persona) a;
			
			if (this.dni == Convert.ToInt32(b.dni)) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMenor(Comparable a){
			
			Persona c = (Persona) a;
			
			if (this.dni > c.getDNI) {
				return true;
			}else{
				return false;
			}
		}
		
		public bool sosMayor(Comparable a){
			
			Persona c = (Persona)a;
			
			if (this.dni > c.getDNI) {
				return false;
			}else{
				return true;
			}			
		}
		
		public override string ToString()
        {
			return this.nombre.ToString()+" "+this.dni.ToString();
        }
	}
}
