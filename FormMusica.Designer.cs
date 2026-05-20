namespace Parcial2Progra3by
{
    partial class FormMusica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textTituloAlbum = new System.Windows.Forms.TextBox();
            this.textArtistaAlbum = new System.Windows.Forms.TextBox();
            this.textNombreCancion = new System.Windows.Forms.TextBox();
            this.textArtistaCancion = new System.Windows.Forms.TextBox();
            this.textDuracion = new System.Windows.Forms.TextBox();
            this.textBuscarArtista = new System.Windows.Forms.TextBox();
            this.dtFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarCancion = new System.Windows.Forms.Button();
            this.btnGuardarAlbum = new System.Windows.Forms.Button();
            this.btnActualizarAlbum = new System.Windows.Forms.Button();
            this.btnBuscarArtista = new System.Windows.Forms.Button();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.dgvAlbumes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // textTituloAlbum
            // 
            this.textTituloAlbum.Location = new System.Drawing.Point(30, 59);
            this.textTituloAlbum.Name = "textTituloAlbum";
            this.textTituloAlbum.Size = new System.Drawing.Size(220, 22);
            this.textTituloAlbum.TabIndex = 0;
            // 
            // textArtistaAlbum
            // 
            this.textArtistaAlbum.Location = new System.Drawing.Point(30, 121);
            this.textArtistaAlbum.Name = "textArtistaAlbum";
            this.textArtistaAlbum.Size = new System.Drawing.Size(220, 22);
            this.textArtistaAlbum.TabIndex = 1;
            // 
            // textNombreCancion
            // 
            this.textNombreCancion.Location = new System.Drawing.Point(300, 72);
            this.textNombreCancion.Name = "textNombreCancion";
            this.textNombreCancion.Size = new System.Drawing.Size(220, 22);
            this.textNombreCancion.TabIndex = 3;
            // 
            // textArtistaCancion
            // 
            this.textArtistaCancion.Location = new System.Drawing.Point(300, 121);
            this.textArtistaCancion.Name = "textArtistaCancion";
            this.textArtistaCancion.Size = new System.Drawing.Size(220, 22);
            this.textArtistaCancion.TabIndex = 4;
            // 
            // textDuracion
            // 
            this.textDuracion.Location = new System.Drawing.Point(300, 163);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(220, 22);
            this.textDuracion.TabIndex = 5;
            // 
            // textBuscarArtista
            // 
            this.textBuscarArtista.Location = new System.Drawing.Point(30, 430);
            this.textBuscarArtista.Name = "textBuscarArtista";
            this.textBuscarArtista.Size = new System.Drawing.Size(220, 22);
            this.textBuscarArtista.TabIndex = 6;
            // 
            // dtFechaPublicacion
            // 
            this.dtFechaPublicacion.Location = new System.Drawing.Point(30, 182);
            this.dtFechaPublicacion.Name = "dtFechaPublicacion";
            this.dtFechaPublicacion.Size = new System.Drawing.Size(220, 22);
            this.dtFechaPublicacion.TabIndex = 2;
            // 
            // btnAgregarCancion
            // 
            this.btnAgregarCancion.Location = new System.Drawing.Point(300, 204);
            this.btnAgregarCancion.Name = "btnAgregarCancion";
            this.btnAgregarCancion.Size = new System.Drawing.Size(220, 40);
            this.btnAgregarCancion.TabIndex = 7;
            this.btnAgregarCancion.Text = "Agregar Canción";
            this.btnAgregarCancion.UseVisualStyleBackColor = true;
            this.btnAgregarCancion.Click += new System.EventHandler(this.btnAgregarCancion_Click);
            // 
            // btnGuardarAlbum
            // 
            this.btnGuardarAlbum.Location = new System.Drawing.Point(30, 225);
            this.btnGuardarAlbum.Name = "btnGuardarAlbum";
            this.btnGuardarAlbum.Size = new System.Drawing.Size(220, 40);
            this.btnGuardarAlbum.TabIndex = 8;
            this.btnGuardarAlbum.Text = "Guardar Álbum";
            this.btnGuardarAlbum.UseVisualStyleBackColor = true;
            this.btnGuardarAlbum.Click += new System.EventHandler(this.btnGuardarAlbum_Click);
            // 
            // btnActualizarAlbum
            // 
            this.btnActualizarAlbum.Location = new System.Drawing.Point(30, 283);
            this.btnActualizarAlbum.Name = "btnActualizarAlbum";
            this.btnActualizarAlbum.Size = new System.Drawing.Size(220, 40);
            this.btnActualizarAlbum.TabIndex = 9;
            this.btnActualizarAlbum.Text = "Actualizar Álbum";
            this.btnActualizarAlbum.UseVisualStyleBackColor = true;
            this.btnActualizarAlbum.Click += new System.EventHandler(this.btnActualizarAlbum_Click);
            // 
            // btnBuscarArtista
            // 
            this.btnBuscarArtista.Location = new System.Drawing.Point(270, 420);
            this.btnBuscarArtista.Name = "btnBuscarArtista";
            this.btnBuscarArtista.Size = new System.Drawing.Size(170, 40);
            this.btnBuscarArtista.TabIndex = 10;
            this.btnBuscarArtista.Text = "Buscar Artista";
            this.btnBuscarArtista.UseVisualStyleBackColor = true;
            this.btnBuscarArtista.Click += new System.EventHandler(this.btnBuscarArtista_Click);
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.Location = new System.Drawing.Point(550, 30);
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.RowHeadersWidth = 51;
            this.dgvCanciones.RowTemplate.Height = 24;
            this.dgvCanciones.Size = new System.Drawing.Size(450, 250);
            this.dgvCanciones.TabIndex = 11;
            // 
            // dgvAlbumes
            // 
            this.dgvAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumes.Location = new System.Drawing.Point(30, 480);
            this.dgvAlbumes.Name = "dgvAlbumes";
            this.dgvAlbumes.RowHeadersWidth = 51;
            this.dgvAlbumes.RowTemplate.Height = 24;
            this.dgvAlbumes.Size = new System.Drawing.Size(970, 280);
            this.dgvAlbumes.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "titulo album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Artista album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "fecha a utillizar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre de la cancion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Artista de la cancion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Duracion";
            // 
            // FormMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 800);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTituloAlbum);
            this.Controls.Add(this.textArtistaAlbum);
            this.Controls.Add(this.dtFechaPublicacion);
            this.Controls.Add(this.textNombreCancion);
            this.Controls.Add(this.textArtistaCancion);
            this.Controls.Add(this.textDuracion);
            this.Controls.Add(this.textBuscarArtista);
            this.Controls.Add(this.btnAgregarCancion);
            this.Controls.Add(this.btnGuardarAlbum);
            this.Controls.Add(this.btnActualizarAlbum);
            this.Controls.Add(this.btnBuscarArtista);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.dgvAlbumes);
            this.Name = "FormMusica";
            this.Text = "Biblioteca de Música";
            this.Load += new System.EventHandler(this.FormMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTituloAlbum;
        private System.Windows.Forms.TextBox textArtistaAlbum;
        private System.Windows.Forms.TextBox textNombreCancion;
        private System.Windows.Forms.TextBox textArtistaCancion;
        private System.Windows.Forms.TextBox textDuracion;
        private System.Windows.Forms.TextBox textBuscarArtista;
        private System.Windows.Forms.DateTimePicker dtFechaPublicacion;
        private System.Windows.Forms.Button btnAgregarCancion;
        private System.Windows.Forms.Button btnGuardarAlbum;
        private System.Windows.Forms.Button btnActualizarAlbum;
        private System.Windows.Forms.Button btnBuscarArtista;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.DataGridView dgvAlbumes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}