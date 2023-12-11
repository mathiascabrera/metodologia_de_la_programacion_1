﻿using System;
using Practica1___Mathias_Cabrera;
using Practica2;

namespace Practica4.Adapter
{
	public interface IAlumno
	{
		int getLegajo();
		double getPromedio();
		int getUltCalif();
		void setNombre(string nombre);
		string getNombre();
		int responderPregunta(int pregunta);
		void establecerCalificacion(int calificacion);
		string mostrarCalificacion();
		bool sosIgual(Comparable a);
		bool sosMenor(Comparable a);
		bool sosMayor(Comparable a);
		
		
	}
}
