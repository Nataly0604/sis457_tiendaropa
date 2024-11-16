namespace sis457_tiendaropa
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.combusuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnumerodocumento = new System.Windows.Forms.TextBox();
            this.textnombrecliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkestado = new System.Windows.Forms.CheckBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.motototal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textmotopago = new System.Windows.Forms.TextBox();
            this.montocambio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combproducto = new System.Windows.Forms.ComboBox();
            this.texttipodoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textdocumentocliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textVentaId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // combusuario
            // 
            this.combusuario.FormattingEnabled = true;
            this.combusuario.Location = new System.Drawing.Point(52, 56);
            this.combusuario.Name = "combusuario";
            this.combusuario.Size = new System.Drawing.Size(121, 21);
            this.combusuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "numero documento";
            // 
            // textnumerodocumento
            // 
            this.textnumerodocumento.Location = new System.Drawing.Point(425, 56);
            this.textnumerodocumento.Name = "textnumerodocumento";
            this.textnumerodocumento.Size = new System.Drawing.Size(100, 20);
            this.textnumerodocumento.TabIndex = 4;
            // 
            // textnombrecliente
            // 
            this.textnombrecliente.Location = new System.Drawing.Point(654, 57);
            this.textnombrecliente.Name = "textnombrecliente";
            this.textnombrecliente.Size = new System.Drawing.Size(100, 20);
            this.textnombrecliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "nombre cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(762, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "estado";
            // 
            // checkestado
            // 
            this.checkestado.AutoSize = true;
            this.checkestado.Location = new System.Drawing.Point(776, 63);
            this.checkestado.Name = "checkestado";
            this.checkestado.Size = new System.Drawing.Size(15, 14);
            this.checkestado.TabIndex = 8;
            this.checkestado.UseVisualStyleBackColor = true;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.id,
            this.producto,
            this.cantidad,
            this.preciounitario,
            this.subtotal});
            this.dgvdata.Location = new System.Drawing.Point(52, 93);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersWidth = 40;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(471, 275);
            this.dgvdata.TabIndex = 21;
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
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // preciounitario
            // 
            this.preciounitario.HeaderText = "precio unitario";
            this.preciounitario.Name = "preciounitario";
            this.preciounitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 17;
            this.btneliminar.Location = new System.Drawing.Point(391, 374);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(134, 23);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Green;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btnagregar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.IconSize = 17;
            this.btnagregar.Location = new System.Drawing.Point(52, 374);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(158, 23);
            this.btnagregar.TabIndex = 32;
            this.btnagregar.Text = "guardar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "moto total:";
            // 
            // motototal
            // 
            this.motototal.AutoSize = true;
            this.motototal.Location = new System.Drawing.Point(639, 132);
            this.motototal.Name = "motototal";
            this.motototal.Size = new System.Drawing.Size(19, 13);
            this.motototal.TabIndex = 35;
            this.motototal.Text = "....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "moto pago :";
            // 
            // textmotopago
            // 
            this.textmotopago.Location = new System.Drawing.Point(598, 169);
            this.textmotopago.Name = "textmotopago";
            this.textmotopago.Size = new System.Drawing.Size(100, 20);
            this.textmotopago.TabIndex = 37;
            // 
            // montocambio
            // 
            this.montocambio.AutoSize = true;
            this.montocambio.Location = new System.Drawing.Point(613, 212);
            this.montocambio.Name = "montocambio";
            this.montocambio.Size = new System.Drawing.Size(19, 13);
            this.montocambio.TabIndex = 39;
            this.montocambio.Text = "....";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "moto cambio :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "producto";
            // 
            // combproducto
            // 
            this.combproducto.FormattingEnabled = true;
            this.combproducto.Location = new System.Drawing.Point(179, 56);
            this.combproducto.Name = "combproducto";
            this.combproducto.Size = new System.Drawing.Size(121, 21);
            this.combproducto.TabIndex = 42;
            // 
            // texttipodoc
            // 
            this.texttipodoc.Location = new System.Drawing.Point(318, 57);
            this.texttipodoc.Name = "texttipodoc";
            this.texttipodoc.Size = new System.Drawing.Size(100, 20);
            this.texttipodoc.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "tipo documento";
            // 
            // textdocumentocliente
            // 
            this.textdocumentocliente.Location = new System.Drawing.Point(539, 57);
            this.textdocumentocliente.Name = "textdocumentocliente";
            this.textdocumentocliente.Size = new System.Drawing.Size(100, 20);
            this.textdocumentocliente.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(536, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "nombre cliente";
            // 
            // textVentaId
            // 
            this.textVentaId.Location = new System.Drawing.Point(82, 12);
            this.textVentaId.Name = "textVentaId";
            this.textVentaId.Size = new System.Drawing.Size(40, 20);
            this.textVentaId.TabIndex = 47;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textVentaId);
            this.Controls.Add(this.textdocumentocliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.texttipodoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combproducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.montocambio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textmotopago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.motototal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.checkestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnombrecliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnumerodocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combusuario);
            this.Controls.Add(this.label1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnumerodocumento;
        private System.Windows.Forms.TextBox textnombrecliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkestado;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label motototal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textmotopago;
        private System.Windows.Forms.Label montocambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combproducto;
        private System.Windows.Forms.TextBox texttipodoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textdocumentocliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textVentaId;
    }
}