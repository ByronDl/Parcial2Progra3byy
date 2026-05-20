using Parcial2Progra3by;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Parcial2Progra3by
{
    public partial class FormMusica : Form
    {
        List<Album> albumes = new List<Album>();
        List<Cancion> cancionesActuales = new List<Cancion>();

        ArchivoAlbumes archivo = new ArchivoAlbumes();

        public FormMusica()
        {
            InitializeComponent();
        }

        private void FormMusica_Load(object sender, EventArgs e)
        {
            albumes = archivo.Leer();
            MostrarAlbumes(albumes);
            MostrarCanciones();
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            Cancion c = new Cancion();

            c.Nombre = textNombreCancion.Text;
            c.Artista = textArtistaCancion.Text;
            c.Duracion = textDuracion.Text;

            cancionesActuales.Add(c);

            MostrarCanciones();

            textNombreCancion.Clear();
            textArtistaCancion.Clear();
            textDuracion.Clear();
        }

        private void btnGuardarAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();

            album.Titulo = textTituloAlbum.Text;
            album.Artista = textArtistaAlbum.Text;
            album.FechaPublicacion = dtFechaPublicacion.Value;
            album.Canciones = cancionesActuales;

            albumes.Add(album);

            archivo.Guardar(albumes);

            MostrarAlbumes(albumes);

            Limpiar();

            MessageBox.Show("Álbum guardado correctamente");
        }

        private void btnActualizarAlbum_Click(object sender, EventArgs e)
        {
            Album album = albumes.FirstOrDefault(a => a.Titulo == textTituloAlbum.Text);

            if (album != null)
            {
                album.Artista = textArtistaAlbum.Text;
                album.FechaPublicacion = dtFechaPublicacion.Value;
                album.Canciones = cancionesActuales;

                archivo.Guardar(albumes);

                MostrarAlbumes(albumes);

                Limpiar();

                MessageBox.Show("Álbum actualizado correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró un álbum con ese título");
            }
        }

        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            var resultado = albumes
                .Where(a => a.Artista.ToLower().Contains(textBuscarArtista.Text.ToLower()))
                .ToList();

            MostrarAlbumes(resultado);
        }

        private void MostrarCanciones()
        {
            dgvCanciones.DataSource = null;
            dgvCanciones.DataSource = cancionesActuales;
        }

        private void MostrarAlbumes(List<Album> lista)
        {
            var datos = lista.Select(a => new
            {
                Titulo = a.Titulo,
                Artista = a.Artista,
                Fecha = a.FechaPublicacion.ToShortDateString(),
                Canciones = a.Canciones.Count
            }).ToList();

            dgvAlbumes.DataSource = null;
            dgvAlbumes.DataSource = datos;
        }

        private void Limpiar()
        {
            textTituloAlbum.Clear();
            textArtistaAlbum.Clear();
            textNombreCancion.Clear();
            textArtistaCancion.Clear();
            textDuracion.Clear();

            cancionesActuales = new List<Cancion>();

            MostrarCanciones();
        }
    }
}