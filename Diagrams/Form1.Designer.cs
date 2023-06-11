namespace Diagrams
{
    partial class frmDiagrams
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMasGist = new System.Windows.Forms.DataGridView();
            this.btCreateMasGist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasGist = new System.Windows.Forms.TextBox();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.txtMinAge = new System.Windows.Forms.GroupBox();
            this.dgvMasRound = new System.Windows.Forms.DataGridView();
            this.btCreateMasRound = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtMasRound = new System.Windows.Forms.TextBox();
            this.btCreateGist = new System.Windows.Forms.Button();
            this.btCreateRound = new System.Windows.Forms.Button();
            this.chartDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).BeginInit();
            this.txtMinAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMasGist);
            this.groupBox1.Controls.Add(this.btCreateMasGist);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMasGist);
            this.groupBox1.Controls.Add(this.txtMinYear);
            this.groupBox1.Location = new System.Drawing.Point(631, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані для гістограми";
            // 
            // dgvMasGist
            // 
            this.dgvMasGist.AllowUserToOrderColumns = true;
            this.dgvMasGist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasGist.Location = new System.Drawing.Point(24, 101);
            this.dgvMasGist.Name = "dgvMasGist";
            this.dgvMasGist.RowHeadersWidth = 51;
            this.dgvMasGist.RowTemplate.Height = 24;
            this.dgvMasGist.Size = new System.Drawing.Size(555, 151);
            this.dgvMasGist.TabIndex = 5;
            // 
            // btCreateMasGist
            // 
            this.btCreateMasGist.Location = new System.Drawing.Point(345, 24);
            this.btCreateMasGist.Name = "btCreateMasGist";
            this.btCreateMasGist.Size = new System.Drawing.Size(234, 56);
            this.btCreateMasGist.TabIndex = 4;
            this.btCreateMasGist.Text = "Згенерувати пустий масив";
            this.btCreateMasGist.UseVisualStyleBackColor = true;
            this.btCreateMasGist.Click += new System.EventHandler(this.btCreateMasGist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть кількість років:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть навчальний рік:";
            // 
            // txtMasGist
            // 
            this.txtMasGist.Location = new System.Drawing.Point(217, 61);
            this.txtMasGist.Name = "txtMasGist";
            this.txtMasGist.Size = new System.Drawing.Size(100, 22);
            this.txtMasGist.TabIndex = 1;
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(217, 21);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(100, 22);
            this.txtMinYear.TabIndex = 0;
            // 
            // txtMinAge
            // 
            this.txtMinAge.Controls.Add(this.dgvMasRound);
            this.txtMinAge.Controls.Add(this.btCreateMasRound);
            this.txtMinAge.Controls.Add(this.label4);
            this.txtMinAge.Controls.Add(this.label3);
            this.txtMinAge.Controls.Add(this.textBox4);
            this.txtMinAge.Controls.Add(this.txtMasRound);
            this.txtMinAge.Location = new System.Drawing.Point(631, 289);
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.Size = new System.Drawing.Size(601, 234);
            this.txtMinAge.TabIndex = 1;
            this.txtMinAge.TabStop = false;
            this.txtMinAge.Text = "Дані для кругової діаграми";
            // 
            // dgvMasRound
            // 
            this.dgvMasRound.AllowUserToOrderColumns = true;
            this.dgvMasRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasRound.Location = new System.Drawing.Point(24, 96);
            this.dgvMasRound.Name = "dgvMasRound";
            this.dgvMasRound.RowHeadersWidth = 51;
            this.dgvMasRound.RowTemplate.Height = 24;
            this.dgvMasRound.Size = new System.Drawing.Size(555, 123);
            this.dgvMasRound.TabIndex = 6;
            // 
            // btCreateMasRound
            // 
            this.btCreateMasRound.Location = new System.Drawing.Point(345, 23);
            this.btCreateMasRound.Name = "btCreateMasRound";
            this.btCreateMasRound.Size = new System.Drawing.Size(234, 56);
            this.btCreateMasRound.TabIndex = 5;
            this.btCreateMasRound.Text = "Згенерувати пустий масив";
            this.btCreateMasRound.UseVisualStyleBackColor = true;
            this.btCreateMasRound.Click += new System.EventHandler(this.btCreateMasRound_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введіть мінімальний вік:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введіть кількість \r\nвікових категорій:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 3;
            // 
            // txtMasRound
            // 
            this.txtMasRound.Location = new System.Drawing.Point(217, 21);
            this.txtMasRound.Name = "txtMasRound";
            this.txtMasRound.Size = new System.Drawing.Size(100, 22);
            this.txtMasRound.TabIndex = 2;
            // 
            // btCreateGist
            // 
            this.btCreateGist.Location = new System.Drawing.Point(32, 529);
            this.btCreateGist.Name = "btCreateGist";
            this.btCreateGist.Size = new System.Drawing.Size(234, 34);
            this.btCreateGist.TabIndex = 2;
            this.btCreateGist.Text = "Побудувати гістограму";
            this.btCreateGist.UseVisualStyleBackColor = true;
            this.btCreateGist.Click += new System.EventHandler(this.btCreateGist_Click);
            // 
            // btCreateRound
            // 
            this.btCreateRound.Location = new System.Drawing.Point(370, 529);
            this.btCreateRound.Name = "btCreateRound";
            this.btCreateRound.Size = new System.Drawing.Size(234, 34);
            this.btCreateRound.TabIndex = 3;
            this.btCreateRound.Text = "Побудувати кругову діаграму";
            this.btCreateRound.UseVisualStyleBackColor = true;
            this.btCreateRound.Click += new System.EventHandler(this.btCreateRound_Click);
            // 
            // chartDiagrams
            // 
            this.chartDiagrams.BackColor = System.Drawing.Color.PeachPuff;
            this.chartDiagrams.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartDiagrams.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chartDiagrams.ChartAreas.Add(chartArea1);
            this.chartDiagrams.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            legend2.Name = "Legend2";
            legend2.Position.Auto = false;
            legend2.Position.Height = 5.686275F;
            legend2.Position.Width = 28.54641F;
            legend2.Position.X = 70.38004F;
            legend2.Position.Y = 50F;
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartDiagrams.Legends.Add(legend1);
            this.chartDiagrams.Legends.Add(legend2);
            this.chartDiagrams.Location = new System.Drawing.Point(32, 12);
            this.chartDiagrams.Name = "chartDiagrams";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Кількість учнів";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend2";
            series2.Name = "Sector";
            this.chartDiagrams.Series.Add(series1);
            this.chartDiagrams.Series.Add(series2);
            this.chartDiagrams.Size = new System.Drawing.Size(572, 511);
            this.chartDiagrams.TabIndex = 4;
            this.chartDiagrams.Text = "chart1";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(848, 529);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(146, 34);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmDiagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 575);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.chartDiagrams);
            this.Controls.Add(this.btCreateRound);
            this.Controls.Add(this.btCreateGist);
            this.Controls.Add(this.txtMinAge);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDiagrams";
            this.Text = "Діаграми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).EndInit();
            this.txtMinAge.ResumeLayout(false);
            this.txtMinAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCreateMasGist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasGist;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.GroupBox txtMinAge;
        private System.Windows.Forms.Button btCreateMasRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtMasRound;
        private System.Windows.Forms.Button btCreateGist;
        private System.Windows.Forms.Button btCreateRound;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagrams;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvMasGist;
        private System.Windows.Forms.DataGridView dgvMasRound;
    }
}

