using System;
using Practica1___Mathias_Cabrera;
using Practica_3.FactoryMethod.Comparables;
using Practica4.Adapter;

namespace Practica5.Proxy
{
	public class ProxyAlumno:IAlumno, Comparable
	{
		IAlumno alum;
		
		private string nombre;
		private int opcion;
		
		public ProxyAlumno(string nombre, int opcion)
		{
			alum = null;
			this.nombre=nombre;
			this.opcion=opcion;
		}
		
		public int getLegajo(){
			
			if (alum==null) {
				
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.getLegajo();
			
		}
		public double getPromedio(){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.getPromedio();
		}
		public int getUltCalif(){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.getUltCalif();
		}
		public void setNombre(string nom){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				}
			alum.setNombre(nom);
		}
		
		public string getNombre(){
			return this.nombre;
		}
		
		public int responderPregunta(int pregunta){
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.responderPregunta(pregunta);
		}
		
		public void establecerCalificacion(int calificacion){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			alum.establecerCalificacion(calificacion);
			
		}
		public string mostrarCalificacion(){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.mostrarCalificacion();
		}
		public bool sosIgual(Comparable a){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.sosIgual(a);
		}
		public bool sosMenor(Comparable a){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.sosMenor(a);
		}
		public bool sosMayor(Comparable a){
			
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			return alum.sosMayor(a);
		}
		
		
		
		public void Instanciar(){
			if (alum==null) {
				Console.WriteLine("\nCreacion del Alumno (Desde el Proxy)\n");
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
		}
		
		public IAlumno getAlumno(){
			
			if (alum==null) {
				alum=(IAlumno)FabricaComparables.crearAleatorio(opcion);
				alum.setNombre(this.nombre);
			}
			
			return alum;
		}
	}
}
