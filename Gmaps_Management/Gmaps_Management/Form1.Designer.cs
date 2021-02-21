
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
            this.btClear = new System.Windows.Forms.Button();
            this.cbFilter1 = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.btMunicipios = new System.Windows.Forms.Button();
            this.tb_menor = new System.Windows.Forms.TextBox();
            this.tb_mayor = new System.Windows.Forms.TextBox();
            this.menorLabel = new System.Windows.Forms.Label();
            this.mayorLabel = new System.Windows.Forms.Label();
            this.search_range = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 32);
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
            this.dataGridView1.Size = new System.Drawing.Size(501, 420);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(645, 163);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Limpiar";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbFilter1
            // 
            this.cbFilter1.FormattingEnabled = true;
            this.cbFilter1.Items.AddRange(new object[] {
            "1.Categorico",
            "2.Cadena",
            "3.Numerico"});
            this.cbFilter1.Location = new System.Drawing.Point(60, 124);
            this.cbFilter1.Name = "cbFilter1";
            this.cbFilter1.Size = new System.Drawing.Size(186, 21);
            this.cbFilter1.TabIndex = 7;
            this.cbFilter1.SelectedIndexChanged += new System.EventHandler(this.cbFilter1_SelectedIndexChanged);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(60, 166);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(186, 21);
            this.cbCategories.TabIndex = 8;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(267, 166);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 10;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btMunicipios
            // 
            this.btMunicipios.Location = new System.Drawing.Point(848, 163);
            this.btMunicipios.Name = "btMunicipios";
            this.btMunicipios.Size = new System.Drawing.Size(140, 23);
            this.btMunicipios.TabIndex = 5;
            this.btMunicipios.Text = "Mostrar Municipios";
            this.btMunicipios.UseVisualStyleBackColor = true;
            this.btMunicipios.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_menor
            // 
            this.tb_menor.AccessibleDescription = "";
            this.tb_menor.Location = new System.Drawing.Point(60, 167);
            this.tb_menor.Name = "tb_menor";
            this.tb_menor.Size = new System.Drawing.Size(70, 20);
            this.tb_menor.TabIndex = 11;
            this.tb_menor.Visible = false;
            this.tb_menor.TextChanged += new System.EventHandler(this.menorValue_TextChanged);
            // 
            // tb_mayor
            // 
            this.tb_mayor.Location = new System.Drawing.Point(181, 167);
            this.tb_mayor.Name = "tb_mayor";
            this.tb_mayor.Size = new System.Drawing.Size(65, 20);
            this.tb_mayor.TabIndex = 12;
            this.tb_mayor.Visible = false;
            // 
            // menorLabel
            // 
            this.menorLabel.AutoSize = true;
            this.menorLabel.Location = new System.Drawing.Point(19, 171);
            this.menorLabel.Name = "menorLabel";
            this.menorLabel.Size = new System.Drawing.Size(39, 13);
            this.menorLabel.TabIndex = 14;
            this.menorLabel.Text = "menor:";
            this.menorLabel.Visible = false;
            this.menorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mayorLabel
            // 
            this.mayorLabel.AutoSize = true;
            this.mayorLabel.Location = new System.Drawing.Point(137, 170);
            this.mayorLabel.Name = "mayorLabel";
            this.mayorLabel.Size = new System.Drawing.Size(38, 13);
            this.mayorLabel.TabIndex = 15;
            this.mayorLabel.Text = "mayor:";
            this.mayorLabel.Visible = false;
            this.mayorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // search_range
            // 
            this.search_range.Location = new System.Drawing.Point(267, 165);
            this.search_range.Name = "search_range";
            this.search_range.Size = new System.Drawing.Size(75, 23);
            this.search_range.TabIndex = 16;
            this.search_range.Text = "search";
            this.search_range.UseVisualStyleBackColor = true;
            this.search_range.Visible = false;
            this.search_range.Click += new System.EventHandler(this.search_range_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 654);
            this.Controls.Add(this.search_range);
            this.Controls.Add(this.mayorLabel);
            this.Controls.Add(this.menorLabel);
            this.Controls.Add(this.tb_mayor);
            this.Controls.Add(this.tb_menor);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbFilter1);
            this.Controls.Add(this.btClear);
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
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox cbFilter1;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button btMunicipios;
        private System.Windows.Forms.TextBox tb_menor;
        private System.Windows.Forms.TextBox tb_mayor;
        private System.Windows.Forms.Label menorLabel;
        private System.Windows.Forms.Label mayorLabel;
        private System.Windows.Forms.Button search_range;
    }
}

