
namespace Punto5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNventas = new System.Windows.Forms.TextBox();
            this.txtValProd = new System.Windows.Forms.TextBox();
            this.txtCantProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbValDesc = new System.Windows.Forms.Label();
            this.lbTotalAPagar = new System.Windows.Forms.Label();
            this.grbTotalVent = new System.Windows.Forms.GroupBox();
            this.lbTotalDesc = new System.Windows.Forms.Label();
            this.lbvalTotVent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.grbTotalVent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de ventas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el valor del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la cantidad de productos:";
            // 
            // txtNventas
            // 
            this.txtNventas.Location = new System.Drawing.Point(313, 66);
            this.txtNventas.Name = "txtNventas";
            this.txtNventas.Size = new System.Drawing.Size(44, 20);
            this.txtNventas.TabIndex = 3;
            // 
            // txtValProd
            // 
            this.txtValProd.Location = new System.Drawing.Point(313, 104);
            this.txtValProd.Name = "txtValProd";
            this.txtValProd.Size = new System.Drawing.Size(111, 20);
            this.txtValProd.TabIndex = 4;
            // 
            // txtCantProd
            // 
            this.txtCantProd.Location = new System.Drawing.Point(313, 143);
            this.txtCantProd.Name = "txtCantProd";
            this.txtCantProd.Size = new System.Drawing.Size(111, 20);
            this.txtCantProd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor del descuento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total a pagar:";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSubtotal.Location = new System.Drawing.Point(609, 66);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(137, 23);
            this.lbSubtotal.TabIndex = 9;
            // 
            // lbValDesc
            // 
            this.lbValDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbValDesc.Location = new System.Drawing.Point(612, 104);
            this.lbValDesc.Name = "lbValDesc";
            this.lbValDesc.Size = new System.Drawing.Size(134, 23);
            this.lbValDesc.TabIndex = 10;
            // 
            // lbTotalAPagar
            // 
            this.lbTotalAPagar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotalAPagar.Location = new System.Drawing.Point(612, 149);
            this.lbTotalAPagar.Name = "lbTotalAPagar";
            this.lbTotalAPagar.Size = new System.Drawing.Size(134, 23);
            this.lbTotalAPagar.TabIndex = 11;
            // 
            // grbTotalVent
            // 
            this.grbTotalVent.Controls.Add(this.lbTotalDesc);
            this.grbTotalVent.Controls.Add(this.lbvalTotVent);
            this.grbTotalVent.Controls.Add(this.label8);
            this.grbTotalVent.Controls.Add(this.label7);
            this.grbTotalVent.Location = new System.Drawing.Point(106, 203);
            this.grbTotalVent.Name = "grbTotalVent";
            this.grbTotalVent.Size = new System.Drawing.Size(539, 162);
            this.grbTotalVent.TabIndex = 12;
            this.grbTotalVent.TabStop = false;
            this.grbTotalVent.Text = "Ventas:";
            this.grbTotalVent.Visible = false;
            // 
            // lbTotalDesc
            // 
            this.lbTotalDesc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTotalDesc.Location = new System.Drawing.Point(311, 87);
            this.lbTotalDesc.Name = "lbTotalDesc";
            this.lbTotalDesc.Size = new System.Drawing.Size(143, 23);
            this.lbTotalDesc.TabIndex = 3;
            // 
            // lbvalTotVent
            // 
            this.lbvalTotVent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbvalTotVent.Location = new System.Drawing.Point(311, 32);
            this.lbvalTotVent.Name = "lbvalTotVent";
            this.lbvalTotVent.Size = new System.Drawing.Size(143, 23);
            this.lbvalTotVent.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Valor total de descuentos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Valor total de las ventas:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(140, 384);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(107, 41);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguente venta";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(329, 384);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(107, 41);
            this.btnFacturar.TabIndex = 14;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(514, 384);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(107, 41);
            this.btnTerminar.TabIndex = 15;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tienda la Barateria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.grbTotalVent);
            this.Controls.Add(this.lbTotalAPagar);
            this.Controls.Add(this.lbValDesc);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantProd);
            this.Controls.Add(this.txtValProd);
            this.Controls.Add(this.txtNventas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbTotalVent.ResumeLayout(false);
            this.grbTotalVent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNventas;
        private System.Windows.Forms.TextBox txtValProd;
        private System.Windows.Forms.TextBox txtCantProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbValDesc;
        private System.Windows.Forms.Label lbTotalAPagar;
        private System.Windows.Forms.GroupBox grbTotalVent;
        private System.Windows.Forms.Label lbTotalDesc;
        private System.Windows.Forms.Label lbvalTotVent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label9;
    }
}

