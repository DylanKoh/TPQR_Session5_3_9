namespace TPQR_Session5_3_9
{
    partial class AnalyzeResults
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSkill = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBestCountry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEasiest = new System.Windows.Forms.Label();
            this.lblToughest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            this.pbRedDown = new System.Windows.Forms.PictureBox();
            this.pbGreenUp = new System.Windows.Forms.PictureBox();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 78);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(826, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 36);
            this.panel2.TabIndex = 4;
            // 
            // cbSkill
            // 
            this.cbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkill.FormattingEnabled = true;
            this.cbSkill.Location = new System.Drawing.Point(416, 126);
            this.cbSkill.Name = "cbSkill";
            this.cbSkill.Size = new System.Drawing.Size(219, 26);
            this.cbSkill.TabIndex = 12;
            this.cbSkill.SelectedIndexChanged += new System.EventHandler(this.cbSkill_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Skill: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(429, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Analyze Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Best Performing Country: ";
            // 
            // lblBestCountry
            // 
            this.lblBestCountry.AutoSize = true;
            this.lblBestCountry.Location = new System.Drawing.Point(416, 171);
            this.lblBestCountry.Name = "lblBestCountry";
            this.lblBestCountry.Size = new System.Drawing.Size(114, 18);
            this.lblBestCountry.TabIndex = 15;
            this.lblBestCountry.Text = "Best Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Easiest Session: ";
            // 
            // lblEasiest
            // 
            this.lblEasiest.AutoSize = true;
            this.lblEasiest.Location = new System.Drawing.Point(416, 207);
            this.lblEasiest.Name = "lblEasiest";
            this.lblEasiest.Size = new System.Drawing.Size(214, 18);
            this.lblEasiest.TabIndex = 18;
            this.lblEasiest.Text = "Session No (Mark Range)";
            // 
            // lblToughest
            // 
            this.lblToughest.AutoSize = true;
            this.lblToughest.Location = new System.Drawing.Point(416, 245);
            this.lblToughest.Name = "lblToughest";
            this.lblToughest.Size = new System.Drawing.Size(214, 18);
            this.lblToughest.TabIndex = 20;
            this.lblToughest.Text = "Session No (Mark Range)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Toughest Session: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Median Mark: ";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Location = new System.Drawing.Point(416, 285);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(18, 18);
            this.lblMedian.TabIndex = 22;
            this.lblMedian.Text = "0";
            // 
            // pbRedDown
            // 
            this.pbRedDown.Image = global::TPQR_Session5_3_9.Properties.Resources._12065697821256125215pitr_red_arrows_set_5_svg_med;
            this.pbRedDown.Location = new System.Drawing.Point(643, 275);
            this.pbRedDown.Name = "pbRedDown";
            this.pbRedDown.Size = new System.Drawing.Size(57, 50);
            this.pbRedDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRedDown.TabIndex = 24;
            this.pbRedDown.TabStop = false;
            // 
            // pbGreenUp
            // 
            this.pbGreenUp.Image = global::TPQR_Session5_3_9.Properties.Resources._41_411930_arrows_clip_art_download_up_green_arrow_png;
            this.pbGreenUp.Location = new System.Drawing.Point(547, 275);
            this.pbGreenUp.Name = "pbGreenUp";
            this.pbGreenUp.Size = new System.Drawing.Size(57, 50);
            this.pbGreenUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGreenUp.TabIndex = 23;
            this.pbGreenUp.TabStop = false;
            // 
            // pbCountry
            // 
            this.pbCountry.Location = new System.Drawing.Point(724, 146);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(200, 130);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCountry.TabIndex = 16;
            this.pbCountry.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(162, 341);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(673, 245);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // AnalyzeResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 628);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pbRedDown);
            this.Controls.Add(this.pbGreenUp);
            this.Controls.Add(this.lblMedian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblToughest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEasiest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbCountry);
            this.Controls.Add(this.lblBestCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSkill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AnalyzeResults";
            this.Text = "Analyze Results";
            this.Load += new System.EventHandler(this.AnalyzeResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbSkill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBestCountry;
        private System.Windows.Forms.PictureBox pbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEasiest;
        private System.Windows.Forms.Label lblToughest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMedian;
        private System.Windows.Forms.PictureBox pbGreenUp;
        private System.Windows.Forms.PictureBox pbRedDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}