using System;
using Practica1___Mathias_Cabrera;

namespace Practica_3.Iterator
{
	public interface Iterador2
	{
		void primero();
		void siguiente();
		Coleccionable actual();
		bool fin();
	}
}
