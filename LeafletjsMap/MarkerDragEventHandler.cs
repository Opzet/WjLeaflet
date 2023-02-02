
using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace LeafletjsMaps
{
	/// <summary>
	/// Represents the method that will handle the marker drag events of a <see cref="T:LeafletjsMaps.LeafletMap" /> control.
	/// </summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">A <see cref="T:LeafletMap.MarkerDragEventArgs" /> that contains the event data. </param>
	public delegate void MarkerDragEventHandler(object sender, MarkerDragEventArgs e);

	/// <summary>
	/// Provides data for the 
	/// <see cref="E:LeafletjsMaps.LeafletMapMarkerDragStart" /> and the 
	/// <see cref="E:LeafletjsMaps.LeafletMapMarkerDragEnd" /> event.
	/// </summary>
	[ApiCategory("LeafletMap")]
	public class MarkerDragEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes an instance of the <see cref="T:LeafletMap.MarkerDragEventArgs" /> class.
		/// </summary>
		/// <param name="e">The event data from the client.</param>
		public MarkerDragEventArgs(WidgetEventArgs e)
		{
			if (e == null)
				throw new ArgumentNullException("e");

			this.Marker = e.Data.marker;
			this.Location = new LatLng(e.Data.lat ?? 0, e.Data.lng ?? 0);
			this.Position = new Point(e.Data.x ?? 0, e.Data.y ?? 0);
		}

		/// <summary>
		/// The ID of the clicked marker that was dragged.
		/// </summary>
		public string Marker { get; private set; }

		/// <summary>
		/// The coordinates of the marker.
		/// </summary>
		public LatLng Location { get; private set; }

		/// <summary>
		/// The position of the marker in pixels.
		///</summary>
		public Point Position { get; private set; }

	}
}
