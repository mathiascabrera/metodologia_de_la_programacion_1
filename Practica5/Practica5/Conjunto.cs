﻿using System;
using System.Collections.Generic;
using Practica1___Mathias_Cabrera;
using Practica2.Iterator;
using Practica5.Command;

namespace Practica2
{
	public class Conjunto :Coleccionable, Iterable, Ordenable
	{
		
		// EJERCICIO 3
		
		private List<Comparable> elementos;
		
		OrdenEnAula1 ordenIncio, ordenAuLlena;
		OrdenEnAula2 ordenLlAlum;
		
		public Conjunto(){
			elementos = new List<Comparable>();
		}
		
		public void agregar(Comparable e){
			
			if (elementos.Count == 0) {
				elementos.Add(e);
				
				ordenIncio.ejecutar();//Primer Elemento
				ordenLlAlum.ejecutar(e);//Primer Elemento
				
			}else{
				if (cuantos()<40 && !elementos.Contains(e)) {
					elementos.Add(e);
					ordenLlAlum.ejecutar(e);
				}
				if (cuantos() == 40) {
					ordenAuLlena.ejecutar();
				}
			}
		}
		
		public bool pertenece(Comparable e){
			return this.contiene(e);
		}
		
		
		public bool contiene(Comparable e){
			
			for (int i = 0; i < elementos.Count; i++) {
				
				if (elementos[i].sosIgual(e)) {
					return true;
				}
			}
			return false;
		}
		
		
		//Metodos de Coleccionable
		public int cuantos(){
			return elementos.Count;
		}
		
		public Comparable minimo(){
			
			Comparable menor = elementos[0];
			
			for (int i = 0; i < elementos.Count; i++) {
				
				if (menor.sosMenor(elementos[i])) {
					
					menor = elementos[i];
				}
			}
			return menor;
		}
		
		
		public Comparable maximo(){
			
			Comparable mayor = null;
			
			int cantidad =0;
			
			while (elementos.Count >= cantidad) {
				
				mayor = elementos[0];
				
				for (int i = 0; i < elementos.Count; i++) {
					
					cantidad++;
					
					if ( mayor.sosMayor(elementos[i])) {
						
						mayor=elementos[i];
						
					}
				}
			}
			return mayor;
		}
		
		//Implemento el método del Iterable
		public Iterador crearIterador(){
			
			return new IteradorPila(elementos);
		}
		
		public void setOrdenInicio(OrdenEnAula1 a){
			this.ordenIncio = a;
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 a){
			this.ordenLlAlum=a;
		}
		public void setOrdenAulaLlena(OrdenEnAula1 a){
			this.ordenAuLlena=a;
		}
	}
}
