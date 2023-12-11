using System;
using Practica1___Mathias_Cabrera;
using Practica2;

namespace Practica_3.FactoryMethod.Coleccionables
{
	public class FabricaConjunto:FabricaColeccionable
	{
		public FabricaConjunto()
		{
		}
		public override Coleccionable crear(){
			return new Conjunto();
		}
	}
}
