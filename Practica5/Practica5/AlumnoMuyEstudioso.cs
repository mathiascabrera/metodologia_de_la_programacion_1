using System;
using Practica1___Mathias_Cabrera;
using Practica4.Adapter;

namespace Practica4
{
	public class AlumnoMuyEstudioso:Alumno
	{
		public AlumnoMuyEstudioso(string n, string ape,int d, int l, double p, int ultimaCalificacion):base(n,ape,d,l,p,ultimaCalificacion)
		{
		}
		
		public override int responderPregunta(int pregunta){
			return pregunta%3;
		}
	}
}
