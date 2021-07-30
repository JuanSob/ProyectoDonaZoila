using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DoñaZoila
{
    class ClsBuscar
    {
        //Atributos
        private static int codigoPuesto= 0;
        private static int rol = 0;
        private static string nombreEmpleado;
        private static int codigoEmpleado;
        private static string esatadoEmpleado;
        
        private static int codProveedor;
        private static string nombreProveedor;
        private static string estado;
        
        private static int codMaterial;
        private static string nombreMaterial;
        private static int cantMaterial;

        private static string nombreZona;
        private static int codZona;

        private static string placaVehiculo;
        private static int codVehiculo;
        private static string estadoVehiculo;

        private static int codCategoria;
        private static string nombreCategoria;

        private static int codProducto;
        private static int cantProducto;
        private static string nombreProducto;

        private static int codCliente;
        private static string nombreCliente;
        private static string estadoCliente;

        private static int codViaje=0;

        //Encapsulamiento
        public int CodigoPuesto { get => codigoPuesto; set => codigoPuesto = value; }
        public int Rol { get => rol; set => rol = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int CodigoEmpleado { get => codigoEmpleado; set => codigoEmpleado = value; }
        public int CodProveedor { get => codProveedor; set => codProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public int CodMaterial { get => codMaterial; set => codMaterial = value; }
        public string NombreMaterial { get => nombreMaterial; set => nombreMaterial = value; }
        public string Estado { get => estado; set => estado = value; }
        public string EsatadoEmpleado { get => esatadoEmpleado; set => esatadoEmpleado = value; }
        public string NombreZona { get => nombreZona; set => nombreZona = value; }
        public int CodZona { get => codZona; set => codZona = value; }
        public string PlacaVehiculo { get => placaVehiculo; set => placaVehiculo = value; }
        public int CodVehiculo { get => codVehiculo; set => codVehiculo = value; }
        public string EstadoVehiculo { get => estadoVehiculo; set => estadoVehiculo = value; }
        public int CodCategoria { get => codCategoria; set => codCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public int CantMaterial { get => cantMaterial; set => cantMaterial = value; }
        public int CodProducto { get => codProducto; set => codProducto = value; }
        public int CantProducto { get => cantProducto; set => cantProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string EstadoCliente { get => estadoCliente; set => estadoCliente = value; }
        public int CodViaje { get => codViaje; set => codViaje = value; }
    }
}
