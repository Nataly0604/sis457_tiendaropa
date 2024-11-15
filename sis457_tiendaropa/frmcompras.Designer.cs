namespace sis457_tiendaropa
{
    partial class frmcompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.combusuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textrazonsocial = new System.Windows.Forms.TextBox();
            this.texttipodocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textnumerodocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datefechacompra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.combestado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.combproducto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericpreciocompra = new System.Windows.Forms.NumericUpDown();
            this.numericcantidad = new System.Windows.Forms.NumericUpDown();
            this.subtotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.agregarproducto = new System.Windows.Forms.Button();
            this.guardarcompra = new System.Windows.Forms.Button();
            this.editarcompra = new System.Windows.Forms.Button();
            this.eliminarcompra = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.motototal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textmontopago = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.montocambio = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotaldgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericpreciocompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "informacion general";
            // 
            // combusuario
            // 
            this.combusuario.FormattingEnabled = true;
            this.combusuario.Location = new System.Drawing.Point(12, 58);
            this.combusuario.Name = "combusuario";
            this.combusuario.Size = new System.Drawing.Size(98, 21);
            this.combusuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razon Social";
            // 
            // textrazonsocial
            // 
            this.textrazonsocial.Location = new System.Drawing.Point(116, 59);
            this.textrazonsocial.Name = "textrazonsocial";
            this.textrazonsocial.Size = new System.Drawing.Size(122, 20);
            this.textrazonsocial.TabIndex = 4;
            // 
            // texttipodocumento
            // 
            this.texttipodocumento.Location = new System.Drawing.Point(244, 59);
            this.texttipodocumento.Name = "texttipodocumento";
            this.texttipodocumento.Size = new System.Drawing.Size(100, 20);
            this.texttipodocumento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo Documento";
            // 
            // textnumerodocumento
            // 
            this.textnumerodocumento.Location = new System.Drawing.Point(362, 59);
            this.textnumerodocumento.Name = "textnumerodocumento";
            this.textnumerodocumento.Size = new System.Drawing.Size(100, 20);
            this.textnumerodocumento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "numero Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "fecha compra";
            // 
            // datefechacompra
            // 
            this.datefechacompra.Location = new System.Drawing.Point(485, 59);
            this.datefechacompra.Name = "datefechacompra";
            this.datefechacompra.Size = new System.Drawing.Size(118, 20);
            this.datefechacompra.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "estado";
            // 
            // combestado
            // 
            this.combestado.FormattingEnabled = true;
            this.combestado.Location = new System.Drawing.Point(615, 58);
            this.combestado.Name = "combestado";
            this.combestado.Size = new System.Drawing.Size(98, 21);
            this.combestado.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "detalle producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Producto";
            // 
            // combproducto
            // 
            this.combproducto.FormattingEnabled = true;
            this.combproducto.Location = new System.Drawing.Point(12, 151);
            this.combproducto.Name = "combproducto";
            this.combproducto.Size = new System.Drawing.Size(118, 21);
            this.combproducto.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "precio Compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "cantidad";
            // 
            // numericpreciocompra
            // 
            this.numericpreciocompra.Location = new System.Drawing.Point(12, 204);
            this.numericpreciocompra.Name = "numericpreciocompra";
            this.numericpreciocompra.Size = new System.Drawing.Size(120, 20);
            this.numericpreciocompra.TabIndex = 20;
            // 
            // numericcantidad
            // 
            this.numericcantidad.Location = new System.Drawing.Point(10, 259);
            this.numericcantidad.Name = "numericcantidad";
            this.numericcantidad.Size = new System.Drawing.Size(120, 20);
            this.numericcantidad.TabIndex = 21;
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(69, 297);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(41, 13);
            this.subtotal.TabIndex = 22;
            this.subtotal.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "subtotal :";
            // 
            // agregarproducto
            // 
            this.agregarproducto.Location = new System.Drawing.Point(590, 149);
            this.agregarproducto.Name = "agregarproducto";
            this.agregarproducto.Size = new System.Drawing.Size(123, 23);
            this.agregarproducto.TabIndex = 24;
            this.agregarproducto.Text = "agregar producto";
            this.agregarproducto.UseVisualStyleBackColor = true;
            this.agregarproducto.Click += new System.EventHandler(this.agregarproducto_Click);
            // 
            // guardarcompra
            // 
            this.guardarcompra.Location = new System.Drawing.Point(590, 201);
            this.guardarcompra.Name = "guardarcompra";
            this.guardarcompra.Size = new System.Drawing.Size(123, 23);
            this.guardarcompra.TabIndex = 25;
            this.guardarcompra.Text = "guardar compra";
            this.guardarcompra.UseVisualStyleBackColor = true;
            this.guardarcompra.Click += new System.EventHandler(this.guardarcompra_Click);
            // 
            // editarcompra
            // 
            this.editarcompra.Location = new System.Drawing.Point(590, 243);
            this.editarcompra.Name = "editarcompra";
            this.editarcompra.Size = new System.Drawing.Size(123, 23);
            this.editarcompra.TabIndex = 26;
            this.editarcompra.Text = "editar compra";
            this.editarcompra.UseVisualStyleBackColor = true;
            this.editarcompra.Click += new System.EventHandler(this.editarcompra_Click);
            // 
            // eliminarcompra
            // 
            this.eliminarcompra.Location = new System.Drawing.Point(590, 287);
            this.eliminarcompra.Name = "eliminarcompra";
            this.eliminarcompra.Size = new System.Drawing.Size(123, 23);
            this.eliminarcompra.TabIndex = 27;
            this.eliminarcompra.Text = "eliminar compra";
            this.eliminarcompra.UseVisualStyleBackColor = true;
            this.eliminarcompra.Click += new System.EventHandler(this.eliminarcompra_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "totales";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "monto total : ";
            // 
            // motototal
            // 
            this.motototal.AutoSize = true;
            this.motototal.Location = new System.Drawing.Point(79, 370);
            this.motototal.Name = "motototal";
            this.motototal.Size = new System.Drawing.Size(59, 13);
            this.motototal.TabIndex = 31;
            this.motototal.Text = "monto total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "monto de pago";
            // 
            // textmontopago
            // 
            this.textmontopago.Location = new System.Drawing.Point(157, 386);
            this.textmontopago.Name = "textmontopago";
            this.textmontopago.Size = new System.Drawing.Size(122, 20);
            this.textmontopago.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(329, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "monto cambio";
            // 
            // montocambio
            // 
            this.montocambio.AutoSize = true;
            this.montocambio.Location = new System.Drawing.Point(422, 370);
            this.montocambio.Name = "montocambio";
            this.montocambio.Size = new System.Drawing.Size(73, 13);
            this.montocambio.TabIndex = 35;
            this.montocambio.Text = "monto cambio";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.Producto,
            this.preciocompra,
            this.Cantidad,
            this.Subtotaldgv});
            this.dgvdata.Location = new System.Drawing.Point(138, 99);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(446, 259);
            this.dgvdata.TabIndex = 36;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.FillWeight = 30F;
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 30;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // preciocompra
            // 
            this.preciocompra.HeaderText = "precio compra";
            this.preciocompra.Name = "preciocompra";
            this.preciocompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotaldgv
            // 
            this.Subtotaldgv.HeaderText = "Subtotal";
            this.Subtotaldgv.Name = "Subtotaldgv";
            this.Subtotaldgv.ReadOnly = true;
            // 
            // frmcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.montocambio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textmontopago);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.motototal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.eliminarcompra);
            this.Controls.Add(this.editarcompra);
            this.Controls.Add(this.guardarcompra);
            this.Controls.Add(this.agregarproducto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.numericcantidad);
            this.Controls.Add(this.numericpreciocompra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combproducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datefechacompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textnumerodocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texttipodocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textrazonsocial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combusuario);
            this.Controls.Add(this.label1);
            this.Name = "frmcompras";
            this.Text = "frmcompras";
            this.Load += new System.EventHandler(this.frmcompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericpreciocompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textrazonsocial;
        private System.Windows.Forms.TextBox texttipodocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textnumerodocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datefechacompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combproducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericpreciocompra;
        private System.Windows.Forms.NumericUpDown numericcantidad;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button agregarproducto;
        private System.Windows.Forms.Button guardarcompra;
        private System.Windows.Forms.Button editarcompra;
        private System.Windows.Forms.Button eliminarcompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label motototal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textmontopago;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label montocambio;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotaldgv;
    }
}