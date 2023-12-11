using System;
using Practica1___Mathias_Cabrera;
using Practica4.Adapter;
using Practica4.Decorator;
using Practica4.FactoryMethod.Comparables;

namespace Practica5.FactoryMethod.Comparables
{
	public class FabricaDecoradosAlumEst:FabricaAlumnoMuyEstudioso
	{
		public FabricaDecoradosAlumEst()
		{
		}
		
		public override Comparable crearAleatorio(){
			
			Comparable comp = base.crearAleatorio();
			IAlumno dec = new DecoradorNota((IAlumno)comp,1);
			dec = new DecoradorLegajo(dec,2);
			dec=new DecoradorPromocion(dec,3);
			dec=new DecoradorOrdenSecuencial(dec,4);
			dec=new DecoradoAsteriscos(dec,5);
			
			return ((Comparable)dec);
		}
		
		public override Comparable crearPorTeclado(){
			
			Comparable comp = base.crearPorTeclado();
			IAlumno dec = new DecoradorNota((IAlumno)comp,1);
			dec = new DecoradorLegajo(dec,2);
			dec=new DecoradorPromocion(dec,3);
			dec=new DecoradorOrdenSecuencial(dec,4);
			dec=new DecoradoAsteriscos(dec,5);
			
			return ((Comparable)dec);
		}
	}
}
