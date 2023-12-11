using System;
using Practica1___Mathias_Cabrera;

namespace Practica2.Iterator
{
	public interface Iterador
	{
		void primero();
		void siguiente();
		Comparable actual();
		bool fin();
		
	}
}
