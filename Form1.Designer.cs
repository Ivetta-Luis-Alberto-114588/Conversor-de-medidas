namespace Conversor_de_Medidas
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
            panel1 = new Panel();
            txtIngreso = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            cmbTipo = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            lstA = new ListBox();
            lstDesde = new ListBox();
            label2 = new Label();
            label4 = new Label();
            lblConversion = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtIngreso);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(94, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 57);
            panel1.TabIndex = 0;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(327, 20);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(167, 23);
            txtIngreso.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbTipo);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(94, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 56);
            panel2.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(335, 17);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(159, 23);
            cmbTipo.TabIndex = 4;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 3;
            label3.Text = "Tipo";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lstA);
            panel3.Controls.Add(lstDesde);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(101, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(573, 148);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(336, 18);
            label5.Name = "label5";
            label5.Size = new Size(25, 25);
            label5.TabIndex = 6;
            label5.Text = "A";
            // 
            // lstA
            // 
            lstA.FormattingEnabled = true;
            lstA.ItemHeight = 15;
            lstA.Location = new Point(367, 30);
            lstA.Name = "lstA";
            lstA.Size = new Size(120, 94);
            lstA.TabIndex = 5;
            // 
            // lstDesde
            // 
            lstDesde.FormattingEnabled = true;
            lstDesde.ItemHeight = 15;
            lstDesde.Location = new Point(113, 30);
            lstDesde.Name = "lstDesde";
            lstDesde.Size = new Size(120, 94);
            lstDesde.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 18);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "Desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(129, 396);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 5;
            label4.Text = "Conversion";
            // 
            // lblConversion
            // 
            lblConversion.AutoSize = true;
            lblConversion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConversion.Location = new Point(373, 9);
            lblConversion.Name = "lblConversion";
            lblConversion.Size = new Size(113, 25);
            lblConversion.TabIndex = 6;
            lblConversion.Text = "Conversion";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblConversion);
            panel4.Location = new Point(102, 386);
            panel4.Name = "panel4";
            panel4.Size = new Size(572, 52);
            panel4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Conversor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtIngreso;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label lblConversion;
        private ComboBox cmbTipo;
        private Label label5;
        private ListBox lstA;
        private ListBox lstDesde;
        private Panel panel4;
    }
}