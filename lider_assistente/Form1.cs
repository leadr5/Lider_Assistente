using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;
using System.Data.SQLite;
using System.Globalization;
using System.Threading;
using System.Timers;
using System.IO;
using System.Media;
using System.Diagnostics;
using System.IO.Ports;
using System.Net;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
//IMPORTAÇÕES PARA RECONHECIMENTO DE FALA(Api Microsoft Speech)
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
//Para sintetização de fala
using SpeechSynthesizer = System.Speech.Synthesis.SpeechSynthesizer;
using System.Net.NetworkInformation;

namespace robo1._3
{
    public partial class Form1 : Form
    {        

        public static SpeechSynthesizer synthVoice2;
        private static SpeechSynthesizer sintetizador2 = new SpeechSynthesizer();
        static SQLiteConnection sqlCon = null;
        string strCon = "Data Source=DGVDB.sdb; Version=3; New=False; Compress = true;";
        string strSql = string.Empty;

        public static string
           nameCid, diaSemana, descricao, city = "", key = "21625a0b", linkWemos = "Nada",
           tempoAtual, umidade, velocidadeVento,sourceMusic, seParoudeFalar, data = "",
           recon, reiniciarCond, CondDes, condCancel, condMusica, porDoSol,
           kj, calado, respCalado;

        public static int ultimoValor;
        public static bool isStopped;
        public static Label rotulo;

        public Form1()
        {
            InitializeComponent();                      
        }

        
        #region Reconhecimento_ON     
        private async static Task FromMic(SpeechConfig speechConfig)
        {
            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            speechConfig.SpeechRecognitionLanguage = "pt-BR";
            var recognizer = new SpeechRecognizer(speechConfig, audioConfig);

            synthVoice2 = new SpeechSynthesizer();
            synthVoice2.Rate = 0;
            synthVoice2.Volume = 100;
            foreach (InstalledVoice voice in synthVoice2.GetInstalledVoices())
            {
                Console.WriteLine(voice.VoiceInfo.Name);
                if(voice.VoiceInfo.Name.Contains("IVONA 2 Ricardo"))
                {
                    synthVoice2.SelectVoice(voice.VoiceInfo.Name);
                }
            }
            
            Comdon comdon = new Comdon();
            string rs;
            var result = await recognizer.RecognizeOnceAsync();
            while (true)
            {
                //Armazenar o resultado do reconhecimento
                result = await recognizer.RecognizeOnceAsync();
                string rst = result.Text;
                if (!string.IsNullOrEmpty(rst))//Se for nulo não faça nada
                {
                    if (result.Text.Contains("Para de falar"))
                    {
                        synthVoice2.SpeakAsyncCancelAll();
                    }
                    Console.WriteLine($"RECONHECIDO: Texto={result.Text}");
                    rs = comdon.GetResponse(result.Text);                    
                    synthVoice2.SpeakAsync(rs);
                    Console.WriteLine(rs);
                    rst = "";
                }               
                
            }
        }
        #endregion

