using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Wisej.Base;
using Wisej.Core;
using Wisej.Design;
using Wisej.Web;

namespace LeafletjsMaps
{
    /// <summary>
    /// Represent an instance of the Google Maps widget.
    /// </summary>
    [ToolboxBitmap(typeof(LeafletMap))]
    [ApiCategory("LeafletMap")]
    public class LeafletMap : Widget
    {
        /// <summary>
        /// Constructs a new <see cref="T: LeafletjsMaps.LeafletMap"/> control.
        /// </summary>
        public LeafletMap()
        {

            //For leaflet you have to load CSS before .js
            /*
               this.Packages.Add(new Package()
               {
                   Name = "leaflet.css",
                   Source = @"https://unpkg.com/leaflet@1.9.3/dist/leaflet.css",
                   Integrity = "sha256-kLaT2GOSpHechhsozzB+flnD+zUyjE2LlfWPgU04xyI="
               });

               this.Packages.Add(new Package()
               {
                   Name = "leaflet.js",
                   Source = @"https://unpkg.com/leaflet@1.9.3/dist/leaflet.js",
                   Integrity = "sha256-WBkoXOwTeyKclOHuWtc+i2uENFpDZ9YPdf5Hf+D7ewM=",
               });
            */

            // 1. Load Javascript.js
            string initscript = this.BuildInitScript();

            // 2.  Initialize the loader with the required libraries.
            List<Package> pksInstalled = Packages;

            // 3. Load options
            //this.Options.zoom = 4;
            //this.Options.center = new LatLng(0, 0);
            //List to initialise


        }

        #region Events

        /// <summary>
        /// Fired when the user clicks on the map or a marker.
        /// </summary>
        public event MapMouseEventHandler MapClick
        {
            add { base.AddHandler(nameof(MapClick), value); }
            remove { base.RemoveHandler(nameof(MapClick), value); }
        }

        /// <summary>
        /// Fires the Click event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMapClick(MapMouseEventArgs e)
        {
            ((MapMouseEventHandler)base.Events[nameof(MapClick)])?.Invoke(this, e);
        }

        /// <summary>
        /// Fired when the user double clicks on the map or a marker.
        /// </summary>
        public event MapMouseEventHandler MapDoubleClick
        {
            add { base.AddHandler(nameof(MapDoubleClick), value); }
            remove { base.RemoveHandler(nameof(MapDoubleClick), value); }
        }

        /// <summary>
        /// Fires the MapDoubleClick event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMapDoubleClick(MapMouseEventArgs e)
        {
            ((MapMouseEventHandler)base.Events[nameof(MapDoubleClick)])?.Invoke(this, e);
        }

        /// <summary>
        /// Fired when the user changes the map by zooming, tilting, or selecting a different map type.
        /// </summary>
        public event MapPropertyChangedEventHandler MapPropertyChanged
        {
            add { base.AddHandler(nameof(MapPropertyChanged), value); }
            remove { base.RemoveHandler(nameof(MapPropertyChanged), value); }
        }

        /// <summary>
        /// Fires the MapPropertyChanged event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMapPropertyChanged(MapPropertyChangedEventArgs e)
        {
            ((MapPropertyChangedEventHandler)base.Events[nameof(MapPropertyChanged)])?.Invoke(this, e);
        }

        /// <summary>
        /// Fired when the user begins dragging a marker.
        /// </summary>
        public event MarkerDragEventHandler MarkerDragStart
        {
            add { base.AddHandler(nameof(MarkerDragStart), value); }
            remove { base.RemoveHandler(nameof(MarkerDragStart), value); }
        }

        /// <summary>
        /// Fires the MarkerDragStart event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMarkerDragStart(MarkerDragEventArgs e)
        {
            ((MarkerDragEventHandler)base.Events[nameof(MarkerDragStart)])?.Invoke(this, e);
        }

        /// <summary>
        /// Fired when the user drags a marker.
        /// </summary>
        public event MarkerDragEventHandler MarkerDragEnd
        {
            add { base.AddHandler(nameof(MarkerDragEnd), value); }
            remove { base.RemoveHandler(nameof(MarkerDragEnd), value); }
        }

        /// <summary>
        /// Fires the MarkerDragEnd event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMarkerDragEnd(MarkerDragEventArgs e)
        {
            ((MarkerDragEventHandler)base.Events[nameof(MarkerDragEnd)])?.Invoke(this, e);
        }

        /// <summary>
        /// Fired when the user drags the map.
        /// </summary>
        public event EventHandler MapDragEnd
        {
            add { base.AddHandler(nameof(MapDragEnd), value); }
            remove { base.RemoveHandler(nameof(MapDragEnd), value); }
        }

