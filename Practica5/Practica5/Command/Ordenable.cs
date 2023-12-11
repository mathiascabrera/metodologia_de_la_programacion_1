using System;

namespace Practica5.Command
{
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 a);
		void setOrdenLlegaAlumno(OrdenEnAula2 a);
		void setOrdenAulaLlena(OrdenEnAula1 a);
		
	}
}
