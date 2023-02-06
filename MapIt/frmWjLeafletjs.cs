
using System;
using LeafletjsMaps;
using Wisej.Web;

namespace MapIt
{
	public partial class frmWjLeafletjs : Page
	{
		public frmWjLeafletjs()
		{
			InitializeComponent();
		}

        private void frmWjLeafletjs_Load(object sender, EventArgs e)
        {
            //Causes load of 2 base packages
            var packages = leafletMap1.Packages;

            //Causes buildInitscript to be called 
            txtInitScript.Text = leafletMap1.InitScript;

            txtMapOptions.Text = Convert.ToString(leafletMap1.Options);
            txtUserData.Text = Convert.ToString(leafletMap1.UserData);


            //leafletMap1.Options.attributionControl = false;

           // this.trackBar1.Value = leafletMap1.Options.zoom;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //To Do: Not implemented yet
            this.leafletMap1.Options.zoom = this.numericUpDownMaxZoom.Value;
            this.leafletMap1.Update();

        }

        int eventCounter = 1;
        private void leafletMap1_WidgetEvent(object sender, WidgetEventArgs e)
        {
            txtEvent.Text += "WidgetEvent: {eventCounter++}\r\n";
        }

        private void btnAddMarker_Click(object sender, EventArgs e)
        {

            leafletMap1.AddMarker("MarkerId", 51.5, -0.09,null,true);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // To Do: Not working

            //leafletMap1.Options.zoom = this.trackBar1.Value.ToString();
            leafletMap1.Update();
        }

        private void leafletMap1_MapClick(object sender, MapMouseEventArgs e)
        {
            
            // To Do : MapMouseEventArgs not bubbling up, always shows as Lat:0 , Lon:0 ?
            // Works in VsCode?

            if (e.Marker == null)
                AlertBox.Show("You clicked location: " + e.Location.ToString());
            else
                AlertBox.Show("You clicked marker: " + e.Marker + "  at location: " + e.Location.ToString());


            //Note: Flyto does a nice move
        }

        private void leafletMap1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
