namespace reproductor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblCancion = new System.Windows.Forms.Label();
            this.mtrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Playlist = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.PictureBox();
            this.timerTransition = new System.Windows.Forms.Timer(this.components);
            this.lblAlbum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Siguientebtn = new System.Windows.Forms.PictureBox();
            this.Anteriorbtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Caratula = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnadjuntar = new System.Windows.Forms.PictureBox();
            this.Repetir = new System.Windows.Forms.PictureBox();
            this.Repeat_text = new System.Windows.Forms.Label();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.Playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siguientebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anteriorbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caratula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repetir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(12, 58);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(270, 446);
            this.lstCanciones.TabIndex = 1;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(205, 523);
            this.mtrackVolumen.Maximum = 100;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(93, 28);
            this.mtrackVolumen.TabIndex = 6;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.MediumAquamarine;
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtrackVolumen.Value = 0;
            this.mtrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackVolumen_ValueChanged);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.lblCancion.Location = new System.Drawing.Point(36, 321);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(21, 20);
            this.lblCancion.TabIndex = 7;
            this.lblCancion.Text = "--";
            // 
            // mtrackStatus
            // 
            this.mtrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.mtrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackStatus.IndentHeight = 6;
            this.mtrackStatus.Location = new System.Drawing.Point(21, 456);
            this.mtrackStatus.Maximum = 100;
            this.mtrackStatus.Minimum = 0;
            this.mtrackStatus.Name = "mtrackStatus";
            this.mtrackStatus.Size = new System.Drawing.Size(295, 28);
            this.mtrackStatus.TabIndex = 8;
            this.mtrackStatus.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackStatus.TickHeight = 4;
            this.mtrackStatus.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackStatus.TrackerColor = System.Drawing.Color.MediumAquamarine;
            this.mtrackStatus.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackStatus.TrackLineHeight = 3;
            this.mtrackStatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtrackStatus.Value = 0;
            this.mtrackStatus.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackStatus_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Artista:";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(82, 371);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(22, 13);
            this.lbArtista.TabIndex = 12;
            this.lbArtista.Text = "-- --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Canción";
            // 
            // Playlist
            // 
            this.Playlist.Controls.Add(this.label3);
            this.Playlist.Controls.Add(this.Closebtn);
            this.Playlist.Controls.Add(this.lstCanciones);
            this.Playlist.Location = new System.Drawing.Point(1, 64);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(294, 511);
            this.Playlist.TabIndex = 15;
            this.Playlist.TabStop = false;
            this.Playlist.Text = "Playlist";
            this.Playlist.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Música encontrada";
            // 
            // Closebtn
            // 
            this.Closebtn.Image = global::reproductor.Properties.Resources.Close;
            this.Closebtn.Location = new System.Drawing.Point(233, 7);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(49, 44);
            this.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Closebtn.TabIndex = 2;
            this.Closebtn.TabStop = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // timerTransition
            // 
            this.timerTransition.Tick += new System.EventHandler(this.timerTransition_Tick);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(83, 352);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(22, 13);
            this.lblAlbum.TabIndex = 19;
            this.lblAlbum.Text = "-- --";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Album:";
            // 
            // Siguientebtn
            // 
            this.Siguientebtn.Image = global::reproductor.Properties.Resources.Siguiente;
            this.Siguientebtn.Location = new System.Drawing.Point(250, 392);
            this.Siguientebtn.Name = "Siguientebtn";
            this.Siguientebtn.Size = new System.Drawing.Size(51, 50);
            this.Siguientebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Siguientebtn.TabIndex = 17;
            this.Siguientebtn.TabStop = false;
            this.Siguientebtn.Click += new System.EventHandler(this.Siguientebtn_Click);
            // 
            // Anteriorbtn
            // 
            this.Anteriorbtn.Image = global::reproductor.Properties.Resources.Anterior;
            this.Anteriorbtn.Location = new System.Drawing.Point(99, 392);
            this.Anteriorbtn.Name = "Anteriorbtn";
            this.Anteriorbtn.Size = new System.Drawing.Size(51, 50);
            this.Anteriorbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anteriorbtn.TabIndex = 16;
            this.Anteriorbtn.TabStop = false;
            this.Anteriorbtn.Click += new System.EventHandler(this.Anteriorbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::reproductor.Properties.Resources.Hamburguesa;
            this.pictureBox1.Location = new System.Drawing.Point(68, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Caratula
            // 
            this.Caratula.Image = global::reproductor.Properties.Resources.DefaultCover;
            this.Caratula.Location = new System.Drawing.Point(55, 75);
            this.Caratula.Name = "Caratula";
            this.Caratula.Size = new System.Drawing.Size(217, 217);
            this.Caratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Caratula.TabIndex = 10;
            this.Caratula.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::reproductor.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(175, 392);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 50);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 9;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::reproductor.Properties.Resources.Sonido;
            this.pictureBox2.Location = new System.Drawing.Point(163, 517);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::reproductor.Properties.Resources.Stop;
            this.btnStop.Location = new System.Drawing.Point(33, 395);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 43);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 3;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnadjuntar
            // 
            this.btnadjuntar.Image = global::reproductor.Properties.Resources.Agregar;
            this.btnadjuntar.Location = new System.Drawing.Point(17, 517);
            this.btnadjuntar.Name = "btnadjuntar";
            this.btnadjuntar.Size = new System.Drawing.Size(45, 43);
            this.btnadjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnadjuntar.TabIndex = 2;
            this.btnadjuntar.TabStop = false;
            this.btnadjuntar.Click += new System.EventHandler(this.btnadjuntar_Click);
            // 
            // Repetir
            // 
            this.Repetir.Image = global::reproductor.Properties.Resources.Repeat;
            this.Repetir.Location = new System.Drawing.Point(114, 517);
            this.Repetir.Name = "Repetir";
            this.Repetir.Size = new System.Drawing.Size(36, 43);
            this.Repetir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Repetir.TabIndex = 20;
            this.Repetir.TabStop = false;
            this.Repetir.Click += new System.EventHandler(this.Repetir_Click);
            // 
            // Repeat_text
            // 
            this.Repeat_text.AutoSize = true;
            this.Repeat_text.Location = new System.Drawing.Point(111, 487);
            this.Repeat_text.Name = "Repeat_text";
            this.Repeat_text.Size = new System.Drawing.Size(110, 13);
            this.Repeat_text.TabIndex = 21;
            this.Repeat_text.Text = "Se repetirá la canción";
            this.Repeat_text.Visible = false;
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(68, 116);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(186, 105);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            this.Reproductor.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Reproductor_MediaChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 577);
            this.Controls.Add(this.Repeat_text);
            this.Controls.Add(this.Repetir);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Siguientebtn);
            this.Controls.Add(this.Anteriorbtn);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Caratula);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.mtrackStatus);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnadjuntar);
            this.Controls.Add(this.Reproductor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(340, 577);
            this.MinimumSize = new System.Drawing.Size(340, 577);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            this.Playlist.ResumeLayout(false);
            this.Playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siguientebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anteriorbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caratula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repetir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnadjuntar;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private System.Windows.Forms.Label lblCancion;
        private XComponent.SliderBar.MACTrackBar mtrackStatus;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Caratula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Closebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerTransition;
        private System.Windows.Forms.PictureBox Anteriorbtn;
        private System.Windows.Forms.PictureBox Siguientebtn;
        private System.Windows.Forms.GroupBox Playlist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Repetir;
        private System.Windows.Forms.Label Repeat_text;
    }
}

