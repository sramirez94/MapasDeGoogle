using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET; //24/09/2019 Salvador R.L. Libreria principal de GMap
using GMap.NET.MapProviders; //24/09/2019 Salvador R.L. Proveedor de mapas
using GMap.NET.WindowsForms; //24/09/2019 Salvador R.L. Windows forms para mapas
using GMap.NET.WindowsForms.Markers; //24/09/2019 Salvador R.L. Marcadores
namespace MapasDeGoogle
{
    public partial class Form1 : Form
    {
        GMarkerGoogle marker; //2019/09/2019 Salvador R.L. Objeto marcador
        GMapOverlay markeroverlay; //2019/09/2019 Salvador R.L. Marcador overlay
        DataTable dt; //2019/09/2019 Salvador R.L. Datatable para ir almacenando momentaneamente las coordenadas
        int filaseleccionada = 0; //2019/09/2019 Salvador R.L. Variable para guardar la fila seleccionada y se inicializa en 0
        double latinicial = 19.521313; //2019/09/2019 Salvador R.L. Latitud inicial inicializada (Puede ser cualquiera)
        double longinicial = -96.923349; //2019/09/2019 Salvador R.L. Longitud inicial
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gMapControl1.DragButton = MouseButtons.Left; //2019/09/2019 Salvador R.L. Usará botón izquierdo
            this.gMapControl1.CanDragMap = true; //2019/09/2019 Salvador R.L. Dibujo del mapa
            this.gMapControl1.MapProvider = GMapProviders.GoogleMap; //2019/09/2019 Salvador R.L. El proveedor del mapa será google maps
            this.gMapControl1.Position = new PointLatLng(latinicial, longinicial); //2019/09/2019 Salvador R.L. Al cargar mostrará latitud y longitud inicial
            this.gMapControl1.MinZoom = 0; //2019/09/2019 Salvador R.L. El zoom será de 0 como mínimo
            this.gMapControl1.MaxZoom = 24; //2019/09/2019 Salvador R.L. El máximo zoom es de 24 pixeles
            this.gMapControl1.Zoom = 9; //2019/09/2019 Salvador R.L. Zoom por defecto
            this.gMapControl1.AutoScroll = true; //2019/09/2019 Salvador R.L. Permitirá autoscroll
        }
    }
}
