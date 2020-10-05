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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.inputDireccion = new System.Windows.Forms.TextBox();
            this.inputTamanio = new System.Windows.Forms.TextBox();
            this.inputPrecioBase = new System.Windows.Forms.TextBox();
            this.inputVejez = new System.Windows.Forms.TextBox();
            this.inputVentanales = new System.Windows.Forms.TextBox();
            this.inputPiso = new System.Windows.Forms.TextBox();
            this.radioPiso = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Antigüedad (años)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de ventanales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° de piso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "m2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo";
            // 
            // botonCalcular
            // 
            this.botonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcular.Location = new System.Drawing.Point(121, 407);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(93, 31);
            this.botonCalcular.TabIndex = 8;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // inputDireccion
            // 
            this.inputDireccion.Location = new System.Drawing.Point(121, 31);
            this.inputDireccion.Name = "inputDireccion";
            this.inputDireccion.Size = new System.Drawing.Size(100, 20);
            this.inputDireccion.TabIndex = 9;
            // 
            // inputTamanio
            // 
            this.inputTamanio.Location = new System.Drawing.Point(121, 86);
            this.inputTamanio.Name = "inputTamanio";
            this.inputTamanio.Size = new System.Drawing.Size(80, 20);
            this.inputTamanio.TabIndex = 10;
            // 
            // inputPrecioBase
            // 
            this.inputPrecioBase.Location = new System.Drawing.Point(121, 135);
            this.inputPrecioBase.Name = "inputPrecioBase";
            this.inputPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.inputPrecioBase.TabIndex = 11;
            // 
            // inputVejez
            // 
            this.inputVejez.Location = new System.Drawing.Point(166, 189);
            this.inputVejez.Name = "inputVejez";
            this.inputVejez.Size = new System.Drawing.Size(100, 20);
            this.inputVejez.TabIndex = 12;
            // 
            // inputVentanales
            // 
            this.inputVentanales.Location = new System.Drawing.Point(218, 315);
            this.inputVentanales.Name = "inputVentanales";
            this.inputVentanales.Size = new System.Drawing.Size(100, 20);
            this.inputVentanales.TabIndex = 13;
            // 
            // inputPiso
            // 
            this.inputPiso.Location = new System.Drawing.Point(121, 361);
            this.inputPiso.Name = "inputPiso";
            this.inputPiso.Size = new System.Drawing.Size(100, 20);
            this.inputPiso.TabIndex = 14;
            // 
            // radioPiso
            // 
            this.radioPiso.AutoSize = true;
            this.radioPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPiso.Location = new System.Drawing.Point(106, 240);
            this.radioPiso.Name = "radioPiso";
            this.radioPiso.Size = new System.Drawing.Size(63, 26);
            this.radioPiso.TabIndex = 15;
            this.radioPiso.TabStop = true;
            this.radioPiso.Text = "Piso";
            this.radioPiso.UseVisualStyleBackColor = true;
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLocal.Location = new System.Drawing.Point(211, 240);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(71, 26);
            this.radioLocal.TabIndex = 16;
            this.radioLocal.TabStop = true;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.radioLocal);
            this.Controls.Add(this.radioPiso);
            this.Controls.Add(this.inputPiso);
            this.Controls.Add(this.inputVentanales);
            this.Controls.Add(this.inputVejez);
            this.Controls.Add(this.inputPrecioBase);
            this.Controls.Add(this.inputTamanio);
            this.Controls.Add(this.inputDireccion);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.TextBox inputDireccion;
        private System.Windows.Forms.TextBox inputTamanio;
        private System.Windows.Forms.TextBox inputPrecioBase;
        private System.Windows.Forms.TextBox inputVejez;
        private System.Windows.Forms.TextBox inputVentanales;
        private System.Windows.Forms.TextBox inputPiso;
        private System.Windows.Forms.RadioButton radioPiso;
        private System.Windows.Forms.RadioButton radioLocal;
    }
}