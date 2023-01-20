
using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Utils;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Manejo de ParametrosPlanSiesa
    /// </summary>
    [DataObject(true)]
    [Description("Parametros para Cuentas Por Plan")]
    public class ParametrosPlanSiesaDB : LiloSoft.Web.ProveedorWeb.BaseDB
    {
        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public ParametrosPlanSiesaDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Base de Datos
        /// </summary>
        /// <param name="db">Manejador de Bases de Datos</param>
        public ParametrosPlanSiesaDB(DB db)
          : this()
        {
            SqlDb = db;
        }
        #endregion


        #region Metodos de Acceso a Datos
        /// <summary>
        /// Insertar un Registro en ParametrosPlanSiesa
        /// </summary>
        /// <param name="m">Objeto ParametrosPlanSiesa a Insertar</param>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public void Insert(ParametrosPlanSiesa m)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Insert), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Actualizar un Registro en ParametrosPlanSiesa
        /// </summary>
        /// <param name="m">Objeto ParametrosPlanSiesa a Actualizar</param>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public void Update(ParametrosPlanSiesa m)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Update), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Eliminar un Registro ParametrosPlanSiesa
        /// </summary>
        /// <param name="m">Objeto ParametrosPlanSiesa a Eliminar</param>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public void Delete(ParametrosPlanSiesa m)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            List<Parametro> lst = GetParametros(m, true);
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Delete), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }


        #endregion

        #region Metodos de Listas
        /// <summary>
        /// Lista de Todos los ParametrosPlanSiesa
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosPlanSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public List<ParametrosPlanSiesa> GetParametrosPlanSiesa(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Criterio);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            var lista = ExecuteGetLista<ParametrosPlanSiesa>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            return lista;
        }

        /// <summary>
        /// Lista de Todos los ParametrosPlanSiesa
        /// </summary>      
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosPlanSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public List<ParametrosPlanSiesa> GetParametrosPlanSiesa(String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            return GetParametrosPlanSiesa("", Empresa);
        }

        /// <summary>
        /// Lista de Todos los ParametrosPlanSiesa
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosPlanSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public List<ParametrosPlanSiesa> GetParametrosPlanSiesaActivo(String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            return GetParametrosPlanSiesaActivo("", Empresa);
        }

        /// <summary>
        /// Lista de Todos los ParametrosPlanSiesa Activos
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosPlanSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public List<ParametrosPlanSiesa> GetParametrosPlanSiesaActivo(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Activo);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.CriterioActivos);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            var lista = ExecuteGetLista<ParametrosPlanSiesa>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los ParametrosPlanSiesa que Inician por un Criterio
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosPlanSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public List<ParametrosPlanSiesa> GetParametrosPlanSiesaInicia(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.Inicia);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            var lista = ExecuteGetLista<ParametrosPlanSiesa>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            return lista;
        }


        /// <summary>
        /// Busca un objeto ParametrosPlanSiesa
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="CodPlan">Código del Plan</param>
        /// <returns>Objeto ParametrosPlanSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        public ParametrosPlanSiesa GetUnParametrosPlanSiesa(string Empresa, string CodPlan)
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        {
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            ParametrosPlanSiesa menu = null;
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            List<Parametro> pars = new List<Parametro>();
            pars.Add(new Parametro("Empresa", Empresa));
            pars.Add(new Parametro("CodPlan", CodPlan));
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            menu = ExecuteGetUnLista<ParametrosPlanSiesa>(GetInstruccionSql<ParametrosPlanSiesa>(TiposProcedimientosAlmacenados.SoloUno), EsProcedimientoAlmacenado, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            return menu;
        }

        #endregion

        #region Metodos Sustituidos
        /// <summary>
        /// Lista de Valores de las ParametrosPlanSiesa por Criterio
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetLista(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
            string Empresa = "";
            var par1 = from p in parametros
                       where p.Name.ToLower() == "empresa"
                       select p;
            if (par1 != null && par1.Count() > 0)
                Empresa = par1.First().Value.ToString();
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            return Tablas<ParametrosPlanSiesa>.ToDataTable(GetParametrosPlanSiesa(criterio, Empresa));
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        }

        /// <summary>
        /// Lista de Valores de las ParametrosPlanSiesa por Criterio Activos
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetListaActiva(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
            string Empresa = "";
            var par1 = from p in parametros
                       where p.Name.ToLower() == "empresa"
                       select p;
            if (par1 != null && par1.Count() > 0)
                Empresa = par1.First().Value.ToString();
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
            return Tablas<ParametrosPlanSiesa>.ToDataTable(GetParametrosPlanSiesaActivo(criterio, Empresa));
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
        }

        #endregion

        #region Metodos de Cargue Excel
        /// <summary>
        /// Lista de MetaData para los Campos de la Tabla a Cargar
        /// </summary>
        /// <returns>Lista de MetaDataExcel de la Tabla</returns>
        public override List<MetaDataExcel> GetMetaData()
        {
            List<MetaDataExcel> lstMeta = new List<MetaDataExcel>();
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Empresa", DescripcionCampo = "Empresa de Trabajo", TipoDato = "Cadena", Tamaño = "6" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "CodPlan", DescripcionCampo = "Código del Plan", TipoDato = "Cadena", Tamaño = "10" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "CuentaEmision", DescripcionCampo = "Cuenta Contable Emisión", TipoDato = "Cadena", Tamaño = "30" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "CuentaRadicacion", DescripcionCampo = "Cuenta de Radicación", TipoDato = "Cadena", Tamaño = "30" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Operacion", DescripcionCampo = "Operacion I:Ingresar A:Actualizar E:Eliminar", TipoDato = "Cadena", Tamaño = "1" });
            return lstMeta;
        }

        /// <summary>
        /// Cargue de Archivo de Excel de la Información en la Tabla
        /// </summary>
        /// <param name="pNombreArchivoExcel">Archivo de Excel a Cargar</param>
        /// <returns>Lista de Errore de la Carga</returns>
        public override List<ErroresCarga> CargarDatos(string pNombreArchivoExcel)
        {
            List<ErroresCarga> lstErrores = new List<ErroresCarga>();
            DataTable dtExcel = LiloSoft.Utils.Utilidades.CargarUnEXCEL(pNombreArchivoExcel, NombreHojaExcel, true);
            // Verificamos si hay Datos
            if (dtExcel != null && dtExcel.Rows.Count > 0)
            {
                int filas = 0;
                foreach (DataRow dr in dtExcel.Rows)
                {
                    try
                    {
                        string Operacion = "";
                        filas++;
                        // Verificamos si Tiene o No Datos el Registro Completo
                        if (
                              string.IsNullOrEmpty(dr["Empresa"].ToString()) &&
                              string.IsNullOrEmpty(dr["CodPlan"].ToString()) &&
                              string.IsNullOrEmpty(dr["CuentaEmision"].ToString()) &&
                              string.IsNullOrEmpty(dr["CuentaRadicacion"].ToString()))
                        {
                            break; // Salimos del Ciclo si el Registro esta Vacio Todo
                        }
                        // Empezamos a Crear el Objeto que Necesitamos
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                        ParametrosPlanSiesa dato = new ParametrosPlanSiesa();
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                        //
                        // Procesamos Empresa de Trabajo
                        //
                        try
                        {
                            dato.Empresa = dr["Empresa"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Empresa de Trabajo Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Empresa"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Código del Plan
                        //
                        try
                        {
                            dato.CodPlan = dr["CodPlan"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Código del Plan Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["CodPlan"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Cuenta Contable Emisión
                        //
                        try
                        {
                            dato.CuentaEmision = dr["CuentaEmision"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Cuenta Contable Emisión Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["CuentaEmision"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Cuenta de Radicación
                        //
                        try
                        {
                            dato.CuentaRadicacion = dr["CuentaRadicacion"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Cuenta de Radicación Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["CuentaRadicacion"].ToString()
                            });
                            continue;
                        }

                        // 
                        // Procesamos la Operacion
                        //
                        try
                        {
                            Operacion = dr["Operacion"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Operación Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Operacion"].ToString()
                            });
                            continue;
                        }
                        // Buscamos el Objeto por su Llave Primaria
#pragma warning disable CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                        ParametrosPlanSiesa datoBase = GetUnParametrosPlanSiesa(dato.Empresa, dato.CodPlan);
#pragma warning restore CS0436 // El tipo 'ParametrosPlanSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs' está en conflicto con el tipo importado 'ParametrosPlanSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosPlanSiesa.cs'.
                        switch (Operacion.ToUpper())
                        {
                            case "I":
                                if (datoBase != null)
                                {
                                    lstErrores.Add(new ErroresCarga()
                                    {
                                        IdError = "Valor ya Existe",
                                        TextoError = "El Registro que Trata de Ingresar ya Existe",
                                        FilaNo = filas,
                                        Info = "Empresa:" + dato.Empresa + "," + "CodPlan:" + dato.CodPlan
                                    });
                                    continue;
                                }
                                else
                                {
                                    Insert(dato);
                                }
                                break;
                            case "A":
                                if (datoBase == null)
                                {
                                    lstErrores.Add(new ErroresCarga()
                                    {
                                        IdError = "Valor No Existe",
                                        TextoError = "El Registro que Trata de Actualizar No Existe",
                                        FilaNo = filas,
                                        Info = "Empresa:" + dato.Empresa + "," + "CodPlan:" + dato.CodPlan
                                    });
                                    continue;
                                }
                                else
                                {
                                    Update(dato);
                                }
                                break;
                            case "E":
                                if (datoBase == null)
                                {
                                    lstErrores.Add(new ErroresCarga()
                                    {
                                        IdError = "Valor No Existe",
                                        TextoError = "El Registro que Trata de Eliminar No Existe",
                                        FilaNo = filas,
                                        Info = "Empresa:" + dato.Empresa + "," + "CodPlan:" + dato.CodPlan
                                    });
                                    continue;
                                }
                                else
                                {
                                    Delete(dato);
                                }
                                break;
                            default:
                                lstErrores.Add(new ErroresCarga()
                                {
                                    IdError = "Operación Es Invalida",
                                    TextoError = "Valor para la Operación es Inválida",
                                    FilaNo = filas,
                                    Info = Operacion
                                });
                                continue;
                        }
                    }// Fin Try
                    catch (Exception ex)
                    {
                        lstErrores.Add(new ErroresCarga()
                        {
                            IdError = "Error General",
                            TextoError = ex.Message,
                            FilaNo = filas,
                            Info = ""
                        });
                        continue;
                    }
                } // Fin de Foreach dtExcel
            } // Fin de Datos excel
            else
            {
                if (dtExcel == null)
                {
                    // No Hay Datos en Excel
                    lstErrores.Add(new ErroresCarga()
                    {
                        IdError = "Error Carga",
                        TextoError = (LiloSoft.Utils.Utilidades.UltimoError != null ? LiloSoft.Utils.Utilidades.UltimoError.Message : "Error No Especificado")
                    });

                }
                else
                {
                    // No Hay Datos en Excel
                    lstErrores.Add(new ErroresCarga()
                    {
                        IdError = "Sin Datos",
                        TextoError = "El Archivo No Tiene Datos"
                    });
                }
            }
            return lstErrores;
        }


        #endregion

    } // Fin Clase
} // Fin NameSpace


