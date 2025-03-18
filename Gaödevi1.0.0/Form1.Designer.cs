namespace Gaödevi1._0._0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.txtElitismRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chartConvergence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Location = new System.Drawing.Point(208, 38);
            this.txtPopulationSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(100, 22);
            this.txtPopulationSize.TabIndex = 0;
            // 
            // txtCrossoverRate
            // 
            this.txtCrossoverRate.Location = new System.Drawing.Point(208, 79);
            this.txtCrossoverRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(100, 22);
            this.txtCrossoverRate.TabIndex = 1;
           
            // 
            // txtMutationRate
            // 
            this.txtMutationRate.Location = new System.Drawing.Point(208, 123);
            this.txtMutationRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(100, 22);
            this.txtMutationRate.TabIndex = 2;
            // 
            // txtGenerations
            // 
            this.txtGenerations.Location = new System.Drawing.Point(208, 164);
            this.txtGenerations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(100, 22);
            this.txtGenerations.TabIndex = 3;
            // 
            // txtElitismRate
            // 
            this.txtElitismRate.Location = new System.Drawing.Point(208, 214);
            this.txtElitismRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtElitismRate.Name = "txtElitismRate";
            this.txtElitismRate.Size = new System.Drawing.Size(100, 22);
            this.txtElitismRate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "populasyon boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "çaprazlama oranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "mutasyon oranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "jenerasyon Sayısı";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(205, 366);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 9;
           
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "seçkinlik oranı";
            // 
            // chartConvergence
            // 
            chartArea3.Name = "ChartArea1";
            this.chartConvergence.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartConvergence.Legends.Add(legend3);
            this.chartConvergence.Location = new System.Drawing.Point(344, 38);
            this.chartConvergence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartConvergence.Name = "chartConvergence";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartConvergence.Series.Add(series3);
            this.chartConvergence.Size = new System.Drawing.Size(376, 369);
            this.chartConvergence.TabIndex = 12;
            this.chartConvergence.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.chartConvergence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElitismRate);
            this.Controls.Add(this.txtGenerations);
            this.Controls.Add(this.txtMutationRate);
            this.Controls.Add(this.txtCrossoverRate);
            this.Controls.Add(this.txtPopulationSize);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
           
            ((System.ComponentModel.ISupportInitialize)(this.chartConvergence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.TextBox txtCrossoverRate;
        private System.Windows.Forms.TextBox txtMutationRate;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.TextBox txtElitismRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConvergence;
    }
}

