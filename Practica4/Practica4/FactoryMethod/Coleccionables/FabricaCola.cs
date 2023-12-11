using System;
using Practica1___Mathias_Cabrera;

namespace Practica_3.FactoryMethod.Coleccionables
{
	public class FabricaCola:FabricaColeccionable
	{
		public FabricaCola()
		{
		}
		public override Coleccionable crear(){
			return new Cola();
		}
	}
}
