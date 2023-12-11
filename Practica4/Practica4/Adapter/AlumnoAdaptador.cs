using System;
using MetodologíasDeProgramaciónI;
using Practica1___Mathias_Cabrera;
using Practica4.Decorator;

namespace Practica4.Adapter
{
	public class AlumnoAdaptador:Student,IAlumno
	{
		private IAlumno alum1;
		
		public AlumnoAdaptador(IAlumno alum2)
		{
			this.alum1= alum2;
		}
		
		public IAlumno getAlumno(){
			return alum1;
		}
		
		public void SetAlumno(IAlumno a){
			this.alum1 = a;
		}
		
		public string getName(){
			return alum1.getNombre();
		}
		public int yourAnswerIs(int question){
			return alum1.responderPregunta(question);
		}
		public void setScore(int score){
			alum1.establecerCalificacion(score);
		}
		public string showResult(){
			return alum1.mostrarCalificacion();
		}
		public bool equals(Student student){
			return alum1.sosIgual(((AlumnoAdaptador)student).getAlumno());
		}
		
		public bool lessThan(Student student){
			return alum1.sosMenor(((AlumnoAdaptador)student).getAlumno());
		}
		public bool greaterThan(Student student){
			return alum1.sosMayor(((AlumnoAdaptador)student).getAlumno());
		}
		
		public int getLegajo(){
			return 0;
		}
		public double getPromedio(){
			return 0;
		}
		public int getUltCalif(){
			return 0;
		}
		public string getNombre(){
			return "";
		}
		public int responderPregunta(int pregunta){
			return 0;
		}
		public void establecerCalificacion(int calificacion){
			
		}
		public string mostrarCalificacion(){
			return "";
		}
		
		public bool sosIgual(Comparable a){
			
			return false;
		
		}
        
		public bool sosMenor(Comparable a){
			return false;
		}
        
		public bool sosMayor(Comparable a){
			return false;
		
		}
	}
}
