
using System;
using System.ComponentModel;
using System.Diagnostics;
using Wisej.Web;

namespace LeafletjsMaps
{
	/// <summary>
	/// Represents the method that will handle the mouse events of a <see cref="T:LeafletjsMaps.LeafletMap" /> control.
	/// </summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">A <see cref="T:LeafletMap.MouseEventArgs" /> that contains the event data. </param>
	public delegate void MapMouseEventHandler(object sender, MapMouseEventArgs e);

	/// <summary>
	/// Provides data for the <see cref="E:LeafletjsMaps.LeafletMapMapClick" /> and the <see cref="E:LeafletjsMaps.LeafletMapMapDoubleClick" /> event.
	/// </summary>
	[ApiCategory("LeafletMap")]
	public class MapMouseEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes an instance of the <see cref="T:LeafletMap.MouseEventArgs" /> class.
		/// </summary>
		/// <param name="e">The event data from the client.</param>
		public MapMouseEventArgs(WidgetEventArgs e)
		{
			if (e == null)
				throw new ArgumentNullException("e");

            //To Do : rightclick lat lon passing back as 0
            // Fix -> {{"lat":0,"lng":0}} on mouse click

            this.Marker = e.Data.marker;
			this.Location = new LatLng(e.Data.lat, e.Data.lng);
			this.Button = e.Type == "rightclick" ? MouseButtons.Right : MouseButtons.Left;
		}

		/// <summary>
		/// The ID of the clicked marker. Null if the click landed on the map outside of a marker.
		/// </summary>
		public string Marker { get; private set; }

		/// <summary>
		/// The coordinates of  the click.
		/// </summary>
		public LatLng Location { get; private set; }

		/// <summary>
		/// Returns which mouse button was pressed.
		///</summary>
		/// <returns>One of the <see cref="T:Wisej.Web.MouseButtons" /> values.</returns>
		public MouseButtons Button { get; private set; }

	}
}
