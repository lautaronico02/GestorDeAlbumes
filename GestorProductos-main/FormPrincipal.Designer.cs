namespace GestorProductos
{
    partial class FormPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtArtista = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            dgvAlbumes = new DataGridView();
            lblContador = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            txtTitulo = new TextBox();
            Artista = new Label();
            btnExportar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(38, 38, 44);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(7, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            lblTitulo.Click += label1_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(38, 38, 44);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(7, 92);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += label2_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.FromArgb(38, 38, 44);
            lblStock.ForeColor = SystemColors.ButtonFace;
            lblStock.Location = new Point(10, 139);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // txtArtista
            // 
            txtArtista.BackColor = Color.FromArgb(38, 38, 44);
            txtArtista.BorderStyle = BorderStyle.FixedSingle;
            txtArtista.ForeColor = SystemColors.ButtonFace;
            txtArtista.Location = new Point(65, 7);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(288, 27);
            txtArtista.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(38, 38, 44);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = SystemColors.ButtonFace;
            txtPrecio.Location = new Point(65, 89);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(288, 27);
            txtPrecio.TabIndex = 4;
            txtPrecio.Leave += txtPrecio_Leave;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(38, 38, 44);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = SystemColors.ButtonFace;
            txtStock.Location = new Point(65, 132);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(288, 27);
            txtStock.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Location = new Point(408, 7);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvAlbumes
            // 
            dgvAlbumes.AllowUserToAddRows = false;
            dgvAlbumes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbumes.BackgroundColor = Color.FromArgb(30, 30, 35);
            dgvAlbumes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 52);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 230, 235);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlbumes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlbumes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumes.EnableHeadersVisualStyles = false;
            dgvAlbumes.GridColor = Color.FromArgb(60, 60, 70);
            dgvAlbumes.Location = new Point(12, 250);
            dgvAlbumes.Name = "dgvAlbumes";
            dgvAlbumes.RowHeadersVisible = false;
            dgvAlbumes.RowHeadersWidth = 51;
            dgvAlbumes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbumes.Size = new Size(776, 188);
            dgvAlbumes.TabIndex = 7;
            dgvAlbumes.DataBindingComplete += dgvAlbumes_DataBindingComplete;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(342, 217);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(79, 20);
            lblContador.TabIndex = 8;
            lblContador.Text = "0 Álbumes";
            lblContador.Click += lblContador_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(160, 60, 60);
            btnEliminar.Location = new Point(408, 50);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(60, 60, 70);
            btnEditar.Location = new Point(517, 7);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(60, 60, 70);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(517, 50);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseCompatibleTextRendering = true;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(38, 38, 44);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.ForeColor = SystemColors.ButtonFace;
            txtTitulo.Location = new Point(65, 47);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(288, 27);
            txtTitulo.TabIndex = 12;
            // 
            // Artista
            // 
            Artista.AutoSize = true;
            Artista.BackColor = Color.FromArgb(38, 38, 44);
            Artista.ForeColor = SystemColors.ButtonFace;
            Artista.Location = new Point(7, 9);
            Artista.Name = "Artista";
            Artista.Size = new Size(52, 20);
            Artista.TabIndex = 13;
            Artista.Text = "Artista";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.DarkOrange;
            btnExportar.Location = new Point(614, 208);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(164, 29);
            btnExportar.TabIndex = 14;
            btnExportar.Text = "Exportar a Texto";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(638, 139);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 16;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 28);
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(btnExportar);
            Controls.Add(Artista);
            Controls.Add(txtTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblContador);
            Controls.Add(dgvAlbumes);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtArtista);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Gestor de Álbumes Musicales";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlbumes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtArtista;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnAgregar;
        private DataGridView dgvAlbumes;
        private Label lblContador;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCancelar;
        private TextBox txtTitulo;
        private Label Artista;
        private Button btnExportar;
        private TextBox txtBuscar;
    }
}
