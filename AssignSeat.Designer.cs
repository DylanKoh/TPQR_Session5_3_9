namespace TPQR_Session5_3_9
{
    partial class AssignSeat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSkill = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCompetitors = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(952, 69);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 18);
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
            this.label1.Location = new System.Drawing.Point(751, 22);
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
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 58);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(394, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assign Seating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Skill: ";
            // 
            // cbSkill
            // 
            this.cbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkill.FormattingEnabled = true;
            this.cbSkill.Location = new System.Drawing.Point(368, 111);
            this.cbSkill.Name = "cbSkill";
            this.cbSkill.Size = new System.Drawing.Size(260, 26);
            this.cbSkill.TabIndex = 6;
            this.cbSkill.SelectedIndexChanged += new System.EventHandler(this.cbSkill_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(26, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(298, 288);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 5;
            // 
            // lbCompetitors
            // 
            this.lbCompetitors.FormattingEnabled = true;
            this.lbCompetitors.ItemHeight = 18;
            this.lbCompetitors.Location = new System.Drawing.Point(570, 231);
            this.lbCompetitors.Name = "lbCompetitors";
            this.lbCompetitors.Size = new System.Drawing.Size(283, 166);
            this.lbCompetitors.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned Competitors: ";
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Location = new System.Drawing.Point(230, 160);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(18, 18);
            this.lblAssigned.TabIndex = 10;
            this.lblAssigned.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unassigned Competitors: ";
            // 
            // lblUnassigned
            // 
            this.lblUnassigned.AutoSize = true;
            this.lblUnassigned.Location = new System.Drawing.Point(795, 160);
            this.lblUnassigned.Name = "lblUnassigned";
            this.lblUnassigned.Size = new System.Drawing.Size(18, 18);
            this.lblUnassigned.TabIndex = 12;
            this.lblUnassigned.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unassigned";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(570, 403);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(135, 50);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Randomly Assign";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(570, 469);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(135, 50);
            this.btnSwap.TabIndex = 15;
            this.btnSwap.Text = "Swap Seats";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(718, 403);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(135, 50);
            this.btnManual.TabIndex = 16;
            this.btnManual.Text = "Manually Assign";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(718, 469);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 50);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // AssignSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUnassigned);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCompetitors);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbSkill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AssignSeat";
            this.Text = "Assign Seat";
            this.Load += new System.EventHandler(this.AssignSeat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox cbSkill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbCompetitors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUnassigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}