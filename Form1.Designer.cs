namespace Examen_Cafeteria_Daniel_Dupuy
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtParaLllevar = new System.Windows.Forms.RadioButton();
            this.rbtServicioNormal = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkPorcionnExtra = new System.Windows.Forms.CheckBox();
            this.chkFrecuente = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(143, 57);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(258, 22);
            this.txtCliente.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(590, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(307, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar al pedido";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(786, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Producto";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cant.";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(160, 192);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(258, 22);
            this.txtProducto.TabIndex = 11;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(160, 238);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(258, 22);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lstPedido
            // 
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 16;
            this.lstPedido.Location = new System.Drawing.Point(525, 164);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(432, 148);
            this.lstPedido.TabIndex = 13;
            this.lstPedido.SelectedIndexChanged += new System.EventHandler(this.lstPedido_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtGrande);
            this.groupBox1.Controls.Add(this.rbtNormal);
            this.groupBox1.Location = new System.Drawing.Point(63, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño";
            // 
            // rbtGrande
            // 
            this.rbtGrande.AutoSize = true;
            this.rbtGrande.Location = new System.Drawing.Point(22, 71);
            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Size = new System.Drawing.Size(132, 20);
            this.rbtGrande.TabIndex = 1;
            this.rbtGrande.TabStop = true;
            this.rbtGrande.Text = "Grande (+RD$25)";
            this.rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Location = new System.Drawing.Point(22, 32);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(72, 20);
            this.rbtNormal.TabIndex = 0;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtParaLllevar);
            this.groupBox2.Controls.Add(this.rbtServicioNormal);
            this.groupBox2.Location = new System.Drawing.Point(292, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servicio";
            // 
            // rbtParaLllevar
            // 
            this.rbtParaLllevar.AutoSize = true;
            this.rbtParaLllevar.Location = new System.Drawing.Point(22, 71);
            this.rbtParaLllevar.Name = "rbtParaLllevar";
            this.rbtParaLllevar.Size = new System.Drawing.Size(152, 20);
            this.rbtParaLllevar.TabIndex = 3;
            this.rbtParaLllevar.TabStop = true;
            this.rbtParaLllevar.Text = "Para llevar (+RD$20)";
            this.rbtParaLllevar.UseVisualStyleBackColor = true;
            // 
            // rbtServicioNormal
            // 
            this.rbtServicioNormal.AutoSize = true;
            this.rbtServicioNormal.Location = new System.Drawing.Point(22, 32);
            this.rbtServicioNormal.Name = "rbtServicioNormal";
            this.rbtServicioNormal.Size = new System.Drawing.Size(72, 20);
            this.rbtServicioNormal.TabIndex = 2;
            this.rbtServicioNormal.TabStop = true;
            this.rbtServicioNormal.Text = "Normal";
            this.rbtServicioNormal.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(585, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "ITBIS(18%)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(585, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "empaque";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(585, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Descuento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(585, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Subtotal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(585, 475);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "TOTAL A PAGAR";
            // 
            // chkPorcionnExtra
            // 
            this.chkPorcionnExtra.AutoSize = true;
            this.chkPorcionnExtra.Location = new System.Drawing.Point(65, 454);
            this.chkPorcionnExtra.Name = "chkPorcionnExtra";
            this.chkPorcionnExtra.Size = new System.Drawing.Size(164, 20);
            this.chkPorcionnExtra.TabIndex = 26;
            this.chkPorcionnExtra.Text = "Porcionn Extra(RD$25)";
            this.chkPorcionnExtra.UseVisualStyleBackColor = true;
            // 
            // chkFrecuente
            // 
            this.chkFrecuente.AutoSize = true;
            this.chkFrecuente.Location = new System.Drawing.Point(65, 99);
            this.chkFrecuente.Name = "chkFrecuente";
            this.chkFrecuente.Size = new System.Drawing.Size(133, 20);
            this.chkFrecuente.TabIndex = 27;
            this.chkFrecuente.Text = "Cliente Frecuente";
            this.chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(72, 491);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 36);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(189, 491);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 36);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(304, 491);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 36);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(160, 138);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(258, 22);
            this.txtFecha.TabIndex = 31;
            this.txtFecha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(165, 281);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(95, 22);
            this.nudCantidad.TabIndex = 32;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 537);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkFrecuente);
            this.Controls.Add(this.chkPorcionnExtra);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtParaLllevar;
        private System.Windows.Forms.RadioButton rbtServicioNormal;
        private System.Windows.Forms.CheckBox chkPorcionnExtra;
        private System.Windows.Forms.CheckBox chkFrecuente;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}

