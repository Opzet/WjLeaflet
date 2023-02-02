using LeafletjsMaps;

namespace MapIt
{
	partial class frmWjLeafletjs
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
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.btnAddMarker = new Wisej.Web.Button();
            this.numericUpDownMaxZoom = new Wisej.Web.NumericUpDown();
            this.txtInitScript = new Wisej.Web.TextBox();
            this.txtUserData = new Wisej.Web.TextBox();
            this.txtMapOptions = new Wisej.Web.TextBox();
            this.txtEvent = new Wisej.Web.TextBox();
            this.trackBar1 = new Wisej.Web.TrackBar();
            this.leafletMap1 = new LeafletjsMaps.LeafletMap();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.leafletMap1);
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.Text = "LeafletjsMap";
            // 
            // btnAddMarker
            // 
            this.btnAddMarker.Location = new System.Drawing.Point(251, 426);
            this.btnAddMarker.Name = "btnAddMarker";
            this.btnAddMarker.Size = new System.Drawing.Size(108, 36);
            this.btnAddMarker.TabIndex = 6;
            this.btnAddMarker.Text = "Add Marker";
            this.btnAddMarker.Click += new System.EventHandler(this.btnAddMarker_Click);
            // 
            // numericUpDownMaxZoom
            // 
            this.numericUpDownMaxZoom.LabelText = "Max Zoom ";
            this.numericUpDownMaxZoom.Location = new System.Drawing.Point(308, 483);
            this.numericUpDownMaxZoom.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numericUpDownMaxZoom.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxZoom.Name = "numericUpDownMaxZoom";
            this.numericUpDownMaxZoom.Size = new System.Drawing.Size(74, 53);
            this.numericUpDownMaxZoom.TabIndex = 9;
            this.numericUpDownMaxZoom.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            this.numericUpDownMaxZoom.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownMaxZoom.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtInitScript
            // 
            this.txtInitScript.AutoSize = false;
            this.txtInitScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInitScript.LabelText = "Init Script";
            this.txtInitScript.Location = new System.Drawing.Point(667, 3);
            this.txtInitScript.Multiline = true;
            this.txtInitScript.Name = "txtInitScript";
            this.txtInitScript.Size = new System.Drawing.Size(446, 459);
            this.txtInitScript.TabIndex = 11;
            // 
            // txtUserData
            // 
            this.txtUserData.AutoSize = false;
            this.txtUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserData.LabelText = "User Data";
            this.txtUserData.Location = new System.Drawing.Point(903, 483);
            this.txtUserData.Multiline = true;
            this.txtUserData.Name = "txtUserData";
            this.txtUserData.Size = new System.Drawing.Size(210, 161);
            this.txtUserData.TabIndex = 12;
            // 
            // txtMapOptions
            // 
            this.txtMapOptions.AutoSize = false;
            this.txtMapOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMapOptions.LabelText = "Map options";
            this.txtMapOptions.Location = new System.Drawing.Point(667, 483);
            this.txtMapOptions.Multiline = true;
            this.txtMapOptions.Name = "txtMapOptions";
            this.txtMapOptions.Size = new System.Drawing.Size(230, 161);
            this.txtMapOptions.TabIndex = 13;
            // 
            // txtEvent
            // 
            this.txtEvent.AutoSize = false;
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEvent.LabelText = "Map options";
            this.txtEvent.Location = new System.Drawing.Point(9, 412);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(214, 232);
            this.txtEvent.TabIndex = 14;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(229, 525);
            this.trackBar1.Maximum = 18;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(248, 34);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // leafletMap1
            // 
            this.leafletMap1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.leafletMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.leafletMap1.Location = new System.Drawing.Point(3, 21);
            this.leafletMap1.Name = "leafletMap1";
            this.leafletMap1.Options = "";
            this.leafletMap1.Size = new System.Drawing.Size(646, 382);
            this.leafletMap1.TabIndex = 4;
            this.leafletMap1.Text = "leafletMap1";
            this.leafletMap1.MapClick += new LeafletjsMaps.MapMouseEventHandler(this.leafletMap1_MapClick);
            this.leafletMap1.MouseMove += new Wisej.Web.MouseEventHandler(this.leafletMap1_MouseMove);
            // 
            // frmWjLeafletjs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtMapOptions);
            this.Controls.Add(this.txtUserData);
            this.Controls.Add(this.txtInitScript);
            this.Controls.Add(this.numericUpDownMaxZoom);
            this.Controls.Add(this.btnAddMarker);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmWjLeafletjs";
            this.Size = new System.Drawing.Size(2123, 1414);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.frmWjLeafletjs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private LeafletMap leafletMap1;
        private Wisej.Web.GroupBox groupBox1;
        private Wisej.Web.Button btnAddMarker;
        private Wisej.Web.NumericUpDown numericUpDownMaxZoom;
        private Wisej.Web.TextBox txtInitScript;
        private Wisej.Web.TextBox txtUserData;
        private Wisej.Web.TextBox txtMapOptions;
        private Wisej.Web.TextBox txtEvent;
        private Wisej.Web.TrackBar trackBar1;
    }
}

