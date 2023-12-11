using System;

namespace Practica1___Mathias_Cabrera
{
	public interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable a);
		bool contiene(Comparable a);
	}
}
