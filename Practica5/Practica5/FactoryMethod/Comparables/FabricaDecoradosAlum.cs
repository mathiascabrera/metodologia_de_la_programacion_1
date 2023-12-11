using System;
using Practica1___Mathias_Cabrera;
using Practica4.Adapter;
using Practica4.Decorator;
using Practica_3.FactoryMethod.Comparables;

namespace Practica5.FactoryMethod.Comparables
{
	public class FabricaDecoradosAlum:FabricaAlumno
	{
		public FabricaDecoradosAlum()
		{
		}
		
		public override Comparable crearAleatorio(){
			
			Alumno comp =(Alumno) base.crearAleatorio();
			IAlumno dec = new DecoradorNota((IAlumno)comp,1);
			dec = new DecoradorLegajo(dec,2);
			dec=new DecoradorPromocion(dec,3);
			dec=new DecoradorOrdenSecuencial(dec,4);
			dec=new DecoradoAsteriscos(dec,5);
			
			return((Comparable)dec);
		}
		
		public override Comparable crearPorTeclado(){
			
			Alumno comp =(Alumno) base.crearPorTeclado();
			IAlumno dec = new DecoradorNota((IAlumno)comp,1);
			dec = new DecoradorLegajo(dec,2);
			dec=new DecoradorPromocion(dec,3);
			dec=new DecoradorOrdenSecuencial(dec,4);
			dec=new DecoradoAsteriscos(dec,5);
			
			return((Comparable) dec);
		}
		
	}
}
