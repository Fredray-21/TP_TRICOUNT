﻿namespace TP_TRICOUNT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDepense = new System.Windows.Forms.TabPage();
            this.DataGVdepense = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDep = new System.Windows.Forms.Label();
            this.lblCoutTotal = new System.Windows.Forms.Label();
            this.titleLBLtotalDepense = new System.Windows.Forms.Label();
            this.titleLBLcoutTotal = new System.Windows.Forms.Label();
            this.tabEquilibres = new System.Windows.Forms.TabPage();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabDepense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVdepense)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDepense);
            this.tabControl.Controls.Add(this.tabEquilibres);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(777, 497);
            this.tabControl.TabIndex = 0;
            // 
            // tabDepense
            // 
            this.tabDepense.Controls.Add(this.label2);
            this.tabDepense.Controls.Add(this.label1);
            this.tabDepense.Controls.Add(this.DataGVdepense);
            this.tabDepense.Controls.Add(this.lblTotalDep);
            this.tabDepense.Controls.Add(this.lblCoutTotal);
            this.tabDepense.Controls.Add(this.titleLBLtotalDepense);
            this.tabDepense.Controls.Add(this.titleLBLcoutTotal);
            this.tabDepense.Location = new System.Drawing.Point(4, 26);
            this.tabDepense.Name = "tabDepense";
            this.tabDepense.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepense.Size = new System.Drawing.Size(769, 467);
            this.tabDepense.TabIndex = 0;
            this.tabDepense.Text = "DÉPENSES";
            this.tabDepense.UseVisualStyleBackColor = true;
            // 
            // DataGVdepense
            // 
            this.DataGVdepense.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataGVdepense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGVdepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVdepense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.payeur,
            this.date,
            this.montant});
            this.DataGVdepense.Location = new System.Drawing.Point(10, 6);
            this.DataGVdepense.MultiSelect = false;
            this.DataGVdepense.Name = "DataGVdepense";
            this.DataGVdepense.RowHeadersWidth = 43;
            this.DataGVdepense.RowTemplate.Height = 27;
            this.DataGVdepense.Size = new System.Drawing.Size(511, 313);
            this.DataGVdepense.TabIndex = 5;
            this.DataGVdepense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVdepense_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // payeur
            // 
            this.payeur.HeaderText = "Payer par";
            this.payeur.Name = "payeur";
            this.payeur.Width = 105;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 105;
            // 
            // montant
            // 
            this.montant.HeaderText = "Montant";
            this.montant.Name = "montant";
            this.montant.Width = 105;
            // 
            // lblTotalDep
            // 
            this.lblTotalDep.AutoSize = true;
            this.lblTotalDep.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDep.Location = new System.Drawing.Point(164, 371);
            this.lblTotalDep.Name = "lblTotalDep";
            this.lblTotalDep.Size = new System.Drawing.Size(44, 19);
            this.lblTotalDep.TabIndex = 4;
            this.lblTotalDep.Text = "00,00";
            // 
            // lblCoutTotal
            // 
            this.lblCoutTotal.AutoSize = true;
            this.lblCoutTotal.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCoutTotal.Location = new System.Drawing.Point(10, 371);
            this.lblCoutTotal.Name = "lblCoutTotal";
            this.lblCoutTotal.Size = new System.Drawing.Size(44, 19);
            this.lblCoutTotal.TabIndex = 3;
            this.lblCoutTotal.Text = "00,00";
            // 
            // titleLBLtotalDepense
            // 
            this.titleLBLtotalDepense.AutoSize = true;
            this.titleLBLtotalDepense.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLBLtotalDepense.Location = new System.Drawing.Point(164, 339);
            this.titleLBLtotalDepense.Name = "titleLBLtotalDepense";
            this.titleLBLtotalDepense.Size = new System.Drawing.Size(124, 23);
            this.titleLBLtotalDepense.TabIndex = 2;
            this.titleLBLtotalDepense.Text = "Total Dépenses";
            // 
            // titleLBLcoutTotal
            // 
            this.titleLBLcoutTotal.AutoSize = true;
            this.titleLBLcoutTotal.Font = new System.Drawing.Font("Segoe UI", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLBLcoutTotal.Location = new System.Drawing.Point(10, 339);
            this.titleLBLcoutTotal.Name = "titleLBLcoutTotal";
            this.titleLBLcoutTotal.Size = new System.Drawing.Size(128, 23);
            this.titleLBLcoutTotal.TabIndex = 1;
            this.titleLBLcoutTotal.Text = "Mon Coût Total";
            // 
            // tabEquilibres
            // 
            this.tabEquilibres.Location = new System.Drawing.Point(4, 26);
            this.tabEquilibres.Name = "tabEquilibres";
            this.tabEquilibres.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquilibres.Size = new System.Drawing.Size(769, 467);
            this.tabEquilibres.TabIndex = 1;
            this.tabEquilibres.Text = "ÉQUILIBRES";
            this.tabEquilibres.UseVisualStyleBackColor = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 105;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(214, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabDepense.ResumeLayout(false);
            this.tabDepense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVdepense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabDepense;
        private TabPage tabEquilibres;
        private Label titleLBLcoutTotal;
        private Label lblTotalDep;
        private Label lblCoutTotal;
        private Label titleLBLtotalDepense;
        private DataGridView DataGVdepense;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn payeur;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn montant;
        private Label label2;
        private Label label1;
    }
}