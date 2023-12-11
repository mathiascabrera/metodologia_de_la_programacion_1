using System;
using Practica1___Mathias_Cabrera;

namespace Practica_3.FactoryMethod.Coleccionables
{
	public class FabricaColeccionMultiple:FabricaColeccionable
	{
		public FabricaColeccionMultiple()
		{
		}
		public override Coleccionable crear(){
			
			//Opciones = 1(Pila), 2(Cola), 3(ColeccionMultiple), 4(Conjunto), 5(Diccionario)
			
			Coleccionable pila = FabricaColeccionable.crear(1);
			
			Coleccionable cola = FabricaColeccionable.crear(2);
			
			return new ColeccionMultiple(pila, cola);
		}
	}
}
