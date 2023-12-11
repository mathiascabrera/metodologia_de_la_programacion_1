using System;
using Practica1___Mathias_Cabrera;
using MetodologíasDeProgramaciónI;
using Practica4.Adapter;

namespace Practica5
{
	public class Aula
	{
		private Teacher teacher;
		
		public Aula()
		{
			
		}
		
		public void comenzar(){
			teacher = new Teacher();
		}
		
		public void nuevoAlumno(Comparable a){
			AlumnoAdaptador aa = new AlumnoAdaptador((IAlumno)a);
			teacher.goToClass((Student)aa);
		}
		
		public void claseLista(){
			teacher.teachingAClass();
		}
	}
}
