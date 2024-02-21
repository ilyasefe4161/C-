namespace Chart_Example
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Oy_Oran = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Oy_Oran)).BeginInit();
            this.SuspendLayout();
            // 
            // Oy_Oran
            // 
            this.Oy_Oran.AccessibleName = "";
            chartArea1.Name = "ChartArea1";
            this.Oy_Oran.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Oy_Oran.Legends.Add(legend1);
            this.Oy_Oran.Location = new System.Drawing.Point(63, 37);
            this.Oy_Oran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Oy_Oran.Name = "Oy_Oran";
            this.Oy_Oran.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Oy";
            this.Oy_Oran.Series.Add(series1);
            this.Oy_Oran.Size = new System.Drawing.Size(540, 415);
            this.Oy_Oran.TabIndex = 0;
            this.Oy_Oran.Text = "Oy oranı";
            title1.Name = "Title1";
            title1.Text = "Oy Oranı";
            this.Oy_Oran.Titles.Add(title1);
            this.Oy_Oran.Click += new System.EventHandler(this.Oy_Oran_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Oy_Oran);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Oy_Oran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Oy_Oran;
    }
}

