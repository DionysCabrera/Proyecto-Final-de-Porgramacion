namespace CalculadorNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxHoras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LMontoTotal = new System.Windows.Forms.Label();
            this.LHorasTotal = new System.Windows.Forms.Label();
            this.LMontoTriple = new System.Windows.Forms.Label();
            this.LHorasTriples = new System.Windows.Forms.Label();
            this.LMontoDoble = new System.Windows.Forms.Label();
            this.LHorasDoble = new System.Windows.Forms.Label();
            this.LMontoNormal = new System.Windows.Forms.Label();
            this.LHoras = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 119);
            this.panel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 292);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnCalcular);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TxHoras);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TxSalario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(298, 208);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(210, 41);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular Pago";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Horas Trabajadas";
            // 
            // TxHoras
            // 
            this.TxHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxHoras.Location = new System.Drawing.Point(298, 146);
            this.TxHoras.Name = "TxHoras";
            this.TxHoras.Size = new System.Drawing.Size(215, 31);
            this.TxHoras.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salario";
            // 
            // TxSalario
            // 
            this.TxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSalario.Location = new System.Drawing.Point(298, 82);
            this.TxSalario.Name = "TxSalario";
            this.TxSalario.Size = new System.Drawing.Size(215, 31);
            this.TxSalario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // TxNombre
            // 
            this.TxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombre.Location = new System.Drawing.Point(298, 18);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(215, 31);
            this.TxNombre.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.LNombre);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.LMontoTotal);
            this.tabPage2.Controls.Add(this.LHorasTotal);
            this.tabPage2.Controls.Add(this.LMontoTriple);
            this.tabPage2.Controls.Add(this.LHorasTriples);
            this.tabPage2.Controls.Add(this.LMontoDoble);
            this.tabPage2.Controls.Add(this.LHorasDoble);
            this.tabPage2.Controls.Add(this.LMontoNormal);
            this.tabPage2.Controls.Add(this.LHoras);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(21, 182);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(79, 24);
            this.LNombre.TabIndex = 15;
            this.LNombre.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(25, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 2);
            this.panel2.TabIndex = 14;
            // 
            // LMontoTotal
            // 
            this.LMontoTotal.AutoSize = true;
            this.LMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMontoTotal.Location = new System.Drawing.Point(388, 218);
            this.LMontoTotal.Name = "LMontoTotal";
            this.LMontoTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LMontoTotal.Size = new System.Drawing.Size(24, 25);
            this.LMontoTotal.TabIndex = 13;
            this.LMontoTotal.Text = "0";
            this.LMontoTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LHorasTotal
            // 
            this.LHorasTotal.AutoSize = true;
            this.LHorasTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHorasTotal.Location = new System.Drawing.Point(302, 217);
            this.LHorasTotal.Name = "LHorasTotal";
            this.LHorasTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LHorasTotal.Size = new System.Drawing.Size(24, 25);
            this.LHorasTotal.TabIndex = 12;
            this.LHorasTotal.Text = "0";
            this.LHorasTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LMontoTriple
            // 
            this.LMontoTriple.AutoSize = true;
            this.LMontoTriple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMontoTriple.Location = new System.Drawing.Point(388, 139);
            this.LMontoTriple.Name = "LMontoTriple";
            this.LMontoTriple.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LMontoTriple.Size = new System.Drawing.Size(24, 25);
            this.LMontoTriple.TabIndex = 11;
            this.LMontoTriple.Text = "0";
            this.LMontoTriple.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LHorasTriples
            // 
            this.LHorasTriples.AutoSize = true;
            this.LHorasTriples.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHorasTriples.Location = new System.Drawing.Point(302, 138);
            this.LHorasTriples.Name = "LHorasTriples";
            this.LHorasTriples.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LHorasTriples.Size = new System.Drawing.Size(24, 25);
            this.LHorasTriples.TabIndex = 10;
            this.LHorasTriples.Text = "0";
            this.LHorasTriples.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LMontoDoble
            // 
            this.LMontoDoble.AutoSize = true;
            this.LMontoDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMontoDoble.Location = new System.Drawing.Point(388, 95);
            this.LMontoDoble.Name = "LMontoDoble";
            this.LMontoDoble.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LMontoDoble.Size = new System.Drawing.Size(24, 25);
            this.LMontoDoble.TabIndex = 9;
            this.LMontoDoble.Text = "0";
            this.LMontoDoble.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LHorasDoble
            // 
            this.LHorasDoble.AutoSize = true;
            this.LHorasDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHorasDoble.Location = new System.Drawing.Point(302, 94);
            this.LHorasDoble.Name = "LHorasDoble";
            this.LHorasDoble.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LHorasDoble.Size = new System.Drawing.Size(24, 25);
            this.LHorasDoble.TabIndex = 8;
            this.LHorasDoble.Text = "0";
            this.LHorasDoble.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LMontoNormal
            // 
            this.LMontoNormal.AutoSize = true;
            this.LMontoNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMontoNormal.Location = new System.Drawing.Point(388, 49);
            this.LMontoNormal.Name = "LMontoNormal";
            this.LMontoNormal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LMontoNormal.Size = new System.Drawing.Size(24, 25);
            this.LMontoNormal.TabIndex = 7;
            this.LMontoNormal.Text = "0";
            this.LMontoNormal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LHoras
            // 
            this.LHoras.AutoSize = true;
            this.LHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LHoras.Location = new System.Drawing.Point(302, 48);
            this.LHoras.Name = "LHoras";
            this.LHoras.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LHoras.Size = new System.Drawing.Size(24, 25);
            this.LHoras.TabIndex = 6;
            this.LHoras.Text = "0";
            this.LHoras.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(383, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Monto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(268, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total de Horas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Horas Extras Triples";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horas Extras Dobles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horas Normales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadorNomina.Properties.Resources.Cp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(-3, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 5);
            this.panel3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = "Proyect Solutions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(572, 411);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Nomina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LMontoTotal;
        private System.Windows.Forms.Label LHorasTotal;
        private System.Windows.Forms.Label LMontoTriple;
        private System.Windows.Forms.Label LHorasTriples;
        private System.Windows.Forms.Label LMontoDoble;
        private System.Windows.Forms.Label LHorasDoble;
        private System.Windows.Forms.Label LMontoNormal;
        private System.Windows.Forms.Label LHoras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