        /// <summary>
        /// Fires the MapDragEnd event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMapDragEnd(EventArgs e)
        {
            ((EventHandler)base.Events[nameof(MapDragEnd)])?.Invoke(this, e);
        }

        /// <summary>
        /// Fired when the user starts dragging the map.
        /// </summary>
        public event EventHandler MapDragStart
        {
            add { base.AddHandler(nameof(MapDragStart), value); }
            remove { base.RemoveHandler(nameof(MapDragStart), value); }
        }

        /// <summary>
        /// Fires the MapDragStart event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnMapDragStart(EventArgs e)
        {
            ((EventHandler)base.Events[nameof(MapDragStart)])?.Invoke(this, e);
        }

        #endregion

        #region Properties
        //To Do: Copy signatures from: leaflet-src.js
        
        // e.g. @function setOptions(obj: Object, options: Object): Object
        // Merges the given properties to the `options` of the `obj` object, returning the resulting options. See `Class options`. Has an `L.setOptions` shortcut.
        // ToDO function setOptions(obj, options)

        /// <summary>
        /// Returns or sets the specified MapOptions:
        /// </summary>
        [DesignerActionList]
        [MergableProperty(false)]
        [Editor("Wisej.Design.CodeEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171",
                "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new virtual dynamic Options
        {
            get
            {
                if (this._options == null)
                    this._options = new DynamicObject();

                return this._options;
            }
            set
            {
                this._options = value;
                Update();
            }
        }

        private dynamic _options;

        /// <summary>
        /// Overridden to create our initialization script.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string InitScript
        {
            get { return BuildInitScript(); }
        }

        /// <summary>
        /// Overridden to return our list of script resources.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override List<Package> Packages
        {
            get
            {
                if (base.Packages.Count == 0)
                {
                    //// Initialize the loader with the required libraries.

                    //For leaflet you have to load CSS before .js
                    base.Packages.Add(new Package()
                    {
                        Name = "leaflet.css",
                        Source = @"https://unpkg.com/leaflet@1.9.3/dist/leaflet.css",
                        Integrity = "sha256-kLaT2GOSpHechhsozzB+flnD+zUyjE2LlfWPgU04xyI="
                    });

                    base.Packages.Add(new Package()
                    {
                        Name = "leaflet.js",
                        Source = @"https://unpkg.com/leaflet@1.9.3/dist/leaflet.js",
                        Integrity = "sha256-WBkoXOwTeyKclOHuWtc+i2uENFpDZ9YPdf5Hf+D7ewM=",
                    });
                }
                return base.Packages;
            }
        }

        
        // disable inlining or we lose the calling assembly in GetResourceString().
        [MethodImpl(MethodImplOptions.NoInlining)]
        private string BuildInitScript()
        {
            // Mark as embedded resource -> startup.js
            string script = GetResourceString("LeafletjsMap.JavaScript.startup.js");
            script = script.Replace("$options", WisejSerializer.Serialize(this.Options));

            return script;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a new marker to the map.
        /// </summary>
        /// <param name="markerId">The unique ID that identifies the marker.</param>
        /// <param name="lat">The latitude of the marker.</param>
        /// <param name="lng">The longitude of the marker.</param>
        /// <param name="options">An optional dynamic object that specifies the marker options:</param>
        /// <param name="center">True to center the map after setting the marker.</param>
        public void AddMarker(string markerId, double lat, double lng, dynamic options = null, bool center = false)
        {
            AddMarker(markerId, new LatLng(lat, lng), options, center);
        }

        /// <summary>
        /// Adds a new marker to the map.
        /// </summary>
        /// <param name="markerId">The unique ID that identifies the marker.</param>
        /// <param name="location">An instance of <see cref="T:LeafletMap.LatLng"/> than identifies the location of the marker.</param>
        /// <param name="options">An optional dynamic object that specifies the marker options:</param>
        /// <param name="center">True to center the map after setting the marker.</param>
        public void AddMarker(string markerId, LatLng location, dynamic options = null, bool center = false)
        {
            Call("addMarker", markerId, location, options, center);
        }

        /// <summary>
        /// Adds a new marker to the map.
        /// </summary>
        /// <param name="markerId">The unique ID that identifies the marker.</param>
        /// <param name="address">The address - to be geocoded - of the marker.</param>
        /// <param name="options">An optional dynamic object that specifies the marker options: </param>
        /// <param name="center">True to center the map after setting the marker.</param>
        public void AddMarker(string markerId, string address, dynamic options = null, bool center = false)
        {
            Call("addMarker", markerId, TextUtils.EscapeText(address), options, center);
        }

        /// <summary>
        /// Removes the marker.
        /// </summary>
        /// <param name="markerId">The unique ID of the marker to remove.</param>
        public void RemoveMarker(string markerId)
        {
            Call("removeMarker", markerId);
        }

        /// <summary>
        /// Removes all the markers from the map.
        /// </summary>
        public void ClearMarkers()
        {
            Call("clearMarkers");
        }

        /// <summary>
        /// Uses LeafletMap DirectionService to route and display a path between the origin and destination.
        /// See https://developers.google.com/maps/documentation/javascript/directions.
        /// </summary>
        /// <param name="origin">The latitude and longitude of the origin.</param>
        /// <param name="destination">The latitude and longitude of the destination.</param>
        /// <param name="travelMode">The type of routing requested.</param>
        public void AddRoute(LatLng origin, LatLng destination, TravelMode travelMode)
        {
            Call("addRoute", origin, destination, travelMode);
        }

        /// <summary>
        /// Uses LeafletMap DirectionService to route and display a path between the origin and destination.
        /// See https://developers.google.com/maps/documentation/javascript/directions.
        /// </summary>
        /// <param name="origin">The name of the origin.</param>
        /// <param name="destination">The name of the destination.</param>
        /// <param name="travelMode">The type of routing requested.</param>
        public void AddRoute(string origin, string destination, TravelMode travelMode)
        {
            Call("addRoute", origin, destination, travelMode);
        }

        /// <summary>
        /// Clears any routes, if they exist.
        /// </summary>
        public void ClearRoutes()
        {
            Call("clearRoutes");
        }

        /// <summary>
        /// Centers the map at the specified location.
        /// </summary>
        /// <param name="lat">The latitude of the center of the map.</param>
        /// <param name="lng">The longitude of the center of the map.</param>
        public void CenterMap(double lat, double lng)
        {
            CenterMap(new LatLng(lat, lng));
        }

        /// <summary>
        /// Centers the map at the specified location.
        /// </summary>
        /// <param name="location">An instance of <see cref="T:LeafletMap.LatLng"/> than identifies the center of the map.</param>
        public void CenterMap(LatLng location)
        {
            Call("centerMap", location);
        }

        /// <summary>
        /// Centers the map at the specified address.
        /// </summary>
        /// <param name="address">The address - to be geocoded - of the new center of the map.</param>
        public void CenterMap(string address)
        {
            Call("centerMap", address);
        }

        /// <summary>
        /// Centers the map around a set of coordinates.
        /// </summary>
        /// <param name="coordinates"></param>
        public void FitBounds(params LatLng[] coordinates)
        {
            Call("fitBounds", coordinates);
        }

        /// <summary>
        /// Shows an instance of the google.maps.InfoWindow class in relation to the marker.
        /// </summary>
        /// <param name="markerId">The marker unique ID.</param>
        /// <param name="html">HTML content to display in the info window.</param>
        public void ShowInfoWindow(string markerId, string html)
        {
            Call("showInfoWindow", markerId, new { content = TextUtils.EscapeText(html, true) });
        }

        /// <summary>
        /// Shows an instance of the google.maps.InfoWindow class in relation to the marker.
        /// </summary>
        /// <param name="markerId">The marker unique ID.</param>
        /// <param name="options">Options for the creation of the InfoWindow.</param>
        public void ShowInfoWindow(string markerId, object options)
        {
            Call("showInfoWindow", markerId, options);
        }

        /// <summary>
        /// Closes the google.maps.InfoWindow related to the specified marker.
        /// </summary>
        /// <param name="markerId">The marker unique ID.</param>
        public void CloseInfoWindow(string markerId)
        {
            Call("closeInfoWindow", markerId);
        }

        #endregion

        #region Wisej Implementation

        /// <summary>
        /// Handles events fired by the widget.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnWidgetEvent(WidgetEventArgs e)
        {
            switch (e.Type)
            {
                case "click":  //Mapclick
                case "rightclick":
                    // latlng 
                    OnMapClick(new MapMouseEventArgs(e));
                    break;

                case "dblclick":
                    OnMapDoubleClick(new MapMouseEventArgs(e));
                    break;

                case "propertychanged":
                    OnMapPropertyChanged(new MapPropertyChangedEventArgs(e));
                    break;

                case "markerdragstart":
                    OnMarkerDragStart(new MarkerDragEventArgs(e));
                    break;

                case "markerdragend":
                    OnMarkerDragEnd(new MarkerDragEventArgs(e));
                    break;

                case "mapdragstart":
                    OnMapDragStart(EventArgs.Empty);
                    break;

                case "mapdragend":
                    OnMapDragEnd(EventArgs.Empty);
                    break;

                default:
                    base.OnWidgetEvent(e);
                    break;
            }
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LeafletMap
            // 
            this.Name = "LeafletMap";
            this.Size = new System.Drawing.Size(307, 208);
            this.ResumeLayout(false);

        }
    }
}
