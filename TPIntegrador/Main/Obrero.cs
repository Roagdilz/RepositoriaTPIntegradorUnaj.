﻿/*
 * Created by SharpDevelop.
 * User: Rodrigo
 * Date: 23/4/2023
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Main
{
	/// <summary>
	/// Description of Obrero.
	/// </summary>
	public class Obrero
	{
		private string nombre;

		private string apellido;

		private string cargo;

		private int numeroLegajo;

		private int dni;

		private int grupoObrero; // ObreroGrupo.ID

		public Obrero()
		{
		}


















		// Propiedades;
		public string Nombre {
			get{
				return this.nombre;
			}
			set{
				this.nombre = value;
			}
		}
		public string Apellido {
			get{
				return this.apellido;
			}
			set{
				this.apellido = value;
			}
		}
		public string Cargo {
			get{
				return this.cargo;
			}
			set{
				this.cargo = value;
			}
		}
		public int NumeroLegajo {
			get{
				return this.numeroLegajo;
			}
			set{
				this.numeroLegajo = value;
			}
		}
		public int Dni {
			get{
				return this.dni;
			}
			set{
				this. dni = value;
			}
		}
		public int GrupoObrero {
			get{
				return this.grupoObrero;
			}
			set{
				this.grupoObrero = value;
			}
		}

	}
}
