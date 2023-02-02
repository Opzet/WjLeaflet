using LeafletjsMaps;

namespace MapIt
{
	partial class frmWidget_Leafletjs
    {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWidget_Leafletjs));
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package2 = new Wisej.Web.Widget.Package();
            this.widget1 = new Wisej.Web.Widget();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.btnInitMap = new Wisej.Web.Button();
            this.leafletMap1 = new LeafletjsMaps.LeafletMap();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.btnMarkerAdd = new Wisej.Web.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // widget1
            // 
            this.widget1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.widget1.Dock = Wisej.Web.DockStyle.Fill;
            this.widget1.InitScript = resources.GetString("widget1.InitScript");
            this.widget1.Location = new System.Drawing.Point(3, 21);
            this.widget1.Name = "widget1";
            this.widget1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "leaflet.css";
            package1.Source = "https://unpkg.com/leaflet@1.9.3/dist/leaflet.css";
            package2.Integrity = "";
            package2.Name = "leaflet.js";
            package2.Source = "https://unpkg.com/leaflet@1.9.3/dist/leaflet.js";
            this.widget1.Packages.Add(package1);
            this.widget1.Packages.Add(package2);
            this.widget1.Size = new System.Drawing.Size(622, 404);
            this.widget1.TabIndex = 1;
            this.widget1.Text = "widget1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.widget1);
            this.groupBox2.Location = new System.Drawing.Point(623, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 428);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "LeafletJs - In Widget";
            // 
            // btnInitMap
            // 
            this.btnInitMap.Location = new System.Drawing.Point(163, 476);
            this.btnInitMap.Name = "btnInitMap";
            this.btnInitMap.Size = new System.Drawing.Size(163, 36);
            this.btnInitMap.TabIndex = 6;
            this.btnInitMap.Text = "Init Map";
            this.btnInitMap.Click += new System.EventHandler(this.btnInitMap_Click);
            // 
            // leafletMap1
            // 
            this.leafletMap1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.leafletMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.leafletMap1.Location = new System.Drawing.Point(3, 21);
            this.leafletMap1.Name = "leafletMap1";
            this.leafletMap1.Options = "";
            this.leafletMap1.Size = new System.Drawing.Size(559, 415);
            this.leafletMap1.TabIndex = 4;
            this.leafletMap1.Text = "leafletMap1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leafletMap1);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 439);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.Text = "LeafletjsMap";
            // 
            // btnMarkerAdd
            // 
            this.btnMarkerAdd.Location = new System.Drawing.Point(824, 457);
            this.btnMarkerAdd.Name = "btnMarkerAdd";
            this.btnMarkerAdd.Size = new System.Drawing.Size(163, 36);
            this.btnMarkerAdd.TabIndex = 7;
            this.btnMarkerAdd.Text = "Marker Add";
            this.btnMarkerAdd.Click += new System.EventHandler(this.btnMarkerAdd_Click);
            // 
            // frmWidget_Leafletjs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.btnMarkerAdd);
            this.Controls.Add(this.btnInitMap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmWidget_Leafletjs";
            this.Size = new System.Drawing.Size(2452, 1369);
            this.Text = "Page1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion
        private Wisej.Web.Widget widget1;
        private Wisej.Web.GroupBox groupBox2;
        private Wisej.Web.Button btnInitMap;
        private LeafletMap leafletMap1;
        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.Button btnMarkerAdd;
    }
}

