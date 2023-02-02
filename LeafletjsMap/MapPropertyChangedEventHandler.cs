
using System;
using System.ComponentModel;
using Wisej.Core;
using Wisej.Web;

namespace LeafletjsMaps
{
	/// <summary>
	/// Represents the method that will handle the <see cref="E:LeafletjsMaps.LeafletMapMapPropertyChanged"/> event of 
	/// a <see cref="T:LeafletMap" /> control.
	/// </summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">A <see cref="T:LeafletMap.MapPropertyChangedEventArgs" /> that contains the event data. </param>
	public delegate void MapPropertyChangedEventHandler(object sender, MapPropertyChangedEventArgs e);

	/// <summary>
	/// Provides data for the <see cref="E:LeafletjsMaps.LeafletMapMapPropertyChanged" /> event.
	/// </summary>
	[ApiCategory("LeafletMap")]
	public class MapPropertyChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Initializes an instance of the <see cref="T:LeafletMap.MapPropertyChangedEventArgs" /> class.
		/// </summary>
		/// <param name="e">The event data from the client.</param>
		public MapPropertyChangedEventArgs(WidgetEventArgs e)
		{
			if (e == null)
				throw new ArgumentNullException("e");

			dynamic data = e.Data;
			this.Name = data.name;
			this.Value = data.value;

			// detect LatLng values.
			if (this.Value != null && this.Value is DynamicObject)
			{
				dynamic latlng = this.Value;
				if (latlng != null && latlng.lat != null && latlng.lng != null)
					this.Value = new LatLng(latlng.lat, latlng.lng);

				if (latlng != null && latlng.east != null && latlng.north != null && latlng.south != null && latlng.west != null)
					this.Value = new LatLngBounds(latlng.east, latlng.north, latlng.south, latlng.west);
			}
		}

		/// <summary>
		/// The name of the property that has changed.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// The new value of the property.
		/// </summary>
		public object Value { get; private set; }
	}
}
