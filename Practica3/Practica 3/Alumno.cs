using System;
using Practica_3.Observer;
using Practica2;

namespace Practica1___Mathias_Cabrera
{
	
	public class Alumno : Persona, Comparable, IObservador
	{
		
		private int legajo;
		private double promedio;
		private Strategy estrategia;
		
		
		public Alumno(string n, int d, int l, double p):base(n,d)
		{
			this.legajo = l;
			this.promedio=p;
			this.estrategia= new porDni();//Por defecto se va a comparar porDni
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
		
		internal void prestarAtencion(){
			Console.WriteLine("\nPrestando atencion.\n");
		}
		
		internal void distraerse(){
			Console.WriteLine("\nMirando el celular.\n");
		}
		
		public void actualizar(bool o){
			if (o) {
				this.prestarAtencion();
			}else{
				this.distraerse();
			}
		}
		
		public bool sosIgual(Comparable a){
			
			return estrategia.sosIgual(this,a);
		}
		
		
		public bool sosMenor(Comparable a){
			
			return estrategia.sosMenor(this,a);
		}
		
		
		public bool sosMayor(Comparable a){
			
			return estrategia.sosMayor(this,a);
		}
		
		public void cambiarEstrategia(Strategy a){
			
			estrategia = a;
			
		}
		
		
		public override string ToString()
		{
			return "Nombre: "+ this.getNombre.ToString()+" .Dni: "+this.getDNI.ToString()+" . Legajo: "+this.legajo.ToString()+" . Promedio: "+this.promedio.ToString();
		}
		
	}
}
