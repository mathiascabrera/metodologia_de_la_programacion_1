using System;
using Practica1___Mathias_Cabrera;

namespace Practica5.Command
{
	public class OrdenLlegaAlumno:OrdenEnAula2
	{
		Aula aula;
		public OrdenLlegaAlumno(Aula a)
		{
			this.aula=a;
		}
		
		public void ejecutar(Comparable a){
			aula.nuevoAlumno(a);
		}
	}
}
