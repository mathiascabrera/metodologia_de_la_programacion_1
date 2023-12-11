using System;
using Practica_3;
using Practica_3.Observer;
using Practica2;
using Practica4.Adapter;
//using Practica4.Strategy;

namespace Practica1___Mathias_Cabrera
{
	
	public class Alumno : Persona, Comparable, IObservador,IAlumno
	{
		private static GeneradorDeDatosAleatorios a = new GeneradorDeDatosAleatorios();
		private int legajo;
		private double promedio;
		private Strategy estrategia;
		private int ultimaCalificacion;
		private string apellido {get ; set;}
		
		
		public Alumno(string n, string ape,int d, int l, double p, int ultimaCalificacion):base(n,d)
		{
			this.apellido=ape;
			this.legajo = l;
			this.promedio=p;
			this.ultimaCalificacion = ultimaCalificacion;
			this.estrategia= new porCalificacion();
		}
		
		
		
		public int getLegajo(){
			return this.legajo;
		}
		
		
		
		public double getPromedio(){
			return promedio;
		}
		
		public int ultCalifSet{
			set{
				ultimaCalificacion=value;
			}
		}
		
		public int getUltCalif(){
			return ultimaCalificacion;
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
		
		public virtual int responderPregunta(int pregunta){
			
			return a.numeroAleatorio(3);
		}
		
		public string mostrarCalificacion(){
			return this.nombre.ToString()+" "+this.apellido.ToString()+" "+this.ultimaCalificacion.ToString();
		}
		
		public void establecerCalificacion(int calificacion){
			this.ultCalifSet=calificacion;
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
			return "Nombre: "+ this.nombre.ToString()+". Apellido: "+this.apellido.ToString()+" .Dni: "+this.getDNI.ToString()+" . Legajo: "+this.legajo.ToString()+" . Promedio: "+this.promedio.ToString();
		}
		
	}
}
