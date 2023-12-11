using System;
using Practica1___Mathias_Cabrera;
using Practica4.Adapter;

namespace Practica4.Decorator
{
	abstract public class Decorador:IAlumno
	{
		protected IAlumno alum1;
		protected int numero = 0;
		
		public  Decorador(IAlumno alum2, int numero1)
		{
			this.alum1=alum2;
			numero = numero + numero1;
		}
		public virtual int getLegajo(){
			return alum1.getLegajo();
		}
		public virtual double getPromedio(){
			return alum1.getPromedio();
		}
		public virtual int getUltCalif(){
			return alum1.getUltCalif();
		}
		public virtual string getNombre(){
			return alum1.getNombre();
		}
		public virtual int responderPregunta(int pregunta){
			return alum1.responderPregunta(pregunta);
		}
		public virtual void establecerCalificacion(int calificacion){
			alum1.establecerCalificacion(calificacion);
		}
		public virtual string mostrarCalificacion(){
			return alum1.mostrarCalificacion();
		}
		public virtual bool sosIgual(Comparable a){
			return alum1.sosIgual( (Comparable)((Decorador)a).alum1 );
		}
		public virtual bool sosMenor(Comparable a){
			return alum1.sosMenor((Comparable)((Decorador)a).alum1);
		}
		public virtual bool sosMayor(Comparable a){
			return alum1.sosMayor((Comparable)((Decorador)a).alum1);
		}
	}
}
