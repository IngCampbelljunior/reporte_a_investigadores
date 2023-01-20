﻿using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    public class Especialidades
    {

        [DisplayName("Codigo Especialidad")]
        [DataObjectField(true)]
        public string Cod_Especialidad { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Especialidad { get; set; }

    }
}