        #region Sintetizador_de_fala
        public static void speak02(string content = "")
        {
            try
            {
                foreach (InstalledVoice voice in sintetizador2.GetInstalledVoices())
                {
                    //Console.WriteLine(voice.VoiceInfo.Name);
                    if (voice.VoiceInfo.Name.Contains("IVONA 2 Ricardo"))
                    {
                        sintetizador2.SelectVoice(voice.VoiceInfo.Name);
                    }
                }

                //sintetizador2.SelectVoice("IVONA 2 Ricardo"); // First list all the voices of the pc with <listAvailableVoicesConfigurator>
                sintetizador2.Volume = 90;
                sintetizador2.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synthesizer_SpeakProgress2);
                sintetizador2.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synthesizer_SpeakCompleted2);
                sintetizador2.SetOutputToDefaultAudioDevice();
                sintetizador2.SpeakAsync(content);
            }
            catch (InvalidOperationException e) { Console.WriteLine(e.Message); }
        }

        //Estado do sintetizador        
        private static void synthesizer_SpeakCompleted2(object sender, SpeakCompletedEventArgs e)
        {
            //            
        }
        private static void synthesizer_SpeakProgress2(object sender, SpeakProgressEventArgs e)
        {
            Console.WriteLine("SpeakProgress: AudioPosition=" + e.AudioPosition + ",\tCharacterPosition=" + e.CharacterPosition + ",\tCharacterCount=" + e.CharacterCount + ",\tText=" + e.Text);
        }
        
        //Parar a fala
        public static void stop2()
        {
            try
            {
                sintetizador2.SpeakAsyncCancelAll();
            }
            catch (ObjectDisposedException) { }
        }
        #endregion                

        #region Eventos_Form
        private void Form1_Shown(object sender, EventArgs e)
        {
            bool cond = CheckForInternetConnection();
            while (cond == false)
            {
                cond = CheckForInternetConnection();
                MessageBox.Show("Verifique a conexão com a internet");
            }
        }
        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            int posX = Cursor.Position.X;
            int posY = Cursor.Position.Y;

            Console.WriteLine("Current mouse position in form's area is " +
                (Control.MousePosition.X - this.Location.X - 8).ToString() +
                "x" +
                (Control.MousePosition.Y - this.Location.Y - 30).ToString()
            );

        }
      

        //form Load        
        private async void Form1_Load(object sender, EventArgs e)
        {
            rotulo = labelRotulo;

            panelContent.Visible = true;
            panelContent.Controls.Clear();
            Inicio inicio = new Inicio();
            inicio.TopLevel = false;
            panelContent.Controls.Add(inicio); //AQUI
            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;
            inicio.Show();

            var speechConfig = SpeechConfig.FromSubscription("810ded2b10834a809285ff49df04d93b", "brazilsouth");
            await FromMic(speechConfig);
            //
        }
       
        //form closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           //
        }
        #endregion

        #region Botoes

        //btn close
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        //btn max
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                btnMax.Image = Image.FromFile("img1/minimize.png");
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                btnMax.Image = Image.FromFile("img1/icons8_full_screen_48px.png");
                WindowState = FormWindowState.Normal;
            }
        }

        //btn minimize
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Btn page inicio
        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            btnMenuSociais.Normalcolor = Color.Indigo;
            btnMenuPredefinidos.Normalcolor = Color.Indigo;
            bunifuFlatButton3.Normalcolor = Color.Black;

            panelContent.Visible = true;
            panelContent.Controls.Clear();
            Inicio inicio = new Inicio();
            inicio.TopLevel = false;
            panelContent.Controls.Add(inicio); //AQUI
            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;
            inicio.Show();
        }

        //Btn sociais
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            btnMenuSociais.Normalcolor = Color.Black;
            btnMenuPredefinidos.Normalcolor = Color.Indigo;
            bunifuFlatButton3.Normalcolor = Color.Indigo;

            panelContent.Visible = true;
            panelContent.Controls.Clear();
            Soc soc = new Soc();
            soc.TopLevel = false;
            panelContent.Controls.Add(soc); //AQUI
            soc.FormBorderStyle = FormBorderStyle.None;
            soc.Dock = DockStyle.Fill;
            soc.Show();
        }

        //Btn predefinidos
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            btnMenuSociais.Normalcolor = Color.Indigo;
            btnMenuPredefinidos.Normalcolor = Color.Black;
            bunifuFlatButton3.Normalcolor = Color.Indigo;

            panelContent.Visible = true;
            panelContent.Controls.Clear();
            Predef predef = new Predef();
            predef.TopLevel = false;
            panelContent.Controls.Add(predef); //AQUI
            predef.FormBorderStyle = FormBorderStyle.None;
            predef.Dock = DockStyle.Fill;
            predef.Show();
        }


        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        #endregion

        #region Filtrar_Texto
        public static string RemoveAccents(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }
        #endregion

        #region Checar_Internet
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

        //Checar se tem conexão com a internet
        public bool CheckForInternetConnection()
        {
            try
            {
                bool hasConnection = (new Ping().Send("www.google.com").Status == IPStatus.Success) ? true : false;
                return hasConnection;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}