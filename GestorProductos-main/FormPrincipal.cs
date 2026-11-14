using System.ComponentModel;
using System.Globalization;
using System.Text;
namespace GestorProductos
{
    public partial class FormPrincipal : Form
    {
        private AlbumController _controller;
        private bool _modoEdicion = false;
        private Album _albumEditando = null;
        public FormPrincipal(AlbumController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string artista = txtArtista.Text.Trim();

            if (string.IsNullOrEmpty(artista))
            {
                MessageBox.Show("El artista no puede estar vacio.");
                txtArtista.Focus();
                return;
            }
            string titulo = txtTitulo.Text.Trim();

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El título no puede estar vacio.");
                txtTitulo.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio invalido.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock invalido.");
                txtStock.Focus();
                return;
            }

            if (_modoEdicion)
            {
                _albumEditando.Titulo = titulo;
                _albumEditando.Artista = artista;
                _albumEditando.Precio = precio;
                _albumEditando.Stock = stock;
                _controller.Modificar(_albumEditando);
                SalirModoEdicion();
            }
            else
            {
                _controller.Agregar(titulo, artista, precio, stock);
            }

            ActualizarTabla();
            LimpiarCampos();
        }
        private void ActualizarTabla()
        {
            var lista = _controller.ObtenerTodos();
            dgvAlbumes.DataSource = new BindingList<Album>(lista);
            dgvAlbumes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbumes.ClearSelection();
            lblContador.Text = $"{lista.Count} álbumes";
        }
        private void LimpiarCampos()
        {
            txtArtista.Clear();
            txtTitulo.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtArtista.Focus();
        }
        private void ActualizarBotones()
        {
            btnAgregar.Text = _modoEdicion ? "Guardar cambios" : "Agregar";
            btnCancelar.Visible = _modoEdicion;
            btnEditar.Enabled = !_modoEdicion;
            btnEliminar.Enabled = !_modoEdicion;
        }

        private void SalirModoEdicion()
        {
            _modoEdicion = false;
            _albumEditando = null;
            ActualizarBotones();
        }
        private Album ObtenerSeleccionado()
        {
            if (dgvAlbumes.SelectedRows.Count == 0)
                return null;

            return dgvAlbumes.SelectedRows[0].DataBoundItem as Album;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado();
            if (p == null) return;

            var confirmar = MessageBox.Show(
                $"Eliminar {p.Titulo}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                _controller.Eliminar(p.Id);
                ActualizarTabla();
            }
        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var p = ObtenerSeleccionado();
            if (p == null) return;

            _modoEdicion = true;
            _albumEditando = p;

            txtArtista.Text = p.Artista;
            txtTitulo.Text = p.Titulo;
            txtPrecio.Text = p.Precio.ToString("C");
            txtStock.Text = p.Stock.ToString();

            ActualizarBotones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SalirModoEdicion();
            LimpiarCampos();
        }

        private void dgvAlbumes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAlbumes.Columns["Precio"].DefaultCellStyle.Format = "C";
            dgvAlbumes.Columns["Id"].Width = 40;
            foreach (DataGridViewRow fila in dgvAlbumes.Rows)
            {
                var album = fila.DataBoundItem as Album;
                if (album == null) continue;
                if (album.Stock < 3) fila.DefaultCellStyle.BackColor = Color.LightCoral;
                else if (album.Stock <= 5) fila.DefaultCellStyle.BackColor = Color.Orange;
                else if (album.Stock <= 10) fila.DefaultCellStyle.BackColor = Color.Khaki;
                else fila.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var lista = _controller.ObtenerTodos();
            var sb = new StringBuilder();
            sb.AppendLine("ID | TITULO | ARTISTA | PRECIO | STOCK");

            foreach (var album in lista)
            {
                sb.AppendLine($"{album.Id} | {album.Titulo} | {album.Artista} | {album.Precio:C} | {album.Stock} ");

            }
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Archivo de texto (*.txt)|*.txt";
                dialogo.FileName = "albumes.txt";

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialogo.FileName, sb.ToString());
                    MessageBox.Show("Exportado correctamente.");
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var resultado = _controller.Buscar(txtBuscar.Text.Trim());
            dgvAlbumes.DataSource = new BindingList<Album>(resultado);
            lblContador.Text = $"{resultado.Count} álbumes";
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal precio))
            {
                txtPrecio.Text = precio.ToString("C");
            }
        }
    }

}
