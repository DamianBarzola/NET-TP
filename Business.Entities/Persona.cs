using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Entities
    {
        public class Persona : BusinessEntity
        {
            
        private TipoPersona tipo;
        private int legajo;
        private string apellido;
        private string nombre;
        private string direccion;
        private string telefono;
        private DateTime fechaNacimiento;

        public enum TipoPersona
        {
            Alumno = 1,
            Docente = 2,
            Administrador = 3
        }

        public TipoPersona Tipo { get => tipo; set => tipo = value; }
        public int Legajo { get => legajo; set => legajo = value; } 
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }

    }

