using System;
using Practica1___Mathias_Cabrera;
using Practica2;

namespace Practica_3.FactoryMethod.Comparables
{
	public class FabricaNumero:FabricaComparables
	{
		public FabricaNumero(){
			
		}
		
		public override Comparable crearAleatorio(){
			return new Numero(new Random().Next(0,9999999));
		}
		
		public override Comparable crearPorTeclado(){
			Console.WriteLine("Ingrese un numero: ");
			int numero=int.Parse(Console.ReadLine());
			return new Numero(numero);
			
		}
	}
}
