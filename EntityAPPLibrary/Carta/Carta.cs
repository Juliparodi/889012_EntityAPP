﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAPPLibrary.Carta
{
    class Carta
    {
        int cantidadCaracteres;
        string contenido;
        string mailCreador;
        string mailRecipiente;
        DateTime fechaCreacion;

        public Carta(int cantidadCaracteres, string contenido, string mailCreador, string mailRecipiente, DateTime fechaCreacion)
        {
            this.CantidadCaracteres = cantidadCaracteres;
            this.Contenido = contenido;
            this.MailCreador = mailCreador;
            this.MailRecipiente = mailRecipiente;
            this.FechaCreacion = fechaCreacion;
        }

        public int CantidadCaracteres { get => cantidadCaracteres; set => cantidadCaracteres = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string MailCreador { get => mailCreador; set => mailCreador = value; }
        public string MailRecipiente { get => mailRecipiente; set => mailRecipiente = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
