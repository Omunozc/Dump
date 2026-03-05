<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FEICPI_IngresarFormulario.ascx.cs" Inherits="STOD_Web.FEICPI_IngresarFormulario" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<style>
    .noneLink {
        text-decoration: none;
        color: black;
    }
    .noneLink:link {
        text-decoration: none;
        color: black;
    }
    .form-control {
        font-size:12px;
        height: 30px;
    }
    .fc-center{
        text-align: center;
    }
    .auto-style1 {
        font-weight: bold;
    }
    .row{
        font-size:11px;
        margin-bottom:12px;
    }
    .nota{
        margin-bottom:0px;
    }
    .tituloPasos{
        font-family: 'Anton', sans-serif;
        font-size: 21px;
        letter-spacing: 0px;
        word-spacing: 0px;
        color: #004170;
        font-weight: bold;
        text-decoration: none;
        font-style: normal;
        font-variant: small-caps;
        text-transform: uppercase;
    }
    hr{
        margin-bottom: 5px;
        margin-top: 5px;
    }
    .btn{
        height: 30px;
    }
    .col-sm-1{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-2{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-3{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-4{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-5{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-6{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-7{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-8{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-9{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-10{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-11{
        padding-left: 5px;
        padding-right: 5px;
    }
    .col-sm-12{
        padding-left: 5px;
        padding-right: 5px;
    }
    body > form > table > tbody > tr > td > table > tbody > tr > td:nth-child(3){
        display: none;
    }
    body > form > table > tbody > tr > td > table > tbody > tr > td:nth-child(2) > table > tbody tr:nth-child(1){
        display:none;
    }
    body > form > table > tbody > tr > td > table > tbody > tr > td:nth-child(2) > table > tbody tr:nth-child(2) > td:nth-child(2) > br:nth-child(1){
        display:none;
    }
    body > form > table > tbody > tr > td > table > tbody > tr > td:nth-child(2) > table > tbody tr:nth-child(2) > td:nth-child(2) > br:nth-child(2){
        display:none;
    }

    .T15-ProductosHeader{
        margin-bottom: 0px;
        background-color: #337ab7;
        color: white;
    }
    .T15-ProductosHeader:hover{
        margin-bottom: 0px;
        background-color: #337ab7;
        color: white;
    }
    .T15-ProductosHeader > tr{
        height: 30px;
        background-color: #337ab7;
        color: white;
    }
    T15-ProductosBody{
        margin-bottom: 0px;
    }
    T15-ProductosBody > tr{
        height: 30px;
    }
    .checkboxlistPago > span{
        text-align: center !important;
    }
    .checkboxlistPago > span > input{
        margin-left: 20px;
    }
    .checkboxlistPago > span > label{
        margin-left: 5px;
    }
    div > div > div > span{
        text-align: center !important;
    }

</style>
<link rel="stylesheet" href="//code.jquery.com/ui/1.13.2/themes/base/jquery-ui.css">
<link rel="stylesheet" href="/resources/demos/style.css">
<script src="https://code.jquery.com/jquery-3.6.0.js"></script>
<script src="https://code.jquery.com/ui/1.13.2/jquery-ui.js"></script>

<script type="text/javascript">
    $(function () {
        $("#<%= T1_fechaCrecionFormulario.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
        <%--$("#<%= T3_fechaInscripcion.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
        $("#<%= T5_escritura_fecha.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });--%>
        $("#<%= T8_fechaNacimiento.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
        <%--$("#<%= T13_fechaInicial.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
        $("#<%= T13_fechaFinal.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });--%>
        $("#<%= T14_fecha.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
        $("#<%= T15_adquisicion_fecha.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
        <%--$("#<%= T16_fecha.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });--%>
        $("#<%= T17_fechaNacimiento.ClientID %>").datepicker({
            format: 'dd/mm/yyyy'
        });
    }
</script>

<div id="contenedorSolicitudInsert" style="margin-left: 0px; margin-right: 10px; width: 99%">
        <div class="panel panel-primary">
            <div class="panel-heading titlePanel">Formulario Electrónico de identificación del Cliente</div>
            <div class="panel-body">
                <asp:Label ID="SEC_0_ErrorCargaCatalogos" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error</asp:Label>
                <!-- SECCIÓN: 01. Principal(Contiente los datos generales del formulario)------------------------------------------------------ -->
                <asp:Panel runat="server" ID="SEC_01_Principal" class="col-md-12" Visible="true">
                    <asp:Label ID="SEC_01_PrincipalValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            <h4 class="tituloPasos">Paso 1:</h4>
                            <p>A continuación debe ingresar la información inicial para asignarle su número de formulario, recuerde llenar todos los campos.</p>
                            <hr></hr>
                        </label>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox></div>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-5 control-label"></label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">Fecha</label>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T1_fechaCrecionFormulario" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            A continuación debe seleccionar la información de la empresa y sucursal a la que pertenece
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            <asp:DropDownList ID="T1_empresa" Style="font-weight: 100" runat="server" AutoPostBack="true" OnSelectedIndexChanged="T1_empresa_SelectedIndexChanged" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione empresa"></asp:ListItem>
                                <asp:ListItem Value="1" Text="Canella"></asp:ListItem>
                                <asp:ListItem Value="2" Text="VESA"></asp:ListItem>
                                <asp:ListItem Value="3" Text="Maquipos"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-6">
                            <asp:DropDownList ID="T1_sucursal" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione sucursal"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            <asp:DropDownList ID="T1_tipoActuacion" Style="font-weight: 100" AutoPostBack="true" OnSelectedIndexChanged="T1_tipoActuacion_SelectedIndexChanged" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione tipo"></asp:ListItem>
                                <asp:ListItem Value="C" Text="Cliente"></asp:ListItem>
                                <asp:ListItem Value="R" Text="Representante"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-6">
                            <label for="inputEmail3" style="font-weight: 100" class="col-sm-2 control-label"></label>
                            <asp:TextBox ID="T1_calidadActua" class="form-control" Width="100%" ReadOnly="true" placeholder="Calidad con que actua" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-2 control-label"></label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-5 control-label">Ingrese el número de orden de venta utilizado en SAP</label>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T1_ordenDeVenta" class="form-control" input type="number" Width="100%" ReadOnly="false" runat="server"></asp:TextBox></div>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-2 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            A continuación debe seleccionar el lugar donde inicia la relación de negocios.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T2_paisID" Style="font-weight: 100" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T2_paisID" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T2_departamentoID" Style="font-weight: 100" AutoPostBack="true" Enabled="false" OnSelectedIndexChanged="cibc_cs_T2_departamentoID" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T2_municipioID" Style="font-weight: 100" Enabled="false" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100; text-align: center;" class="col-sm-12 control-label">
                            Una vez completados los campos anteriores, presione el botón para generar el número de formulario.
                        </label>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:Button Text="Guardar y generar formulario" ID="btnSEC_01_Principal_Guardar" OnClick="insert_T01" CssClass="btn btn-success" runat="server" /></div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_01_Principal_Siguiente" OnClick="btn_SEC_01_Siguiente" Visible="false" CssClass="btn btn-success" runat="server" /></div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 02. Datos del representante ------------------------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_16_DatosDelRepresentanteLegal" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_16_DatosDelRepresentanteLegalValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos del representante:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T16_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos del representante.</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T16_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T16_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T16_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T16_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T16_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T16_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_tipoDocumentoIdentificiacion" AutoPostBack="true" OnSelectedIndexChanged="T16_tipoDocumentoIdentificiacion_SelectedIndexChanged" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Indique el documento de identificación"></asp:ListItem>
                                <asp:ListItem Value="D" Text="DPI"></asp:ListItem>
                                <asp:ListItem Value="P" Text="Pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T16_numeroDocumentoIdentificacion"  class="form-control" Width="100%" runat="server" placeholder="Ingrese número del documento de identificación" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_emisionPasaporte" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione el pais que emite el pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T16_nit" class="form-control" Width="100%" runat="server" placeholder="Ingrese número identificación tributaria (NIT)" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_sexo" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Indique el genero del representante"></asp:ListItem>
                                <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T16_fechaNacimiento" class="form-control" Width="100%" runat="server" placeholder="Ingrese la fecha de nacimiento EJ: (09/12/1999)" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            Ingrese los datos del lugar de nacimiento del representante.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_direccionnacimiento_Pais" AutoPostBack="true" OnSelectedIndexChanged="T16_direccionnacimiento_Pais_SelectedIndexChanged" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_direccionnacimiento_Departamento" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="T16_direccionnacimiento_Departamento_SelectedIndexChanged" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_direccionnacimiento_Municipio" Enabled="false" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            Ingrese los datos de la dirección de residencia del representante.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_direccionResidencia_Pais" AutoPostBack="true" OnSelectedIndexChanged="T16_direccionResidencia_Pais_SelectedIndexChanged" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_direccionResidencia_Departamento" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="T16_direccionResidencia_Departamento_SelectedIndexChanged" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_direccionResidencia_Municipio" Enabled="false" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T16_direccionResidencia_Zona" class="form-control" Width="100%" runat="server" placeholder="Ingrese la zona." AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="T16_direccionResidencia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el complemento de la dirección social del cliente" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            A continuación se le permite seleccionar 3 nacionalidades diferentes, la primera es obligatoria, si el cliente no cuenta con más nacionalidades, seleccione "No aplica" en el resto de opciones.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_nacionalidad1" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="00" Text="Nacionalidad del representante"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_nacionalidad2" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="00" Text="2da nacionalidad del representante"></asp:ListItem>
                                <asp:ListItem Value="01" Text="No aplica"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_nacionalidad3" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="00" Text="3ra nacionalidad del representante"></asp:ListItem>
                                <asp:ListItem Value="01" Text="No aplica"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T16_condicionMigratoria" Style="font-weight: 100; text-align: center;" AutoPostBack="true" OnSelectedIndexChanged="T16_condicionMigratoria_SelectedIndexChanged" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione condición migratoria"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox ID="T16_otraCondicionMigratoria" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique la condición migratoria adicional, si no aplica ingrese 'N/A'" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:DropDownList ID="T16_estadoCivil" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Estado civil del representante"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Soltero"></asp:ListItem>
                                <asp:ListItem Value="C" Text="Casado"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T16_profesionOficio" class="form-control" Width="100%" runat="server" placeholder="Ingrese la profesión del representante" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T16_email" class="form-control" Width="100%" runat="server" placeholder="Ingrese el email de contacto" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Guardar" ID="btnSEC_16_DatosDelRepresentanteLegal_Guardar" OnClick="insert_T16" Visible="true" CssClass="btn btn-success" runat="server" />
                            <asp:Button Text="Siguiente paso." ID="btnSEC_16_DatosDelRepresentanteLegal_Siguiente" Visible="false" OnClick="btn_SEC_16_Rep_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 03. Números de telefono del representante ----------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_21_TelefonosDelRepresentante" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_21_TelefonosDelRepresentanteValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Números de teléfono del representante</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T21_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los números de teléfono del representante (3 como máximo).</p>
                        </div>
                        <hr></hr>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-3 control-label"></label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T21_Telefono" class="form-control" Width="100%" runat="server" placeholder="Ingrese el número telefónico (Ejemplo: 12345678)" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-2">
                            <asp:Button Text="Agregar teléfono" ID="Button1" OnClick="insert_T21" Visible="true" CssClass="btn btn-primary" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_21_TeRL_Siguiente" Visible="false" OnClick="btn_SEC_21_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                    <div class="row" style="overflow-x: auto; overflow-y: auto;">
                        <div class="col-md-12">
                            <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                            <asp:GridView ID="GV_TelefonosRepresentante"
                                runat="server"
                                CssClass="table table-striped table-hover table-bordered"
                                BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T21_RegID"
                                ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                UseAccessibleHeader="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:ButtonField CommandName="eliminar"
                                        ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                        <ControlStyle></ControlStyle>
                                        <ItemStyle Width="20px" />
                                    </asp:ButtonField>
                                </Columns>
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 04. Datos PEP - Del representante ------------------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_17_PEP_Cliente" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_17_PEP_ClienteValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP del representante:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="TextBox2" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación indique si el representante es una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                        <hr></hr>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_pep" Style="font-weight: 100" runat="server" AutoPostBack="true" OnSelectedIndexChanged="T17_pep_SelectedIndexChanged" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El representante es PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="SEC_17_PEP_Cliente_Info" Visible="false">
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T17_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese entidad a la que pertenece el representante" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T17_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña el representante" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:DropDownList ID="T17_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="País de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="T17_origenRiqueza" AutoPostBack="true" Style="font-weight: 100" runat="server" OnSelectedIndexChanged="cibc_cs_T17_origenRiqueza" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0" Text="Origen de riqueza del representante"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T17_otroOrigenriqueza" class="form-control" Width="100%" runat="server" placeholder="Detalle el otro origen de riqueza." Enabled="false" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSEC_17_PEP_Cliente_Agregar" OnClick="insert_T22" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_17_PEP_Cliente_Siguiente" Visible="true" OnClick="btn_SEC_22_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>

                    <div class="row" style="overflow-x: auto; overflow-y: auto;">
                        <div class="col-md-12">
                            <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                            <asp:GridView ID="GV_DatosPEP_Representante"
                                runat="server"
                                CssClass="table table-striped table-hover table-bordered"
                                BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T17_RegID"
                                ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                UseAccessibleHeader="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:ButtonField CommandName="eliminar"
                                        ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                        <ControlStyle></ControlStyle>
                                        <ItemStyle Width="20px" />
                                    </asp:ButtonField>
                                </Columns>
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 05. Datos PEP - Pariente del representante ---------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_19_PEP_ParienteRLC" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_19_PEP_ParienteRLCValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de parientes del representante:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="TextBox3" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si el representante (PEP) es pariente de una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T19_parientePep" Style="font-weight: 100" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="T19_parientePep_SelectedIndexChanged" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El representante es pariente de una PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="SEC_19_PEP_ParienteRLC_Info" Visible="false">
                        <div class="row">
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T19_parentesco" AutoPostBack="true" OnSelectedIndexChanged="T19_parentesco_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Seleccione el parentesco entre cliente y la PEP"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-8">
                                <asp:TextBox ID="T19_otroPerntesco" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique el parentesco si no aparece en la lista" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos del pariente PEP del representante</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T19_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T19_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T19_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T19_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T19_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T19_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T19_sexo" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Genero de la persona"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T19_condicion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Nacionalidad"></asp:ListItem>
                                    <asp:ListItem Value="N" Text="Nacional"></asp:ListItem>
                                    <asp:ListItem Value="E" Text="Extranjero"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos de la entidad a la que pertenece pariente PEP del representante</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8">
                                <asp:TextBox ID="T19_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la entidad a la que pertenece la persona" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T19_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Pais de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T19_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la persona" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="Button2" OnClick="insert_T23" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_DatosPEP_parienterepresentantePEP" runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T19_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente." ID="btnSEC_19_PEP_ParienteRLC_Siguiente" Visible="true" OnClick="btn_SEC_23_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 06. Datos PEP - Asociado del representante ---------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_20_AsociadoRLC" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_21_AsociadoRLCValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de asociados del representante:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="TextBox4" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si el representante (PEP) es asociado de una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T20_asociadoPep" Style="font-weight: 100" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="T20_asociadoPep_SelectedIndexChanged" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El representante es asociado de una PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="SEC_20_AsociadoRLC_Info" Visible="false">
                        <div class="row">
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T20_motivoAsociacion" AutoPostBack="true" OnSelectedIndexChanged="T20_motivoAsociacion_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Seleccione el motivo de asociación entre representante y la PEP"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-8">
                                <asp:TextBox ID="T20_otroMotivoAsociacion" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique el motivo de asociación si no aparece en la lista" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos del asociado PEP del representante</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T20_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T20_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T20_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T20_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T20_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T20_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T20_sexo" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Genero de la persona"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T20_condicion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Nacionalidad"></asp:ListItem>
                                    <asp:ListItem Value="N" Text="Nacional"></asp:ListItem>
                                    <asp:ListItem Value="E" Text="Extranjero"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos de la entidad a la que pertenece el asociado PEP del representante</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8">
                                <asp:TextBox ID="T20_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la entidad a la que pertenece la persona" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T20_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Pais de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T20_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la persona" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="Button3" OnClick="insert_T24" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_DatosAsociadoPEPRepresentante"
                                    runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T20_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>0
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_20_AsociadoRLC_Siguiente" Visible="true" OnClick="btn_SEC_24_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 07. Datos del cliente ------------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_07_DatosDelRepresentanteLegal" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_07_DatosDelRepresentanteLegalValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos del cliente:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T8_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos del cliente.</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:DropDownList ID="T8_clienteCPE" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El cliente es CPE?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                                <asp:ListItem Value="NA" Text="No aplica"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T8_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T8_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T8_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T8_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T8_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T8_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_tipoDocumentoIdentificiacion" AutoPostBack="true" OnSelectedIndexChanged="T8_tipoDocumentoIdentificiacion_SelectedIndexChanged" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Indique el documento de identificación"></asp:ListItem>
                                <asp:ListItem Value="D" Text="DPI"></asp:ListItem>
                                <asp:ListItem Value="P" Text="Pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T8_numeroDocumentoIdentificacion" class="form-control" Width="100%" runat="server" placeholder="Ingrese número del documento de identificación" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_emisionPasaporte" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione el pais que emite el pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T8_nit" class="form-control" Width="100%" runat="server" placeholder="Ingrese número identificación tributaria (NIT)" AutoPostBack="true" OnTextChanged="T8_nit_TextChanged" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_sexo" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Indique el genero del cliente"></asp:ListItem>
                                <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T8_fechaNacimiento" class="form-control" Width="100%" runat="server" placeholder="Ingrese la fecha de nacimiento EJ: 09/12/1999" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            Ingrese los datos del lugar de nacimiento del cliente.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_direccionnacimiento_Pais" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T8_direccionnacimiento_Pais" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_direccionnacimiento_Departamento" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T8_direccionnacimiento_Departamento" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_direccionnacimiento_Municipio" Enabled="false" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            Ingrese los datos de la dirección de residencia del cliente.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_direccionResidencia_Pais" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T8_direccionResidencia_Pais" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_direccionResidencia_Departamento" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T8_direccionResidencia_Departamento" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_direccionResidencia_Municipio" Enabled="false" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T8_direccionResidencia_Zona" class="form-control" Width="100%" runat="server" placeholder="Ingrese la zona." AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="T8_direccionResidencia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el complemento de la dirección social del representante" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            A continuación se le permite seleccionar 3 nacionalidades diferentes, la primera es obligatoria, si el representante no cuenta con más nacionalidades, seleccione "No aplica" en el resto de opciones.
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_nacionalidad1" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="00" Text="Nacionalidad del cliente"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_nacionalidad2" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="00" Text="2da nacionalidad del cliente"></asp:ListItem>
                                <asp:ListItem Value="01" Text="No aplica"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_nacionalidad3" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="00" Text="3ra nacionalidad del cliente"></asp:ListItem>
                                <asp:ListItem Value="01" Text="No aplica"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T8_condicionMigratoria" Style="font-weight: 100; text-align: center;" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T8_condicionMigratoria" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione condición migratoria"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-8">
                            <asp:TextBox ID="T8_otraCondicionMigratoria" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique la condición migratoria adicional de ser necesario" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:DropDownList ID="T8_estadoCivil" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Estado civil del cliente"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Soltero"></asp:ListItem>
                                <asp:ListItem Value="C" Text="Casado"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T8_profesionOficio" class="form-control" Width="100%" runat="server" placeholder="Ingrese la profesión del representante" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T8_email" class="form-control" Width="100%" runat="server" placeholder="Ingrese el email de contacto" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Guardar" ID="btnSEC_07_DatosDelRepresentanteLegal_Guardar" OnClick="insert_T08" Visible="true" CssClass="btn btn-success" runat="server" />
                            <asp:Button Text="Siguiente paso." ID="btnSEC_07_DatosDelRepresentanteLegal_Siguiente" Visible="false" OnClick="btn_SEC_07_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 08. Números de telefono del cleinte ----------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_08_TelefonosDelRepresentante" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_08_TelefonosDelRepresentanteValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Números de teléfono del cleinte:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T9_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los números de teléfono cleinte (3 como máximo).</p>
                        </div>
                        <hr></hr>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-3 control-label"></label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T9_Telefono" class="form-control" Width="100%" runat="server" placeholder="Ingrese el número telefónico (Ejemplo: 12345678)" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-2">
                            <asp:Button Text="Agregar teléfono" ID="SEC_08_TeRL_Agregar" OnClick="insert_T09" Visible="true" CssClass="btn btn-primary" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_08_TeRL_Siguiente" Visible="false" OnClick="btn_SEC_08_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                    <div class="row" style="overflow-x: auto; overflow-y: auto;">
                        <div class="col-md-12">
                            <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                            <asp:GridView ID="GV_TelefonosRepresentanteLegal"
                                runat="server"
                                CssClass="table table-striped table-hover table-bordered"
                                BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T15_RegID"
                                ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                UseAccessibleHeader="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:ButtonField CommandName="eliminar"
                                        ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                        <ControlStyle></ControlStyle>
                                        <ItemStyle Width="20px" />
                                    </asp:ButtonField>
                                </Columns>
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 09. Datos PEP - cleinte ----------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_09_PEP_Cliente" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_09_PEP_ClienteValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP del cleinte:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T10_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación indique si el cleinte es una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                        <hr></hr>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T10_pep" Style="font-weight: 100" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T10_pep" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El cleinte es PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="SEC_09_PEP_Cliente_Info" Visible="false">
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T10_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese entidad a la que pertenece el cleinte" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T10_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña el cleinte" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:DropDownList ID="T10_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="País de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="T10_origenRiqueza" AutoPostBack="true" OnSelectedIndexChanged="T10_origenRiqueza_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0" Text="Origen de riqueza de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T10_otroOrigenriqueza" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Detalle el otro origen de riqueza de ser necesario" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSEC_09_PEP_Cliente_Agregar" OnClick="insert_T10" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_09_PEP_Cliente_Siguiente" Visible="true" OnClick="btn_SEC_09_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>

                    <div class="row" style="overflow-x: auto; overflow-y: auto;">
                        <div class="col-md-12">
                            <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                            <asp:GridView ID="GV_DatosPEP_Cliente"
                                runat="server"
                                CssClass="table table-striped table-hover table-bordered"
                                BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T4_RegID"
                                ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                UseAccessibleHeader="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:ButtonField CommandName="eliminar"
                                        ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                        <ControlStyle></ControlStyle>
                                        <ItemStyle Width="20px" />
                                    </asp:ButtonField>
                                </Columns>
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 10. Datos PEP - Pariente RLC ------------------------------------------------------------------------------------ -->
                <asp:Panel runat="server" ID="SEC_10_PEP_ParienteRLC" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_10_PEP_ParienteRLCValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de parientes del cliente:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T11_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si el cliente (PEP) es pariente de una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T11_parientePep" Style="font-weight: 100" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T11_parientePep" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El representante es pariente de una PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="SEC_10_PEP_ParienteRLC_Info" Visible="false">
                        <div class="row">
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T11_parentesco" AutoPostBack="true" OnSelectedIndexChanged="T11_parentesco_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Seleccione el parentesco entre cliente y la PEP"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-8">
                                <asp:TextBox ID="T11_otroPerntesco" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique el parentesco si es necesario" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos del pariente PEP del cliente</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T11_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T11_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T11_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T11_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T11_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T11_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T11_sexo" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Genero de la persona"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T11_condicion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Nacionalidad"></asp:ListItem>
                                    <asp:ListItem Value="N" Text="Nacional"></asp:ListItem>
                                    <asp:ListItem Value="E" Text="Extranjero"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos de la entidad a la que pertenece pariente PEP del cliente</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8">
                                <asp:TextBox ID="T11_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la entidad a la que pertenece la persona" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T11_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Pais de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T11_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la persona" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSEC_10_PEP_ParienteRLC_Agregar" OnClick="insert_T11" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_DatosPEP_parientePEP" runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T5_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente." ID="btnSEC_10_PEP_ParienteRLC_Siguiente" Visible="true" OnClick="btn_SEC_10_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 11. Datos PEP - Asociado RLC ------------------------------------------------------------------------------------ -->
                <asp:Panel runat="server" ID="SEC_11_AsociadoRLC" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_11_AsociadoRLCValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de asociados del cliente:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T12_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si el cliente (PEP) es asociado de una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T12_asociadoPep" Style="font-weight: 100" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T12_asociadoPep" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El representante es asociado de una PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="SEC_11_AsociadoRLC_Info" Visible="false">
                        <div class="row">
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T12_motivoAsociacion" AutoPostBack="true" OnSelectedIndexChanged="T12_motivoAsociacion_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Seleccione el motivo de asociación entre cliente y la PEP"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-8">
                                <asp:TextBox ID="T12_otroMotivoAsociacion" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique el motivo de asociación si es necesario" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos del asociado PEP del cliente</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T12_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T12_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T12_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T12_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T12_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T12_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T12_sexo" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Genero de la persona"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T12_condicion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Nacionalidad"></asp:ListItem>
                                    <asp:ListItem Value="N" Text="Nacional"></asp:ListItem>
                                    <asp:ListItem Value="E" Text="Extranjero"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos de la entidad a la que pertenece el asociado PEP del cliente</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8">
                                <asp:TextBox ID="T12_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la entidad a la que pertenece la persona" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T12_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Pais de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T12_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la persona" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSEC_11_AsociadoRLC_Agregar" OnClick="insert_T12" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_DatosAsociadoPEPRL"
                                    runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T6_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_11_AsociadoRLC_Siguiente" Visible="true" OnClick="btn_SEC_11_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 12. Datos de la información económica del cliente --------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_13_InfoEconomicaDelCliente" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_13_InfoEconomicaDelClienteValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Información económica del cliente:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T14_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos de la información económica del cliente.</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-8">
                            <asp:DropDownList ID="T14_establecimientoInformacion" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Tipo de información de la persona"></asp:ListItem>
                                <asp:ListItem Value="I" Text="Inicial: Primera vez que el cliente brinda esta información"></asp:ListItem>
                                <asp:ListItem Value="A" Text="Actualización: El cliente brindó esta información anteriormente y se esta actualizando."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T14_fecha" TextMode="Date" class="form-control" Width="100%" runat="server" placeholder="Ingrese fecha" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:DropDownList ID="T14_TipoActividad" Style="font-weight: 100; text-align: center;" runat="server" AutoPostBack="true" OnSelectedIndexChanged="T14_TipoActividad_SelectedIndexChanged" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NA" Text="Seleccione una opcion"></asp:ListItem>
                                <asp:ListItem Value="NP" Text="Negocio Propio"></asp:ListItem>
                                <asp:ListItem Value="NE" Text="Relación de Dependencia"></asp:ListItem>
                                <asp:ListItem Value="OT" Text="Otros Ingresos"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:TextBox ID="T14_actividadEconomicaRTU" TextMode="MultiLine" Rows="3" class="form-control" Width="100%" runat="server" placeholder="Ingrese la actividad económica tal y como esta en el RTU del cliente" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:TextBox ID="T14_nombreComercial"  Enabled="false" TextMode="MultiLine" Rows="3" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre comercial del negocio propio del cliente" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:TextBox ID="T14_nombreEmpleador" Enabled="false" TextMode="MultiLine" Rows="3" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la relacion de dependencia del cliente" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:DropDownList ID="T14_ingresos_tipoIngreso" Style="font-weight: 100; text-align: center;" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T14_ingresos_tipoIngreso" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione el tipo de ingresos del cliente"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="T14_ingresos_otroTipoIngreso" class="form-control" Width="100%" runat="server" placeholder="Detalle el tipo de ingreso si aplica, caso contrario omita este campo" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T14_ingresos_moneda" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione la moneda del monto de ingresos"></asp:ListItem>
                                <asp:ListItem Value="GTQ" Text="(Q. ) - Quetzales"></asp:ListItem>
                                <asp:ListItem Value="USD" Text="($. ) - Dolares"></asp:ListItem>
                                <asp:ListItem Value="EUR" Text="(€. ) - Euros"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T14_ingresos_monto" class="form-control" Width="100%" runat="server" placeholder="Monto: Ingresos" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T14_egresos_moneda" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione la moneda del monto de egresos"></asp:ListItem>
                                <asp:ListItem Value="GTQ" Text="(Q. ) - Quetzales"></asp:ListItem>
                                <asp:ListItem Value="USD" Text="($. ) - Dolares"></asp:ListItem>
                                <asp:ListItem Value="EUR" Text="(€. ) - Euros"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T14_egresos_monto" class="form-control" Width="100%" runat="server" placeholder="Monto: Egresos" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <asp:TextBox ID="T14_propositoRC" TextMode="MultiLine" Rows="3" class="form-control" Width="100%" runat="server" placeholder="Indique el proposito por el cual se inicia la relación comercial." AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Guardar" ID="btnSEC_13_InfoEconomicaDelCliente_Guardar" OnClick="insert_T14" Visible="true" CssClass="btn btn-success" runat="server" />
                            <asp:Button Text="Siguiente paso." ID="btnSEC_13_InfoEconomicaDelCliente_Siguiente" Visible="false" OnClick="btn_SEC_13_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                    <div class="row" style="overflow-x: auto; overflow-y: auto;">
                        <div class="col-md-12">
                            <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                            <asp:GridView ID="GV_InfoEconomicaCliente"
                                runat="server"
                                CssClass="table table-striped table-hover table-bordered"
                                BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T7_RegID"
                                ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                UseAccessibleHeader="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:ButtonField CommandName="eliminar"
                                        ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                        <ControlStyle></ControlStyle>
                                        <ItemStyle Width="20px" />
                                    </asp:ButtonField>
                                </Columns>
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 13. Datos de los productos -------------------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_14_Productos" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_14_ProductosValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Información de los productos adquiridos:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T15_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>Indique la fecha y el lugar en el que el cliente adquirió los productos</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T15_adquisicion_fecha" TextMode="Date" class="form-control" Width="100%" runat="server" placeholder="Ingrese fecha" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T15_adquisicion_Pais" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T15_adquisicion_Pais" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T15_adquisicion_Departamento" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T15_adquisicion_Departamento" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T15_adquisicion_Municipio" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>Indique la forma de compra del producto</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T15_nombreContrata" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre que contrata el producto" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T15_fondosPropios" Style="font-weight: 100" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T15_T15_FondosPropios" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Fondos utilizados"></asp:ListItem>
                                <asp:ListItem Value="1" Text="Fondos propios"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Fondos de terceros"></asp:ListItem>
                                <asp:ListItem Value="3" Text="Fondos propios y de terceros"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T15_fondosTercero" Style="font-weight: 100" runat="server" Enabled="false" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Si utiliza fondos de terceros, el tercero es"></asp:ListItem>
                                <asp:ListItem Value="PI" Text="Tercero - Persona individual"></asp:ListItem>
                                <asp:ListItem Value="PJ" Text="Tercero - Persona jurídíca"></asp:ListItem>
                                <asp:ListItem Value="PU" Text="Tercero - Persona individual y jurídica"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Cargar productos desde orden de venta" ID="btnSEC_14_CargarProductosSAP" OnClick="btnCargarProductosSAP" Visible="false" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación se cargaron los productos desde la orden de compra, si desea ingresar algún otro producto ingrese la información y de click en agregar</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T15_tipo" class="form-control" Width="100%" runat="server" placeholder="Ingrese el tipo de articulo" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-8">
                            <asp:TextBox ID="T15_nombreDescripcion" class="form-control" Width="100%" runat="server" placeholder="Ingrese el código del articulo" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T15_identificador" Tclass="form-control" Width="100%" runat="server" placeholder="Ingrese el chasis del articulo" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T15_moneda" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione moneda."></asp:ListItem>
                                <asp:ListItem Value="GTQ" Text="(Q. ) - Quetzales"></asp:ListItem>
                                <asp:ListItem Value="USD" Text="($. ) - Dolares"></asp:ListItem>
                                <asp:ListItem Value="EUR" Text="(€. ) - Euros"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T15_valor" class="form-control" Width="100%" runat="server" placeholder="Ingrese valor del articulo según la moneda indicada" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Agregar" ID="btnSEC_14_Productos_Agregar" OnClick="insert_T15" Visible="true" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                    <div class="row" style="overflow-x: auto; overflow-y: auto;">
                        <div class="col-md-12">
                            <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                            <asp:GridView ID="GV_Productos"
                                runat="server"
                                CssClass="table table-striped table-hover table-bordered"
                                BackColor="White" BorderColor="#999999"
                                BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T8_RegID"
                                ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                UseAccessibleHeader="False">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:ButtonField CommandName="eliminar"
                                        ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                        <ControlStyle></ControlStyle>
                                        <ItemStyle Width="20px" />
                                    </asp:ButtonField>
                                </Columns>
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_14_Productos_Siguiente" Visible="false" OnClick="btn_SEC_14_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 14. Datos persona individual que provee fondos como tercero ----------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_16_PI_FondosTercero" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_16_PI_FondosTerceroValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos de la perosna individual que provee fondos como tercero</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T17_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos de la persona individual que provee fondos como tercero</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T17_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T17_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T17_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T17_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-3">
                            <asp:TextBox ID="T17_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T17_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_tipoDocumentoIdentificacion" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Indique el documento de identificación"></asp:ListItem>
                                <asp:ListItem Value="D" Text="DPI"></asp:ListItem>
                                <asp:ListItem Value="P" Text="Pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T17_numeroDocumentoIdentificacion" class="form-control" Width="100%" runat="server" placeholder="Ingrese número del documento de identificación" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_emisionPasaporte" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione el pais que emite el pasaporte"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T17_nit" class="form-control" Width="100%" runat="server" placeholder="Ingrese número identificación tributaria (NIT)" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_sexo" Style="font-weight: 100; text-align: center;" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Indique el genero de la persona individual que provee fondos como tercero"></asp:ListItem>
                                <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T17_fechaNacimiento" type="date" class="form-control" Width="100%" runat="server" placeholder="Seleccione la fecha de nacimiento" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            Ingrese los datos de la dirección de residencia de la persona individual que provee fondos como tercero
                        </label>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_direccionResidencia_Pais" Style="font-weight: 100" runat="server" AutoPostBack="true" OnSelectedIndexChanged="T17_direccionResidencia_Pais_SelectedIndexChanged" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_direccionResidencia_Departamento" Style="font-weight: 100" runat="server" AutoPostBack="true" OnSelectedIndexChanged="T17_direccionResidencia_Departamento_SelectedIndexChanged" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T17_direccionResidencia_Municipio" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T17_direccionResidencia_Zona" class="form-control" Width="100%" runat="server" placeholder="Ingrese la zona." AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="T17_direccionResidencia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el complemento de la dirección social del cliente" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Guardar" ID="btnSEC_16_PI_FondosTercero_Guardar" OnClick="insert_T17" Visible="true" CssClass="btn btn-success" runat="server" />
                            <asp:Button Text="Siguiente paso." ID="btnSEC_16_PI_FondosTercero_Seguir" Visible="true" OnClick="btn_SEC_16_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 15. Datos PEP - PIPFT ------------------------------------------------------------------------------------------ -->
                <asp:Panel runat="server" ID="SEC_17_PEP_PIPFT" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_17_PEP_PIPFTValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de la persona que provee fondos como tercero:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">REG ID</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T18_Ref_PersonaIndividualPEPRegID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si persona individual que provee fondos como tercero (PIPFT) es una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                        <hr></hr>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                        <div class="col-sm-8">
                            <asp:DropDownList ID="T18_pep" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T18_pep" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿La persona individual que provee fondos como tercero (PIPFT) es PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="Panel3" Visible="false">
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T18_pep_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese entidad a la que pertenece la PIPFT" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T18_pep_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la PIPFT" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:DropDownList ID="T18_pep_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="País de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="T18_pep_origenRiqueza" AutoPostBack="true" OnSelectedIndexChanged="T18_pep_origenRiqueza_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0" Text="Origen de riqueza de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T18_pep_otroOrigenriqueza" class="form-control" Width="100%" runat="server" placeholder="Detalle el otro origen de riqueza, si no aplica ingrese 'N/A'" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSEC_17_PEP_PIPFT_Agregar" OnClick="insert_T18_PPIPF" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_PEP_PIPFT"
                                    runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T18_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_17_PEP_PIPFT_Siguiente" Visible="true" OnClick="btn_SEC_17_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 16. Datos PEP - Pariente PIPFT ---------------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_18_PEPPIPFT_Pariente" class="col-md-12" Visible="false">
                    <asp:Label ID="SE_18_PEPPIPFT_ParienteValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de parientes de la persona que provee fondos como tercero:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T18_Ref_PersonaIndividualParientePEPRegID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si la persona individual que provee fondos como tercero (PIPFT) es pariente de una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-1 control-label"></label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="T18_parientePep" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T18_parientePep" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿La persona individual que provee fondos como tercero (PIPFT) es pariente de una PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="Panel5" Visible="true">
                        <div class="row">
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_parientePep_parentesco" AutoPostBack="true" OnSelectedIndexChanged="T18_parientePep_parentesco_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0" Text="Seleccione el parentesco entre PIPFT y la PEP"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-8">
                                <asp:TextBox ID="T18_parientePep_otroPerntesco" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique el parentesco si no aparece en la lista" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos del pariente PEP de la persona individual que provee fondos como tercero (PIPFT)</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_parientePep_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_parientePep_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T18_parientePep_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_parientePep_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_parientePep_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T18_parientePep_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_parientePep_sexo" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Genero de la persona"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_parientePep_condicion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Nacionalidad"></asp:ListItem>
                                    <asp:ListItem Value="N" Text="Nacional"></asp:ListItem>
                                    <asp:ListItem Value="E" Text="Extranjero"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos de la entidad a la que pertenece pariente PEP de la persona individual que provee fondos como tercero (PIPFT)</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox13" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la entidad a la que pertenece la persona" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_parientePep_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Pais de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T18_parientePep_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la persona" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSE_18_PEPPIPFT_Pariente_Agregar" OnClick="insert_T18_ParientePIPF" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_PEP_ParientePIPFT"
                                    runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T18_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSE_18_PEPPIPFT_Pariente_Siguiente" Visible="true" OnClick="btn_SEC_18_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 17. Datos PEP - Asociado PIPFT ---------------------------------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_19_PEPPIPFT_Asociado" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_19_PEPPIPFT_AsociadoValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos PEP de asociados de la persona que provee fondos como tercero:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T18_Ref_PersonaIndividualAsociadoPEPRegID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique si cuenta si la persona individual que provee fondos como tercero (PIPFT) es asociado de una Persona Expuesta Politicamente (PEP).</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T18_asociadoPep" Style="font-weight: 100" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="T18_asociadoPep_SelectedIndexChanged" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="¿El cliente es asociado de una PEP?"></asp:ListItem>
                                <asp:ListItem Value="S" Text="Si"></asp:ListItem>
                                <asp:ListItem Value="N" Text="No"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                    <asp:Panel runat="server" ID="Panel7" Visible="true">
                        <div class="row">
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_asociadoPep_motivoAsociacion" AutoPostBack="true" OnSelectedIndexChanged="T18_asociadoPep_motivoAsociacion_CHANGE" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0" Text="Seleccione el motivo de asociación entre PIPFT y la PEP"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-8">
                                <asp:TextBox ID="T18_asociadoPep_otroMotivoAsociacion" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Especifique el motivo de asociación si no aparece en la lista" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos del asociado PEP de la persona individual que provee fondos como tercero (PIPFT)</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_asociadoPep_primerNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_asociadoPep_segundoNombre" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo nombre" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T18_asociadoPep_otrosNombres" class="form-control" Width="100%" runat="server" placeholder="Ingrese otros nombre" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_asociadoPep_primerApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese primer apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="T18_asociadoPep_segundoApellido" class="form-control" Width="100%" runat="server" placeholder="Ingrese segundo apellido" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-6">
                                <asp:TextBox ID="T18_asociadoPep_apellidoCasada" class="form-control" Width="100%" runat="server" placeholder="Ingrese apellido de casada" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_asociadoPep_sexo" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Genero de la persona"></asp:ListItem>
                                    <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
                                    <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_asociadoPep_condicion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Nacionalidad"></asp:ListItem>
                                    <asp:ListItem Value="N" Text="Nacional"></asp:ListItem>
                                    <asp:ListItem Value="E" Text="Extranjero"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row nota">
                            <div class="col-sm-12">
                                <p>A continuación ingrese los datos de la entidad a la que pertenece el asociado PEP de la persona individual que provee fondos como tercero (PIPFT)</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-8">
                                <asp:TextBox ID="T18_asociadoPep_entidad" class="form-control" Width="100%" runat="server" placeholder="Ingrese el nombre de la entidad a la que pertenece la persona" AutoComplete="off"></asp:TextBox></div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="T18_asociadoPep_paisEntidad" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <asp:ListItem Value="NE" Text="Pais de la entidad"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:TextBox ID="T18_asociadoPep_puestoDesempenia" class="form-control" Width="100%" runat="server" placeholder="Ingrese el puesto que desempeña la persona" AutoComplete="off"></asp:TextBox></div>
                        </div>
                        <div class="row">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                            <div class="col-sm-2">
                                <asp:Button Text="Agregar" ID="btnSEC_19_PEPPIPFT_Asociado_Agregar" OnClick="insert_T18_AsociadoPIPF" Visible="true" CssClass="btn btn-primary" runat="server" />
                            </div>
                        </div>
                        <div class="row" style="overflow-x: auto; overflow-y: auto;">
                            <div class="col-md-12">
                                <!--OnRowCommand="GV_TelefonoPJ_RowCommand" -->
                                <asp:GridView ID="GV_PEP_AsociadoPIPFT"
                                    runat="server"
                                    CssClass="table table-striped table-hover table-bordered"
                                    BackColor="White" BorderColor="#999999"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="True" DataKeyNames="T18_RegID"
                                    ForeColor="Black" GridLines="Vertical" Width="780px" HorizontalAlign="Center"
                                    UseAccessibleHeader="False">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:ButtonField CommandName="eliminar"
                                            ButtonType="Image" Text="Eliminar" ImageUrl="~/images/icons/cancel.png">
                                            <ControlStyle></ControlStyle>
                                            <ItemStyle Width="20px" />
                                        </asp:ButtonField>
                                    </Columns>
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            </div>
                        </div>
                    </asp:Panel>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_19_PEPPIPFT_Asociado_Siguiente" Visible="true" OnClick="btn_SEC_19_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 18. Datos persona jurídica que provee fondos como tercero ------------------------------------------------------- -->
                <asp:Panel runat="server" ID="SEC_20_PJ_FondosTercero" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_20_PJ_FondosTerceroValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos de la persona jurídica que provee fondos como tercero:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T19_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos de la persona juridica que provee fondos como tercero solicitante del producto.</p>
                        </div>
                        <hr></hr>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label"></label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="T19_nombreRazonSocial" class="form-control" Width="100%" runat="server" placeholder="Ingrese nombre razón social" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label"></label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="T19_nombreComercial" class="form-control" Width="100%" runat="server" placeholder="Ingrese nombre comercial" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6">
                            <asp:DropDownList ID="T19_paisJurisdiccionConstitucion" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais de jurisdicción o constitución."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-6">
                            <asp:TextBox ID="T19_nit" class="form-control" Width="100%" runat="server" placeholder="Ingrese NIT" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos de la dirección de la empresa</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T19_direccion_Pais" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T19_direccion_Pais" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="NE" Text="Seleccione pais."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T19_direccion_Departamento" AutoPostBack="true" OnSelectedIndexChanged="cibc_cs_T19_direccion_Departamento" Enabled="false" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione departamento."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="T19_direccion_Municipio" Enabled="false" Style="font-weight: 100" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="0" Text="Seleccione municipio."></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-3">
                            <asp:TextBox ID="T19_direccion_Zona" class="form-control" Width="100%" runat="server" placeholder="Ingrese la zona." AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-9">
                            <asp:TextBox ID="T19_direccion" class="form-control" Width="100%" runat="server" placeholder="Ingrese el complemento de la dirección social del cliente" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación debe ingresar los datos de la patente de empresa solicitante del producto.</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <asp:TextBox ID="T19_numeroPatente" class="form-control" Width="100%" runat="server" placeholder="Ingrese el número" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T19_folioPatente" class="form-control" Width="100%" runat="server" placeholder="Ingrese el folio" AutoComplete="off"></asp:TextBox></div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="T19_libroPatente" class="form-control" Width="100%" runat="server" placeholder="Ingrese el libro" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Guardar" ID="btnSEC_20_PJ_FondosTercero_Guardar" OnClick="insert_T19" Visible="true" CssClass="btn btn-primary" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Siguiente paso." ID="btnSEC_20_PJ_FondosTercero_Siguiente" Visible="true" OnClick="btn_SEC_20_Siguiente" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 19. Datos de pago ------------------------------------------------------------------------------------------ -->
                <asp:Panel runat="server" ID="SEC_21_Pago" class="col-md-12" Visible="false">
                    <asp:Label ID="SEC_21_PagoValidation" runat="server" Visible="false" ForeColor="Red" Style="text-align: center;" class="col-md-12">Error: 001 - falta código cliente</asp:Label>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-9 control-label">
                            <h4 class="tituloPasos">Datos de pago:</h4>
                        </label>
                        <label for="inputEmail3" style="font-weight: 100" class="col-sm-1 control-label">No. Formulario</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="T20_FormularioID" class="form-control" Width="100%" ReadOnly="true" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <hr></hr>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique la modalidad de pago utilizada</p>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                        <div class="col-sm-12 checkboxlistPago" style="text-align: center">
                            <asp:CheckBoxList ID="checkboxlist1"
                                CellPadding="5"
                                CellSpacing="5"
                                RepeatColumns="3"
                                RepeatDirection="Horizontal"
                                RepeatLayout="Flow"
                                TextAlign="Right"
                                runat="server">
                                <asp:ListItem>Contado</asp:ListItem>
                                <asp:ListItem>Credito interno</asp:ListItem>
                                <asp:ListItem>Credito externo</asp:ListItem>
                            </asp:CheckBoxList>
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique el lugar donde el cliente efectuara el pago</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12 checkboxlistPago" style="text-align: center">
                            <asp:CheckBoxList ID="checkboxlist2"
                                CellPadding="5"
                                CellSpacing="5"
                                RepeatColumns="3"
                                RepeatDirection="Horizontal"
                                RepeatLayout="Flow"
                                TextAlign="Right"
                                runat="server">
                                <asp:ListItem>Caja propia</asp:ListItem>
                                <asp:ListItem>Entidad bancaria</asp:ListItem>
                                <asp:ListItem style="display:none">Caja rural</asp:ListItem>
                                <asp:ListItem style="display:none">Caja propia y entidad bancaria</asp:ListItem>
                                <asp:ListItem style="display:none">Caja rural y entidad bancaria</asp:ListItem>
                                <asp:ListItem style="display:none">Caja propia y caja rural</asp:ListItem>
                            </asp:CheckBoxList>
                        </div>
                    </div>
                    <div class="row nota">
                        <div class="col-sm-12">
                            <p>A continuación indique el medio de pago utilizado por el cliente</p>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-12 checkboxlistPago" style="text-align: center">
                            <asp:CheckBoxList ID="checkboxlist3" AutoPostBack="true" OnSelectedIndexChanged="checkboxlist3_CHANGE"
                                CellPadding="5"
                                CellSpacing="5"
                                RepeatColumns="3"
                                RepeatDirection="Horizontal"
                                RepeatLayout="Flow"
                                TextAlign="Right"
                                runat="server">
                                <asp:ListItem>Efectivo</asp:ListItem>
                                <asp:ListItem>Cheque</asp:ListItem>
                                <asp:ListItem>Transferencia</asp:ListItem>
                                <asp:ListItem>Tarjeta</asp:ListItem>
                                <asp:ListItem>Otro</asp:ListItem>
                            </asp:CheckBoxList>
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-2 control-label"></label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="TextBox1" Enabled="false" class="form-control" Width="100%" runat="server" placeholder="Si seleccionó otro medio de pago, detallelo. Caso contrario omita este campo" AutoComplete="off"></asp:TextBox></div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-5 control-label"></label>
                        <div class="col-sm-2">
                            <asp:Button Text="Agregar" ID="btnSEC_21_Pago_Agregar" OnClick="insert_T20" Visible="true" CssClass="btn btn-primary" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                        <div class="col-sm-4">
                            <asp:Button Text="Finalizar formulario" ID="btnSEC_21_Pago_Finalizar" OnClick="btn_SEC_21_Finalizar" Visible="true" CssClass="btn btn-success" runat="server" />
                        </div>
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-4 control-label"></label>
                    </div>
                </asp:Panel>
                <!-- SECCIÓN: 20. Sección final ------------------------------------------------------------------------------------------ -->
                <asp:Panel runat="server" ID="PanelFInal" class="col-md-12" Visible="false">
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label">
                            <h4 class="tituloPasos" style="text-align: center;">FORMULARIO FINALIZADO</h4>
                        </label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota" style="text-align: center;">
                        <div class="col-sm-12">
                            <svg xmlns="http://www.w3.org/2000/svg" fill="green" id="Layer_1" data-name="Layer 1" viewBox="0 0 24 24" width="150" height="150">
                                <path d="m17.298,6.289l1.404,1.423-6.792,6.707c-.387.387-.897.581-1.408.581s-1.025-.195-1.416-.585l-3.785-3.699,1.397-1.431,3.793,3.707,6.806-6.703Zm6.702-3.289v17h-6.852l-3.847,3.18c-.362.322-.825.484-1.293.484-.476,0-.955-.168-1.337-.507l-3.748-3.157H0V3C0,1.346,1.346,0,3,0h18c1.654,0,3,1.346,3,3Zm-2,0c0-.551-.448-1-1-1H3c-.551,0-1,.449-1,1v15h5.654l4.326,3.645,4.448-3.645h5.572V3Z" />
                            </svg>
                        </div>
                    </div>
                    <div class="row nota" style="text-align: center;">
                        <div class="col-sm-12">
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-1 control-label"></label>
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-10 control-label">
                                <h4 class="tituloPasos" style="text-align: center;">Su formulario ha sido ingresado correctamente, puede proceder a imprimir su formulario.</h4>
                            </label>
                            <label for="inputEmail3" style="font-weight: 100;" class="col-sm-1 control-label"></label>
                        </div>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                    <div class="row nota">
                        <label for="inputEmail3" style="font-weight: 100;" class="col-sm-12 control-label"></label>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </div>

