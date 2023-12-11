using System;
using Practica1___Mathias_Cabrera;

namespace Practica_3.FactoryMethod.Coleccionables
{
	abstract public class FabricaColeccionable
	{
		public static Coleccionable crear(int opcion){
			
			//Opciones = 1(Pila), 2(Cola), 3(ColeccionMultiple), 4(Conjunto), 5(Diccionario)
			
			FabricaColeccionable f = null;
			
			
			switch(opcion){
				case 1:
					f=new FabricaPila();
					break;
				case 2:
					f=new FabricaCola();
					break;
				case 3:
					f=new FabricaColeccionMultiple();
					break;
				case 4:
					f=new FabricaConjunto();
					break;
				case 5:
					f=new FabricaDiccionario();
					break;
				default:
					return null;
			}
			return f.crear();
		}
		abstract public Coleccionable crear();
		
	}
}
