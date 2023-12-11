using System;
using Practica_3.Observer;
using Practica2;
using Practica1___Mathias_Cabrera;

//using Practica_3.Strategy;



namespace Practica_3
{
	public class Profesor: Persona, Comparable
	{
		
		private int antiguedad;
		private Strategy estrategia;
		
		//Persona(string n, int d)
		
		public Profesor(string n, int d, int a ):base(n,d)
		{
			this.antiguedad = a;
			
			this.estrategia = new porAntiguedad();
		}
		
		public int getAntiguedad{
			get{
				return this.antiguedad;
			}
		}
		
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algún tema.");
			this.notificar(true);
		}
		
		public void escribirEnElPizarron(){
			Console.WriteLine("Escribiendo en el pízarron.");
			this.notificar(false);
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
			return "Nombre: "+ this.getNombre.ToString()+" .Dni: "+this.getDNI.ToString()+" . Antiguedad: "+this.antiguedad.ToString()+".";
        }
	}
}
