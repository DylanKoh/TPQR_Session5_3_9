namespace TPQR_Session5_3_9
{
    partial class ViewResults
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSessions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSkill = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGold = new System.Windows.Forms.GroupBox();
            this.btnGold = new System.Windows.Forms.Button();
            this.pbGold2 = new System.Windows.Forms.PictureBox();
            this.pbGold1 = new System.Windows.Forms.PictureBox();
            this.gbSilver = new System.Windows.Forms.GroupBox();
            this.btnSilver = new System.Windows.Forms.Button();
            this.pbSilver2 = new System.Windows.Forms.PictureBox();
            this.pbSilver1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBronze = new System.Windows.Forms.Button();
            this.pbBronze2 = new System.Windows.Forms.PictureBox();
            this.pbBronze1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbGold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold1)).BeginInit();
            this.gbSilver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(988, 78);
            this.panel1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(787, 26);
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
            this.panel2.Location = new System.Drawing.Point(0, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 36);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(407, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "View Results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. of Sessions: ";
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Location = new System.Drawing.Point(207, 151);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(18, 18);
            this.lblSessions.TabIndex = 6;
            this.lblSessions.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "No. of Completed Sessions: ";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(754, 151);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(18, 18);
            this.lblCompleted.TabIndex = 8;
            this.lblCompleted.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Skill: ";
            // 
            // cbSkill
            // 
            this.cbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkill.FormattingEnabled = true;
            this.cbSkill.Location = new System.Drawing.Point(372, 115);
            this.cbSkill.Name = "cbSkill";
            this.cbSkill.Size = new System.Drawing.Size(219, 26);
            this.cbSkill.TabIndex = 10;
            this.cbSkill.SelectedIndexChanged += new System.EventHandler(this.cbSkill_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(527, 417);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Competitor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 124;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Country";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 96;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Marks";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 126;
            // 
            // gbGold
            // 
            this.gbGold.Controls.Add(this.btnGold);
            this.gbGold.Controls.Add(this.pbGold2);
            this.gbGold.Controls.Add(this.pbGold1);
            this.gbGold.Location = new System.Drawing.Point(545, 179);
            this.gbGold.Name = "gbGold";
            this.gbGold.Size = new System.Drawing.Size(431, 135);
            this.gbGold.TabIndex = 12;
            this.gbGold.TabStop = false;
            this.gbGold.Text = "Gold";
            // 
            // btnGold
            // 
            this.btnGold.Location = new System.Drawing.Point(151, 106);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(163, 23);
            this.btnGold.TabIndex = 2;
            this.btnGold.Text = "More Gold";
            this.btnGold.UseVisualStyleBackColor = true;
            this.btnGold.Visible = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // pbGold2
            // 
            this.pbGold2.Location = new System.Drawing.Point(259, 51);
            this.pbGold2.Name = "pbGold2";
            this.pbGold2.Size = new System.Drawing.Size(100, 50);
            this.pbGold2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGold2.TabIndex = 1;
            this.pbGold2.TabStop = false;
            // 
            // pbGold1
            // 
            this.pbGold1.Location = new System.Drawing.Point(90, 51);
            this.pbGold1.Name = "pbGold1";
            this.pbGold1.Size = new System.Drawing.Size(100, 50);
            this.pbGold1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGold1.TabIndex = 0;
            this.pbGold1.TabStop = false;
            // 
            // gbSilver
            // 
            this.gbSilver.Controls.Add(this.btnSilver);
            this.gbSilver.Controls.Add(this.pbSilver2);
            this.gbSilver.Controls.Add(this.pbSilver1);
            this.gbSilver.Location = new System.Drawing.Point(545, 320);
            this.gbSilver.Name = "gbSilver";
            this.gbSilver.Size = new System.Drawing.Size(431, 135);
            this.gbSilver.TabIndex = 13;
            this.gbSilver.TabStop = false;
            this.gbSilver.Text = "Silver";
            // 
            // btnSilver
            // 
            this.btnSilver.Location = new System.Drawing.Point(151, 106);
            this.btnSilver.Name = "btnSilver";
            this.btnSilver.Size = new System.Drawing.Size(163, 23);
            this.btnSilver.TabIndex = 3;
            this.btnSilver.Text = "More Silver";
            this.btnSilver.UseVisualStyleBackColor = true;
            this.btnSilver.Visible = false;
            this.btnSilver.Click += new System.EventHandler(this.btnSilver_Click);
            // 
            // pbSilver2
            // 
            this.pbSilver2.Location = new System.Drawing.Point(259, 53);
            this.pbSilver2.Name = "pbSilver2";
            this.pbSilver2.Size = new System.Drawing.Size(100, 50);
            this.pbSilver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSilver2.TabIndex = 2;
            this.pbSilver2.TabStop = false;
            // 
            // pbSilver1
            // 
            this.pbSilver1.Location = new System.Drawing.Point(90, 53);
            this.pbSilver1.Name = "pbSilver1";
            this.pbSilver1.Size = new System.Drawing.Size(100, 50);
            this.pbSilver1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSilver1.TabIndex = 1;
            this.pbSilver1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBronze);
            this.groupBox3.Controls.Add(this.pbBronze2);
            this.groupBox3.Controls.Add(this.pbBronze1);
            this.groupBox3.Location = new System.Drawing.Point(545, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 135);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bronze";
            // 
            // btnBronze
            // 
            this.btnBronze.Location = new System.Drawing.Point(151, 106);
            this.btnBronze.Name = "btnBronze";
            this.btnBronze.Size = new System.Drawing.Size(163, 23);
            this.btnBronze.TabIndex = 3;
            this.btnBronze.Text = "More Bronze";
            this.btnBronze.UseVisualStyleBackColor = true;
            this.btnBronze.Visible = false;
            this.btnBronze.Click += new System.EventHandler(this.btnBronze_Click);
            // 
            // pbBronze2
            // 
            this.pbBronze2.Location = new System.Drawing.Point(259, 54);
            this.pbBronze2.Name = "pbBronze2";
            this.pbBronze2.Size = new System.Drawing.Size(100, 50);
            this.pbBronze2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBronze2.TabIndex = 2;
            this.pbBronze2.TabStop = false;
            // 
            // pbBronze1
            // 
            this.pbBronze1.Location = new System.Drawing.Point(90, 54);
            this.pbBronze1.Name = "pbBronze1";
            this.pbBronze1.Size = new System.Drawing.Size(100, 50);
            this.pbBronze1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBronze1.TabIndex = 1;
            this.pbBronze1.TabStop = false;
            // 
            // ViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 638);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbSilver);
            this.Controls.Add(this.gbGold);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbSkill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSessions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ViewResults";
            this.Text = "View Results";
            this.Load += new System.EventHandler(this.ViewResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbGold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGold2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold1)).EndInit();
            this.gbSilver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSilver1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBronze1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSessions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSkill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gbGold;
        private System.Windows.Forms.GroupBox gbSilver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.PictureBox pbGold2;
        private System.Windows.Forms.PictureBox pbGold1;
        private System.Windows.Forms.Button btnSilver;
        private System.Windows.Forms.PictureBox pbSilver2;
        private System.Windows.Forms.PictureBox pbSilver1;
        private System.Windows.Forms.Button btnBronze;
        private System.Windows.Forms.PictureBox pbBronze2;
        private System.Windows.Forms.PictureBox pbBronze1;
    }
}