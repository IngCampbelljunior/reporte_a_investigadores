﻿namespace LiloSoft.Siesa.Interfaz.Circular016
{
#pragma warning disable CS0436 // El tipo 'BaseRegistroFT' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs' está en conflicto con el tipo importado 'BaseRegistroFT' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs'.
    public class RegistroFT009 : BaseRegistroFT
#pragma warning restore CS0436 // El tipo 'BaseRegistroFT' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs' está en conflicto con el tipo importado 'BaseRegistroFT' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs'.
    {
        /// <summary>
        ///Escriba la línea de negocio Deudor de la obligación (reportante)
        /// 1:= Aseguramiento obligatorio
        /// 2:= Aseguramiento voluntario
        /// 3:= Prestación de servicios
        ///Numérico(1)
        /// </summary>
        public int lineaNegocio { get; set; }

        /// <summary>
        ///Tipo moneda de la cuenta registrada en la entidad. Escriba:
        /// USD:= Dólar de los Estados Unidos de América
        /// GBP:= Libra Británica
        /// EUR:= Euro
        /// CAD:= Dólar Canadiense
        /// CHF:= Franco Suizo
        /// JPY:= Yen Japonés
        /// OTR:= Otra
        ///Texto(3)
        /// </summary>
        public string tipoMoneda { get; set; }

        /// <summary>
        ///Total activos en cada tipo de Moneda extranjera
        ///Numérico(18)
        /// </summary>
        public long activos { get; set; }

        /// <summary>
        ///Total Pasivos en cada tipo de Moneda extranjera
        ///Numérico(18)
        /// </summary>
        public long pasivos { get; set; }


    }
}
