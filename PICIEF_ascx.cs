using STOD_Web.FIVEWS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace STOD_Web
{
    public partial class FEICPI_IngresarFormulario : System.Web.UI.UserControl
    {
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // VARIABLES UTILIZADAS PARA LAS TABLAS (var)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int noFormulario;
        protected void Page_Load(object sender, EventArgs e)
        {
            // CARGA DE INFORMACIÓN INICIAL
            if (!IsPostBack)
            {
                //llii_TipoEntidad();
                //llii_TipoModificacion();
                llii_CondicionMigratoria();
                llii_TipoIngreso();
                //llii_Sucursales();
                llii_Paises();
                llii_LlenarCamposFecha();
                llii_OrigenRiquezaPEP();
                llii_TipoParentescoPEP();
                llii_MotivoAsociacionPEP();
            }
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // METODOS UTILIZADOS PARA CARGAR INFORMACIÓN INICIAL (llii_)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void llii_CondicionMigratoria()
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = Session["USR_Usuario"].ToString();
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_04_CondicionMigratoria(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T8_condicionMigratoria.DataValueField = "CMigratoriaID";
                T8_condicionMigratoria.DataTextField = "Descripcion";
                T8_condicionMigratoria.DataSource = dt;
                T8_condicionMigratoria.DataBind();

                T16_condicionMigratoria.DataValueField = "CMigratoriaID";
                T16_condicionMigratoria.DataTextField = "Descripcion";
                T16_condicionMigratoria.DataSource = dt;
                T16_condicionMigratoria.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Condición migratoria";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_OrigenRiquezaPEP()
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = Session["USR_Usuario"].ToString();
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_05_OrigenRiquezaPEP(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T18_pep_origenRiqueza.DataValueField = "OrigenRiquezaPEPID";
                T18_pep_origenRiqueza.DataTextField = "Descripcion";
                T18_pep_origenRiqueza.DataSource = dt;
                T18_pep_origenRiqueza.DataBind();

                T17_origenRiqueza.DataValueField = "OrigenRiquezaPEPID";
                T17_origenRiqueza.DataTextField = "Descripcion";
                T17_origenRiqueza.DataSource = dt;
                T17_origenRiqueza.DataBind();

                T10_origenRiqueza.DataValueField = "OrigenRiquezaPEPID";
                T10_origenRiqueza.DataTextField = "Descripcion";
                T10_origenRiqueza.DataSource = dt;
                T10_origenRiqueza.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Origen de riqueza PEP";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_TipoParentescoPEP()
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = Session["USR_Usuario"].ToString();
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_06_TipoParentescoPEP(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T11_parentesco.DataValueField = "ParentescoPEPID";
                T11_parentesco.DataTextField = "Descripcion";
                T11_parentesco.DataSource = dt;
                T11_parentesco.DataBind();
                T18_parientePep_parentesco.DataValueField = "ParentescoPEPID";
                T18_parientePep_parentesco.DataTextField = "Descripcion";
                T18_parientePep_parentesco.DataSource = dt;
                T18_parientePep_parentesco.DataBind();
                T19_parentesco.DataValueField = "ParentescoPEPID";
                T19_parentesco.DataTextField = "Descripcion";
                T19_parentesco.DataSource = dt;
                T19_parentesco.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Tipo parentesco PEP";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_MotivoAsociacionPEP()
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = Session["USR_Usuario"].ToString();
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_07_MotivoAsociacionPEP(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T12_motivoAsociacion.DataValueField = "MotivoID";
                T12_motivoAsociacion.DataTextField = "Descripcion";
                T12_motivoAsociacion.DataSource = dt;
                T12_motivoAsociacion.DataBind();
                //----------------------------------------------------------------------
                T18_asociadoPep_motivoAsociacion.DataValueField = "MotivoID";
                T18_asociadoPep_motivoAsociacion.DataTextField = "Descripcion";
                T18_asociadoPep_motivoAsociacion.DataSource = dt;
                T18_asociadoPep_motivoAsociacion.DataBind();
                //----------------------------------------------------------------------
                T20_motivoAsociacion.DataValueField = "MotivoID";
                T20_motivoAsociacion.DataTextField = "Descripcion";
                T20_motivoAsociacion.DataSource = dt;
                T20_motivoAsociacion.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Motivo de asociación PEP";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_TipoIngreso()
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = Session["USR_Usuario"].ToString();
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPI_WS_CAT_08_TipoIngreso(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T14_ingresos_tipoIngreso.DataValueField = "TipoIngresoID";
                T14_ingresos_tipoIngreso.DataTextField = "Descripcion";
                T14_ingresos_tipoIngreso.DataSource = dt;
                T14_ingresos_tipoIngreso.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Tipo ingreso";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_Paises()
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = "1";
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_09_Paises(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cargar error si es necesario
                if (tipoMensaje == 1)
                {
                    //  Cergar información resultante a los elementos correspondientes
                    T2_paisID.DataValueField = "PaisID";
                    T2_paisID.DataTextField = "Descripcion";
                    T2_paisID.DataSource = dt;
                    T2_paisID.DataBind();
                    // ------------------------------------------------------------------------
                    T19_paisEntidad.DataValueField = "PaisID";
                    T19_paisEntidad.DataTextField = "Descripcion";
                    T19_paisEntidad.DataSource = dt;
                    T19_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T20_paisEntidad.DataValueField = "PaisID";
                    T20_paisEntidad.DataTextField = "Descripcion";
                    T20_paisEntidad.DataSource = dt;
                    T20_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T16_direccionnacimiento_Pais.DataValueField = "PaisID";
                    T16_direccionnacimiento_Pais.DataTextField = "Descripcion";
                    T16_direccionnacimiento_Pais.DataSource = dt;
                    T16_direccionnacimiento_Pais.DataBind();
                    //// ------------------------------------------------------------------------
                    T16_direccionResidencia_Pais.DataValueField = "PaisID";
                    T16_direccionResidencia_Pais.DataTextField = "Descripcion";
                    T16_direccionResidencia_Pais.DataSource = dt;
                    T16_direccionResidencia_Pais.DataBind();
                    //// ------------------------------------------------------------------------
                    T16_nacionalidad1.DataValueField = "PaisID";
                    T16_nacionalidad1.DataTextField = "Descripcion";
                    T16_nacionalidad1.DataSource = dt;
                    T16_nacionalidad1.DataBind();
                    // ------------------------------------------------------------------------
                    T8_direccionResidencia_Pais.DataValueField = "PaisID";
                    T8_direccionResidencia_Pais.DataTextField = "Descripcion";
                    T8_direccionResidencia_Pais.DataSource = dt;
                    T8_direccionResidencia_Pais.DataBind();
                    // ------------------------------------------------------------------------
                    T8_direccionnacimiento_Pais.DataValueField = "PaisID";
                    T8_direccionnacimiento_Pais.DataTextField = "Descripcion";
                    T8_direccionnacimiento_Pais.DataSource = dt;
                    T8_direccionnacimiento_Pais.DataBind();
                    // ------------------------------------------------------------------------
                    T8_emisionPasaporte.DataValueField = "PaisID";
                    T8_emisionPasaporte.DataTextField = "Descripcion";
                    T8_emisionPasaporte.DataSource = dt;
                    T8_emisionPasaporte.DataBind();
                    // ------------------------------------------------------------------------
                    T16_emisionPasaporte.DataValueField = "PaisID";
                    T16_emisionPasaporte.DataTextField = "Descripcion";
                    T16_emisionPasaporte.DataSource = dt;
                    T16_emisionPasaporte.DataBind();
                    // ------------------------------------------------------------------------
                    T10_paisEntidad.DataValueField = "PaisID";
                    T10_paisEntidad.DataTextField = "Descripcion";
                    T10_paisEntidad.DataSource = dt;
                    T10_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T8_nacionalidad1.DataValueField = "PaisID";
                    T8_nacionalidad1.DataTextField = "Descripcion";
                    T8_nacionalidad1.DataSource = dt;
                    T8_nacionalidad1.DataBind();
                    // ------------------------------------------------------------------------
                    T8_nacionalidad2.DataValueField = "PaisID";
                    T8_nacionalidad2.DataTextField = "Descripcion";
                    T8_nacionalidad2.DataSource = dt;
                    T8_nacionalidad2.DataBind();
                    // ------------------------------------------------------------------------
                    T8_nacionalidad3.DataValueField = "PaisID";
                    T8_nacionalidad3.DataTextField = "Descripcion";
                    T8_nacionalidad3.DataSource = dt;
                    T8_nacionalidad3.DataBind();
                    // ------------------------------------------------------------------------
                    T8_emisionPasaporte.DataValueField = "PaisID";
                    T8_emisionPasaporte.DataTextField = "Descripcion";
                    T8_emisionPasaporte.DataSource = dt;
                    T8_emisionPasaporte.DataBind();
                    // ------------------------------------------------------------------------
                    T11_paisEntidad.DataValueField = "PaisID";
                    T11_paisEntidad.DataTextField = "Descripcion";
                    T11_paisEntidad.DataSource = dt;
                    T11_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T12_paisEntidad.DataValueField = "PaisID";
                    T12_paisEntidad.DataTextField = "Descripcion";
                    T12_paisEntidad.DataSource = dt;
                    T12_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T15_adquisicion_Pais.DataValueField = "PaisID";
                    T15_adquisicion_Pais.DataTextField = "Descripcion";
                    T15_adquisicion_Pais.DataSource = dt;
                    T15_adquisicion_Pais.DataBind();
                    // ------------------------------------------------------------------------
                    T16_nacionalidad2.DataValueField = "PaisID";
                    T16_nacionalidad2.DataTextField = "Descripcion";
                    T16_nacionalidad2.DataSource = dt;
                    T16_nacionalidad2.DataBind();
                    //// ------------------------------------------------------------------------
                    T16_nacionalidad3.DataValueField = "PaisID";
                    T16_nacionalidad3.DataTextField = "Descripcion";
                    T16_nacionalidad3.DataSource = dt;
                    T16_nacionalidad3.DataBind();
                    // ------------------------------------------------------------------------
                    T17_paisEntidad.DataValueField = "PaisID";
                    T17_paisEntidad.DataTextField = "Descripcion";
                    T17_paisEntidad.DataSource = dt;
                    T17_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T17_direccionResidencia_Pais.DataValueField = "PaisID";
                    T17_direccionResidencia_Pais.DataTextField = "Descripcion";
                    T17_direccionResidencia_Pais.DataSource = dt;
                    T17_direccionResidencia_Pais.DataBind();
                    // ------------------------------------------------------------------------
                    T17_emisionPasaporte.DataValueField = "PaisID";
                    T17_emisionPasaporte.DataTextField = "Descripcion";
                    T17_emisionPasaporte.DataSource = dt;
                    T17_emisionPasaporte.DataBind();
                    // ------------------------------------------------------------------------
                    T18_pep_paisEntidad.DataValueField = "PaisID";
                    T18_pep_paisEntidad.DataTextField = "Descripcion";
                    T18_pep_paisEntidad.DataSource = dt;
                    T18_pep_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T18_parientePep_paisEntidad.DataValueField = "PaisID";
                    T18_parientePep_paisEntidad.DataTextField = "Descripcion";
                    T18_parientePep_paisEntidad.DataSource = dt;
                    T18_parientePep_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T18_asociadoPep_paisEntidad.DataValueField = "PaisID";
                    T18_asociadoPep_paisEntidad.DataTextField = "Descripcion";
                    T18_asociadoPep_paisEntidad.DataSource = dt;
                    T18_asociadoPep_paisEntidad.DataBind();
                    // ------------------------------------------------------------------------
                    T19_paisJurisdiccionConstitucion.DataValueField = "PaisID";
                    T19_paisJurisdiccionConstitucion.DataTextField = "Descripcion";
                    T19_paisJurisdiccionConstitucion.DataSource = dt;
                    T19_paisJurisdiccionConstitucion.DataBind();
                    // ------------------------------------------------------------------------
                    T19_direccion_Pais.DataValueField = "PaisID";
                    T19_direccion_Pais.DataTextField = "Descripcion";
                    T19_direccion_Pais.DataSource = dt;
                    T19_direccion_Pais.DataBind();
                }
                //  Cargar error si es necesario
                else if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Listado paises";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_Sucursales(int Empresa)
        {
            // Catalogo (Tabla): 
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario ParametrosEmpresa = new FIVEWS.CL_Diccionario();
                ParametrosEmpresa.Nombre = "@EmpresaID";
                ParametrosEmpresa.Valor = Empresa;
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(ParametrosEmpresa);
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                Parametros.Nombre = "@Usuario";
                Parametros.Valor = Session["USR_Usuario"].ToString();
                // Agregar Paramtetros al listado de parámetros
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPI_WS_CAT_12_Sucursales(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                T1_sucursal.Items.Clear();
                //  Cergar información resultante a los elementos correspondientes
                T1_sucursal.DataValueField = "SucursalID";
                T1_sucursal.DataTextField = "Descripcion";
                T1_sucursal.DataSource = dt;
                T1_sucursal.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_0_ErrorCargaCatalogos.Visible = true;
                    SEC_0_ErrorCargaCatalogos.Text = mensajeDescripcion + ": Listado de sucursales";
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void llii_LlenarCamposFecha()
        {
            // Setea la fecha actual en los campos indicados.
            T1_fechaCrecionFormulario.Text = DateTime.Now.ToShortDateString();
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // METODOS UTILIZADOS PARA CARGAR INFORMACIÓN POR EVENTOS BASADO EN CAMBIOS EN LA VISTA (cibc_) + (cs_ o ct_)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Eventos de la sección 01 -----------------------------------------------------------------
        protected void cibc_cs_T2_paisID(object sender, EventArgs e)
        {
            if (T2_paisID.SelectedValue == "GT")
            {
                T2_departamentoID.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T2_departamentoID.DataValueField = "DepartamentoID";
                    T2_departamentoID.DataTextField = "Descripcion";
                    T2_departamentoID.DataSource = dt;
                    T2_departamentoID.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_01_PrincipalValidation.Visible = true;
                        SEC_01_PrincipalValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T2_departamentoID.Enabled = false;
                    T2_municipioID.Enabled = false;
                }
            }
            else
            {
                T2_departamentoID.Enabled = false;
                T2_municipioID.Enabled = false;
            }
        }
        protected void cibc_cs_T2_departamentoID(object sender, EventArgs e)
        {
            try
            {
                T2_municipioID.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T2_departamentoID.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T2_municipioID.DataValueField = "MunicipioID";
                T2_municipioID.DataTextField = "Descripcion";
                T2_municipioID.DataSource = dt;
                T2_municipioID.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_01_PrincipalValidation.Visible = true;
                    SEC_01_PrincipalValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        //Eventos de la sección 4 -----------------------------------------------------------------
        protected void cibc_cs_T17_tipoDocumentoIdentificacion(object sender, EventArgs e)
        {
            if (T17_tipoDocumentoIdentificacion.SelectedValue == "D")
            {
                T17_emisionPasaporte.Enabled = false;
                T17_emisionPasaporte.SelectedValue = "NE";
            }
            else
            {
                T17_emisionPasaporte.Enabled = true;
                T17_emisionPasaporte.SelectedValue = "NE";
            }
        }
        protected void cibc_cs_T17_direccionResidencia_Pais(object sender, EventArgs e)
        {
            if (T17_direccionResidencia_Pais.SelectedValue == "GT")
            {
                T17_direccionResidencia_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T17_direccionResidencia_Departamento.DataValueField = "DepartamentoID";
                    T17_direccionResidencia_Departamento.DataTextField = "Descripcion";
                    T17_direccionResidencia_Departamento.DataSource = dt;
                    T17_direccionResidencia_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_16_PI_FondosTerceroValidation.Visible = true;
                        SEC_16_PI_FondosTerceroValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T17_direccionResidencia_Departamento.Enabled = false;
                    T17_direccionResidencia_Municipio.Enabled = false;
                }
            }
            else
            {
                T17_direccionResidencia_Departamento.Enabled = false;
                T17_direccionResidencia_Municipio.Enabled = false;
            }
        }
        protected void cibc_cs_T17_direccionResidencia_Departamento(object sender, EventArgs e)
        {
            try
            {
                T17_direccionResidencia_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T17_direccionResidencia_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T17_direccionResidencia_Municipio.DataValueField = "MunicipioID";
                T17_direccionResidencia_Municipio.DataTextField = "Descripcion";
                T17_direccionResidencia_Municipio.DataSource = dt;
                T17_direccionResidencia_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_16_PI_FondosTerceroValidation.Visible = true;
                    SEC_16_PI_FondosTerceroValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void cibc_cs_T17_origenRiqueza(object sender, EventArgs e)
        {
            if(T17_origenRiqueza.SelectedValue.ToString() == "8")
            {
                T17_otroOrigenriqueza.Enabled = true;
            }
            else
            {
                T17_otroOrigenriqueza.Enabled = false;
            }
        }
        //Eventos de la sección 20 -----------------------------------------------------------------
        protected void cibc_cs_T19_direccion_Pais(object sender, EventArgs e)
        {
            if (T19_direccion_Pais.SelectedValue == "GT")
            {
                T19_direccion_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T19_direccion_Departamento.DataValueField = "DepartamentoID";
                    T19_direccion_Departamento.DataTextField = "Descripcion";
                    T19_direccion_Departamento.DataSource = dt;
                    T19_direccion_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_20_PJ_FondosTerceroValidation.Visible = true;
                        SEC_20_PJ_FondosTerceroValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    SEC_20_PJ_FondosTerceroValidation.Enabled = false;
                    SEC_20_PJ_FondosTerceroValidation.Enabled = false;
                }
            }
            else
            {
                T19_direccion_Departamento.Enabled = false;
                T19_direccion_Municipio.Enabled = false;
            }
        }
        protected void cibc_cs_T19_direccion_Departamento(object sender, EventArgs e)
        {
            try
            {
                T19_direccion_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T19_direccion_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T19_direccion_Municipio.DataValueField = "MunicipioID";
                T19_direccion_Municipio.DataTextField = "Descripcion";
                T19_direccion_Municipio.DataSource = dt;
                T19_direccion_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_20_PJ_FondosTerceroValidation.Visible = true;
                    SEC_20_PJ_FondosTerceroValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void cibc_cs_T19_parentesco(object sender, EventArgs e)
        {
            if (T19_parentesco.SelectedValue.ToString() == "O")
            {
                T19_otroPerntesco.Enabled = true;
            }
            else
            {
                T19_otroPerntesco.Enabled = false;
            }
        }
        //Eventos de la sección 07 -----------------------------------------------------------------
        protected void cibc_cs_T8_direccionnacimiento_Pais(object sender, EventArgs e)
        {
            if (T8_direccionnacimiento_Pais.SelectedValue == "GT")
            {
                T8_direccionnacimiento_Departamento.Enabled = true;
                T8_condicionMigratoria.Enabled = false;
                T8_condicionMigratoria.SelectedValue = "0";
                T8_tipoDocumentoIdentificiacion.Enabled = false;
                T8_tipoDocumentoIdentificiacion.SelectedValue = "D";
                T8_emisionPasaporte.Enabled = false;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T8_direccionnacimiento_Departamento.DataValueField = "DepartamentoID";
                    T8_direccionnacimiento_Departamento.DataTextField = "Descripcion";
                    T8_direccionnacimiento_Departamento.DataSource = dt;
                    T8_direccionnacimiento_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                        SEC_07_DatosDelRepresentanteLegalValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T8_direccionnacimiento_Departamento.Enabled = false;
                    T8_direccionnacimiento_Municipio.Enabled = false;
                }
            }
            else
            {
                T8_condicionMigratoria.Enabled = true;
                T8_direccionnacimiento_Departamento.Enabled = false;
                T8_direccionnacimiento_Departamento.SelectedValue = "0";
                T8_direccionnacimiento_Municipio.Enabled = false;
                T8_direccionnacimiento_Municipio.SelectedValue = "0";
                T8_tipoDocumentoIdentificiacion.Enabled = false;
                T8_tipoDocumentoIdentificiacion.SelectedValue = "P";
                T8_emisionPasaporte.Enabled = true;
            }
        }
        protected void cibc_cs_T8_direccionnacimiento_Departamento(object sender, EventArgs e)
        {
            try
            {
                T8_direccionnacimiento_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T8_direccionnacimiento_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T8_direccionnacimiento_Municipio.DataValueField = "MunicipioID";
                T8_direccionnacimiento_Municipio.DataTextField = "Descripcion";
                T8_direccionnacimiento_Municipio.DataSource = dt;
                T8_direccionnacimiento_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_07_DatosDelRepresentanteLegalValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void cibc_cs_T8_direccionResidencia_Pais(object sender, EventArgs e)
        {
            if (T8_direccionResidencia_Pais.SelectedValue == "GT")
            {
                T8_direccionResidencia_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T8_direccionResidencia_Departamento.DataValueField = "DepartamentoID";
                    T8_direccionResidencia_Departamento.DataTextField = "Descripcion";
                    T8_direccionResidencia_Departamento.DataSource = dt;
                    T8_direccionResidencia_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                        SEC_07_DatosDelRepresentanteLegalValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T8_direccionResidencia_Departamento.Enabled = false;
                    T8_direccionResidencia_Municipio.Enabled = false;
                }
            }
            else
            {
                T8_direccionResidencia_Departamento.Enabled = false;
                T8_direccionResidencia_Departamento.SelectedValue = "0";
                T8_direccionResidencia_Municipio.Enabled = false;
                T8_direccionResidencia_Municipio.SelectedValue = "0";
            }
        }
        protected void cibc_cs_T8_direccionResidencia_Departamento(object sender, EventArgs e)
        {
            try
            {
                T8_direccionResidencia_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T8_direccionResidencia_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T8_direccionResidencia_Municipio.DataValueField = "MunicipioID";
                T8_direccionResidencia_Municipio.DataTextField = "Descripcion";
                T8_direccionResidencia_Municipio.DataSource = dt;
                T8_direccionResidencia_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_07_DatosDelRepresentanteLegalValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void cibc_cs_T8_condicionMigratoria(object sender, EventArgs e)
        {
            if (T8_condicionMigratoria.SelectedValue == "9")
            {
                T8_otraCondicionMigratoria.Enabled = true;
            }
            else
            {
                T8_otraCondicionMigratoria.Enabled = false;
            }
        }
        //Eventos de la sección 08 -----------------------------------------------------------------
        protected void cibc_cs_T8_sdireccionnacimiento_Pais(object sender, EventArgs e)
        {
            if (T8_direccionnacimiento_Pais.SelectedValue == "GT")
            {
                T8_direccionnacimiento_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T8_direccionnacimiento_Departamento.DataValueField = "DepartamentoID";
                    T8_direccionnacimiento_Departamento.DataTextField = "Descripcion";
                    T8_direccionnacimiento_Departamento.DataSource = dt;
                    T8_direccionnacimiento_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                        SEC_07_DatosDelRepresentanteLegalValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T8_direccionnacimiento_Departamento.Enabled = false;
                    T8_direccionnacimiento_Municipio.Enabled = false;
                }
            }
            else
            {

            }
        }
        protected void cibc_cs_T2_T8_direccionnacimiento_Departamento(object sender, EventArgs e)
        {
            try
            {
                T8_direccionnacimiento_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T8_direccionnacimiento_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T8_direccionnacimiento_Municipio.DataValueField = "MunicipioID";
                T8_direccionnacimiento_Municipio.DataTextField = "Descripcion";
                T8_direccionnacimiento_Municipio.DataSource = dt;
                T8_direccionnacimiento_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_07_DatosDelRepresentanteLegalValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        //Eventos de la sección 09 -----------------------------------------------------------------
        protected void cibc_cs_T10_pep(object sender, EventArgs e)
        {
            if (T10_pep.SelectedValue == "S")
            {
                SEC_09_PEP_Cliente_Info.Visible = true;
            }
            else
            {
                SEC_09_PEP_Cliente_Info.Visible = false;
            }
        }
        //------------------------------------------------------------------------------------------
        //Eventos de la sección 10 -----------------------------------------------------------------
        protected void cibc_cs_T11_parientePep(object sender, EventArgs e)
        {
            if (T11_parientePep.SelectedValue == "S")
            {
                SEC_10_PEP_ParienteRLC_Info.Visible = true;
            }
            else
            {
                SEC_10_PEP_ParienteRLC_Info.Visible = false;
            }
        }
        //Eventos de la sección 11 -----------------------------------------------------------------
        protected void cibc_cs_T12_asociadoPep(object sender, EventArgs e)
        {
            if (T12_asociadoPep.SelectedValue == "S")
            {
                SEC_11_AsociadoRLC_Info.Visible = true;
            }
            else
            {
                SEC_11_AsociadoRLC_Info.Visible = false;
            }
        }
        //Eventos de la sección 13 -----------------------------------------------------------------
        protected void cibc_cs_T14_ingresos_tipoIngreso(object sender, EventArgs e)
        {
            if (T14_ingresos_tipoIngreso.SelectedValue == "9")
            {
                T14_ingresos_otroTipoIngreso.Enabled = true;
                T14_ingresos_otroTipoIngreso.Text = "";
            }
            else
            {
                T14_ingresos_otroTipoIngreso.Enabled = false;
                T14_ingresos_otroTipoIngreso.Text = "No aplica, por favor omitir este campo";
            }
        }
        //Eventos de la sección 14 -----------------------------------------------------------------
        protected void cibc_cs_T15_adquisicion_Pais(object sender, EventArgs e)
        {
            if (T15_adquisicion_Pais.SelectedValue == "GT")
            {
                T15_adquisicion_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T15_adquisicion_Departamento.DataValueField = "DepartamentoID";
                    T15_adquisicion_Departamento.DataTextField = "Descripcion";
                    T15_adquisicion_Departamento.DataSource = dt;
                    T15_adquisicion_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_14_ProductosValidation.Visible = true;
                        SEC_14_ProductosValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    SEC_14_ProductosValidation.Visible = true;
                    SEC_14_ProductosValidation.Text = "Error al cargar el listado de departamentos";
                }
            }
            else
            {
                T15_adquisicion_Departamento.Enabled = false;
                T15_adquisicion_Municipio.Enabled = false;
            }
        }
        protected void cibc_cs_T15_adquisicion_Departamento(object sender, EventArgs e)
        {
            try
            {
                T15_adquisicion_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T15_adquisicion_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T15_adquisicion_Municipio.DataValueField = "MunicipioID";
                T15_adquisicion_Municipio.DataTextField = "Descripcion";
                T15_adquisicion_Municipio.DataSource = dt;
                T15_adquisicion_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_14_ProductosValidation.Visible = true;
                    SEC_14_ProductosValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void cibc_cs_T15_T15_FondosPropios(object sender, EventArgs e)
        {
            if (T15_fondosPropios.SelectedValue == "1")
            {
                T15_fondosTercero.Enabled = false;
            }
            else
            {
                T15_fondosTercero.Enabled = true;
            }
        }
        //Eventos de la sección 17 -----------------------------------------------------------------
        protected void cibc_cs_T18_pep(object sender, EventArgs e)
        {
            if (T18_pep.SelectedValue == "S")
            {
                Panel3.Visible = true;
            }
            else
            {
                Panel3.Visible = false;
            }
        }
        //Eventos de la sección 18 -----------------------------------------------------------------
        protected void cibc_cs_T18_parientePep(object sender, EventArgs e)
        {
            if (T18_parientePep.SelectedValue == "S")
            {
                Panel5.Visible = true;
            }
            else
            {
                Panel5.Visible = false;
            }
        }
        //Eventos de la sección 19 -----------------------------------------------------------------
        protected void cibc_cs_T18_asociadoPep(object sender, EventArgs e)
        {
            if (T18_asociadoPep.SelectedValue == "S")
            {
                Panel7.Visible = true;
            }
            else
            {
                Panel7.Visible = false;
            }
        }
        //------------------------------------------------------------------------------------------

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // METODOS UTILIZADOS EN LOS BOTONES PARA CAMBIAR DE PESTAÑA (btn_)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        protected void btn_SEC_01_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_01_Principal.Visible = false;
            // Sección a mostrar
            if(T1_tipoActuacion.SelectedValue == "C")
            {
                SEC_07_DatosDelRepresentanteLegal.Visible = true;
            }
            if (T1_tipoActuacion.SelectedValue == "R")
            {
                SEC_16_DatosDelRepresentanteLegal.Visible = true;
            }
            

        }
        protected void btn_SEC_07_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_07_DatosDelRepresentanteLegal.Visible = false;
            // Sección a mostrar
            SEC_08_TelefonosDelRepresentante.Visible = true;
        }
        protected void btn_SEC_16_Rep_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_16_DatosDelRepresentanteLegal.Visible = false;
            // Sección a mostrar
            SEC_21_TelefonosDelRepresentante.Visible = true;
        }
        protected void btn_SEC_21_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_21_TelefonosDelRepresentante.Visible = false;
            // Sección a mostrar
            SEC_17_PEP_Cliente.Visible = true;
        }
        protected void btn_SEC_08_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_08_TelefonosDelRepresentante.Visible = false;
            // Sección a mostrar
            SEC_09_PEP_Cliente.Visible = true;
        }
        protected void btn_SEC_22_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_17_PEP_Cliente.Visible = false;
            // Sección a mostrar
            SEC_19_PEP_ParienteRLC.Visible = true;
        }
        protected void btn_SEC_09_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_09_PEP_Cliente.Visible = false;
            // Sección a mostrar
            SEC_10_PEP_ParienteRLC.Visible = true;
        }
        protected void btn_SEC_23_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_19_PEP_ParienteRLC.Visible = false;
            // Sección a mostrar
            SEC_20_AsociadoRLC.Visible = true;
        }
        protected void btn_SEC_10_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_10_PEP_ParienteRLC.Visible = false;
            // Sección a mostrar
            SEC_11_AsociadoRLC.Visible = true;
        }
        protected void btn_SEC_24_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_20_AsociadoRLC.Visible = false;
            // Sección a mostrar
            SEC_07_DatosDelRepresentanteLegal.Visible = true;
        }
        protected void btn_SEC_11_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_11_AsociadoRLC.Visible = false;
            // Sección a mostrar
            SEC_13_InfoEconomicaDelCliente.Visible = true;
        }
        protected void btn_SEC_13_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_13_InfoEconomicaDelCliente.Visible = false;
            // Sección a mostrar
            SEC_14_Productos.Visible = true;
        }
        protected void btn_SEC_14_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_14_Productos.Visible = false;
            // Sección a mostrar
            
                if (T15_fondosPropios.SelectedValue == "0" || T15_fondosPropios.SelectedValue == "1")
                {
                    SEC_21_Pago.Visible = true;
                }
                else
                {
                    if (T15_fondosTercero.SelectedValue == "PI" || T15_fondosTercero.SelectedValue == "PU")
                    {
                        SEC_16_PI_FondosTercero.Visible = true;
                    }
                    else if (T15_fondosTercero.SelectedValue == "PJ")
                    {
                        SEC_20_PJ_FondosTercero.Visible = true;
                    }
                    else
                    {
                        SEC_21_Pago.Visible = true;
                    }
                
            }
        }
        protected void btn_SEC_16_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_16_PI_FondosTercero.Visible = false;
            // Sección a mostrar
            SEC_17_PEP_PIPFT.Visible = true;
        }
        protected void btn_SEC_17_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_17_PEP_PIPFT.Visible = false;
            // Sección a mostrar
            SEC_18_PEPPIPFT_Pariente.Visible = true;
        }
        protected void btn_SEC_18_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_18_PEPPIPFT_Pariente.Visible = false;
            // Sección a mostrar
            SEC_19_PEPPIPFT_Asociado.Visible = true;
        }
        protected void btn_SEC_19_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_19_PEPPIPFT_Asociado.Visible = false;
            // Sección a mostrar
            if (T15_fondosTercero.SelectedValue == "PJ" || T15_fondosTercero.SelectedValue == "PU")
            {
                SEC_20_PJ_FondosTercero.Visible = true;
            }
            else
            {
                SEC_21_Pago.Visible = true;
            }
        }
        protected void btn_SEC_20_Siguiente(object sender, EventArgs e)
        {
            // Sección actual
            SEC_20_PJ_FondosTercero.Visible = false;
            // Sección a mostrar
            SEC_21_Pago.Visible = true;
        }
        protected void btn_SEC_21_Finalizar(object sender, EventArgs e)
        {
            // Sección actual
            SEC_21_Pago.Visible = false;
            // Sección a mostrar
            PanelFInal.Visible = true;
        }
        protected void btn_SEC_22_Redireccionar(object sender, EventArgs e)
        {
            Response.Redirect("VisorReportes.aspx?ReporteID=1962");
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // METODOS UTILIZADOS AL MOMENTO DE CAMBIAR EL VALOR SELECCIONADO DE UN DROPDOWNLIST (sc_)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        protected void sc_(object sender, EventArgs e)
        {
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // METODOS UTILIZADOS AL MOMENTO DE CAMBIAR EL VALOR SELECCIONADO DE UN TEXTBOX (tb_)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        protected void tc_(object sender, EventArgs e)
        {
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
        // METODOS UTILIZADOS PARA GUARDAR DATOS (insert_)
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // SEC 1 : Principal
        protected void insert_T01(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT1_empresa = new FIVEWS.CL_Diccionario(); ;
                ParamT1_empresa.Nombre = "@empresa";
                ParamT1_empresa.Valor = T1_empresa.SelectedValue;
                ListParamsIn.Add(ParamT1_empresa);
                FIVEWS.CL_Diccionario ParamT1_sucursal = new FIVEWS.CL_Diccionario(); ;
                ParamT1_sucursal.Nombre = "@sucursal";
                ParamT1_sucursal.Valor = T1_sucursal.SelectedValue;
                ListParamsIn.Add(ParamT1_sucursal);
                FIVEWS.CL_Diccionario ParamT1_ordenDeVenta = new FIVEWS.CL_Diccionario(); ;
                ParamT1_ordenDeVenta.Nombre = "@ordenDeVenta";
                ParamT1_ordenDeVenta.Valor = T1_ordenDeVenta.Text;
                ListParamsIn.Add(ParamT1_ordenDeVenta);
                FIVEWS.CL_Diccionario ParamT1_fechaCrecionFormulario = new FIVEWS.CL_Diccionario(); ;
                ParamT1_fechaCrecionFormulario.Nombre = "@fechaCrecionFormulario";
                ParamT1_fechaCrecionFormulario.Valor = Convert.ToDateTime(T1_fechaCrecionFormulario.Text);
                ListParamsIn.Add(ParamT1_fechaCrecionFormulario);
                FIVEWS.CL_Diccionario ParamT2_paisID = new FIVEWS.CL_Diccionario(); ;
                ParamT2_paisID.Nombre = "@paisID";
                ParamT2_paisID.Valor = T2_paisID.SelectedValue;
                ListParamsIn.Add(ParamT2_paisID);
                FIVEWS.CL_Diccionario ParamT2_departamentoID = new FIVEWS.CL_Diccionario(); ;
                ParamT2_departamentoID.Nombre = "@departamentoID";
                ParamT2_departamentoID.Valor = T2_departamentoID.SelectedValue;
                ListParamsIn.Add(ParamT2_departamentoID);
                FIVEWS.CL_Diccionario ParamT2_municipioID = new FIVEWS.CL_Diccionario(); ;
                ParamT2_municipioID.Nombre = "@municipioID";
                ParamT2_municipioID.Valor = T2_municipioID.SelectedValue;
                ListParamsIn.Add(ParamT2_municipioID);
                FIVEWS.CL_Diccionario ParamT1_tipoActuacion = new FIVEWS.CL_Diccionario(); ;
                ParamT1_tipoActuacion.Nombre = "@tipoActuacion";
                ParamT1_tipoActuacion.Valor = T1_tipoActuacion.SelectedValue;
                ListParamsIn.Add(ParamT1_tipoActuacion);
                FIVEWS.CL_Diccionario ParamT1_calidadActua = new FIVEWS.CL_Diccionario(); ;
                ParamT1_calidadActua.Nombre = "@calidadActua";
                ParamT1_calidadActua.Valor = T1_calidadActua.Text;
                ListParamsIn.Add(ParamT1_calidadActua);
                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT01_Principal(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_01_PrincipalValidation.Visible = true;
                    SEC_01_PrincipalValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_01_PrincipalValidation.ForeColor = System.Drawing.Color.White;
                    SEC_01_PrincipalValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_01_PrincipalValidation.Visible = true;
                    SEC_01_PrincipalValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_01_PrincipalValidation.ForeColor = System.Drawing.Color.White;
                    SEC_01_PrincipalValidation.BackColor = System.Drawing.Color.Green;
                    FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    //T3_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    //T4_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    //T5_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    //T6_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    //T7_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T8_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T9_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T10_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T11_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T12_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    //T13_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T14_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T15_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T16_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T17_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T18_Ref_PersonaIndividualPEPRegID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T18_Ref_PersonaIndividualParientePEPRegID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T18_Ref_PersonaIndividualAsociadoPEPRegID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T19_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T20_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    T21_FormularioID.Text = resultado.Mensaje.MensajeTipo.ToString();
                    TextBox2.Text = resultado.Mensaje.MensajeTipo.ToString();
                    TextBox3.Text = resultado.Mensaje.MensajeTipo.ToString();
                    TextBox4.Text = resultado.Mensaje.MensajeTipo.ToString();
                    btnSEC_01_Principal_Siguiente.Visible = true;
                    btnSEC_01_Principal_Guardar.Visible = false;
                    btnSEC_01_Principal_Guardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
            }
        }
        protected void insert_T08(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT8_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT8_FormularioID.Nombre = "@FormularioID";
                ParamT8_FormularioID.Valor = T8_FormularioID.Text;
                ListParamsIn.Add(ParamT8_FormularioID);

                FIVEWS.CL_Diccionario ParamT8_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT8_primerNombre.Nombre = "@primerNombre";
                ParamT8_primerNombre.Valor = T8_primerNombre.Text;
                ListParamsIn.Add(ParamT8_primerNombre);

                FIVEWS.CL_Diccionario ParamT8_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT8_segundoNombre.Nombre = "@segundoNombre";
                ParamT8_segundoNombre.Valor = T8_segundoNombre.Text;
                ListParamsIn.Add(ParamT8_segundoNombre);

                FIVEWS.CL_Diccionario ParamT8_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT8_otrosNombres.Nombre = "@otrosNombres";
                ParamT8_otrosNombres.Valor = T8_otrosNombres.Text;
                ListParamsIn.Add(ParamT8_otrosNombres);

                FIVEWS.CL_Diccionario ParamT8_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT8_primerApellido.Nombre = "@primerApellido";
                ParamT8_primerApellido.Valor = T8_primerApellido.Text;
                ListParamsIn.Add(ParamT8_primerApellido);

                FIVEWS.CL_Diccionario ParamT8_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT8_segundoApellido.Nombre = "@segundoApellido";
                ParamT8_segundoApellido.Valor = T8_segundoApellido.Text;
                ListParamsIn.Add(ParamT8_segundoApellido);

                FIVEWS.CL_Diccionario ParamT8_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT8_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT8_apellidoCasada.Valor = T8_apellidoCasada.Text;
                ListParamsIn.Add(ParamT8_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT8_tipoDocumentoIdentificiacion = new FIVEWS.CL_Diccionario();
                ParamT8_tipoDocumentoIdentificiacion.Nombre = "@tipoDocumentoIdentificiacion";
                ParamT8_tipoDocumentoIdentificiacion.Valor = T8_tipoDocumentoIdentificiacion.SelectedValue;
                ListParamsIn.Add(ParamT8_tipoDocumentoIdentificiacion);

                FIVEWS.CL_Diccionario ParamT8_numeroDocumentoIdentificacion = new FIVEWS.CL_Diccionario();
                ParamT8_numeroDocumentoIdentificacion.Nombre = "@numeroDocumentoIdentificacion";
                ParamT8_numeroDocumentoIdentificacion.Valor = T8_numeroDocumentoIdentificacion.Text;
                ListParamsIn.Add(ParamT8_numeroDocumentoIdentificacion);

                FIVEWS.CL_Diccionario ParamT8_emisionPasaporte = new FIVEWS.CL_Diccionario();
                ParamT8_emisionPasaporte.Nombre = "@emisionPasaporte";
                ParamT8_emisionPasaporte.Valor = T8_emisionPasaporte.SelectedValue;
                ListParamsIn.Add(ParamT8_emisionPasaporte);

                FIVEWS.CL_Diccionario ParamT8_nit = new FIVEWS.CL_Diccionario();
                ParamT8_nit.Nombre = "@nit";
                ParamT8_nit.Valor = T8_nit.Text;
                ListParamsIn.Add(ParamT8_nit);

                FIVEWS.CL_Diccionario ParamT8_sexo = new FIVEWS.CL_Diccionario();
                ParamT8_sexo.Nombre = "@sexo";
                ParamT8_sexo.Valor = T8_sexo.SelectedValue;
                ListParamsIn.Add(ParamT8_sexo);

                FIVEWS.CL_Diccionario ParamT8_fechaNacimiento = new FIVEWS.CL_Diccionario();
                ParamT8_fechaNacimiento.Nombre = "@fechaNacimiento";
                ParamT8_fechaNacimiento.Valor = Convert.ToDateTime(T8_fechaNacimiento.Text);
                ListParamsIn.Add(ParamT8_fechaNacimiento);

                FIVEWS.CL_Diccionario ParamT8_direccionResidencia = new FIVEWS.CL_Diccionario();
                ParamT8_direccionResidencia.Nombre = "@direccionResidencia";
                ParamT8_direccionResidencia.Valor = T8_direccionResidencia.Text;
                ListParamsIn.Add(ParamT8_direccionResidencia);

                FIVEWS.CL_Diccionario ParamT8_direccionResidencia_Pais = new FIVEWS.CL_Diccionario();
                ParamT8_direccionResidencia_Pais.Nombre = "@direccionResidencia_Pais";
                ParamT8_direccionResidencia_Pais.Valor = T8_direccionResidencia_Pais.SelectedValue;
                ListParamsIn.Add(ParamT8_direccionResidencia_Pais);

                FIVEWS.CL_Diccionario ParamT8_direccionResidencia_Departamento = new FIVEWS.CL_Diccionario();
                ParamT8_direccionResidencia_Departamento.Nombre = "@direccionResidencia_Departamento";
                ParamT8_direccionResidencia_Departamento.Valor = T8_direccionResidencia_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT8_direccionResidencia_Departamento);

                FIVEWS.CL_Diccionario ParamT8_direccionResidencia_Municipio = new FIVEWS.CL_Diccionario();
                ParamT8_direccionResidencia_Municipio.Nombre = "@direccionResidencia_Municipio";
                ParamT8_direccionResidencia_Municipio.Valor = T8_direccionResidencia_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT8_direccionResidencia_Municipio);

                FIVEWS.CL_Diccionario ParamT8_direccionResidencia_Zona = new FIVEWS.CL_Diccionario();
                ParamT8_direccionResidencia_Zona.Nombre = "@direccionResidencia_Zona";
                ParamT8_direccionResidencia_Zona.Valor = T8_direccionResidencia_Zona.Text;
                ListParamsIn.Add(ParamT8_direccionResidencia_Zona);

                FIVEWS.CL_Diccionario ParamT8_direccionnacimiento_Pais = new FIVEWS.CL_Diccionario();
                ParamT8_direccionnacimiento_Pais.Nombre = "@direccionnacimiento_Pais";
                ParamT8_direccionnacimiento_Pais.Valor = T8_direccionnacimiento_Pais.SelectedValue;
                ListParamsIn.Add(ParamT8_direccionnacimiento_Pais);

                FIVEWS.CL_Diccionario ParamT8_direccionnacimiento_Departamento = new FIVEWS.CL_Diccionario();
                ParamT8_direccionnacimiento_Departamento.Nombre = "@direccionnacimiento_Departamento";
                ParamT8_direccionnacimiento_Departamento.Valor = T8_direccionnacimiento_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT8_direccionnacimiento_Departamento);

                FIVEWS.CL_Diccionario ParamT8_direccionnacimiento_Municipio = new FIVEWS.CL_Diccionario();
                ParamT8_direccionnacimiento_Municipio.Nombre = "@direccionnacimiento_Municipio";
                ParamT8_direccionnacimiento_Municipio.Valor = T8_direccionnacimiento_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT8_direccionnacimiento_Municipio);

                FIVEWS.CL_Diccionario ParamT8_condicionMigratoria = new FIVEWS.CL_Diccionario();
                ParamT8_condicionMigratoria.Nombre = "@condicionMigratoria";
                ParamT8_condicionMigratoria.Valor = T8_condicionMigratoria.SelectedValue;
                ListParamsIn.Add(ParamT8_condicionMigratoria);

                FIVEWS.CL_Diccionario ParamT8_otraCondicionMigratoria = new FIVEWS.CL_Diccionario();
                ParamT8_otraCondicionMigratoria.Nombre = "@otraCondicionMigratoria";
                ParamT8_otraCondicionMigratoria.Valor = T8_otraCondicionMigratoria.Text;
                ListParamsIn.Add(ParamT8_otraCondicionMigratoria);

                FIVEWS.CL_Diccionario ParamT8_nacionalidades = new FIVEWS.CL_Diccionario();
                ParamT8_nacionalidades.Nombre = "@nacionalidades";
                ParamT8_nacionalidades.Valor = "[" + T8_nacionalidad1.SelectedValue.ToString() + ";" + T8_nacionalidad2.SelectedValue.ToString() + ";" + T8_nacionalidad3.SelectedValue.ToString() + "]";
                ListParamsIn.Add(ParamT8_nacionalidades);

                FIVEWS.CL_Diccionario ParamT8_estadoCivil = new FIVEWS.CL_Diccionario();
                ParamT8_estadoCivil.Nombre = "@estadoCivil";
                ParamT8_estadoCivil.Valor = T8_estadoCivil.SelectedValue;
                ListParamsIn.Add(ParamT8_estadoCivil);

                FIVEWS.CL_Diccionario ParamT8_profesionOficio = new FIVEWS.CL_Diccionario();
                ParamT8_profesionOficio.Nombre = "@profesionOficio";
                ParamT8_profesionOficio.Valor = T8_profesionOficio.Text;
                ListParamsIn.Add(ParamT8_profesionOficio);

                FIVEWS.CL_Diccionario ParamT8_email = new FIVEWS.CL_Diccionario();
                ParamT8_email.Nombre = "@email";
                ParamT8_email.Valor = T8_email.Text;
                ListParamsIn.Add(ParamT8_email);

                FIVEWS.CL_Diccionario ParamT8_clienteCPE = new FIVEWS.CL_Diccionario();
                ParamT8_clienteCPE.Nombre = "@clienteCPE";
                ParamT8_clienteCPE.Valor = T8_clienteCPE.SelectedValue;
                ListParamsIn.Add(ParamT8_clienteCPE);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT03_Cliente(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_07_DatosDelRepresentanteLegalValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_07_DatosDelRepresentanteLegalValidation.ForeColor = System.Drawing.Color.White;
                    SEC_07_DatosDelRepresentanteLegalValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_07_DatosDelRepresentanteLegalValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_07_DatosDelRepresentanteLegalValidation.ForeColor = System.Drawing.Color.White;
                    SEC_07_DatosDelRepresentanteLegalValidation.BackColor = System.Drawing.Color.Green;
                    btnSEC_07_DatosDelRepresentanteLegal_Siguiente.Visible = true;
                }
            }
            catch (Exception ex)
            {
                SEC_07_DatosDelRepresentanteLegalValidation.Visible = true;
                SEC_07_DatosDelRepresentanteLegalValidation.Text = "La carga de telefonos ha fallado, contacte a informatica" + ex.ToString();
                SEC_07_DatosDelRepresentanteLegalValidation.ForeColor = System.Drawing.Color.White;
                SEC_07_DatosDelRepresentanteLegalValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 7 : Datos del representante legal
        protected void insert_T16(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT16_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT16_FormularioID.Nombre = "@FormularioID";
                ParamT16_FormularioID.Valor = T16_FormularioID.Text;
                ListParamsIn.Add(ParamT16_FormularioID);

                FIVEWS.CL_Diccionario ParamT16_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT16_primerNombre.Nombre = "@primerNombre";
                ParamT16_primerNombre.Valor = T16_primerNombre.Text;
                ListParamsIn.Add(ParamT16_primerNombre);

                FIVEWS.CL_Diccionario ParamT16_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT16_segundoNombre.Nombre = "@segundoNombre";
                ParamT16_segundoNombre.Valor = T16_segundoNombre.Text;
                ListParamsIn.Add(ParamT16_segundoNombre);

                FIVEWS.CL_Diccionario ParamT16_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT16_otrosNombres.Nombre = "@otrosNombres";
                ParamT16_otrosNombres.Valor = T16_otrosNombres.Text;
                ListParamsIn.Add(ParamT16_otrosNombres);

                FIVEWS.CL_Diccionario ParamT16_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT16_primerApellido.Nombre = "@primerApellido";
                ParamT16_primerApellido.Valor = T16_primerApellido.Text;
                ListParamsIn.Add(ParamT16_primerApellido);

                FIVEWS.CL_Diccionario ParamT16_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT16_segundoApellido.Nombre = "@segundoApellido";
                ParamT16_segundoApellido.Valor = T16_segundoApellido.Text;
                ListParamsIn.Add(ParamT16_segundoApellido);

                FIVEWS.CL_Diccionario ParamT16_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT16_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT16_apellidoCasada.Valor = T16_apellidoCasada.Text;
                ListParamsIn.Add(ParamT16_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT16_tipoDocumentoIdentificiacion = new FIVEWS.CL_Diccionario();
                ParamT16_tipoDocumentoIdentificiacion.Nombre = "@tipoDocumentoIdentificiacion";
                ParamT16_tipoDocumentoIdentificiacion.Valor = T16_tipoDocumentoIdentificiacion.SelectedValue;
                ListParamsIn.Add(ParamT16_tipoDocumentoIdentificiacion);

                FIVEWS.CL_Diccionario ParamT16_numeroDocumentoIdentificacion = new FIVEWS.CL_Diccionario();
                ParamT16_numeroDocumentoIdentificacion.Nombre = "@numeroDocumentoIdentificacion";
                ParamT16_numeroDocumentoIdentificacion.Valor = T16_numeroDocumentoIdentificacion.Text;
                ListParamsIn.Add(ParamT16_numeroDocumentoIdentificacion);

                FIVEWS.CL_Diccionario ParamT16_emisionPasaporte = new FIVEWS.CL_Diccionario();
                ParamT16_emisionPasaporte.Nombre = "@emisionPasaporte";
                ParamT16_emisionPasaporte.Valor = T16_emisionPasaporte.SelectedValue;
                ListParamsIn.Add(ParamT16_emisionPasaporte);

                FIVEWS.CL_Diccionario ParamT16_nit = new FIVEWS.CL_Diccionario();
                ParamT16_nit.Nombre = "@nit";
                ParamT16_nit.Valor = T16_nit.Text;
                ListParamsIn.Add(ParamT16_nit);

                FIVEWS.CL_Diccionario ParamT16_sexo = new FIVEWS.CL_Diccionario();
                ParamT16_sexo.Nombre = "@sexo";
                ParamT16_sexo.Valor = T16_sexo.SelectedValue;
                ListParamsIn.Add(ParamT16_sexo);

                FIVEWS.CL_Diccionario ParamT16_fechaNacimiento = new FIVEWS.CL_Diccionario();
                ParamT16_fechaNacimiento.Nombre = "@fechaNacimiento";
                ParamT16_fechaNacimiento.Valor = Convert.ToDateTime(T16_fechaNacimiento.Text);
                ListParamsIn.Add(ParamT16_fechaNacimiento);

                FIVEWS.CL_Diccionario ParamT16_direccionResidencia = new FIVEWS.CL_Diccionario();
                ParamT16_direccionResidencia.Nombre = "@direccionResidencia";
                ParamT16_direccionResidencia.Valor = T16_direccionResidencia.Text;
                ListParamsIn.Add(ParamT16_direccionResidencia);

                FIVEWS.CL_Diccionario ParamT16_direccionResidencia_Pais = new FIVEWS.CL_Diccionario();
                ParamT16_direccionResidencia_Pais.Nombre = "@direccionResidencia_Pais";
                ParamT16_direccionResidencia_Pais.Valor = T16_direccionResidencia_Pais.SelectedValue;
                ListParamsIn.Add(ParamT16_direccionResidencia_Pais);

                FIVEWS.CL_Diccionario ParamT16_direccionResidencia_Departamento = new FIVEWS.CL_Diccionario();
                ParamT16_direccionResidencia_Departamento.Nombre = "@direccionResidencia_Departamento";
                ParamT16_direccionResidencia_Departamento.Valor = T16_direccionResidencia_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT16_direccionResidencia_Departamento);

                FIVEWS.CL_Diccionario ParamT16_direccionResidencia_Municipio = new FIVEWS.CL_Diccionario();
                ParamT16_direccionResidencia_Municipio.Nombre = "@direccionResidencia_Municipio";
                ParamT16_direccionResidencia_Municipio.Valor = T16_direccionResidencia_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT16_direccionResidencia_Municipio);

                FIVEWS.CL_Diccionario ParamT16_direccionResidencia_Zona = new FIVEWS.CL_Diccionario();
                ParamT16_direccionResidencia_Zona.Nombre = "@direccionResidencia_Zona";
                ParamT16_direccionResidencia_Zona.Valor = T16_direccionResidencia_Zona.Text;
                ListParamsIn.Add(ParamT16_direccionResidencia_Zona);

                FIVEWS.CL_Diccionario ParamT16_direccionnacimiento_Pais = new FIVEWS.CL_Diccionario();
                ParamT16_direccionnacimiento_Pais.Nombre = "@direccionnacimiento_Pais";
                ParamT16_direccionnacimiento_Pais.Valor = T16_direccionnacimiento_Pais.SelectedValue;
                ListParamsIn.Add(ParamT16_direccionnacimiento_Pais);

                FIVEWS.CL_Diccionario ParamT16_direccionnacimiento_Departamento = new FIVEWS.CL_Diccionario();
                ParamT16_direccionnacimiento_Departamento.Nombre = "@direccionnacimiento_Departamento";
                ParamT16_direccionnacimiento_Departamento.Valor = T16_direccionnacimiento_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT16_direccionnacimiento_Departamento);

                FIVEWS.CL_Diccionario ParamT16_direccionnacimiento_Municipio = new FIVEWS.CL_Diccionario();
                ParamT16_direccionnacimiento_Municipio.Nombre = "@direccionnacimiento_Municipio";
                ParamT16_direccionnacimiento_Municipio.Valor = T16_direccionnacimiento_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT16_direccionnacimiento_Municipio);

                FIVEWS.CL_Diccionario ParamT16_condicionMigratoria = new FIVEWS.CL_Diccionario();
                ParamT16_condicionMigratoria.Nombre = "@condicionMigratoria";
                ParamT16_condicionMigratoria.Valor = T16_condicionMigratoria.SelectedValue;
                ListParamsIn.Add(ParamT16_condicionMigratoria);

                FIVEWS.CL_Diccionario ParamT16_otraCondicionMigratoria = new FIVEWS.CL_Diccionario();
                ParamT16_otraCondicionMigratoria.Nombre = "@otraCondicionMigratoria";
                ParamT16_otraCondicionMigratoria.Valor = T16_otraCondicionMigratoria.Text;
                ListParamsIn.Add(ParamT16_otraCondicionMigratoria);

                FIVEWS.CL_Diccionario ParamT16_nacionalidades = new FIVEWS.CL_Diccionario();
                ParamT16_nacionalidades.Nombre = "@nacionalidades";
                ParamT16_nacionalidades.Valor = "[" + T16_nacionalidad1.SelectedValue.ToString() + ";" + T16_nacionalidad2.SelectedValue.ToString() + ";" + T16_nacionalidad3.SelectedValue.ToString() + "]";
                ListParamsIn.Add(ParamT16_nacionalidades);

                FIVEWS.CL_Diccionario ParamT16_estadoCivil = new FIVEWS.CL_Diccionario();
                ParamT16_estadoCivil.Nombre = "@estadoCivil";
                ParamT16_estadoCivil.Valor = T16_estadoCivil.SelectedValue;
                ListParamsIn.Add(ParamT16_estadoCivil);

                FIVEWS.CL_Diccionario ParamT16_profesionOficio = new FIVEWS.CL_Diccionario();
                ParamT16_profesionOficio.Nombre = "@profesionOficio";
                ParamT16_profesionOficio.Valor = T16_profesionOficio.Text;
                ListParamsIn.Add(ParamT16_profesionOficio);

                FIVEWS.CL_Diccionario ParamT16_email = new FIVEWS.CL_Diccionario();
                ParamT16_email.Nombre = "@email";
                ParamT16_email.Valor = T16_email.Text;
                ListParamsIn.Add(ParamT16_email);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT16_Representante(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_16_DatosDelRepresentanteLegalValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_16_DatosDelRepresentanteLegalValidation.ForeColor = System.Drawing.Color.White;
                    SEC_16_DatosDelRepresentanteLegalValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_16_DatosDelRepresentanteLegalValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_16_DatosDelRepresentanteLegalValidation.ForeColor = System.Drawing.Color.White;
                    SEC_16_DatosDelRepresentanteLegalValidation.BackColor = System.Drawing.Color.Green;
                    btnSEC_16_DatosDelRepresentanteLegal_Siguiente.Visible = true;
                }
            }
            catch (Exception ex)
            {
                SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                SEC_16_DatosDelRepresentanteLegalValidation.Text = "La carga de telefonos ha fallado, contacte a informatica" + ex.ToString();
                SEC_16_DatosDelRepresentanteLegalValidation.ForeColor = System.Drawing.Color.White;
                SEC_16_DatosDelRepresentanteLegalValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 8 : Números de telefono del representante legal
        protected void insert_T09(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT9_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT9_FormularioID.Nombre = "@FormularioID";
                ParamT9_FormularioID.Valor = T9_FormularioID.Text;
                ListParamsIn.Add(ParamT9_FormularioID);

                FIVEWS.CL_Diccionario ParamT9_Telefono = new FIVEWS.CL_Diccionario();
                ParamT9_Telefono.Nombre = "@Telefono";
                ParamT9_Telefono.Valor = T9_Telefono.Text;
                ListParamsIn.Add(ParamT9_Telefono);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT15_TelefonosDelCliente(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_08_TelefonosDelRepresentanteValidation.Visible = true;
                    SEC_08_TelefonosDelRepresentanteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_08_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_08_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_08_TelefonosDelRepresentanteValidation.Visible = true;
                    SEC_08_TelefonosDelRepresentanteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_08_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_08_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Green;
                    btnSEC_08_TeRL_Siguiente.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T9_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_TelefonosDelCliente(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_TelefonosRepresentanteLegal.DataSource = dt;
                GV_TelefonosRepresentanteLegal.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_08_TelefonosDelRepresentanteValidation.Visible = true;
                    SEC_08_TelefonosDelRepresentanteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_08_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_08_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_08_TelefonosDelRepresentanteValidation.Visible = true;
                SEC_08_TelefonosDelRepresentanteValidation.Text = "La carga de telefonos ha fallado, contacte a informatica" + ex.ToString();
                SEC_08_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                SEC_08_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 8 : Números de telefono del representante
        protected void insert_T21(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT21_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT21_FormularioID.Nombre = "@FormularioID";
                ParamT21_FormularioID.Valor = T21_FormularioID.Text;
                ListParamsIn.Add(ParamT21_FormularioID);

                FIVEWS.CL_Diccionario ParamT21_Telefono = new FIVEWS.CL_Diccionario();
                ParamT21_Telefono.Nombre = "@Telefono";
                ParamT21_Telefono.Valor = T21_Telefono.Text;
                ListParamsIn.Add(ParamT21_Telefono);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT21_TelefonosDelCliente(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_21_TelefonosDelRepresentanteValidation.Visible = true;
                    SEC_21_TelefonosDelRepresentanteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_21_TelefonosDelRepresentanteValidation.Visible = true;
                    SEC_21_TelefonosDelRepresentanteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Green;
                    btnSEC_21_TeRL_Siguiente.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T21_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_TelefonosDelClienteRepresentante(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_TelefonosRepresentante.DataSource = dt;
                GV_TelefonosRepresentante.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_21_TelefonosDelRepresentanteValidation.Visible = true;
                    SEC_21_TelefonosDelRepresentanteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_21_TelefonosDelRepresentanteValidation.Visible = true;
                SEC_21_TelefonosDelRepresentanteValidation.Text = "La carga de telefonos ha fallado, contacte a informatica" + ex.ToString();
                SEC_21_TelefonosDelRepresentanteValidation.ForeColor = System.Drawing.Color.White;
                SEC_21_TelefonosDelRepresentanteValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 9 : Datos PEP - Representante legal
        protected void insert_T10(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT10_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT10_FormularioID.Nombre = "@FormularioID";
                ParamT10_FormularioID.Valor = T10_FormularioID.Text;
                ListParamsIn.Add(ParamT10_FormularioID);

                FIVEWS.CL_Diccionario ParamT10_pep = new FIVEWS.CL_Diccionario();
                ParamT10_pep.Nombre = "@pep";
                ParamT10_pep.Valor = T10_pep.SelectedValue;
                ListParamsIn.Add(ParamT10_pep);

                FIVEWS.CL_Diccionario ParamT10_entidad = new FIVEWS.CL_Diccionario();
                ParamT10_entidad.Nombre = "@entidad";
                ParamT10_entidad.Valor = T10_entidad.Text;
                ListParamsIn.Add(ParamT10_entidad);

                FIVEWS.CL_Diccionario ParamT10_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT10_puestoDesempenia.Nombre = "@puestoDesempenia";
                ParamT10_puestoDesempenia.Valor = T10_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT10_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT10_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT10_paisEntidad.Nombre = "@paisEntidad";
                ParamT10_paisEntidad.Valor = T10_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT10_paisEntidad);

                FIVEWS.CL_Diccionario ParamT10_origenRiqueza = new FIVEWS.CL_Diccionario();
                ParamT10_origenRiqueza.Nombre = "@origenRiqueza";
                ParamT10_origenRiqueza.Valor = T10_origenRiqueza.SelectedValue;
                ListParamsIn.Add(ParamT10_origenRiqueza);

                FIVEWS.CL_Diccionario ParamT10_otroOrigenriqueza = new FIVEWS.CL_Diccionario();
                ParamT10_otroOrigenriqueza.Nombre = "@otroOrigenriqueza";
                ParamT10_otroOrigenriqueza.Valor = T10_otroOrigenriqueza.Text;
                ListParamsIn.Add(ParamT10_otroOrigenriqueza);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT04_ClientePEP(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_09_PEP_ClienteValidation.Visible = true;
                    SEC_09_PEP_ClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_09_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_09_PEP_ClienteValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_09_PEP_ClienteValidation.Visible = true;
                    SEC_09_PEP_ClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_09_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_09_PEP_ClienteValidation.BackColor = System.Drawing.Color.Green;
                    SEC_09_PEP_ClienteValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_RepresentatneLegal(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_DatosPEP_Cliente.DataSource = dt;
                GV_DatosPEP_Cliente.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_09_PEP_ClienteValidation.Visible = true;
                    SEC_09_PEP_ClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_09_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_09_PEP_ClienteValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_09_PEP_ClienteValidation.Visible = true;
                SEC_09_PEP_ClienteValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_09_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                SEC_09_PEP_ClienteValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 9 : Datos PEP - Representante legal
        protected void insert_T22(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT22_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT22_FormularioID.Nombre = "@FormularioID";
                ParamT22_FormularioID.Valor = T17_FormularioID.Text;
                ListParamsIn.Add(ParamT22_FormularioID);

                FIVEWS.CL_Diccionario ParamT22_pep = new FIVEWS.CL_Diccionario();
                ParamT22_pep.Nombre = "@pep";
                ParamT22_pep.Valor = T17_pep.SelectedValue;
                ListParamsIn.Add(ParamT22_pep);

                FIVEWS.CL_Diccionario ParamT22_entidad = new FIVEWS.CL_Diccionario();
                ParamT22_entidad.Nombre = "@entidad";
                ParamT22_entidad.Valor = T17_entidad.Text;
                ListParamsIn.Add(ParamT22_entidad);

                FIVEWS.CL_Diccionario ParamT22_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT22_puestoDesempenia.Nombre = "@puestoDesempenia";
                ParamT22_puestoDesempenia.Valor = T17_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT22_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT22_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT22_paisEntidad.Nombre = "@paisEntidad";
                ParamT22_paisEntidad.Valor = T17_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT22_paisEntidad);

                FIVEWS.CL_Diccionario ParamT22_origenRiqueza = new FIVEWS.CL_Diccionario();
                ParamT22_origenRiqueza.Nombre = "@origenRiqueza";
                ParamT22_origenRiqueza.Valor = T17_origenRiqueza.SelectedValue;
                ListParamsIn.Add(ParamT22_origenRiqueza);

                FIVEWS.CL_Diccionario ParamT22_otroOrigenriqueza = new FIVEWS.CL_Diccionario();
                ParamT22_otroOrigenriqueza.Nombre = "@otroOrigenriqueza";
                ParamT22_otroOrigenriqueza.Valor = T17_otroOrigenriqueza.Text;
                ListParamsIn.Add(ParamT22_otroOrigenriqueza);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT17_ClientePEP(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_17_PEP_ClienteValidation.Visible = true;
                    SEC_17_PEP_ClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_17_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_17_PEP_ClienteValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_17_PEP_ClienteValidation.Visible = true;
                    SEC_17_PEP_ClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_17_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_17_PEP_ClienteValidation.BackColor = System.Drawing.Color.Green;
                    SEC_17_PEP_ClienteValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T17_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_Representante(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_DatosPEP_Representante.DataSource = dt;
                GV_DatosPEP_Representante.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_17_PEP_ClienteValidation.Visible = true;
                    SEC_17_PEP_ClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_17_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_17_PEP_ClienteValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_17_PEP_ClienteValidation.Visible = true;
                SEC_17_PEP_ClienteValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_17_PEP_ClienteValidation.ForeColor = System.Drawing.Color.White;
                SEC_17_PEP_ClienteValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 10 : Datos PEP - Pariente RLC
        protected void insert_T11(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT11_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT11_FormularioID.Nombre = "@FormularioID";
                ParamT11_FormularioID.Valor = T11_FormularioID.Text;
                ListParamsIn.Add(ParamT11_FormularioID);

                FIVEWS.CL_Diccionario ParamT11_parientePep = new FIVEWS.CL_Diccionario();
                ParamT11_parientePep.Nombre = "@parientePep";
                ParamT11_parientePep.Valor = T11_parientePep.SelectedValue;
                ListParamsIn.Add(ParamT11_parientePep);

                FIVEWS.CL_Diccionario ParamT11_parentesco = new FIVEWS.CL_Diccionario();
                ParamT11_parentesco.Nombre = "@parentesco";
                ParamT11_parentesco.Valor = T11_parentesco.SelectedValue;
                ListParamsIn.Add(ParamT11_parentesco);

                FIVEWS.CL_Diccionario ParamT11_otroPerntesco = new FIVEWS.CL_Diccionario();
                ParamT11_otroPerntesco.Nombre = "@otroPerntesco";
                ParamT11_otroPerntesco.Valor = T11_otroPerntesco.Text;
                ListParamsIn.Add(ParamT11_otroPerntesco);

                FIVEWS.CL_Diccionario ParamT11_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT11_primerNombre.Nombre = "@primerNombre";
                ParamT11_primerNombre.Valor = T11_primerNombre.Text;
                ListParamsIn.Add(ParamT11_primerNombre);

                FIVEWS.CL_Diccionario ParamT11_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT11_segundoNombre.Nombre = "@segundoNombre";
                ParamT11_segundoNombre.Valor = T11_segundoNombre.Text;
                ListParamsIn.Add(ParamT11_segundoNombre);

                FIVEWS.CL_Diccionario ParamT11_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT11_otrosNombres.Nombre = "@otrosNombres";
                ParamT11_otrosNombres.Valor = T11_otrosNombres.Text;
                ListParamsIn.Add(ParamT11_otrosNombres);

                FIVEWS.CL_Diccionario ParamT11_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT11_primerApellido.Nombre = "@primerApellido";
                ParamT11_primerApellido.Valor = T11_primerApellido.Text;
                ListParamsIn.Add(ParamT11_primerApellido);

                FIVEWS.CL_Diccionario ParamT11_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT11_segundoApellido.Nombre = "@segundoApellido";
                ParamT11_segundoApellido.Valor = T11_segundoApellido.Text;
                ListParamsIn.Add(ParamT11_segundoApellido);

                FIVEWS.CL_Diccionario ParamT11_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT11_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT11_apellidoCasada.Valor = T11_apellidoCasada.Text;
                ListParamsIn.Add(ParamT11_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT11_sexo = new FIVEWS.CL_Diccionario();
                ParamT11_sexo.Nombre = "@sexo";
                ParamT11_sexo.Valor = T11_sexo.SelectedValue;
                ListParamsIn.Add(ParamT11_sexo);

                FIVEWS.CL_Diccionario ParamT11_condicion = new FIVEWS.CL_Diccionario();
                ParamT11_condicion.Nombre = "@condicion";
                ParamT11_condicion.Valor = T11_condicion.SelectedValue;
                ListParamsIn.Add(ParamT11_condicion);

                FIVEWS.CL_Diccionario ParamT11_entidad = new FIVEWS.CL_Diccionario();
                ParamT11_entidad.Nombre = "@entidad";
                ParamT11_entidad.Valor = T11_entidad.Text;
                ListParamsIn.Add(ParamT11_entidad);

                FIVEWS.CL_Diccionario ParamT11_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT11_puestoDesempenia.Nombre = "@puestoDesempenia";
                ParamT11_puestoDesempenia.Valor = T11_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT11_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT11_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT11_paisEntidad.Nombre = "@paisEntidad";
                ParamT11_paisEntidad.Valor = T11_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT11_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT05_ClienteParientePEP(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_10_PEP_ParienteRLCValidation.Visible = true;
                    SEC_10_PEP_ParienteRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_10_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_10_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_10_PEP_ParienteRLCValidation.Visible = true;
                    SEC_10_PEP_ParienteRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_10_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_10_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Green;
                    SEC_10_PEP_ParienteRLCValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_ParienteRepresentatneLegal(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_DatosPEP_parientePEP.DataSource = dt;
                GV_DatosPEP_parientePEP.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_10_PEP_ParienteRLCValidation.Visible = true;
                    SEC_10_PEP_ParienteRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_10_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_10_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_10_PEP_ParienteRLCValidation.Visible = true;
                SEC_10_PEP_ParienteRLCValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_10_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                SEC_10_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 10 : Datos PEP - Pariente RLC
        protected void insert_T23(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT23_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT23_FormularioID.Nombre = "@FormularioID";
                ParamT23_FormularioID.Valor = T19_FormularioID.Text;
                ListParamsIn.Add(ParamT23_FormularioID);

                FIVEWS.CL_Diccionario ParamT23_parientePep = new FIVEWS.CL_Diccionario();
                ParamT23_parientePep.Nombre = "@parientePep";
                ParamT23_parientePep.Valor = T19_parientePep.SelectedValue;
                ListParamsIn.Add(ParamT23_parientePep);

                FIVEWS.CL_Diccionario ParamT23_parentesco = new FIVEWS.CL_Diccionario();
                ParamT23_parentesco.Nombre = "@parentesco";
                ParamT23_parentesco.Valor = T19_parentesco.SelectedValue;
                ListParamsIn.Add(ParamT23_parentesco);

                FIVEWS.CL_Diccionario ParamT23_otroPerntesco = new FIVEWS.CL_Diccionario();
                ParamT23_otroPerntesco.Nombre = "@otroPerntesco";
                ParamT23_otroPerntesco.Valor = T19_otroPerntesco.Text;
                ListParamsIn.Add(ParamT23_otroPerntesco);

                FIVEWS.CL_Diccionario ParamT23_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT23_primerNombre.Nombre = "@primerNombre";
                ParamT23_primerNombre.Valor = T19_primerNombre.Text;
                ListParamsIn.Add(ParamT23_primerNombre);

                FIVEWS.CL_Diccionario ParamT23_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT23_segundoNombre.Nombre = "@segundoNombre";
                ParamT23_segundoNombre.Valor = T19_segundoNombre.Text;
                ListParamsIn.Add(ParamT23_segundoNombre);

                FIVEWS.CL_Diccionario ParamT23_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT23_otrosNombres.Nombre = "@otrosNombres";
                ParamT23_otrosNombres.Valor = T19_otrosNombres.Text;
                ListParamsIn.Add(ParamT23_otrosNombres);

                FIVEWS.CL_Diccionario ParamT23_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT23_primerApellido.Nombre = "@primerApellido";
                ParamT23_primerApellido.Valor = T19_primerApellido.Text;
                ListParamsIn.Add(ParamT23_primerApellido);

                FIVEWS.CL_Diccionario ParamT23_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT23_segundoApellido.Nombre = "@segundoApellido";
                ParamT23_segundoApellido.Valor = T19_segundoApellido.Text;
                ListParamsIn.Add(ParamT23_segundoApellido);

                FIVEWS.CL_Diccionario ParamT23_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT23_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT23_apellidoCasada.Valor = T19_apellidoCasada.Text;
                ListParamsIn.Add(ParamT23_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT23_sexo = new FIVEWS.CL_Diccionario();
                ParamT23_sexo.Nombre = "@sexo";
                ParamT23_sexo.Valor = T19_sexo.SelectedValue;
                ListParamsIn.Add(ParamT23_sexo);

                FIVEWS.CL_Diccionario ParamT23_condicion = new FIVEWS.CL_Diccionario();
                ParamT23_condicion.Nombre = "@condicion";
                ParamT23_condicion.Valor = T19_condicion.SelectedValue;
                ListParamsIn.Add(ParamT23_condicion);

                FIVEWS.CL_Diccionario ParamT23_entidad = new FIVEWS.CL_Diccionario();
                ParamT23_entidad.Nombre = "@entidad";
                ParamT23_entidad.Valor = T19_entidad.Text;
                ListParamsIn.Add(ParamT23_entidad);

                FIVEWS.CL_Diccionario ParamT23_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT23_puestoDesempenia.Nombre = "@puestoDesempenia";
                ParamT23_puestoDesempenia.Valor = T19_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT23_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT23_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT23_paisEntidad.Nombre = "@paisEntidad";
                ParamT23_paisEntidad.Valor = T19_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT23_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT19_ClienteParientePEP(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_19_PEP_ParienteRLCValidation.Visible = true;
                    SEC_19_PEP_ParienteRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_19_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_19_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_19_PEP_ParienteRLCValidation.Visible = true;
                    SEC_19_PEP_ParienteRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_19_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_19_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Green;
                    SEC_19_PEP_ParienteRLCValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T19_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_ParienteRepresentante(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_DatosPEP_parienterepresentantePEP.DataSource = dt;
                GV_DatosPEP_parienterepresentantePEP.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_19_PEP_ParienteRLCValidation.Visible = true;
                    SEC_19_PEP_ParienteRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_19_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_19_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_19_PEP_ParienteRLCValidation.Visible = true;
                SEC_19_PEP_ParienteRLCValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_19_PEP_ParienteRLCValidation.ForeColor = System.Drawing.Color.White;
                SEC_19_PEP_ParienteRLCValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 11 : Datos PEP - Asociado RLC
        protected void insert_T12(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT12_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT12_FormularioID.Nombre = "@FormularioID";
                ParamT12_FormularioID.Valor = T12_FormularioID.Text;
                ListParamsIn.Add(ParamT12_FormularioID);

                FIVEWS.CL_Diccionario ParamT12_asociadoPep = new FIVEWS.CL_Diccionario();
                ParamT12_asociadoPep.Nombre = "@asociadoPep";
                ParamT12_asociadoPep.Valor = T12_asociadoPep.SelectedValue;
                ListParamsIn.Add(ParamT12_asociadoPep);

                FIVEWS.CL_Diccionario ParamT12_motivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT12_motivoAsociacion.Nombre = "@motivoAsociacion";
                ParamT12_motivoAsociacion.Valor = T12_motivoAsociacion.SelectedValue;
                ListParamsIn.Add(ParamT12_motivoAsociacion);

                FIVEWS.CL_Diccionario ParamT12_otroMotivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT12_otroMotivoAsociacion.Nombre = "@otroMotivoAsociacion";
                ParamT12_otroMotivoAsociacion.Valor = T12_otroMotivoAsociacion.Text;
                ListParamsIn.Add(ParamT12_otroMotivoAsociacion);

                FIVEWS.CL_Diccionario ParamT12_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT12_primerNombre.Nombre = "@primerNombre";
                ParamT12_primerNombre.Valor = T12_primerNombre.Text;
                ListParamsIn.Add(ParamT12_primerNombre);

                FIVEWS.CL_Diccionario ParamT12_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT12_segundoNombre.Nombre = "@segundoNombre";
                ParamT12_segundoNombre.Valor = T12_segundoNombre.Text;
                ListParamsIn.Add(ParamT12_segundoNombre);

                FIVEWS.CL_Diccionario ParamT12_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT12_otrosNombres.Nombre = "@otrosNombres";
                ParamT12_otrosNombres.Valor = T12_otrosNombres.Text;
                ListParamsIn.Add(ParamT12_otrosNombres);

                FIVEWS.CL_Diccionario ParamT12_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT12_primerApellido.Nombre = "@primerApellido";
                ParamT12_primerApellido.Valor = T12_primerApellido.Text;
                ListParamsIn.Add(ParamT12_primerApellido);

                FIVEWS.CL_Diccionario ParamT12_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT12_segundoApellido.Nombre = "@segundoApellido";
                ParamT12_segundoApellido.Valor = T12_segundoApellido.Text;
                ListParamsIn.Add(ParamT12_segundoApellido);

                FIVEWS.CL_Diccionario ParamT12_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT12_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT12_apellidoCasada.Valor = T12_apellidoCasada.Text;
                ListParamsIn.Add(ParamT12_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT12_sexo = new FIVEWS.CL_Diccionario();
                ParamT12_sexo.Nombre = "@sexo";
                ParamT12_sexo.Valor = T12_sexo.SelectedValue;
                ListParamsIn.Add(ParamT12_sexo);

                FIVEWS.CL_Diccionario ParamT12_condicion = new FIVEWS.CL_Diccionario();
                ParamT12_condicion.Nombre = "@condicion";
                ParamT12_condicion.Valor = T12_condicion.SelectedValue;
                ListParamsIn.Add(ParamT12_condicion);

                FIVEWS.CL_Diccionario ParamT12_entidad = new FIVEWS.CL_Diccionario();
                ParamT12_entidad.Nombre = "@entidad";
                ParamT12_entidad.Valor = T12_entidad.Text;
                ListParamsIn.Add(ParamT12_entidad);

                FIVEWS.CL_Diccionario ParamT12_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT12_puestoDesempenia.Nombre = "@puestoDesempenia";
                ParamT12_puestoDesempenia.Valor = T12_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT12_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT12_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT12_paisEntidad.Nombre = "@paisEntidad";
                ParamT12_paisEntidad.Valor = T12_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT12_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT06_ClienteAsociadoPEP(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_11_AsociadoRLCValidation.Visible = true;
                    SEC_11_AsociadoRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_11_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_11_AsociadoRLCValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_11_AsociadoRLCValidation.Visible = true;
                    SEC_11_AsociadoRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_11_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_11_AsociadoRLCValidation.BackColor = System.Drawing.Color.Green;
                    SEC_11_AsociadoRLCValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_AsociadoRepresentatneLegal(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_DatosAsociadoPEPRL.DataSource = dt;
                GV_DatosAsociadoPEPRL.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_11_AsociadoRLCValidation.Visible = true;
                    SEC_11_AsociadoRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_11_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_11_AsociadoRLCValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_11_AsociadoRLCValidation.Visible = true;
                SEC_11_AsociadoRLCValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_11_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                SEC_11_AsociadoRLCValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        protected void insert_T24(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT24_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT24_FormularioID.Nombre = "@FormularioID";
                ParamT24_FormularioID.Valor = T20_FormularioID.Text;
                ListParamsIn.Add(ParamT24_FormularioID);

                FIVEWS.CL_Diccionario ParamT24_asociadoPep = new FIVEWS.CL_Diccionario();
                ParamT24_asociadoPep.Nombre = "@asociadoPep";
                ParamT24_asociadoPep.Valor = T20_asociadoPep.SelectedValue;
                ListParamsIn.Add(ParamT24_asociadoPep);

                FIVEWS.CL_Diccionario ParamT24_motivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT24_motivoAsociacion.Nombre = "@motivoAsociacion";
                ParamT24_motivoAsociacion.Valor = T20_motivoAsociacion.SelectedValue;
                ListParamsIn.Add(ParamT24_motivoAsociacion);

                FIVEWS.CL_Diccionario ParamT24_otroMotivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT24_otroMotivoAsociacion.Nombre = "@otroMotivoAsociacion";
                ParamT24_otroMotivoAsociacion.Valor = T20_otroMotivoAsociacion.Text;
                ListParamsIn.Add(ParamT24_otroMotivoAsociacion);

                FIVEWS.CL_Diccionario ParamT24_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT24_primerNombre.Nombre = "@primerNombre";
                ParamT24_primerNombre.Valor = T20_primerNombre.Text;
                ListParamsIn.Add(ParamT24_primerNombre);

                FIVEWS.CL_Diccionario ParamT24_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT24_segundoNombre.Nombre = "@segundoNombre";
                ParamT24_segundoNombre.Valor = T20_segundoNombre.Text;
                ListParamsIn.Add(ParamT24_segundoNombre);

                FIVEWS.CL_Diccionario ParamT24_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT24_otrosNombres.Nombre = "@otrosNombres";
                ParamT24_otrosNombres.Valor = T20_otrosNombres.Text;
                ListParamsIn.Add(ParamT24_otrosNombres);

                FIVEWS.CL_Diccionario ParamT24_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT24_primerApellido.Nombre = "@primerApellido";
                ParamT24_primerApellido.Valor = T20_primerApellido.Text;
                ListParamsIn.Add(ParamT24_primerApellido);

                FIVEWS.CL_Diccionario ParamT24_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT24_segundoApellido.Nombre = "@segundoApellido";
                ParamT24_segundoApellido.Valor = T20_segundoApellido.Text;
                ListParamsIn.Add(ParamT24_segundoApellido);

                FIVEWS.CL_Diccionario ParamT24_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT24_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT24_apellidoCasada.Valor = T20_apellidoCasada.Text;
                ListParamsIn.Add(ParamT24_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT24_sexo = new FIVEWS.CL_Diccionario();
                ParamT24_sexo.Nombre = "@sexo";
                ParamT24_sexo.Valor = T20_sexo.SelectedValue;
                ListParamsIn.Add(ParamT24_sexo);

                FIVEWS.CL_Diccionario ParamT24_condicion = new FIVEWS.CL_Diccionario();
                ParamT24_condicion.Nombre = "@condicion";
                ParamT24_condicion.Valor = T20_condicion.SelectedValue;
                ListParamsIn.Add(ParamT24_condicion);

                FIVEWS.CL_Diccionario ParamT24_entidad = new FIVEWS.CL_Diccionario();
                ParamT24_entidad.Nombre = "@entidad";
                ParamT24_entidad.Valor = T20_entidad.Text;
                ListParamsIn.Add(ParamT24_entidad);

                FIVEWS.CL_Diccionario ParamT24_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT24_puestoDesempenia.Nombre = "@puestoDesempenia";
                ParamT24_puestoDesempenia.Valor = T20_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT24_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT24_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT24_paisEntidad.Nombre = "@paisEntidad";
                ParamT24_paisEntidad.Valor = T20_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT24_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT20_ClienteAsociadoPEP(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_21_AsociadoRLCValidation.Visible = true;
                    SEC_21_AsociadoRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_AsociadoRLCValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_21_AsociadoRLCValidation.Visible = true;
                    SEC_21_AsociadoRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_AsociadoRLCValidation.BackColor = System.Drawing.Color.Green;
                    SEC_21_AsociadoRLCValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T20_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_AsociadoRepresentante(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_DatosAsociadoPEPRepresentante.DataSource = dt;
                GV_DatosAsociadoPEPRepresentante.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_21_AsociadoRLCValidation.Visible = true;
                    SEC_21_AsociadoRLCValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_AsociadoRLCValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_21_AsociadoRLCValidation.Visible = true;
                SEC_21_AsociadoRLCValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_21_AsociadoRLCValidation.ForeColor = System.Drawing.Color.White;
                SEC_21_AsociadoRLCValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        protected void insert_T14(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT14_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT14_FormularioID.Nombre = "@FormularioID";
                ParamT14_FormularioID.Valor = T14_FormularioID.Text;
                ListParamsIn.Add(ParamT14_FormularioID);

                FIVEWS.CL_Diccionario ParamT14_establecimientoInformacion = new FIVEWS.CL_Diccionario();
                ParamT14_establecimientoInformacion.Nombre = "@establecimientoInformacion";
                ParamT14_establecimientoInformacion.Valor = T14_establecimientoInformacion.SelectedValue;
                ListParamsIn.Add(ParamT14_establecimientoInformacion);

                FIVEWS.CL_Diccionario ParamT14_tipoEmpresa = new FIVEWS.CL_Diccionario();
                ParamT14_tipoEmpresa.Nombre = "@tipoEmpresa";
                ParamT14_tipoEmpresa.Valor = T14_TipoActividad.SelectedValue;
                ListParamsIn.Add(ParamT14_tipoEmpresa);

                FIVEWS.CL_Diccionario ParamT14_fecha = new FIVEWS.CL_Diccionario();
                ParamT14_fecha.Nombre = "@fecha";
                ParamT14_fecha.Valor = Convert.ToDateTime(T14_fecha.Text);
                ListParamsIn.Add(ParamT14_fecha);

                FIVEWS.CL_Diccionario ParamT14_actividadEconomicaRTU = new FIVEWS.CL_Diccionario();
                ParamT14_actividadEconomicaRTU.Nombre = "@actividadEconomicaRTU";
                ParamT14_actividadEconomicaRTU.Valor = T14_actividadEconomicaRTU.Text;
                ListParamsIn.Add(ParamT14_actividadEconomicaRTU);

                FIVEWS.CL_Diccionario ParamT14_nombreComercial = new FIVEWS.CL_Diccionario();
                ParamT14_nombreComercial.Nombre = "@nombreComercial";
                ParamT14_nombreComercial.Valor = T14_nombreComercial.Text;
                ListParamsIn.Add(ParamT14_nombreComercial);

                FIVEWS.CL_Diccionario ParamT14_nombreEmpleador = new FIVEWS.CL_Diccionario();
                ParamT14_nombreEmpleador.Nombre = "@nombreEmpleador";
                ParamT14_nombreEmpleador.Valor = T14_nombreEmpleador.Text;
                ListParamsIn.Add(ParamT14_nombreEmpleador);

                FIVEWS.CL_Diccionario ParamT14_ingresos_tipoIngreso = new FIVEWS.CL_Diccionario();
                ParamT14_ingresos_tipoIngreso.Nombre = "@ingresos_tipoIngreso";
                ParamT14_ingresos_tipoIngreso.Valor = T14_ingresos_tipoIngreso.SelectedValue;
                ListParamsIn.Add(ParamT14_ingresos_tipoIngreso);

                FIVEWS.CL_Diccionario ParamT14_ingresos_otroTipoIngreso = new FIVEWS.CL_Diccionario();
                ParamT14_ingresos_otroTipoIngreso.Nombre = "@ingresos_otroTipoIngreso";
                ParamT14_ingresos_otroTipoIngreso.Valor = T14_ingresos_otroTipoIngreso.Text;
                ListParamsIn.Add(ParamT14_ingresos_otroTipoIngreso);

                FIVEWS.CL_Diccionario ParamT14_ingresos_moneda = new FIVEWS.CL_Diccionario();
                ParamT14_ingresos_moneda.Nombre = "@ingresos_moneda";
                ParamT14_ingresos_moneda.Valor = T14_ingresos_moneda.SelectedValue;
                ListParamsIn.Add(ParamT14_ingresos_moneda);

                FIVEWS.CL_Diccionario ParamT14_ingresos_monto = new FIVEWS.CL_Diccionario();
                ParamT14_ingresos_monto.Nombre = "@ingresos_monto";
                ParamT14_ingresos_monto.Valor = T14_ingresos_monto.Text;
                ListParamsIn.Add(ParamT14_ingresos_monto);

                FIVEWS.CL_Diccionario ParamT14_egresos_moneda = new FIVEWS.CL_Diccionario();
                ParamT14_egresos_moneda.Nombre = "@egresos_moneda";
                ParamT14_egresos_moneda.Valor = T14_egresos_moneda.SelectedValue;
                ListParamsIn.Add(ParamT14_egresos_moneda);

                FIVEWS.CL_Diccionario ParamT14_egresos_monto = new FIVEWS.CL_Diccionario();
                ParamT14_egresos_monto.Nombre = "@egresos_monto";
                ParamT14_egresos_monto.Valor = T14_egresos_monto.Text;
                ListParamsIn.Add(ParamT14_egresos_monto);

                FIVEWS.CL_Diccionario ParamT14_propositoRC = new FIVEWS.CL_Diccionario();
                ParamT14_propositoRC.Nombre = "@propositoRC";
                ParamT14_propositoRC.Valor = T14_propositoRC.Text;
                ListParamsIn.Add(ParamT14_propositoRC);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT07_InformacionEconomicaDelCliente(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_13_InfoEconomicaDelClienteValidation.Visible = true;
                    SEC_13_InfoEconomicaDelClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_13_InfoEconomicaDelClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_13_InfoEconomicaDelClienteValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_13_InfoEconomicaDelClienteValidation.Visible = true;
                    SEC_13_InfoEconomicaDelClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_13_InfoEconomicaDelClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_13_InfoEconomicaDelClienteValidation.BackColor = System.Drawing.Color.Green;
                    SEC_13_InfoEconomicaDelClienteValidation.Visible = true;
                    btnSEC_13_InfoEconomicaDelCliente_Siguiente.Visible = true;
                    btnSEC_13_InfoEconomicaDelCliente_Guardar.Visible = true;
                }

                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario ParamA = new FIVEWS.CL_Diccionario();
                ParamA.Nombre = "@FormularioID";
                ParamA.Valor = T14_FormularioID.Text;
                ListParamsInC.Add(ParamA);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_SelectT14_InformacionEconomicaDelCliente(ListParamsInC.ToArray());
                DataTable dtC = resultadoC.Datos;
                GV_InfoEconomicaCliente.DataSource = dtC;
                GV_InfoEconomicaCliente.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_13_InfoEconomicaDelClienteValidation.Visible = true;
                    SEC_13_InfoEconomicaDelClienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_13_InfoEconomicaDelClienteValidation.ForeColor = System.Drawing.Color.White;
                    SEC_13_InfoEconomicaDelClienteValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_13_InfoEconomicaDelClienteValidation.Visible = true;
                SEC_13_InfoEconomicaDelClienteValidation.Text = "La carga de datos ha fallado: " + ex.ToString();
                SEC_13_InfoEconomicaDelClienteValidation.ForeColor = System.Drawing.Color.White;
                SEC_13_InfoEconomicaDelClienteValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 14 : Datos de los productos
        protected void insert_T15(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT15_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT15_FormularioID.Nombre = "@FormularioID";
                ParamT15_FormularioID.Valor = T15_FormularioID.Text;
                ListParamsIn.Add(ParamT15_FormularioID);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_Pais = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_Pais.Nombre = "@adquisicion_Pais";
                ParamT15_adquisicion_Pais.Valor = T15_adquisicion_Pais.SelectedValue;
                ListParamsIn.Add(ParamT15_adquisicion_Pais);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_Departamento = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_Departamento.Nombre = "@adquisicion_Departamento";
                ParamT15_adquisicion_Departamento.Valor = T15_adquisicion_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT15_adquisicion_Departamento);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_Municipio = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_Municipio.Nombre = "@adquisicion_Municipio";
                ParamT15_adquisicion_Municipio.Valor = T15_adquisicion_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT15_adquisicion_Municipio);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_fecha = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_fecha.Nombre = "@adquisicion_fecha";
                ParamT15_adquisicion_fecha.Valor = Convert.ToDateTime(T15_adquisicion_fecha.Text);
                ListParamsIn.Add(ParamT15_adquisicion_fecha);

                FIVEWS.CL_Diccionario ParamT15_tipo = new FIVEWS.CL_Diccionario();
                ParamT15_tipo.Nombre = "@tipo";
                ParamT15_tipo.Valor = T15_tipo.Text;
                ListParamsIn.Add(ParamT15_tipo);

                FIVEWS.CL_Diccionario ParamT15_nombreDescripcion = new FIVEWS.CL_Diccionario();
                ParamT15_nombreDescripcion.Nombre = "@nombreDescripcion";
                ParamT15_nombreDescripcion.Valor = T15_nombreDescripcion.Text;
                ListParamsIn.Add(ParamT15_nombreDescripcion);

                FIVEWS.CL_Diccionario ParamT15_identificador = new FIVEWS.CL_Diccionario();
                ParamT15_identificador.Nombre = "@identificador";
                ParamT15_identificador.Valor = T15_identificador.Text;
                ListParamsIn.Add(ParamT15_identificador);

                FIVEWS.CL_Diccionario ParamT15_moneda = new FIVEWS.CL_Diccionario();
                ParamT15_moneda.Nombre = "@moneda";
                ParamT15_moneda.Valor = T15_moneda.SelectedValue;
                ListParamsIn.Add(ParamT15_moneda);

                FIVEWS.CL_Diccionario ParamT15_valor = new FIVEWS.CL_Diccionario();
                ParamT15_valor.Nombre = "@valor";
                ParamT15_valor.Valor = T15_valor.Text;
                ListParamsIn.Add(ParamT15_valor);

                FIVEWS.CL_Diccionario ParamT15_empresapropiedad = new FIVEWS.CL_Diccionario();
                ParamT15_empresapropiedad.Nombre = "@nombreContrata";
                ParamT15_empresapropiedad.Valor = T15_nombreContrata.Text;
                ListParamsIn.Add(ParamT15_empresapropiedad);

                FIVEWS.CL_Diccionario ParamT15_reclamoAseguradora = new FIVEWS.CL_Diccionario();
                ParamT15_reclamoAseguradora.Nombre = "@reclamoAseguradora";
                ParamT15_reclamoAseguradora.Valor = "N";
                ListParamsIn.Add(ParamT15_reclamoAseguradora);

                FIVEWS.CL_Diccionario ParamT15_fondosPropios = new FIVEWS.CL_Diccionario();
                ParamT15_fondosPropios.Nombre = "@fondosPropios";
                ParamT15_fondosPropios.Valor = T15_fondosPropios.SelectedValue;
                ListParamsIn.Add(ParamT15_fondosPropios);

                FIVEWS.CL_Diccionario ParamT15_fondosTercero = new FIVEWS.CL_Diccionario();
                ParamT15_fondosTercero.Nombre = "@fondosTercero";
                ParamT15_fondosTercero.Valor = T15_fondosTercero.SelectedValue;
                ListParamsIn.Add(ParamT15_fondosTercero);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT08_ProductoInformacionGeneral(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_14_ProductosValidation.Visible = true;
                    SEC_14_ProductosValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_14_ProductosValidation.ForeColor = System.Drawing.Color.White;
                    SEC_14_ProductosValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_14_ProductosValidation.Visible = true;
                    SEC_14_ProductosValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_14_ProductosValidation.ForeColor = System.Drawing.Color.White;
                    SEC_14_ProductosValidation.BackColor = System.Drawing.Color.Green;
                    SEC_14_ProductosValidation.Visible = true;
                    btnSEC_14_Productos_Siguiente.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_Productos(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_Productos.DataSource = dt;
                GV_Productos.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_14_ProductosValidation.Visible = true;
                    SEC_14_ProductosValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_14_ProductosValidation.ForeColor = System.Drawing.Color.White;
                    SEC_14_ProductosValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_14_ProductosValidation.Visible = true;
                SEC_14_ProductosValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_14_ProductosValidation.ForeColor = System.Drawing.Color.White;
                SEC_14_ProductosValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        protected void insert_T17(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT17_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT17_FormularioID.Nombre = "@FormularioID";
                ParamT17_FormularioID.Valor = T17_FormularioID.Text;
                ListParamsIn.Add(ParamT17_FormularioID);

                FIVEWS.CL_Diccionario ParamT17_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT17_primerNombre.Nombre = "@primerNombre";
                ParamT17_primerNombre.Valor = T17_primerNombre.Text;
                ListParamsIn.Add(ParamT17_primerNombre);

                FIVEWS.CL_Diccionario ParamT17_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT17_segundoNombre.Nombre = "@segundoNombre";
                ParamT17_segundoNombre.Valor = T17_segundoNombre.Text;
                ListParamsIn.Add(ParamT17_segundoNombre);

                FIVEWS.CL_Diccionario ParamT17_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT17_otrosNombres.Nombre = "@otrosNombres";
                ParamT17_otrosNombres.Valor = T17_otrosNombres.Text;
                ListParamsIn.Add(ParamT17_otrosNombres);

                FIVEWS.CL_Diccionario ParamT17_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT17_primerApellido.Nombre = "@primerApellido";
                ParamT17_primerApellido.Valor = T17_primerApellido.Text;
                ListParamsIn.Add(ParamT17_primerApellido);

                FIVEWS.CL_Diccionario ParamT17_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT17_segundoApellido.Nombre = "@segundoApellido";
                ParamT17_segundoApellido.Valor = T17_segundoApellido.Text;
                ListParamsIn.Add(ParamT17_segundoApellido);

                FIVEWS.CL_Diccionario ParamT17_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT17_apellidoCasada.Nombre = "@apellidoCasada";
                ParamT17_apellidoCasada.Valor = T17_apellidoCasada.Text;
                ListParamsIn.Add(ParamT17_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT17_tipoDocumentoIdentificacion = new FIVEWS.CL_Diccionario();
                ParamT17_tipoDocumentoIdentificacion.Nombre = "@tipoDocumentoIdentificacion";
                ParamT17_tipoDocumentoIdentificacion.Valor = T17_tipoDocumentoIdentificacion.SelectedValue;
                ListParamsIn.Add(ParamT17_tipoDocumentoIdentificacion);

                FIVEWS.CL_Diccionario ParamT17_numeroDocumentoIdentificacion = new FIVEWS.CL_Diccionario();
                ParamT17_numeroDocumentoIdentificacion.Nombre = "@numeroDocumentoIdentificacion";
                ParamT17_numeroDocumentoIdentificacion.Valor = T17_numeroDocumentoIdentificacion.Text;
                ListParamsIn.Add(ParamT17_numeroDocumentoIdentificacion);

                FIVEWS.CL_Diccionario ParamT17_emisionPasaporte = new FIVEWS.CL_Diccionario();
                ParamT17_emisionPasaporte.Nombre = "@emisionPasaporte";
                ParamT17_emisionPasaporte.Valor = T17_emisionPasaporte.SelectedValue;
                ListParamsIn.Add(ParamT17_emisionPasaporte);

                FIVEWS.CL_Diccionario ParamT17_nit = new FIVEWS.CL_Diccionario();
                ParamT17_nit.Nombre = "@nit";
                ParamT17_nit.Valor = T17_nit.Text;
                ListParamsIn.Add(ParamT17_nit);

                FIVEWS.CL_Diccionario ParamT17_sexo = new FIVEWS.CL_Diccionario();
                ParamT17_sexo.Nombre = "@sexo";
                ParamT17_sexo.Valor = T17_sexo.SelectedValue;
                ListParamsIn.Add(ParamT17_sexo);

                FIVEWS.CL_Diccionario ParamT17_fechaNacimiento = new FIVEWS.CL_Diccionario();
                ParamT17_fechaNacimiento.Nombre = "@fechaNacimiento";
                ParamT17_fechaNacimiento.Valor = Convert.ToDateTime(T17_fechaNacimiento.Text);
                ListParamsIn.Add(ParamT17_fechaNacimiento);

                FIVEWS.CL_Diccionario ParamT17_direccionResidencia = new FIVEWS.CL_Diccionario();
                ParamT17_direccionResidencia.Nombre = "@direccionResidencia";
                ParamT17_direccionResidencia.Valor = T17_direccionResidencia.Text;
                ListParamsIn.Add(ParamT17_direccionResidencia);

                FIVEWS.CL_Diccionario ParamT17_direccionResidencia_Pais = new FIVEWS.CL_Diccionario();
                ParamT17_direccionResidencia_Pais.Nombre = "@direccionResidencia_Pais";
                ParamT17_direccionResidencia_Pais.Valor = T17_direccionResidencia_Pais.SelectedValue;
                ListParamsIn.Add(ParamT17_direccionResidencia_Pais);

                FIVEWS.CL_Diccionario ParamT17_direccionResidencia_Departamento = new FIVEWS.CL_Diccionario();
                ParamT17_direccionResidencia_Departamento.Nombre = "@direccionResidencia_Departamento";
                ParamT17_direccionResidencia_Departamento.Valor = T17_direccionResidencia_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT17_direccionResidencia_Departamento);

                FIVEWS.CL_Diccionario ParamT17_direccionResidencia_Municipio = new FIVEWS.CL_Diccionario();
                ParamT17_direccionResidencia_Municipio.Nombre = "@direccionResidencia_Municipio";
                ParamT17_direccionResidencia_Municipio.Valor = T17_direccionResidencia_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT17_direccionResidencia_Municipio);

                FIVEWS.CL_Diccionario ParamT17_direccionResidencia_Zona = new FIVEWS.CL_Diccionario();
                ParamT17_direccionResidencia_Zona.Nombre = "@direccionResidencia_Zona";
                ParamT17_direccionResidencia_Zona.Valor = T17_direccionResidencia_Zona.Text;
                ListParamsIn.Add(ParamT17_direccionResidencia_Zona);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT09_PersonaIndividualProveeFondos(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_16_PI_FondosTerceroValidation.Visible = true;
                    SEC_16_PI_FondosTerceroValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_16_PI_FondosTerceroValidation.ForeColor = System.Drawing.Color.White;
                    SEC_16_PI_FondosTerceroValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_16_PI_FondosTerceroValidation.Visible = true;
                    SEC_16_PI_FondosTerceroValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_16_PI_FondosTerceroValidation.ForeColor = System.Drawing.Color.White;
                    SEC_16_PI_FondosTerceroValidation.BackColor = System.Drawing.Color.Green;
                    SEC_16_PI_FondosTerceroValidation.Visible = true;
                }
            }
            catch (Exception ex)
            {
                SEC_16_PI_FondosTerceroValidation.Visible = true;
                SEC_16_PI_FondosTerceroValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_16_PI_FondosTerceroValidation.ForeColor = System.Drawing.Color.White;
                SEC_16_PI_FondosTerceroValidation.BackColor = System.Drawing.Color.Red; ;
            }
        }
        // SEC 17 : Datos PEP - PIPFT
        protected void insert_T18_PPIPF(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT18_Ref_PersonaIndividualRegID = new FIVEWS.CL_Diccionario();
                ParamT18_Ref_PersonaIndividualRegID.Nombre = "@FormularioID";
                ParamT18_Ref_PersonaIndividualRegID.Valor = T18_Ref_PersonaIndividualPEPRegID.Text;
                ListParamsIn.Add(ParamT18_Ref_PersonaIndividualRegID);

                FIVEWS.CL_Diccionario ParamT18_pep = new FIVEWS.CL_Diccionario();
                ParamT18_pep.Nombre = "@pep";
                ParamT18_pep.Valor = T18_pep.SelectedValue;
                ListParamsIn.Add(ParamT18_pep);

                FIVEWS.CL_Diccionario ParamT18_pep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_pep_entidad.Nombre = "@pep_entidad";
                ParamT18_pep_entidad.Valor = T18_pep_entidad.Text;
                ListParamsIn.Add(ParamT18_pep_entidad);

                FIVEWS.CL_Diccionario ParamT18_pep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_pep_puestoDesempenia.Nombre = "@pep_puestoDesempenia";
                ParamT18_pep_puestoDesempenia.Valor = T18_pep_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT18_pep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_pep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_pep_paisEntidad.Nombre = "@pep_paisEntidad";
                ParamT18_pep_paisEntidad.Valor = T18_pep_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT18_pep_paisEntidad);

                FIVEWS.CL_Diccionario ParamT18_pep_origenRiqueza = new FIVEWS.CL_Diccionario();
                ParamT18_pep_origenRiqueza.Nombre = "@pep_origenRiqueza";
                ParamT18_pep_origenRiqueza.Valor = T18_pep_origenRiqueza.SelectedValue;
                ListParamsIn.Add(ParamT18_pep_origenRiqueza);

                FIVEWS.CL_Diccionario ParamT18_pep_otroOrigenriqueza = new FIVEWS.CL_Diccionario();
                ParamT18_pep_otroOrigenriqueza.Nombre = "@pep_otroOrigenriqueza";
                ParamT18_pep_otroOrigenriqueza.Valor = T18_pep_otroOrigenriqueza.Text;
                ListParamsIn.Add(ParamT18_pep_otroOrigenriqueza);

                FIVEWS.CL_Diccionario ParamT18_parientePep = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep.Nombre = "@parientePep";
                ParamT18_parientePep.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep);

                FIVEWS.CL_Diccionario ParamT18_parientePep_parentesco = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_parentesco.Nombre = "@parientePep_parentesco";
                ParamT18_parientePep_parentesco.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_parentesco);

                FIVEWS.CL_Diccionario ParamT18_parientePep_otroPerntesco = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_otroPerntesco.Nombre = "@parientePep_otroPerntesco";
                ParamT18_parientePep_otroPerntesco.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_otroPerntesco);

                FIVEWS.CL_Diccionario ParamT18_parientePep_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_primerNombre.Nombre = "@parientePep_primerNombre";
                ParamT18_parientePep_primerNombre.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_primerNombre);

                FIVEWS.CL_Diccionario ParamT18_parientePep_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_segundoNombre.Nombre = "@parientePep_segundoNombre";
                ParamT18_parientePep_segundoNombre.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_segundoNombre);

                FIVEWS.CL_Diccionario ParamT18_parientePep_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_otrosNombres.Nombre = "@parientePep_otrosNombres";
                ParamT18_parientePep_otrosNombres.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_otrosNombres);

                FIVEWS.CL_Diccionario ParamT18_parientePep_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_primerApellido.Nombre = "@parientePep_primerApellido";
                ParamT18_parientePep_primerApellido.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_primerApellido);

                FIVEWS.CL_Diccionario ParamT18_parientePep_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_segundoApellido.Nombre = "@parientePep_segundoApellido";
                ParamT18_parientePep_segundoApellido.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_segundoApellido);

                FIVEWS.CL_Diccionario ParamT18_parientePep_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_apellidoCasada.Nombre = "@parientePep_apellidoCasada";
                ParamT18_parientePep_apellidoCasada.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT18_parientePep_sexo = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_sexo.Nombre = "@parientePep_sexo";
                ParamT18_parientePep_sexo.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_sexo);

                FIVEWS.CL_Diccionario ParamT18_parientePep_condicion = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_condicion.Nombre = "@parientePep_condicion";
                ParamT18_parientePep_condicion.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_condicion);

                FIVEWS.CL_Diccionario ParamT18_parientePep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_entidad.Nombre = "@parientePep_entidad";
                ParamT18_parientePep_entidad.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_entidad);

                FIVEWS.CL_Diccionario ParamT18_parientePep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_puestoDesempenia.Nombre = "@parientePep_puestoDesempenia";
                ParamT18_parientePep_puestoDesempenia.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_parientePep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_paisEntidad.Nombre = "@parientePep_paisEntidad";
                ParamT18_parientePep_paisEntidad.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_paisEntidad);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep.Nombre = "@asociadoPep";
                ParamT18_asociadoPep.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_motivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_motivoAsociacion.Nombre = "@asociadoPep_motivoAsociacion";
                ParamT18_asociadoPep_motivoAsociacion.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_motivoAsociacion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_otroMotivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_otroMotivoAsociacion.Nombre = "@asociadoPep_otroMotivoAsociacion";
                ParamT18_asociadoPep_otroMotivoAsociacion.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_otroMotivoAsociacion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_primerNombre.Nombre = "@asociadoPep_primerNombre";
                ParamT18_asociadoPep_primerNombre.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_primerNombre);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_segundoNombre.Nombre = "@asociadoPep_segundoNombre";
                ParamT18_asociadoPep_segundoNombre.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_segundoNombre);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_otrosNombres.Nombre = "@asociadoPep_otrosNombres";
                ParamT18_asociadoPep_otrosNombres.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_otrosNombres);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_primerApellido.Nombre = "@asociadoPep_primerApellido";
                ParamT18_asociadoPep_primerApellido.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_primerApellido);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_segundoApellido.Nombre = "@asociadoPep_segundoApellido";
                ParamT18_asociadoPep_segundoApellido.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_segundoApellido);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_apellidoCasada.Nombre = "@asociadoPep_apellidoCasada";
                ParamT18_asociadoPep_apellidoCasada.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_sexo = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_sexo.Nombre = "@asociadoPep_sexo";
                ParamT18_asociadoPep_sexo.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_sexo);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_condicion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_condicion.Nombre = "@asociadoPep_condicion";
                ParamT18_asociadoPep_condicion.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_condicion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_entidad.Nombre = "@asociadoPep_entidad";
                ParamT18_asociadoPep_entidad.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_entidad);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_puestoDesempenia.Nombre = "@asociadoPep_puestoDesempenia";
                ParamT18_asociadoPep_puestoDesempenia.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_paisEntidad.Nombre = "@asociadoPep_paisEntidad";
                ParamT18_asociadoPep_paisEntidad.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT18_InformacionEmpresaSolicitante(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_17_PEP_PIPFTValidation.Visible = true;
                    SEC_17_PEP_PIPFTValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_17_PEP_PIPFTValidation.ForeColor = System.Drawing.Color.White;
                    SEC_17_PEP_PIPFTValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_17_PEP_PIPFTValidation.Visible = true;
                    SEC_17_PEP_PIPFTValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_17_PEP_PIPFTValidation.ForeColor = System.Drawing.Color.White;
                    SEC_17_PEP_PIPFTValidation.BackColor = System.Drawing.Color.Green;
                    SEC_17_PEP_PIPFTValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_PIPF(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_PEP_PIPFT.DataSource = dt;
                GV_PEP_PIPFT.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_17_PEP_PIPFTValidation.Visible = true;
                    SEC_17_PEP_PIPFTValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_17_PEP_PIPFTValidation.ForeColor = System.Drawing.Color.White;
                    SEC_17_PEP_PIPFTValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_17_PEP_PIPFTValidation.Visible = true;
                SEC_17_PEP_PIPFTValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_17_PEP_PIPFTValidation.ForeColor = System.Drawing.Color.White;
                SEC_17_PEP_PIPFTValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 18 : Datos PEP - Pariente PIPFT
        protected void insert_T18_ParientePIPF(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT18_Ref_PersonaIndividualRegID = new FIVEWS.CL_Diccionario();
                ParamT18_Ref_PersonaIndividualRegID.Nombre = "@FormularioID";
                ParamT18_Ref_PersonaIndividualRegID.Valor = T18_Ref_PersonaIndividualPEPRegID.Text;
                ListParamsIn.Add(ParamT18_Ref_PersonaIndividualRegID);

                FIVEWS.CL_Diccionario ParamT18_pep = new FIVEWS.CL_Diccionario();
                ParamT18_pep.Nombre = "@pep";
                ParamT18_pep.Valor = "";
                ListParamsIn.Add(ParamT18_pep);

                FIVEWS.CL_Diccionario ParamT18_pep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_pep_entidad.Nombre = "@pep_entidad";
                ParamT18_pep_entidad.Valor = "";
                ListParamsIn.Add(ParamT18_pep_entidad);

                FIVEWS.CL_Diccionario ParamT18_pep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_pep_puestoDesempenia.Nombre = "@pep_puestoDesempenia";
                ParamT18_pep_puestoDesempenia.Valor = "";
                ListParamsIn.Add(ParamT18_pep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_pep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_pep_paisEntidad.Nombre = "@pep_paisEntidad";
                ParamT18_pep_paisEntidad.Valor = "";
                ListParamsIn.Add(ParamT18_pep_paisEntidad);

                FIVEWS.CL_Diccionario ParamT18_pep_origenRiqueza = new FIVEWS.CL_Diccionario();
                ParamT18_pep_origenRiqueza.Nombre = "@pep_origenRiqueza";
                ParamT18_pep_origenRiqueza.Valor = "";
                ListParamsIn.Add(ParamT18_pep_origenRiqueza);

                FIVEWS.CL_Diccionario ParamT18_pep_otroOrigenriqueza = new FIVEWS.CL_Diccionario();
                ParamT18_pep_otroOrigenriqueza.Nombre = "@pep_otroOrigenriqueza";
                ParamT18_pep_otroOrigenriqueza.Valor = "";
                ListParamsIn.Add(ParamT18_pep_otroOrigenriqueza);

                FIVEWS.CL_Diccionario ParamT18_parientePep = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep.Nombre = "@parientePep";
                ParamT18_parientePep.Valor = T18_parientePep.SelectedValue;
                ListParamsIn.Add(ParamT18_parientePep);

                FIVEWS.CL_Diccionario ParamT18_parientePep_parentesco = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_parentesco.Nombre = "@parientePep_parentesco";
                ParamT18_parientePep_parentesco.Valor = T18_parientePep_parentesco.SelectedValue;
                ListParamsIn.Add(ParamT18_parientePep_parentesco);

                FIVEWS.CL_Diccionario ParamT18_parientePep_otroPerntesco = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_otroPerntesco.Nombre = "@parientePep_otroPerntesco";
                ParamT18_parientePep_otroPerntesco.Valor = T18_parientePep_otroPerntesco.Text;
                ListParamsIn.Add(ParamT18_parientePep_otroPerntesco);

                FIVEWS.CL_Diccionario ParamT18_parientePep_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_primerNombre.Nombre = "@parientePep_primerNombre";
                ParamT18_parientePep_primerNombre.Valor = T18_parientePep_primerNombre.Text;
                ListParamsIn.Add(ParamT18_parientePep_primerNombre);

                FIVEWS.CL_Diccionario ParamT18_parientePep_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_segundoNombre.Nombre = "@parientePep_segundoNombre";
                ParamT18_parientePep_segundoNombre.Valor = T18_parientePep_segundoNombre.Text;
                ListParamsIn.Add(ParamT18_parientePep_segundoNombre);

                FIVEWS.CL_Diccionario ParamT18_parientePep_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_otrosNombres.Nombre = "@parientePep_otrosNombres";
                ParamT18_parientePep_otrosNombres.Valor = T18_parientePep_otrosNombres.Text;
                ListParamsIn.Add(ParamT18_parientePep_otrosNombres);

                FIVEWS.CL_Diccionario ParamT18_parientePep_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_primerApellido.Nombre = "@parientePep_primerApellido";
                ParamT18_parientePep_primerApellido.Valor = T18_parientePep_primerApellido.Text;
                ListParamsIn.Add(ParamT18_parientePep_primerApellido);

                FIVEWS.CL_Diccionario ParamT18_parientePep_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_segundoApellido.Nombre = "@parientePep_segundoApellido";
                ParamT18_parientePep_segundoApellido.Valor = T18_parientePep_segundoApellido.Text;
                ListParamsIn.Add(ParamT18_parientePep_segundoApellido);

                FIVEWS.CL_Diccionario ParamT18_parientePep_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_apellidoCasada.Nombre = "@parientePep_apellidoCasada";
                ParamT18_parientePep_apellidoCasada.Valor = T18_parientePep_apellidoCasada.Text;
                ListParamsIn.Add(ParamT18_parientePep_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT18_parientePep_sexo = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_sexo.Nombre = "@parientePep_sexo";
                ParamT18_parientePep_sexo.Valor = T18_parientePep_sexo.SelectedValue;
                ListParamsIn.Add(ParamT18_parientePep_sexo);

                FIVEWS.CL_Diccionario ParamT18_parientePep_condicion = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_condicion.Nombre = "@parientePep_condicion";
                ParamT18_parientePep_condicion.Valor = T18_parientePep_condicion.SelectedValue;
                ListParamsIn.Add(ParamT18_parientePep_condicion);

                FIVEWS.CL_Diccionario ParamT18_parientePep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_entidad.Nombre = "@parientePep_entidad";
                ParamT18_parientePep_entidad.Valor = T18_parientePep.SelectedValue;
                ListParamsIn.Add(ParamT18_parientePep_entidad);

                FIVEWS.CL_Diccionario ParamT18_parientePep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_puestoDesempenia.Nombre = "@parientePep_puestoDesempenia";
                ParamT18_parientePep_puestoDesempenia.Valor = T18_parientePep_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT18_parientePep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_parientePep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_paisEntidad.Nombre = "@parientePep_paisEntidad";
                ParamT18_parientePep_paisEntidad.Valor = T18_parientePep_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT18_parientePep_paisEntidad);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep.Nombre = "@asociadoPep";
                ParamT18_asociadoPep.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_motivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_motivoAsociacion.Nombre = "@asociadoPep_motivoAsociacion";
                ParamT18_asociadoPep_motivoAsociacion.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_motivoAsociacion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_otroMotivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_otroMotivoAsociacion.Nombre = "@asociadoPep_otroMotivoAsociacion";
                ParamT18_asociadoPep_otroMotivoAsociacion.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_otroMotivoAsociacion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_primerNombre.Nombre = "@asociadoPep_primerNombre";
                ParamT18_asociadoPep_primerNombre.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_primerNombre);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_segundoNombre.Nombre = "@asociadoPep_segundoNombre";
                ParamT18_asociadoPep_segundoNombre.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_segundoNombre);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_otrosNombres.Nombre = "@asociadoPep_otrosNombres";
                ParamT18_asociadoPep_otrosNombres.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_otrosNombres);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_primerApellido.Nombre = "@asociadoPep_primerApellido";
                ParamT18_asociadoPep_primerApellido.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_primerApellido);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_segundoApellido.Nombre = "@asociadoPep_segundoApellido";
                ParamT18_asociadoPep_segundoApellido.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_segundoApellido);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_apellidoCasada.Nombre = "@asociadoPep_apellidoCasada";
                ParamT18_asociadoPep_apellidoCasada.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_sexo = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_sexo.Nombre = "@asociadoPep_sexo";
                ParamT18_asociadoPep_sexo.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_sexo);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_condicion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_condicion.Nombre = "@asociadoPep_condicion";
                ParamT18_asociadoPep_condicion.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_condicion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_entidad.Nombre = "@asociadoPep_entidad";
                ParamT18_asociadoPep_entidad.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_entidad);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_puestoDesempenia.Nombre = "@asociadoPep_puestoDesempenia";
                ParamT18_asociadoPep_puestoDesempenia.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_paisEntidad.Nombre = "@asociadoPep_paisEntidad";
                ParamT18_asociadoPep_paisEntidad.Valor = "";
                ListParamsIn.Add(ParamT18_asociadoPep_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT18_InformacionEmpresaSolicitante(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SE_18_PEPPIPFT_ParienteValidation.Visible = true;
                    SE_18_PEPPIPFT_ParienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SE_18_PEPPIPFT_ParienteValidation.ForeColor = System.Drawing.Color.White;
                    SE_18_PEPPIPFT_ParienteValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SE_18_PEPPIPFT_ParienteValidation.Visible = true;
                    SE_18_PEPPIPFT_ParienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SE_18_PEPPIPFT_ParienteValidation.ForeColor = System.Drawing.Color.White;
                    SE_18_PEPPIPFT_ParienteValidation.BackColor = System.Drawing.Color.Green;
                    SE_18_PEPPIPFT_ParienteValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_ParientePIPF(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_PEP_ParientePIPFT.DataSource = dt;
                GV_PEP_ParientePIPFT.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SE_18_PEPPIPFT_ParienteValidation.Visible = true;
                    SE_18_PEPPIPFT_ParienteValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SE_18_PEPPIPFT_ParienteValidation.ForeColor = System.Drawing.Color.White;
                    SE_18_PEPPIPFT_ParienteValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SE_18_PEPPIPFT_ParienteValidation.Visible = true;
                SE_18_PEPPIPFT_ParienteValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SE_18_PEPPIPFT_ParienteValidation.ForeColor = System.Drawing.Color.White;
                SE_18_PEPPIPFT_ParienteValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 19 : Datos PEP - Asociado PIPFT
        protected void insert_T18_AsociadoPIPF(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT18_Ref_PersonaIndividualRegID = new FIVEWS.CL_Diccionario();
                ParamT18_Ref_PersonaIndividualRegID.Nombre = "@FormularioID";
                ParamT18_Ref_PersonaIndividualRegID.Valor = T18_Ref_PersonaIndividualPEPRegID.Text;
                ListParamsIn.Add(ParamT18_Ref_PersonaIndividualRegID);

                FIVEWS.CL_Diccionario ParamT18_pep = new FIVEWS.CL_Diccionario();
                ParamT18_pep.Nombre = "@pep";
                ParamT18_pep.Valor = "";
                ListParamsIn.Add(ParamT18_pep);

                FIVEWS.CL_Diccionario ParamT18_pep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_pep_entidad.Nombre = "@pep_entidad";
                ParamT18_pep_entidad.Valor = "";
                ListParamsIn.Add(ParamT18_pep_entidad);

                FIVEWS.CL_Diccionario ParamT18_pep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_pep_puestoDesempenia.Nombre = "@pep_puestoDesempenia";
                ParamT18_pep_puestoDesempenia.Valor = T18_pep_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT18_pep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_pep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_pep_paisEntidad.Nombre = "@pep_paisEntidad";
                ParamT18_pep_paisEntidad.Valor = "";
                ListParamsIn.Add(ParamT18_pep_paisEntidad);

                FIVEWS.CL_Diccionario ParamT18_pep_origenRiqueza = new FIVEWS.CL_Diccionario();
                ParamT18_pep_origenRiqueza.Nombre = "@pep_origenRiqueza";
                ParamT18_pep_origenRiqueza.Valor = "";
                ListParamsIn.Add(ParamT18_pep_origenRiqueza);

                FIVEWS.CL_Diccionario ParamT18_pep_otroOrigenriqueza = new FIVEWS.CL_Diccionario();
                ParamT18_pep_otroOrigenriqueza.Nombre = "@pep_otroOrigenriqueza";
                ParamT18_pep_otroOrigenriqueza.Valor = "";
                ListParamsIn.Add(ParamT18_pep_otroOrigenriqueza);

                FIVEWS.CL_Diccionario ParamT18_parientePep = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep.Nombre = "@parientePep";
                ParamT18_parientePep.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep);

                FIVEWS.CL_Diccionario ParamT18_parientePep_parentesco = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_parentesco.Nombre = "@parientePep_parentesco";
                ParamT18_parientePep_parentesco.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_parentesco);

                FIVEWS.CL_Diccionario ParamT18_parientePep_otroPerntesco = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_otroPerntesco.Nombre = "@parientePep_otroPerntesco";
                ParamT18_parientePep_otroPerntesco.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_otroPerntesco);

                FIVEWS.CL_Diccionario ParamT18_parientePep_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_primerNombre.Nombre = "@parientePep_primerNombre";
                ParamT18_parientePep_primerNombre.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_primerNombre);

                FIVEWS.CL_Diccionario ParamT18_parientePep_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_segundoNombre.Nombre = "@parientePep_segundoNombre";
                ParamT18_parientePep_segundoNombre.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_segundoNombre);

                FIVEWS.CL_Diccionario ParamT18_parientePep_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_otrosNombres.Nombre = "@parientePep_otrosNombres";
                ParamT18_parientePep_otrosNombres.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_otrosNombres);

                FIVEWS.CL_Diccionario ParamT18_parientePep_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_primerApellido.Nombre = "@parientePep_primerApellido";
                ParamT18_parientePep_primerApellido.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_primerApellido);

                FIVEWS.CL_Diccionario ParamT18_parientePep_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_segundoApellido.Nombre = "@parientePep_segundoApellido";
                ParamT18_parientePep_segundoApellido.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_segundoApellido);

                FIVEWS.CL_Diccionario ParamT18_parientePep_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_apellidoCasada.Nombre = "@parientePep_apellidoCasada";
                ParamT18_parientePep_apellidoCasada.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT18_parientePep_sexo = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_sexo.Nombre = "@parientePep_sexo";
                ParamT18_parientePep_sexo.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_sexo);

                FIVEWS.CL_Diccionario ParamT18_parientePep_condicion = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_condicion.Nombre = "@parientePep_condicion";
                ParamT18_parientePep_condicion.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_condicion);

                FIVEWS.CL_Diccionario ParamT18_parientePep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_entidad.Nombre = "@parientePep_entidad";
                ParamT18_parientePep_entidad.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_entidad);

                FIVEWS.CL_Diccionario ParamT18_parientePep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_puestoDesempenia.Nombre = "@parientePep_puestoDesempenia";
                ParamT18_parientePep_puestoDesempenia.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_parientePep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_parientePep_paisEntidad.Nombre = "@parientePep_paisEntidad";
                ParamT18_parientePep_paisEntidad.Valor = "";
                ListParamsIn.Add(ParamT18_parientePep_paisEntidad);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep.Nombre = "@asociadoPep";
                ParamT18_asociadoPep.Valor = T18_asociadoPep.SelectedValue;
                ListParamsIn.Add(ParamT18_asociadoPep);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_motivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_motivoAsociacion.Nombre = "@asociadoPep_motivoAsociacion";
                ParamT18_asociadoPep_motivoAsociacion.Valor = T18_asociadoPep_motivoAsociacion.SelectedValue;
                ListParamsIn.Add(ParamT18_asociadoPep_motivoAsociacion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_otroMotivoAsociacion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_otroMotivoAsociacion.Nombre = "@asociadoPep_otroMotivoAsociacion";
                ParamT18_asociadoPep_otroMotivoAsociacion.Valor = T18_asociadoPep_otroMotivoAsociacion.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_otroMotivoAsociacion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_primerNombre = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_primerNombre.Nombre = "@asociadoPep_primerNombre";
                ParamT18_asociadoPep_primerNombre.Valor = T18_asociadoPep_primerNombre.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_primerNombre);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_segundoNombre = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_segundoNombre.Nombre = "@asociadoPep_segundoNombre";
                ParamT18_asociadoPep_segundoNombre.Valor = T18_asociadoPep_segundoNombre.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_segundoNombre);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_otrosNombres = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_otrosNombres.Nombre = "@asociadoPep_otrosNombres";
                ParamT18_asociadoPep_otrosNombres.Valor = T18_asociadoPep_otrosNombres.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_otrosNombres);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_primerApellido = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_primerApellido.Nombre = "@asociadoPep_primerApellido";
                ParamT18_asociadoPep_primerApellido.Valor = T18_asociadoPep_primerApellido.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_primerApellido);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_segundoApellido = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_segundoApellido.Nombre = "@asociadoPep_segundoApellido";
                ParamT18_asociadoPep_segundoApellido.Valor = T18_asociadoPep_segundoApellido.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_segundoApellido);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_apellidoCasada = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_apellidoCasada.Nombre = "@asociadoPep_apellidoCasada";
                ParamT18_asociadoPep_apellidoCasada.Valor = T18_asociadoPep_apellidoCasada.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_apellidoCasada);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_sexo = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_sexo.Nombre = "@asociadoPep_sexo";
                ParamT18_asociadoPep_sexo.Valor = T18_asociadoPep_sexo.SelectedValue;
                ListParamsIn.Add(ParamT18_asociadoPep_sexo);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_condicion = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_condicion.Nombre = "@asociadoPep_condicion";
                ParamT18_asociadoPep_condicion.Valor = T18_asociadoPep_condicion.SelectedValue;
                ListParamsIn.Add(ParamT18_asociadoPep_condicion);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_entidad = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_entidad.Nombre = "@asociadoPep_entidad";
                ParamT18_asociadoPep_entidad.Valor = T18_asociadoPep_entidad.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_entidad);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_puestoDesempenia = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_puestoDesempenia.Nombre = "@asociadoPep_puestoDesempenia";
                ParamT18_asociadoPep_puestoDesempenia.Valor = T18_asociadoPep_puestoDesempenia.Text;
                ListParamsIn.Add(ParamT18_asociadoPep_puestoDesempenia);

                FIVEWS.CL_Diccionario ParamT18_asociadoPep_paisEntidad = new FIVEWS.CL_Diccionario();
                ParamT18_asociadoPep_paisEntidad.Nombre = "@asociadoPep_paisEntidad";
                ParamT18_asociadoPep_paisEntidad.Valor = T18_asociadoPep_paisEntidad.SelectedValue;
                ListParamsIn.Add(ParamT18_asociadoPep_paisEntidad);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT18_InformacionEmpresaSolicitante(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_19_PEPPIPFT_AsociadoValidation.Visible = true;
                    SEC_19_PEPPIPFT_AsociadoValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_19_PEPPIPFT_AsociadoValidation.ForeColor = System.Drawing.Color.White;
                    SEC_19_PEPPIPFT_AsociadoValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_19_PEPPIPFT_AsociadoValidation.Visible = true;
                    SEC_19_PEPPIPFT_AsociadoValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_19_PEPPIPFT_AsociadoValidation.ForeColor = System.Drawing.Color.White;
                    SEC_19_PEPPIPFT_AsociadoValidation.BackColor = System.Drawing.Color.Green;
                    SEC_19_PEPPIPFT_AsociadoValidation.Visible = true;
                }
                FIVEWebService wsC = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsInC = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();
                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsInC.Add(Param);
                FIVEWS.CL_Resultado resultadoC = wsC.FEICPI_WS_PEP_AsociadoPIPF(ListParamsInC.ToArray());
                DataTable dt = resultadoC.Datos;
                GV_PEP_AsociadoPIPFT.DataSource = dt;
                GV_PEP_AsociadoPIPFT.DataBind();
                int tipoMensaje = resultadoC.Mensaje.MensajeTipo;
                if (resultadoC.Mensaje.MensajeTipo == 0)
                {
                    SEC_19_PEPPIPFT_AsociadoValidation.Visible = true;
                    SEC_19_PEPPIPFT_AsociadoValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_19_PEPPIPFT_AsociadoValidation.ForeColor = System.Drawing.Color.White;
                    SEC_19_PEPPIPFT_AsociadoValidation.BackColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_19_PEPPIPFT_AsociadoValidation.Visible = true;
                SEC_19_PEPPIPFT_AsociadoValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_19_PEPPIPFT_AsociadoValidation.ForeColor = System.Drawing.Color.White;
                SEC_19_PEPPIPFT_AsociadoValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 20 : Datos persona jurídica que provee fondos como tercero
        protected void insert_T19(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT19_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT19_FormularioID.Nombre = "@FormularioID";
                ParamT19_FormularioID.Valor = T19_FormularioID.Text;
                ListParamsIn.Add(ParamT19_FormularioID);

                FIVEWS.CL_Diccionario ParamT19_nombreRazonSocial = new FIVEWS.CL_Diccionario();
                ParamT19_nombreRazonSocial.Nombre = "@nombreRazonSocial";
                ParamT19_nombreRazonSocial.Valor = T19_nombreRazonSocial.Text;
                ListParamsIn.Add(ParamT19_nombreRazonSocial);

                FIVEWS.CL_Diccionario ParamT19_nombreComercial = new FIVEWS.CL_Diccionario();
                ParamT19_nombreComercial.Nombre = "@nombreComercial";
                ParamT19_nombreComercial.Valor = T19_nombreComercial.Text;
                ListParamsIn.Add(ParamT19_nombreComercial);

                FIVEWS.CL_Diccionario ParamT19_paisJurisdiccionConstitucion = new FIVEWS.CL_Diccionario();
                ParamT19_paisJurisdiccionConstitucion.Nombre = "@paisJurisdiccionConstitucion";
                ParamT19_paisJurisdiccionConstitucion.Valor = T19_paisJurisdiccionConstitucion.SelectedValue;
                ListParamsIn.Add(ParamT19_paisJurisdiccionConstitucion);

                FIVEWS.CL_Diccionario ParamT19_nit = new FIVEWS.CL_Diccionario();
                ParamT19_nit.Nombre = "@nit";
                ParamT19_nit.Valor = T19_nit.Text;
                ListParamsIn.Add(ParamT19_nit);

                FIVEWS.CL_Diccionario ParamT19_direccion = new FIVEWS.CL_Diccionario();
                ParamT19_direccion.Nombre = "@direccion";
                ParamT19_direccion.Valor = T19_direccion.Text;
                ListParamsIn.Add(ParamT19_direccion);

                FIVEWS.CL_Diccionario ParamT19_direccion_Pais = new FIVEWS.CL_Diccionario();
                ParamT19_direccion_Pais.Nombre = "@direccion_Pais";
                ParamT19_direccion_Pais.Valor = T19_direccion_Pais.SelectedValue;
                ListParamsIn.Add(ParamT19_direccion_Pais);

                FIVEWS.CL_Diccionario ParamT19_direccion_Departamento = new FIVEWS.CL_Diccionario();
                ParamT19_direccion_Departamento.Nombre = "@direccion_Departamento";
                ParamT19_direccion_Departamento.Valor = T19_direccion_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT19_direccion_Departamento);

                FIVEWS.CL_Diccionario ParamT19_direccion_Municipio = new FIVEWS.CL_Diccionario();
                ParamT19_direccion_Municipio.Nombre = "@direccion_Municipio";
                ParamT19_direccion_Municipio.Valor = T19_direccion_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT19_direccion_Municipio);

                FIVEWS.CL_Diccionario ParamT19_direccion_Zona = new FIVEWS.CL_Diccionario();
                ParamT19_direccion_Zona.Nombre = "@direccion_Zona";
                ParamT19_direccion_Zona.Valor = T19_direccion_Zona.Text;
                ListParamsIn.Add(ParamT19_direccion_Zona);

                FIVEWS.CL_Diccionario ParamT19_numeroPatente = new FIVEWS.CL_Diccionario();
                ParamT19_numeroPatente.Nombre = "@numeroPatente";
                ParamT19_numeroPatente.Valor = T19_numeroPatente.Text;
                ListParamsIn.Add(ParamT19_numeroPatente);

                FIVEWS.CL_Diccionario ParamT19_folioPatente = new FIVEWS.CL_Diccionario();
                ParamT19_folioPatente.Nombre = "@folioPatente";
                ParamT19_folioPatente.Valor = T19_folioPatente.Text;
                ListParamsIn.Add(ParamT19_folioPatente);

                FIVEWS.CL_Diccionario ParamT19_libroPatente = new FIVEWS.CL_Diccionario();
                ParamT19_libroPatente.Nombre = "@libroPatente";
                ParamT19_libroPatente.Valor = T19_libroPatente.Text;
                ListParamsIn.Add(ParamT19_libroPatente);



                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_InsertT13_PersonaJuridicaProveeFondos(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_20_PJ_FondosTerceroValidation.Visible = true;
                    SEC_20_PJ_FondosTerceroValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_20_PJ_FondosTerceroValidation.ForeColor = System.Drawing.Color.White;
                    SEC_20_PJ_FondosTerceroValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_20_PJ_FondosTerceroValidation.Visible = true;
                    SEC_20_PJ_FondosTerceroValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_20_PJ_FondosTerceroValidation.ForeColor = System.Drawing.Color.White;
                    SEC_20_PJ_FondosTerceroValidation.BackColor = System.Drawing.Color.Green;
                    SEC_20_PJ_FondosTerceroValidation.Visible = true;
                }

            }
            catch (Exception ex)
            {
                SEC_20_PJ_FondosTerceroValidation.Visible = true;
                SEC_20_PJ_FondosTerceroValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_20_PJ_FondosTerceroValidation.ForeColor = System.Drawing.Color.White;
                SEC_20_PJ_FondosTerceroValidation.BackColor = System.Drawing.Color.Red;
            }
        }
        // SEC 21 : Datos de pago
        protected void insert_T20(object sender, EventArgs e)
        {
            try
            {
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                //  Definicion de la lista de parametros
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Agregar elementos a la lista de parametros
                FIVEWS.CL_Diccionario ParamT19_FormularioID = new FIVEWS.CL_Diccionario();
                ParamT19_FormularioID.Nombre = "@FormularioID";
                ParamT19_FormularioID.Valor = T19_FormularioID.Text;
                ListParamsIn.Add(ParamT19_FormularioID);

                FIVEWS.CL_Diccionario ParamT19_P1 = new FIVEWS.CL_Diccionario();
                ParamT19_P1.Nombre = "@T20_MP_Contado";
                ParamT19_P1.Valor = checkboxlist1.Items[0].Selected;
                ListParamsIn.Add(ParamT19_P1);
                FIVEWS.CL_Diccionario ParamT19_P2 = new FIVEWS.CL_Diccionario();
                ParamT19_P2.Nombre = "@T20_MP_CreditoInterno";
                ParamT19_P2.Valor = checkboxlist1.Items[1].Selected;
                ListParamsIn.Add(ParamT19_P2);
                FIVEWS.CL_Diccionario ParamT19_P3 = new FIVEWS.CL_Diccionario();
                ParamT19_P3.Nombre = "@T20_MP_CreditoExterno";
                ParamT19_P3.Valor = checkboxlist1.Items[2].Selected;
                ListParamsIn.Add(ParamT19_P3);

                FIVEWS.CL_Diccionario ParamT19_P4 = new FIVEWS.CL_Diccionario();
                ParamT19_P4.Nombre = "@T20_DEP_CajaPropia";
                ParamT19_P4.Valor = checkboxlist2.Items[0].Selected;
                ListParamsIn.Add(ParamT19_P4);
                FIVEWS.CL_Diccionario ParamT19_P5 = new FIVEWS.CL_Diccionario();
                ParamT19_P5.Nombre = "@T20_DEP_EntidadBancaria";
                ParamT19_P5.Valor = checkboxlist2.Items[1].Selected;
                ListParamsIn.Add(ParamT19_P5);
                FIVEWS.CL_Diccionario ParamT19_P6 = new FIVEWS.CL_Diccionario();
                ParamT19_P6.Nombre = "@T20_DEP_CajaRural";
                ParamT19_P6.Valor = checkboxlist2.Items[2].Selected;
                ListParamsIn.Add(ParamT19_P6);
                FIVEWS.CL_Diccionario ParamT19_P7 = new FIVEWS.CL_Diccionario();
                ParamT19_P7.Nombre = "@T20_DEP_CajaPropiaYEntidadBancaria";
                ParamT19_P7.Valor = checkboxlist2.Items[3].Selected;
                ListParamsIn.Add(ParamT19_P7);
                FIVEWS.CL_Diccionario ParamT19_P8 = new FIVEWS.CL_Diccionario();
                ParamT19_P8.Nombre = "@T20_DEP_CajaRuralYBanco";
                ParamT19_P8.Valor = checkboxlist2.Items[4].Selected;
                ListParamsIn.Add(ParamT19_P8);
                FIVEWS.CL_Diccionario ParamT19_P9 = new FIVEWS.CL_Diccionario();
                ParamT19_P9.Nombre = "@T20_DEP_CajaPropiaYRural";
                ParamT19_P9.Valor = checkboxlist2.Items[5].Selected;
                ListParamsIn.Add(ParamT19_P9);

                FIVEWS.CL_Diccionario ParamT19_P10 = new FIVEWS.CL_Diccionario();
                ParamT19_P10.Nombre = "@T20_MP_Efectivo";
                ParamT19_P10.Valor = checkboxlist3.Items[0].Selected;
                ListParamsIn.Add(ParamT19_P10);
                FIVEWS.CL_Diccionario ParamT19_P11 = new FIVEWS.CL_Diccionario();
                ParamT19_P11.Nombre = "@T20_MP_Cheque";
                ParamT19_P11.Valor = checkboxlist3.Items[1].Selected;
                ListParamsIn.Add(ParamT19_P11);
                FIVEWS.CL_Diccionario ParamT19_P12 = new FIVEWS.CL_Diccionario();
                ParamT19_P12.Nombre = "@T20_MP_Trensferencia";
                ParamT19_P12.Valor = checkboxlist3.Items[2].Selected;
                ListParamsIn.Add(ParamT19_P12);
                FIVEWS.CL_Diccionario ParamT19_P13 = new FIVEWS.CL_Diccionario();
                ParamT19_P13.Nombre = "@T20_MP_Tarjeta";
                ParamT19_P13.Valor = checkboxlist3.Items[3].Selected;
                ListParamsIn.Add(ParamT19_P13);
                FIVEWS.CL_Diccionario ParamT19_P14 = new FIVEWS.CL_Diccionario();
                ParamT19_P14.Nombre = "@T20_MP_Otro";
                ParamT19_P14.Valor = checkboxlist3.Items[4].Selected;
                ListParamsIn.Add(ParamT19_P14);

                FIVEWS.CL_Diccionario ParamT19_P15 = new FIVEWS.CL_Diccionario();
                ParamT19_P15.Nombre = "@T20_MP_DetalleOtro";
                ParamT19_P15.Valor = TextBox1.Text;
                ListParamsIn.Add(ParamT19_P15);

                //  Definicion del objeto resulado del ws
                FIVEWS.CL_Resultado resultado = new FIVEWS.CL_Resultado();
                //  Ejecución del ws y asignación del resultado.
                resultado = ws.FEICPI_Insert_T14_DatosDePago(ListParamsIn.ToArray());
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_21_PagoValidation.Visible = true;
                    SEC_21_PagoValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_PagoValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_PagoValidation.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    SEC_21_PagoValidation.Visible = true;
                    SEC_21_PagoValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_21_PagoValidation.ForeColor = System.Drawing.Color.White;
                    SEC_21_PagoValidation.BackColor = System.Drawing.Color.Green;
                    SEC_21_PagoValidation.Visible = true;
                }
            }
            catch (Exception ex)
            {
                SEC_21_PagoValidation.Visible = true;
                SEC_21_PagoValidation.Text = "La carga de peps ha fallado, contacte a informatica" + ex.ToString();
                SEC_21_PagoValidation.ForeColor = System.Drawing.Color.White;
                SEC_21_PagoValidation.BackColor = System.Drawing.Color.Red;
            }
        }

        protected void btnCargarProductosSAP(object sender, EventArgs e)
        {
            try
            {
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                FIVEWS.CL_Diccionario Param = new FIVEWS.CL_Diccionario();

                Param.Nombre = "@OV";
                Param.Valor = T1_ordenDeVenta.Text;
                ListParamsIn.Add(Param);

                Param.Nombre = "@FormularioID";
                Param.Valor = T8_FormularioID.Text;
                ListParamsIn.Add(Param);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_Pais = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_Pais.Nombre = "@adquisicion_Pais";
                ParamT15_adquisicion_Pais.Valor = T15_adquisicion_Pais.SelectedValue;
                ListParamsIn.Add(ParamT15_adquisicion_Pais);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_Departamento = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_Departamento.Nombre = "@adquisicion_Departamento";
                ParamT15_adquisicion_Departamento.Valor = T15_adquisicion_Departamento.SelectedValue;
                ListParamsIn.Add(ParamT15_adquisicion_Departamento);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_Municipio = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_Municipio.Nombre = "@adquisicion_Municipio";
                ParamT15_adquisicion_Municipio.Valor = T15_adquisicion_Municipio.SelectedValue;
                ListParamsIn.Add(ParamT15_adquisicion_Municipio);

                FIVEWS.CL_Diccionario ParamT15_adquisicion_fecha = new FIVEWS.CL_Diccionario();
                ParamT15_adquisicion_fecha.Nombre = "@adquisicion_fecha";
                ParamT15_adquisicion_fecha.Valor = Convert.ToDateTime(T15_adquisicion_fecha.Text);
                ListParamsIn.Add(ParamT15_adquisicion_fecha);

                FIVEWS.CL_Diccionario ParamT15_empresapropiedad = new FIVEWS.CL_Diccionario();
                ParamT15_empresapropiedad.Nombre = "@nombreContrata";
                ParamT15_empresapropiedad.Valor = T15_nombreContrata.Text;
                ListParamsIn.Add(ParamT15_empresapropiedad);

                FIVEWS.CL_Diccionario ParamT15_reclamoAseguradora = new FIVEWS.CL_Diccionario();
                ParamT15_reclamoAseguradora.Nombre = "@reclamoAseguradora";
                ParamT15_reclamoAseguradora.Valor = "N";
                ListParamsIn.Add(ParamT15_reclamoAseguradora);

                FIVEWS.CL_Diccionario ParamT15_fondosPropios = new FIVEWS.CL_Diccionario();
                ParamT15_fondosPropios.Nombre = "@fondosPropios";
                ParamT15_fondosPropios.Valor = T15_fondosPropios.SelectedValue;
                ListParamsIn.Add(ParamT15_fondosPropios);

                FIVEWS.CL_Diccionario ParamT15_fondosTercero = new FIVEWS.CL_Diccionario();
                ParamT15_fondosTercero.Nombre = "@fondosTercero";
                ParamT15_fondosTercero.Valor = T15_fondosTercero.SelectedValue;
                ListParamsIn.Add(ParamT15_fondosTercero);

                FIVEWS.CL_Resultado resultado = ws.FEICPI_WS_CargarProductoSAP(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                GV_Productos.DataSource = dt;
                GV_Productos.DataBind();
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                if (resultado.Mensaje.MensajeTipo == 0)
                {
                    SEC_14_ProductosValidation.Visible = true;
                    SEC_14_ProductosValidation.Text = resultado.Mensaje.MensajeDescripcion;
                    SEC_14_ProductosValidation.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SEC_14_ProductosValidation.Visible = true;
                SEC_14_ProductosValidation.Text = "La carga de telefonos ha fallado, contacte a informatica" + ex.ToString();
                SEC_14_ProductosValidation.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void T1_tipoActuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T1_tipoActuacion.SelectedValue == "R")
            {
                T1_calidadActua.ReadOnly = false;
            }
            else
            {
                T1_calidadActua.ReadOnly = true;
            }
        }

        protected void T17_direccionResidencia_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                T17_direccionResidencia_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T17_direccionResidencia_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T17_direccionResidencia_Municipio.DataValueField = "MunicipioID";
                T17_direccionResidencia_Municipio.DataTextField = "Descripcion";
                T17_direccionResidencia_Municipio.DataSource = dt;
                T17_direccionResidencia_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_16_PI_FondosTerceroValidation.Visible = true;
                    SEC_16_PI_FondosTerceroValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void T17_direccionResidencia_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T17_direccionResidencia_Pais.SelectedValue == "GT")
            {
                T17_direccionResidencia_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T17_direccionResidencia_Departamento.DataValueField = "DepartamentoID";
                    T17_direccionResidencia_Departamento.DataTextField = "Descripcion";
                    T17_direccionResidencia_Departamento.DataSource = dt;
                    T17_direccionResidencia_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_16_PI_FondosTerceroValidation.Visible = true;
                        SEC_16_PI_FondosTerceroValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T17_direccionResidencia_Departamento.Enabled = false;
                    T17_direccionResidencia_Municipio.Enabled = false;
                }
            }
            else
            {

            }
        }

        protected void T16_direccionnacimiento_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T16_direccionnacimiento_Pais.SelectedValue == "GT")
            {
                T16_direccionnacimiento_Departamento.Enabled = true;
                T16_condicionMigratoria.Enabled = false;
                T16_condicionMigratoria.SelectedValue = "0";
                T16_tipoDocumentoIdentificiacion.Enabled = false;
                T16_tipoDocumentoIdentificiacion.SelectedValue = "D";
                T16_emisionPasaporte.Enabled = false;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T16_direccionnacimiento_Departamento.DataValueField = "DepartamentoID";
                    T16_direccionnacimiento_Departamento.DataTextField = "Descripcion";
                    T16_direccionnacimiento_Departamento.DataSource = dt;
                    T16_direccionnacimiento_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                        SEC_16_DatosDelRepresentanteLegalValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T16_direccionnacimiento_Departamento.Enabled = false;
                    T16_direccionnacimiento_Municipio.Enabled = false;
                }
            }
            else
            {
                T16_condicionMigratoria.Enabled = true;
                T16_direccionnacimiento_Departamento.Enabled = false;
                T16_direccionnacimiento_Departamento.SelectedValue = "0";
                T16_direccionnacimiento_Municipio.Enabled = false;
                T16_direccionnacimiento_Municipio.SelectedValue = "0";
                T16_tipoDocumentoIdentificiacion.Enabled = false;
                T16_tipoDocumentoIdentificiacion.SelectedValue = "P";
                T16_emisionPasaporte.Enabled = true;
            }
        }

        protected void T16_direccionnacimiento_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                T16_direccionnacimiento_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T16_direccionnacimiento_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T16_direccionnacimiento_Municipio.DataValueField = "MunicipioID";
                T16_direccionnacimiento_Municipio.DataTextField = "Descripcion";
                T16_direccionnacimiento_Municipio.DataSource = dt;
                T16_direccionnacimiento_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_16_DatosDelRepresentanteLegalValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void T16_direccionResidencia_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T16_direccionResidencia_Pais.SelectedValue == "GT")
            {
                T16_direccionResidencia_Departamento.Enabled = true;
                try
                {
                    //  Definicion del WebService
                    FIVEWebService ws = new FIVEWebService();
                    List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                    //  Definición de la lista de parametros utilizados por el SP
                    FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                    // Agregar Paramtetros al listado de parámetros
                    Parametros.Nombre = "@Usuario";
                    Parametros.Valor = Session["USR_Usuario"].ToString();
                    ListParamsIn.Add(Parametros);
                    // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                    FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_10_Departamentos(ListParamsIn.ToArray());
                    DataTable dt = resultado.Datos;
                    string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                    int tipoMensaje = resultado.Mensaje.MensajeTipo;
                    //  Cergar información resultante a los elementos correspondientes
                    T16_direccionResidencia_Departamento.DataValueField = "DepartamentoID";
                    T16_direccionResidencia_Departamento.DataTextField = "Descripcion";
                    T16_direccionResidencia_Departamento.DataSource = dt;
                    T16_direccionResidencia_Departamento.DataBind();
                    //  Cargar error si es necesario
                    if (tipoMensaje == 0)
                    {
                        SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                        SEC_16_DatosDelRepresentanteLegalValidation.Text = "Error al cargar el listado de departamentos";
                    }
                }
                catch (Exception ex)
                {
                    T16_direccionResidencia_Departamento.Enabled = false;
                    T16_direccionResidencia_Municipio.Enabled = false;
                }
            }
            else
            {
                T16_direccionResidencia_Departamento.Enabled = false;
                T16_direccionResidencia_Departamento.SelectedValue = "0";
                T16_direccionResidencia_Municipio.Enabled = false;
                T16_direccionResidencia_Municipio.SelectedValue = "0";
            }
        }

        protected void T16_direccionResidencia_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                T16_direccionResidencia_Municipio.Enabled = true;
                //  Definicion del WebService
                FIVEWebService ws = new FIVEWebService();
                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();
                //  Definición de la lista de parametros utilizados por el SP
                FIVEWS.CL_Diccionario Parametros = new FIVEWS.CL_Diccionario();
                // Agregar Paramtetros al listado de parámetros
                Parametros.Nombre = "@DepartamentoID";
                Parametros.Valor = Convert.ToInt32(T16_direccionResidencia_Departamento.SelectedIndex);
                ListParamsIn.Add(Parametros);
                // FIVEWS.CL_Diccionario listaParmas = ListParamsIn;
                FIVEWS.CL_Resultado resultado = ws.FEICPJ_WS_CAT_11_Municipios(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                string mensajeDescripcion = resultado.Mensaje.MensajeDescripcion;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;
                //  Cergar información resultante a los elementos correspondientes
                T16_direccionResidencia_Municipio.DataValueField = "MunicipioID";
                T16_direccionResidencia_Municipio.DataTextField = "Descripcion";
                T16_direccionResidencia_Municipio.DataSource = dt;
                T16_direccionResidencia_Municipio.DataBind();
                //  Cargar error si es necesario
                if (tipoMensaje == 0)
                {
                    SEC_16_DatosDelRepresentanteLegalValidation.Visible = true;
                    SEC_16_DatosDelRepresentanteLegalValidation.Text = mensajeDescripcion + "Error al cargar los municipios del departamento seleccionado";
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void T16_condicionMigratoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T16_condicionMigratoria.SelectedValue == "9")
            {
                T16_otraCondicionMigratoria.Enabled = true;
            }
            else
            {
                T16_otraCondicionMigratoria.Enabled = false;
            }
        }

        protected void T17_pep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T17_pep.SelectedValue == "S")
            {
                SEC_17_PEP_Cliente_Info.Visible = true;
            }
            else
            {
                SEC_17_PEP_Cliente_Info.Visible = false;
            }
        }

        protected void T19_parientePep_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (T19_parientePep.SelectedValue == "S")
            {
                SEC_19_PEP_ParienteRLC_Info.Visible = true;
            }
            else
            {
                SEC_19_PEP_ParienteRLC_Info.Visible = false;
            }
        }

        protected void T20_asociadoPep_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (T20_asociadoPep.SelectedValue == "S")
        {
            SEC_20_AsociadoRLC_Info.Visible = true;
        }
        else
        {
            SEC_20_AsociadoRLC_Info.Visible = false;
        }
    }

        protected void T14_TipoActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(T14_TipoActividad.SelectedValue == "NP")
            {
                T14_nombreComercial.Enabled = true;
                T14_nombreEmpleador.Enabled = false;
                T14_ingresos_tipoIngreso.Enabled = false;
                T14_ingresos_otroTipoIngreso.Enabled = false;
            }
            if (T14_TipoActividad.SelectedValue == "NE")
            {
                T14_nombreComercial.Enabled = false;
                T14_nombreEmpleador.Enabled = true;
                T14_ingresos_tipoIngreso.Enabled = false;
                T14_ingresos_otroTipoIngreso.Enabled = false;
            }
            if (T14_TipoActividad.SelectedValue == "OT")
            {
                T14_nombreComercial.Enabled = false;
                T14_nombreEmpleador.Enabled = false;
                T14_ingresos_tipoIngreso.Enabled = true;
                T14_ingresos_otroTipoIngreso.Enabled = true;
            }
            if (T14_TipoActividad.SelectedValue == "NA")
            {
                T14_nombreComercial.Enabled = false;
                T14_nombreEmpleador.Enabled = false;
                T14_ingresos_tipoIngreso.Enabled = false;
                T14_ingresos_otroTipoIngreso.Enabled = false;
            }
            T14_actividadEconomicaRTU.Text = "";
            T14_nombreComercial.Text = "";
            T14_nombreEmpleador.Text = "";
            T14_ingresos_otroTipoIngreso.Text = "";
            T14_ingresos_monto.Text = "";
            T14_egresos_monto.Text = "";
            T14_ingresos_tipoIngreso.SelectedValue = "0";
            T14_ingresos_moneda.SelectedValue = "NE";
            T14_egresos_moneda.SelectedValue = "NE";
        }

        protected void T8_nit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FIVEWebService ws = new FIVEWebService();

                List<FIVEWS.CL_Diccionario> ListParamsIn = new List<FIVEWS.CL_Diccionario>();

                FIVEWS.CL_Diccionario Param1 = new FIVEWS.CL_Diccionario();
                Param1.Nombre = "@NIT";
                Param1.Valor = T8_nit.Text;
                ListParamsIn.Add(Param1);

                FIVEWS.CL_Diccionario Param2 = new FIVEWS.CL_Diccionario();
                Param2.Nombre = "@Empresa";
                Param2.Valor = Convert.ToInt32(T1_empresa.SelectedValue);
                ListParamsIn.Add(Param2);

                FIVEWS.CL_Diccionario Param3 = new FIVEWS.CL_Diccionario();
                Param3.Nombre = "@Usuario";
                Param3.Valor = Session["USR_Usuario"].ToString();
                ListParamsIn.Add(Param3);

                FIVEWS.CL_Resultado resultado = ws.FIVE_SelectDetalleCliente(ListParamsIn.ToArray());
                DataTable dt = resultado.Datos;
                int tipoMensaje = resultado.Mensaje.MensajeTipo;

                DataRow row;
                if (dt.Rows.Count > 0)
                {
                    row = dt.Rows[0];
                    //txtCodCliente.Text = row[0].ToString();
                    T14_nombreComercial.Text = row[2].ToString();
                    //txtNombreComercialIEC.Text = row[2].ToString();
                    T8_direccionResidencia.Text = row[3].ToString();
                    T9_Telefono.Text = row[4].ToString();
                    T8_email.Text = row[5].ToString();
                    T8_primerNombre.Text = row[6].ToString();
                    T8_segundoNombre.Text = row[7].ToString();
                    T8_primerApellido.Text = row[8].ToString();
                    T8_segundoApellido.Text = row[9].ToString();
                    T8_apellidoCasada.Text = row[10].ToString();
                    T8_fechaNacimiento.Text = row[11].ToString();
                    T8_numeroDocumentoIdentificacion.Text = row[14].ToString();
                    if (row[15].ToString() == "89")
                    {
                        T8_nacionalidad1.SelectedValue = "GT";
                    }
                    //T8_nacionalidad2.SelectedValue = row[15].ToString();
                    //T8_tipoDocumentoIdentificiacion.SelectedValue = row[13].ToString();
                    T8_sexo.SelectedValue = row[16].ToString();
                    T8_estadoCivil.SelectedValue = row[17].ToString();
                    if (row[13].ToString() == "1")
                    {
                        T8_tipoDocumentoIdentificiacion.SelectedValue = "D";
                        T8_emisionPasaporte.Enabled = false;
                    }
                    else
                    {
                        T8_tipoDocumentoIdentificiacion.SelectedValue = "P";
                        T8_emisionPasaporte.Enabled = true;
                    }

                    //if (DDLTipoIdentificacion.SelectedValue == "2")
                    //{
                    //    txtCUI.Text = "0";
                    //    txtCUI.Enabled = false;
                    //}

                    ////Cargar a pais generado por Gerson 
                    //llenarComboPais_Direccion();
                    //llenarComboDepartamentoID_Direccion();

                    //DateTime gg = DateTime.Now;
                    //int ano = gg.Year;

                    //DateTime gg2 = Convert.ToDateTime(row[11].ToString());
                    //int ano2 = gg2.Year;

                    //string hola = Convert.ToString(ano - ano2);
                    //txtEdad.Text = hola;
                }
            }
            catch (Exception ex)
            {
            }
        }

        protected void T1_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            llii_Sucursales(Convert.ToInt32(T1_empresa.SelectedValue));
        }

        protected void T18_asociadoPep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T18_asociadoPep.SelectedValue == "S")
            {
                Panel7.Visible = true;
            }
            else
            {
                Panel7.Visible = false;
            }
        }

        protected void T16_tipoDocumentoIdentificiacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T16_tipoDocumentoIdentificiacion.SelectedValue == "D")
            {
                T16_emisionPasaporte.Enabled = false;
            }
            else
            {
                T16_emisionPasaporte.Enabled = true;
            }
        }

        protected void T8_tipoDocumentoIdentificiacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T8_tipoDocumentoIdentificiacion.SelectedValue == "D")
            {
                T8_emisionPasaporte.Enabled = false;
            }
            else
            {
                T8_emisionPasaporte.Enabled = true;
            }
        }

        protected void checkboxlist3_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in checkboxlist3.Items)
            {
                if (item.Value == "Otro")
                {
                    TextBox1.Enabled = true;
                }
                else
                {
                    TextBox1.Enabled = false;
                }
            }
        }
        // EVENTOS AGREGADOS POST ENTREGA 12/01/2024
        protected void T17_origenRiqueza_CHANGE(object sender, EventArgs e)
        {
            if (T17_origenRiqueza.SelectedValue == "8")
            {
                T17_otroOrigenriqueza.Visible = true;
            }
            else
            {
                T17_otroOrigenriqueza.Visible = false;
            }
        }
        protected void T18_pep_origenRiqueza_CHANGE(object sender, EventArgs e)
        {
            if (T18_pep_origenRiqueza.SelectedValue == "8")
            {
                T18_pep_otroOrigenriqueza.Visible = true;
            }
            else
            {
                T18_pep_otroOrigenriqueza.Visible = false;
            }
        }
        protected void T10_origenRiqueza_CHANGE(object sender, EventArgs e)
        {
            if (T10_origenRiqueza.SelectedValue == "8")
            {
                T10_otroOrigenriqueza.Visible = true;
            }
            else
            {
                T10_otroOrigenriqueza.Visible = false;
            }
        }
        //----------------
        protected void T19_parentesco_CHANGE(object sender, EventArgs e)
        {
            if (T19_parentesco.SelectedValue == "O")
            {
                T19_otroPerntesco.Visible = true;
            }
            else
            {
                T19_otroPerntesco.Visible = false;
            }
        }
        protected void T11_parentesco_CHANGE(object sender, EventArgs e)
        {
            if (T11_parentesco.SelectedValue == "O")
            {
                T11_otroPerntesco.Visible = true;
            }
            else
            {
                T11_otroPerntesco.Visible = false;
            }
        }
        protected void T18_parientePep_parentesco_CHANGE(object sender, EventArgs e)
        {
            if (T18_parientePep_parentesco.SelectedValue == "O")
            {
                T18_parientePep_otroPerntesco.Visible = true;
            }
            else
            {
                T18_parientePep_otroPerntesco.Visible = false;
            }
        }
        //----------------
        protected void T20_motivoAsociacion_CHANGE(object sender, EventArgs e)
        {
            if (T20_motivoAsociacion.SelectedValue == "O")
            {
                T20_otroMotivoAsociacion.Visible = true;
            }
            else
            {
                T20_otroMotivoAsociacion.Visible = false;
            }
        }
        protected void T12_motivoAsociacion_CHANGE(object sender, EventArgs e)
        {
            if (T12_motivoAsociacion.SelectedValue == "O")
            {
                T12_otroMotivoAsociacion.Visible = true;
            }
            else
            {
                T12_otroMotivoAsociacion.Visible = false;
            }
        }
        protected void T18_asociadoPep_motivoAsociacion_CHANGE(object sender, EventArgs e)
        {
            if (T18_asociadoPep_motivoAsociacion.SelectedValue == "O")
            {
                T18_asociadoPep_otroMotivoAsociacion.Visible = true;
            }
            else
            {
                T18_asociadoPep_otroMotivoAsociacion.Visible = false;
            }
        }
        //----------------
        protected void checkboxlist3_CHANGE(object sender, EventArgs e)
        {
            if (checkboxlist3.Items[4].Selected)
            {
                TextBox1.Visible = true;
            }
            else
            {
                TextBox1.Visible = false;
            }
        }
        
    }
}
