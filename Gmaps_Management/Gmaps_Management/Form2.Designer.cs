
namespace Gmaps_Management
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraphicBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pointChar3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Graficas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphicBar
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphicBar.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.GraphicBar.Legends.Add(legend1);
            this.GraphicBar.Location = new System.Drawing.Point(0, 175);
            this.GraphicBar.Name = "GraphicBar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraphicBar.Series.Add(series1);
            this.GraphicBar.Size = new System.Drawing.Size(300, 300);
            this.GraphicBar.TabIndex = 0;
            this.GraphicBar.Text = "chart1";
            this.GraphicBar.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pointChar3
            // 
            chartArea2.Name = "ChartArea1";
            this.pointChar3.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.pointChar3.Legends.Add(legend2);
            this.pointChar3.Location = new System.Drawing.Point(678, 175);
            this.pointChar3.Name = "pointChar3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pointChar3.Series.Add(series2);
            this.pointChar3.Size = new System.Drawing.Size(300, 300);
            this.pointChar3.TabIndex = 1;
            this.pointChar3.Text = "chart2";
            // 
            // PieChart
            // 
            this.PieChart.CausesValidation = false;
            chartArea3.Name = "ChartArea3";
            this.PieChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend3";
            this.PieChart.Legends.Add(legend3);
            this.PieChart.Location = new System.Drawing.Point(345, 175);
            this.PieChart.Name = "PieChart";
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend3";
            series3.Name = "Series3";
            this.PieChart.Series.Add(series3);
            this.PieChart.Size = new System.Drawing.Size(300, 300);
            this.PieChart.TabIndex = 2;
            this.PieChart.Text = "chart3";
            this.PieChart.Click += new System.EventHandler(this.PieChart_Click);
            // 
            // Graficas
            // 
            this.Graficas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Graficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graficas.Location = new System.Drawing.Point(12, 25);
            this.Graficas.Name = "Graficas";
            this.Graficas.Size = new System.Drawing.Size(300, 68);
            this.Graficas.TabIndex = 3;
            this.Graficas.Text = "Graficas equipo covip";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 610);
            this.Controls.Add(this.Graficas);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.pointChar3);
            this.Controls.Add(this.GraphicBar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraphicBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointChar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraphicBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart pointChar3;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.Label Graficas;
    }
}