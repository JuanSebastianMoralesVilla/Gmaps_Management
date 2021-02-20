
namespace Gmaps_Management
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txloadFile = new System.Windows.Forms.TextBox();
            this.txBoxload2 = new System.Windows.Forms.TextBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btMunicipios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txloadFile
            // 
            this.txloadFile.Location = new System.Drawing.Point(222, 22);
            this.txloadFile.Name = "txloadFile";
            this.txloadFile.Size = new System.Drawing.Size(382, 20);
            this.txloadFile.TabIndex = 1;
            // 
            // txBoxload2
            // 
            this.txBoxload2.Location = new System.Drawing.Point(222, 74);
            this.txBoxload2.Name = "txBoxload2";
            this.txBoxload2.Size = new System.Drawing.Size(382, 20);
            this.txBoxload2.TabIndex = 2;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(589, 205);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 20;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(549, 420);
            this.gMap.TabIndex = 3;
            this.gMap.Zoom = 13D;
            this.gMap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 388);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btMunicipios
            // 
            this.btMunicipios.Location = new System.Drawing.Point(998, 165);
            this.btMunicipios.Name = "btMunicipios";
            this.btMunicipios.Size = new System.Drawing.Size(140, 23);
            this.btMunicipios.TabIndex = 5;
            this.btMunicipios.Text = "Mostrar Municipios";
            this.btMunicipios.UseVisualStyleBackColor = true;
            this.btMunicipios.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 632);
            this.Controls.Add(this.btMunicipios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.txBoxload2);
            this.Controls.Add(this.txloadFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txloadFile;
        private System.Windows.Forms.TextBox txBoxload2;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btMunicipios;
    }
}

