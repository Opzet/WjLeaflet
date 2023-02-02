
using System.ComponentModel;

namespace LeafletjsMaps
{
	/// <summary>
	/// Indicates additional data about the specified location.
	/// </summary>
	[ApiCategory("LeafletMap")]
	public enum TravelMode
    {
        /// <summary>
        /// Specifies a bicycling directions request.
        /// </summary>
        Bicycling,

        /// <summary>
        /// Specifies a driving directions request.
        /// </summary>
        Driving,

        /// <summary>
        /// Specifies a transit directions request.
        /// </summary>
        Transit,

        /// <summary>
        /// Specifies a walking directions request.
        /// </summary>
        Walking
    }
}