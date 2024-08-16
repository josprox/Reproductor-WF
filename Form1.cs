using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib;
using MaterialSkin;
using MaterialSkin.Controls;

namespace reproductor
{
    public partial class Form1 : MaterialForm
    {
        bool play = false;
        bool repeat = false; // Variable para controlar la repetición
        string[] RutasArchivosMP3;
        bool isOpening = false;
        int slideSpeed = 10; // Ajusta la velocidad del deslizamiento
        private bool isUpdatingTrackBar = false;
        private bool handlingPlayStateChange = false;

        public Form1()
        {
            InitializeComponent();
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Tema claro
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, // Color primario
                Primary.BlueGrey900, // Color oscuro primario
                Primary.BlueGrey500, // Color de acento
                Accent.LightBlue200, // Color de acento claro
                TextShade.WHITE
            );

            // Configura el Timer
            timerTransition.Interval = 10; // Ajusta el intervalo de tiempo
            timerTransition.Tick += new EventHandler(timerTransition_Tick);

            // Establecer volumen inicial
            Reproductor.settings.volume = 98;
            Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Reproductor_PlayStateChange);
        }

        private void btnadjuntar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog CajaDeBusquedaDeCarpetas = new FolderBrowserDialog();

            if (CajaDeBusquedaDeCarpetas.ShowDialog() == DialogResult.OK)
            {
                // Buscar archivos .mp3 y .flac
                string[] archivos = Directory.GetFiles(CajaDeBusquedaDeCarpetas.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".mp3") || s.EndsWith(".flac")).ToArray();
                RutasArchivosMP3 = archivos;

                lstCanciones.Items.Clear();
                foreach (string ruta in RutasArchivosMP3)
                {
                    var archivo = TagLib.File.Create(ruta);
                    string nombreCancion = archivo.Tag.Title ?? Path.GetFileNameWithoutExtension(ruta);
                    lstCanciones.Items.Add(nombreCancion);
                }

                if (RutasArchivosMP3.Length > 0)
                {
                    CargarCancion(0);
                    lstCanciones.SelectedIndex = 0;
                    btnPlay.Image = Properties.Resources.Pausa;
                }
            }
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCancion(lstCanciones.SelectedIndex);
        }

        private void CargarCancion(int index)
        {
            if (index < 0 || index >= RutasArchivosMP3.Length)
                return;

            Reproductor.URL = RutasArchivosMP3[index];
            var archivo = TagLib.File.Create(RutasArchivosMP3[index]);

            lblCancion.Text = archivo.Tag.Title ?? Path.GetFileNameWithoutExtension(RutasArchivosMP3[index]);
            lbArtista.Text = archivo.Tag.FirstPerformer ?? "Artista desconocido";
            lblAlbum.Text = archivo.Tag.Album ?? "Álbum desconocido";

            if (archivo.Tag.Pictures.Length > 0)
            {
                var bin = (byte[])(archivo.Tag.Pictures[0].Data.Data);
                using (var ms = new MemoryStream(bin))
                {
                    var originalImage = Image.FromStream(ms);
                    Caratula.Image = CrearImagenConBordeRedondeado(originalImage, 42);
                }
            }
            else
            {
                Caratula.Image = CrearImagenConBordeRedondeado(Properties.Resources.DefaultCover, 42);
            }
        }


        private Image CrearImagenConBordeRedondeado(Image originalImage, int radio)
        {
            int ancho = originalImage.Width;
            int alto = originalImage.Height;

            Bitmap imagenConBordeRedondeado = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(imagenConBordeRedondeado))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddArc(0, 0, radio, radio, 180, 90);
                    gp.AddArc(ancho - radio, 0, radio, radio, 270, 90);
                    gp.AddArc(ancho - radio, alto - radio, radio, radio, 0, 90);
                    gp.AddArc(0, alto - radio, radio, radio, 90, 90);
                    gp.CloseFigure();

                    g.SetClip(gp);
                    g.DrawImage(originalImage, 0, 0, ancho, alto);
                }
            }

            return imagenConBordeRedondeado;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (play)
            {
                Reproductor.Ctlcontrols.pause();
                btnPlay.Image = Properties.Resources.Play;
                play = false;
            }
            else
            {
                Reproductor.Ctlcontrols.play();
                btnPlay.Image = Properties.Resources.Pausa;
                play = true;
            }
        }

        private void ctl_logic_music()
        {
            Timer playTimer = new Timer();
            // Asegúrate de que el reproductor esté listo antes de reproducir
            playTimer.Interval = 100; // 100 ms de retraso para asegurar que el reproductor esté listo
            playTimer.Tick += (s, args) =>
            {
                Reproductor.Ctlcontrols.play();
                playTimer.Stop(); // Detén el temporizador
            };
            playTimer.Start();
            if (play)
            {
                Reproductor.Ctlcontrols.pause();
                play = false;
            }
            else
            {
                Reproductor.Ctlcontrols.play();
                play = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.Play;
            play = false;
        }

        public void ActualizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mtrackStatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mtrackStatus.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();

            // Actualiza el TrackBar con la posición actual del reproductor
            isUpdatingTrackBar = true;
            mtrackStatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            isUpdatingTrackBar = false;

            // Actualiza el volumen
            mtrackVolumen.Value = Reproductor.settings.volume;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // Verificar si el mensaje ya se mostró o si está en una transición
                if (Reproductor.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    Console.WriteLine("Canción terminada. Repetir: " + repeat);

                    if (repeat)
                    {
                        btnPlay_Click(this, EventArgs.Empty);
                        // Registra el estado antes de intentar reproducir
                        Console.WriteLine("Reproduciendo nuevamente... Estado del reproductor: " + Reproductor.playState);

                        ctl_logic_music();
                    }
                    else
                    {
                        Console.WriteLine("Reproduciendo siguiente canción... Estado del reproductor: " + Reproductor.playState);
                        Siguientebtn_Click(this, EventArgs.Empty);
                        ctl_logic_music();
                    }
                }
            }
        }





        private void mtrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = mtrackVolumen.Value;
        }

        private void mtrackStatus_ValueChanged(object sender, decimal value)
        {
            // Solo actualizar la posición del reproductor si no estamos actualizando el TrackBar desde el código
            if (!isUpdatingTrackBar)
            {
                Reproductor.Ctlcontrols.currentPosition = mtrackStatus.Value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isOpening = true;
            Playlist.Width = 0;
            Playlist.BringToFront();
            Playlist.Visible = true;
            timerTransition.Start();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            isOpening = false;
            timerTransition.Start();
        }

        private void timerTransition_Tick(object sender, EventArgs e)
        {
            if (isOpening)
            {
                if (Playlist.Width <= 300) // Ajusta el tamaño final del panel
                {
                    Playlist.Width += slideSpeed;
                }
                else
                {
                    Playlist.Width = 300;
                    timerTransition.Stop();
                }
            }
            else
            {
                if (Playlist.Width > 0)
                {
                    Playlist.Width -= slideSpeed;
                }
                else
                {
                    Playlist.Width = 0;
                    timerTransition.Stop();
                    Playlist.Visible = false;
                }
            }
        }

        private void Anteriorbtn_Click(object sender, EventArgs e)
        {
            // Verifica si hay canciones en la lista
            if (RutasArchivosMP3.Length > 0)
            {
                // Obtiene el índice actual de la canción
                int currentIndex = lstCanciones.SelectedIndex;

                // Calcula el índice de la canción anterior
                int previousIndex = currentIndex - 1;

                // Si el índice anterior es menor que 0, se ajusta al último elemento
                if (previousIndex < 0)
                {
                    previousIndex = RutasArchivosMP3.Length - 1;
                }

                // Carga la canción en el índice calculado
                CargarCancion(previousIndex);
                lstCanciones.SelectedIndex = previousIndex;
            }
        }

        private void Siguientebtn_Click(object sender, EventArgs e)
        {
            if (RutasArchivosMP3.Length > 0)
            {
                int currentIndex = lstCanciones.SelectedIndex;
                int nextIndex = currentIndex + 1;

                if (nextIndex >= RutasArchivosMP3.Length)
                {
                    nextIndex = 0;
                }

                CargarCancion(nextIndex);
                lstCanciones.SelectedIndex = nextIndex; // Asegúrate de que esto esté correctamente actualizado
            }
        }



        private void Repetir_Click(object sender, EventArgs e)
        {
            // Alterna la opción de repetir
            repeat = !repeat;
            Repeat_text.Visible = repeat; // Muestra/oculta texto según el estado de repetir
        }

        private void ReproducirCancion()
        {
            if (!play)
            {
                Reproductor.Ctlcontrols.play();
                btnPlay.Image = Properties.Resources.Pausa;
                play = true;
            }
        }

        private void Reproductor_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
        }
    }
}
