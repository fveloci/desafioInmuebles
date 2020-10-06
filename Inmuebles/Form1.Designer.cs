namespace Inmuebles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVentanales = new System.Windows.Forms.Label();
            this.lblNPiso = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.inputDireccion = new System.Windows.Forms.TextBox();
            this.inputTamanio = new System.Windows.Forms.TextBox();
            this.inputPrecioBase = new System.Windows.Forms.TextBox();
            this.inputVentanales = new System.Windows.Forms.TextBox();
            this.inputPiso = new System.Windows.Forms.TextBox();
            this.radioPiso = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.groupBoxPisoLocal = new System.Windows.Forms.GroupBox();
            this.radioSegundaMano = new System.Windows.Forms.RadioButton();
            this.radioNuevo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPisoLocal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Base";
            // 
            // lblVentanales
            // 
            this.lblVentanales.AutoSize = true;
            this.lblVentanales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentanales.Location = new System.Drawing.Point(337, 73);
            this.lblVentanales.Name = "lblVentanales";
            this.lblVentanales.Size = new System.Drawing.Size(199, 23);
            this.lblVentanales.TabIndex = 4;
            this.lblVentanales.Text = "Cantidad de ventanales";
            this.lblVentanales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVentanales.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNPiso
            // 
            this.lblNPiso.AutoSize = true;
            this.lblNPiso.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPiso.Location = new System.Drawing.Point(337, 31);
            this.lblNPiso.Name = "lblNPiso";
            this.lblNPiso.Size = new System.Drawing.Size(97, 23);
            this.lblNPiso.TabIndex = 5;
            this.lblNPiso.Text = "N° de piso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "m²";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(32, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 23);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.Form1_Load);
            // 
            // botonCalcular
            // 
            this.botonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcular.Location = new System.Drawing.Point(251, 257);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(195, 59);
            this.botonCalcular.TabIndex = 8;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // inputDireccion
            // 
            this.inputDireccion.Location = new System.Drawing.Point(136, 213);
            this.inputDireccion.Name = "inputDireccion";
            this.inputDireccion.Size = new System.Drawing.Size(478, 20);
            this.inputDireccion.TabIndex = 9;
            // 
            // inputTamanio
            // 
            this.inputTamanio.Location = new System.Drawing.Point(419, 168);
            this.inputTamanio.Name = "inputTamanio";
            this.inputTamanio.Size = new System.Drawing.Size(90, 20);
            this.inputTamanio.TabIndex = 10;
            // 
            // inputPrecioBase
            // 
            this.inputPrecioBase.Location = new System.Drawing.Point(452, 120);
            this.inputPrecioBase.Name = "inputPrecioBase";
            this.inputPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.inputPrecioBase.TabIndex = 11;
            // 
            // inputVentanales
            // 
            this.inputVentanales.Location = new System.Drawing.Point(536, 76);
            this.inputVentanales.Name = "inputVentanales";
            this.inputVentanales.Size = new System.Drawing.Size(100, 20);
            this.inputVentanales.TabIndex = 13;
            // 
            // inputPiso
            // 
            this.inputPiso.Location = new System.Drawing.Point(452, 36);
            this.inputPiso.Name = "inputPiso";
            this.inputPiso.Size = new System.Drawing.Size(100, 20);
            this.inputPiso.TabIndex = 14;
            // 
            // radioPiso
            // 
            this.radioPiso.AutoSize = true;
            this.radioPiso.Checked = true;
            this.radioPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPiso.Location = new System.Drawing.Point(20, 19);
            this.radioPiso.Name = "radioPiso";
            this.radioPiso.Size = new System.Drawing.Size(63, 26);
            this.radioPiso.TabIndex = 15;
            this.radioPiso.TabStop = true;
            this.radioPiso.Text = "Piso";
            this.radioPiso.UseVisualStyleBackColor = true;
            this.radioPiso.CheckedChanged += new System.EventHandler(this.radioPiso_CheckedChanged);
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLocal.Location = new System.Drawing.Point(103, 19);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(71, 26);
            this.radioLocal.TabIndex = 16;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            this.radioLocal.CheckedChanged += new System.EventHandler(this.radioLocal_CheckedChanged);
            // 
            // groupBoxPisoLocal
            // 
            this.groupBoxPisoLocal.Controls.Add(this.radioPiso);
            this.groupBoxPisoLocal.Controls.Add(this.radioLocal);
            this.groupBoxPisoLocal.Location = new System.Drawing.Point(105, 12);
            this.groupBoxPisoLocal.Name = "groupBoxPisoLocal";
            this.groupBoxPisoLocal.Size = new System.Drawing.Size(196, 56);
            this.groupBoxPisoLocal.TabIndex = 19;
            this.groupBoxPisoLocal.TabStop = false;
            // 
            // radioSegundaMano
            // 
            this.radioSegundaMano.AutoSize = true;
            this.radioSegundaMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSegundaMano.Location = new System.Drawing.Point(6, 51);
            this.radioSegundaMano.Name = "radioSegundaMano";
            this.radioSegundaMano.Size = new System.Drawing.Size(149, 26);
            this.radioSegundaMano.TabIndex = 18;
            this.radioSegundaMano.TabStop = true;
            this.radioSegundaMano.Text = "Segunda Mano";
            this.radioSegundaMano.UseVisualStyleBackColor = true;
            // 
            // radioNuevo
            // 
            this.radioNuevo.AutoSize = true;
            this.radioNuevo.Checked = true;
            this.radioNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNuevo.Location = new System.Drawing.Point(6, 19);
            this.radioNuevo.Name = "radioNuevo";
            this.radioNuevo.Size = new System.Drawing.Size(219, 26);
            this.radioNuevo.TabIndex = 17;
            this.radioNuevo.TabStop = true;
            this.radioNuevo.Text = "Nuevo (menos 15 años)";
            this.radioNuevo.UseVisualStyleBackColor = true;
            this.radioNuevo.CheckedChanged += new System.EventHandler(this.radioNuevo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNuevo);
            this.groupBox2.Controls.Add(this.radioSegundaMano);
            this.groupBox2.Location = new System.Drawing.Point(36, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 90);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPisoLocal);
            this.Controls.Add(this.inputPiso);
            this.Controls.Add(this.inputVentanales);
            this.Controls.Add(this.inputPrecioBase);
            this.Controls.Add(this.inputTamanio);
            this.Controls.Add(this.inputDireccion);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNPiso);
            this.Controls.Add(this.lblVentanales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPisoLocal.ResumeLayout(false);
            this.groupBoxPisoLocal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVentanales;
        private System.Windows.Forms.Label lblNPiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.TextBox inputDireccion;
        private System.Windows.Forms.TextBox inputTamanio;
        private System.Windows.Forms.TextBox inputPrecioBase;
        private System.Windows.Forms.TextBox inputVentanales;
        private System.Windows.Forms.TextBox inputPiso;
        private System.Windows.Forms.RadioButton radioPiso;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.GroupBox groupBoxPisoLocal;
        private System.Windows.Forms.RadioButton radioSegundaMano;
        private System.Windows.Forms.RadioButton radioNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}