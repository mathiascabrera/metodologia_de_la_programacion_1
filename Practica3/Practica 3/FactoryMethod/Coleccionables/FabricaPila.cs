using System;
using Practica1___Mathias_Cabrera;

namespace Practica_3.FactoryMethod.Coleccionables
{
	public class FabricaPila:FabricaColeccionable
	{
		public FabricaPila()
		{
		}
		public override Coleccionable crear(){
			return new Pila();
		}
	}
}
