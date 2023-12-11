using System;
using Practica1___Mathias_Cabrera;
using Practica4.Adapter;
using Practica4.Decorator;

namespace Practica4.FactoryMethod.Comparables
{
	public class SmartStudentFactory:FabricaAlumnoMuyEstudioso
	{
		public SmartStudentFactory()
		{
		}
		public override Comparable crearAleatorio(){
			
			Comparable comp = base.crearAleatorio();
			IAlumno dec = new DecoradorNota((IAlumno)comp,1);
			dec = new DecoradorLegajo(dec,2);
			dec=new DecoradorPromocion(dec,3);
			dec=new DecoradorOrdenSecuencial(dec,4);
			dec=new DecoradoAsteriscos(dec,5);
			
			Comparable aa = new AlumnoAdaptador(dec);
			
			return (aa);
		}
		public override Comparable crearPorTeclado(){
			
			Comparable comp = base.crearPorTeclado();
			IAlumno dec = new DecoradorNota((IAlumno)comp,1);
			dec = new DecoradorLegajo(dec,2);
			dec=new DecoradorPromocion(dec,3);
			dec=new DecoradorOrdenSecuencial(dec,4);
			dec=new DecoradoAsteriscos(dec,5);
			
			Comparable aa = new AlumnoAdaptador(dec);
			
			return (aa);
		}
	}
}
