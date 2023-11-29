
namespace PIDeffine
{
    partial class FrmCarrito
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
            this.paneldecontrol = new System.Windows.Forms.Panel();
            this.pcbVolver = new System.Windows.Forms.PictureBox();
            this.pcbCerrar = new System.Windows.Forms.PictureBox();
            this.pcbMinimizar = new System.Windows.Forms.PictureBox();
            this.pcbLogOut = new System.Windows.Forms.PictureBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.grbComprar = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCarritoVacio = new System.Windows.Forms.Label();
            this.bttVolverCarrito = new System.Windows.Forms.Button();
            this.btnConfCompra = new System.Windows.Forms.Button();
            this.bttEliminarCarrito = new System.Windows.Forms.Button();
            this.bttComprar = new System.Windows.Forms.Button();
            this.pcbPrincipal = new System.Windows.Forms.PictureBox();
            this.pcbDeffine = new System.Windows.Forms.PictureBox();
            this.pcbspain = new System.Windows.Forms.PictureBox();
            this.pcbingle = new System.Windows.Forms.PictureBox();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.lblPrecioTotalCamb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbPerfil = new System.Windows.Forms.PictureBox();
            this.paneldecontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.grbComprar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeffine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbspain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldecontrol
            // 
            this.paneldecontrol.BackColor = System.Drawing.Color.DimGray;
            this.paneldecontrol.Controls.Add(this.pcbVolver);
            this.paneldecontrol.Controls.Add(this.pcbCerrar);
            this.paneldecontrol.Controls.Add(this.pcbMinimizar);
            this.paneldecontrol.Controls.Add(this.pcbLogOut);
            this.paneldecontrol.Location = new System.Drawing.Point(-3, -14);
            this.paneldecontrol.Name = "paneldecontrol";
            this.paneldecontrol.Size = new System.Drawing.Size(1022, 55);
            this.paneldecontrol.TabIndex = 25;
            this.paneldecontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseDown);
            this.paneldecontrol.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseMove);
            this.paneldecontrol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneldecontrol_MouseUp);
            // 
            // pcbVolver
            // 
            this.pcbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVolver.Image = global::PIDeffine.Properties.Resources.image_removebg_preview__13_1;
            this.pcbVolver.Location = new System.Drawing.Point(17, 17);
            this.pcbVolver.Name = "pcbVolver";
            this.pcbVolver.Size = new System.Drawing.Size(38, 35);
            this.pcbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVolver.TabIndex = 28;
            this.pcbVolver.TabStop = false;
            this.pcbVolver.Click += new System.EventHandler(this.pcbVolver_Click);
            // 
            // pcbCerrar
            // 
            this.pcbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrar.Image = global::PIDeffine.Properties.Resources.cerrar;
            this.pcbCerrar.Location = new System.Drawing.Point(953, 17);
            this.pcbCerrar.Name = "pcbCerrar";
            this.pcbCerrar.Size = new System.Drawing.Size(41, 35);
            this.pcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrar.TabIndex = 24;
            this.pcbCerrar.TabStop = false;
            this.pcbCerrar.Click += new System.EventHandler(this.pcbCerrar_Click);
            // 
            // pcbMinimizar
            // 
            this.pcbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMinimizar.Image = global::PIDeffine.Properties.Resources.minimizzar;
            this.pcbMinimizar.Location = new System.Drawing.Point(910, 17);
            this.pcbMinimizar.Name = "pcbMinimizar";
            this.pcbMinimizar.Size = new System.Drawing.Size(37, 35);
            this.pcbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMinimizar.TabIndex = 0;
            this.pcbMinimizar.TabStop = false;
            this.pcbMinimizar.Click += new System.EventHandler(this.pcbMinimizar_Click);
            // 
            // pcbLogOut
            // 
            this.pcbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLogOut.Image = global::PIDeffine.Properties.Resources.loguott;
            this.pcbLogOut.Location = new System.Drawing.Point(866, 17);
            this.pcbLogOut.Name = "pcbLogOut";
            this.pcbLogOut.Size = new System.Drawing.Size(38, 35);
            this.pcbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOut.TabIndex = 26;
            this.pcbLogOut.TabStop = false;
            this.pcbLogOut.Click += new System.EventHandler(this.pcbLogOut_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.White;
            this.lblIdioma.Location = new System.Drawing.Point(111, 79);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(70, 25);
            this.lblIdioma.TabIndex = 51;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblCarrito.Font = new System.Drawing.Font("Arial", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCarrito.ForeColor = System.Drawing.Color.White;
            this.lblCarrito.Location = new System.Drawing.Point(404, 186);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(212, 49);
            this.lblCarrito.TabIndex = 59;
            this.lblCarrito.Text = "CARRITO";
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(60, 238);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.Size = new System.Drawing.Size(867, 343);
            this.dgvCarrito.TabIndex = 60;
            // 
            // grbComprar
            // 
            this.grbComprar.BackColor = System.Drawing.Color.Transparent;
            this.grbComprar.Controls.Add(this.txtCliente);
            this.grbComprar.Controls.Add(this.txtCorreo);
            this.grbComprar.Controls.Add(this.lblCorreo);
            this.grbComprar.Controls.Add(this.lblCliente);
            this.grbComprar.Controls.Add(this.txtCodPostal);
            this.grbComprar.Controls.Add(this.lblCodPostal);
            this.grbComprar.Controls.Add(this.txtDireccion);
            this.grbComprar.Controls.Add(this.lblDireccion);
            this.grbComprar.ForeColor = System.Drawing.Color.Transparent;
            this.grbComprar.Location = new System.Drawing.Point(81, 253);
            this.grbComprar.Name = "grbComprar";
            this.grbComprar.Size = new System.Drawing.Size(820, 309);
            this.grbComprar.TabIndex = 84;
            this.grbComprar.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(262, 53);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(481, 30);
            this.txtCliente.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(262, 103);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(481, 30);
            this.txtCorreo.TabIndex = 10;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(48, 106);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(186, 23);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo de contacto:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(48, 56);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(76, 23);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(262, 206);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(481, 30);
            this.txtCodPostal.TabIndex = 7;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(48, 209);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(139, 23);
            this.lblCodPostal.TabIndex = 4;
            this.lblCodPostal.Text = "Código Postal:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(262, 156);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(481, 30);
            this.txtDireccion.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(48, 163);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(97, 23);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblCarritoVacio
            // 
            this.lblCarritoVacio.AutoSize = true;
            this.lblCarritoVacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblCarritoVacio.Font = new System.Drawing.Font("Arial", 30F);
            this.lblCarritoVacio.ForeColor = System.Drawing.Color.White;
            this.lblCarritoVacio.Location = new System.Drawing.Point(181, 362);
            this.lblCarritoVacio.Name = "lblCarritoVacio";
            this.lblCarritoVacio.Size = new System.Drawing.Size(631, 57);
            this.lblCarritoVacio.TabIndex = 86;
            this.lblCarritoVacio.Text = "EL CARRITO ESTÁ VACÍO";
            this.lblCarritoVacio.Visible = false;
            // 
            // bttVolverCarrito
            // 
            this.bttVolverCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bttVolverCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttVolverCarrito.FlatAppearance.BorderSize = 0;
            this.bttVolverCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttVolverCarrito.ForeColor = System.Drawing.Color.White;
            this.bttVolverCarrito.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttVolverCarrito.Location = new System.Drawing.Point(133, 585);
            this.bttVolverCarrito.Name = "bttVolverCarrito";
            this.bttVolverCarrito.Size = new System.Drawing.Size(342, 57);
            this.bttVolverCarrito.TabIndex = 87;
            this.bttVolverCarrito.Text = "Volver Al Carrito";
            this.bttVolverCarrito.UseVisualStyleBackColor = false;
            this.bttVolverCarrito.Visible = false;
            this.bttVolverCarrito.Click += new System.EventHandler(this.bttVolverCarrito_Click);
            // 
            // btnConfCompra
            // 
            this.btnConfCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnConfCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfCompra.FlatAppearance.BorderSize = 0;
            this.btnConfCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfCompra.ForeColor = System.Drawing.Color.White;
            this.btnConfCompra.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.btnConfCompra.Location = new System.Drawing.Point(525, 585);
            this.btnConfCompra.Name = "btnConfCompra";
            this.btnConfCompra.Size = new System.Drawing.Size(342, 57);
            this.btnConfCompra.TabIndex = 85;
            this.btnConfCompra.Text = "Confirmar Compra";
            this.btnConfCompra.UseVisualStyleBackColor = false;
            this.btnConfCompra.Click += new System.EventHandler(this.btnConfCompra_Click);
            // 
            // bttEliminarCarrito
            // 
            this.bttEliminarCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bttEliminarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEliminarCarrito.FlatAppearance.BorderSize = 0;
            this.bttEliminarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEliminarCarrito.ForeColor = System.Drawing.Color.White;
            this.bttEliminarCarrito.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttEliminarCarrito.Location = new System.Drawing.Point(133, 648);
            this.bttEliminarCarrito.Name = "bttEliminarCarrito";
            this.bttEliminarCarrito.Size = new System.Drawing.Size(342, 57);
            this.bttEliminarCarrito.TabIndex = 83;
            this.bttEliminarCarrito.Text = "Eliminar Carrito";
            this.bttEliminarCarrito.UseVisualStyleBackColor = false;
            this.bttEliminarCarrito.Click += new System.EventHandler(this.bttEliminarCarrito_Click);
            // 
            // bttComprar
            // 
            this.bttComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.bttComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttComprar.FlatAppearance.BorderSize = 0;
            this.bttComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttComprar.ForeColor = System.Drawing.Color.White;
            this.bttComprar.Image = global::PIDeffine.Properties.Resources.RegistrarBtont;
            this.bttComprar.Location = new System.Drawing.Point(525, 648);
            this.bttComprar.Name = "bttComprar";
            this.bttComprar.Size = new System.Drawing.Size(342, 57);
            this.bttComprar.TabIndex = 82;
            this.bttComprar.Text = "Comprar Ahora";
            this.bttComprar.UseVisualStyleBackColor = false;
            this.bttComprar.Click += new System.EventHandler(this.bttComprar_Click);
            // 
            // pcbPrincipal
            // 
            this.pcbPrincipal.Image = global::PIDeffine.Properties.Resources.FONDOGRISS;
            this.pcbPrincipal.Location = new System.Drawing.Point(22, 157);
            this.pcbPrincipal.Name = "pcbPrincipal";
            this.pcbPrincipal.Size = new System.Drawing.Size(952, 585);
            this.pcbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPrincipal.TabIndex = 58;
            this.pcbPrincipal.TabStop = false;
            // 
            // pcbDeffine
            // 
            this.pcbDeffine.Image = global::PIDeffine.Properties.Resources.deffinneeHeader;
            this.pcbDeffine.Location = new System.Drawing.Point(294, 64);
            this.pcbDeffine.Name = "pcbDeffine";
            this.pcbDeffine.Size = new System.Drawing.Size(312, 65);
            this.pcbDeffine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDeffine.TabIndex = 52;
            this.pcbDeffine.TabStop = false;
            // 
            // pcbspain
            // 
            this.pcbspain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbspain.Image = global::PIDeffine.Properties.Resources.image_removebg_preview__13_;
            this.pcbspain.Location = new System.Drawing.Point(56, 64);
            this.pcbspain.Name = "pcbspain";
            this.pcbspain.Size = new System.Drawing.Size(56, 53);
            this.pcbspain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbspain.TabIndex = 50;
            this.pcbspain.TabStop = false;
            this.pcbspain.Click += new System.EventHandler(this.pcbspain_Click);
            // 
            // pcbingle
            // 
            this.pcbingle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbingle.Image = global::PIDeffine.Properties.Resources.engli1;
            this.pcbingle.Location = new System.Drawing.Point(60, 64);
            this.pcbingle.Name = "pcbingle";
            this.pcbingle.Size = new System.Drawing.Size(56, 52);
            this.pcbingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbingle.TabIndex = 55;
            this.pcbingle.TabStop = false;
            this.pcbingle.Click += new System.EventHandler(this.pcbingle_Click);
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblTotalPedido.ForeColor = System.Drawing.Color.White;
            this.lblTotalPedido.Location = new System.Drawing.Point(687, 602);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(125, 23);
            this.lblTotalPedido.TabIndex = 88;
            this.lblTotalPedido.Text = "Total Pedido:";
            // 
            // lblPrecioTotalCamb
            // 
            this.lblPrecioTotalCamb.AutoSize = true;
            this.lblPrecioTotalCamb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblPrecioTotalCamb.ForeColor = System.Drawing.Color.White;
            this.lblPrecioTotalCamb.Location = new System.Drawing.Point(818, 602);
            this.lblPrecioTotalCamb.Name = "lblPrecioTotalCamb";
            this.lblPrecioTotalCamb.Size = new System.Drawing.Size(108, 23);
            this.lblPrecioTotalCamb.TabIndex = 89;
            this.lblPrecioTotalCamb.Text = "precio total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-3, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1007, 706);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pcbPerfil
            // 
            this.pcbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPerfil.Image = global::PIDeffine.Properties.Resources.Ellipse_2;
            this.pcbPerfil.Location = new System.Drawing.Point(863, 64);
            this.pcbPerfil.Name = "pcbPerfil";
            this.pcbPerfil.Size = new System.Drawing.Size(69, 67);
            this.pcbPerfil.TabIndex = 90;
            this.pcbPerfil.TabStop = false;
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1004, 735);
            this.Controls.Add(this.pcbPerfil);
            this.Controls.Add(this.lblPrecioTotalCamb);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.bttVolverCarrito);
            this.Controls.Add(this.lblCarritoVacio);
            this.Controls.Add(this.btnConfCompra);
            this.Controls.Add(this.grbComprar);
            this.Controls.Add(this.bttEliminarCarrito);
            this.Controls.Add(this.bttComprar);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.pcbPrincipal);
            this.Controls.Add(this.paneldecontrol);
            this.Controls.Add(this.pcbDeffine);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.pcbspain);
            this.Controls.Add(this.pcbingle);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarrito";
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.paneldecontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.grbComprar.ResumeLayout(false);
            this.grbComprar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeffine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbspain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneldecontrol;
        private System.Windows.Forms.PictureBox pcbCerrar;
        private System.Windows.Forms.PictureBox pcbMinimizar;
        private System.Windows.Forms.PictureBox pcbLogOut;
        private System.Windows.Forms.PictureBox pcbDeffine;
        private System.Windows.Forms.PictureBox pcbspain;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.PictureBox pcbingle;
        private System.Windows.Forms.PictureBox pcbPrincipal;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button bttComprar;
        private System.Windows.Forms.Button bttEliminarCarrito;
        private System.Windows.Forms.PictureBox pcbVolver;
        private System.Windows.Forms.GroupBox grbComprar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Button btnConfCompra;
        private System.Windows.Forms.Label lblCarritoVacio;
        private System.Windows.Forms.Button bttVolverCarrito;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Label lblPrecioTotalCamb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbPerfil;
    }
}