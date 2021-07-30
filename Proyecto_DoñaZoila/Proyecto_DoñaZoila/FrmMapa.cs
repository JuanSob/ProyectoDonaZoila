using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Proyecto_DoñaZoila
{
    public partial class FrmMapa : Form
    {
        //Variables globales
        GMarkerGoogle marker;
        GMapOverlay mapOverlay;
        DataTable dt;

        //Ruta automatizada
        Boolean trazarRuta = false;
        int contadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;

        double latInicial = 14.0729519560881;
        double lonInicial = -87.1639421582222;

        public FrmMapa()
        {
            InitializeComponent();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMapa_Load(object sender, EventArgs e)
        {
            //Configuracion del datagrid

            //dgvMapa.Columns.Add(new DataColumn("Descripcion",typeof(string)));
            //dgvMapa.Columns.Add(new DataColumn("Lat",typeof(string)));
            //dgvMapa.Columns.Add(new DataColumn("Long",typeof(string)));

            //Insertar datos al datagrid
            dgvMapa.Rows.Add("Local Doña Zoila", latInicial, lonInicial);
            dgvMapa.Columns[1].Visible = false; //no se ve en el dgv
            dgvMapa.Columns[2].Visible = true; //no se ve en el dgv


            //Vista configuración
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial,lonInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            mapOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lonInicial), GMarkerGoogleType.green);
            mapOverlay.Markers.Add(marker); //Agregamos al mapa

            //Agregamos un tooltip de tecto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("ubicación: \n latitud: {0} \n Longitud: {1}", latInicial, lonInicial);

            //Configuracion del mapa y el control
            gMapControl1.Overlays.Add(mapOverlay);
        }

        private void dgvMapa_MouseClick(object sender, MouseEventArgs e)
        {
            //Pasa los datos del data grid al textbox
            txtDescripcion.Text = dgvMapa.Rows[dgvMapa.CurrentRow.Index].Cells[0].Value.ToString();
            txtLatitud.Text = dgvMapa.Rows[dgvMapa.CurrentRow.Index].Cells[1].Value.ToString();
            txtLongitud.Text = dgvMapa.Rows[dgvMapa.CurrentRow.Index].Cells[2].Value.ToString();

            //Los valores del data grid al marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));

            //Le mapa se posiciona en el marcador
            gMapControl1.Position = marker.Position;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Se obtienen los datos de latitud y longitud donde se le da click

            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lon = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //Se posicionan en el txt de la latitud y longitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lon.ToString();

            //Se mueve el marcador en donde se dio doble click
            marker.Position = new PointLatLng(lat, lon);

            //Agregar el mensaje al marcador
            marker.ToolTipText = string.Format("ubicación: \n latitud: {0} \n Longitud: {1}", lat, lon);

            CrearDireccionTrazarRuta(lat, lon);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvMapa.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvMapa.Rows.RemoveAt(dgvMapa.CurrentRow.Index);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay Ruta = new GMapOverlay("CapaRuta");
            List<PointLatLng> puntos = new List<PointLatLng>();

            double lng, lat;

            //Variable para almacenar los datos
            for(int filas = 0; filas < dgvMapa.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dgvMapa.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dgvMapa.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);

            //Actualizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

        private void btnLLegar_Click(object sender, EventArgs e)
        {
            trazarRuta = true;
            btnLLegar.Enabled = false;
        }

        public void CrearDireccionTrazarRuta(double lat, double lng)
        {
            if(trazarRuta)
            {
                switch(contadorIndicadoresRuta)
                {
                    case 0: //Primer marcador o inicio
                        contadorIndicadoresRuta++;
                        inicio = new PointLatLng(lat, lng);
                        break;
                    case 1: //Segundo marcador o final
                        final = new PointLatLng(lat, lng);
                        GDirections direccion;

                        var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion,inicio,final,false,false,false,false,false);
                        GMapRoute RutaObtenida = new GMapRoute(direccion.Route, "Ruta Ubicación");
                        GMapOverlay CapaRutas = new GMapOverlay("Capa de la ruta");
                        CapaRutas.Routes.Add(RutaObtenida);
                        gMapControl1.Overlays.Add(CapaRutas);
                        gMapControl1.Zoom = +1;
                        gMapControl1.Zoom = -1;
                        contadorIndicadoresRuta = 0;
                        trazarRuta = false;
                        btnLLegar.Enabled = true;


                        break;
                }
            }
        }
    }
}
