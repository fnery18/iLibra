using iLibra.ReconhecimentoVoz.Reconhecimento.Properties;
using Microsoft.Speech.Recognition;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace iLibra.ReconhecimentoVoz.Reconhecimento
{
    public class Reconhece
    {
        static CultureInfo culture;
        static SpeechRecognitionEngine reconhecedor;
        readonly SpeechSynthesizer resposta;
        private readonly string[] palavras;
        private readonly Label lblResultado;
        private readonly PictureBox gif;
        int QuantidadeFrame = 0;
        int FrameAtual = 0;

        public Reconhece(Label ondeExibirResultado, PictureBox ondeExibirGif)
        {
            culture = new CultureInfo("pt-BR");
            resposta = new SpeechSynthesizer();
            lblResultado = ondeExibirResultado;
            gif = ondeExibirGif;

            palavras = new string[]
            {
                //colocar aqui as novas palavras e adicionar nos resources o gif com o mesmo nome da palavra
                "a","oi","A","Acessibilidade","Aula","B","Bem_vindo_alunos","Boa_noite","Boa_tarde","Bom_dia","C","Computador","D","E","Engenharia","F","Faculdade","G","H","I","J","K","L","Libras","Linguagem","M","N","O","Ola","P","Programação","Q","R","S","T","Tchau","Tecnologia","U","V","W","X","Y","Z"
            };


            AjustaVolume();

            InicializarReconhecimento();
        }

        private void AjustaVolume()
        {
            resposta.Volume = 100;
            resposta.Rate = 4;
        }

        private void InicializarReconhecimento()
        {
            try
            {
                reconhecedor = new SpeechRecognitionEngine(culture);

                var escolhas = new Choices();
                escolhas.Add(palavras);

                var construtorGramatica = new GrammarBuilder();
                construtorGramatica.Append(escolhas);


                ExecutaReconhecimento(gramatica: new Grammar(construtorGramatica));

            }
            catch (System.Exception e)
            {

                ExibeMensagemErro("Ops! " + e.Message);
            }

        }

        private void ExibeMensagemErro(string mensagem)
        {
            lblResultado.Text = mensagem;
            //MessageBox.Show(mensagem, "iLibra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExecutaReconhecimento(Grammar gramatica)
        {
            reconhecedor.RequestRecognizerUpdate();

            reconhecedor.LoadGrammarAsync(gramatica);
            reconhecedor.SpeechRecognized += ProcessarReconhecimento;
            reconhecedor.SpeechDetected += ProcessarPalavraNaoReconhecida;
            reconhecedor.SpeechRecognitionRejected += ProcessarTeste;
            reconhecedor.RecognizeCompleted += ProcessarTeste2;
            reconhecedor.SpeechHypothesized += ProcessarTeste3;

            reconhecedor.SetInputToDefaultAudioDevice();

            resposta.SetOutputToDefaultAudioDevice();

            reconhecedor.RecognizeAsync(RecognizeMode.Multiple);
            ExibirPalavraFalada("Detectando palavra....");
        }

        private void ProcessarTeste3(object sender, SpeechHypothesizedEventArgs e)
        {
   
        }

        private void ProcessarTeste2(object sender, RecognizeCompletedEventArgs e)
        {

        }

        private void ProcessarTeste(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            
        }

        private void ProcessarPalavraNaoReconhecida(object sender, SpeechDetectedEventArgs e)
        {
            ExibirPalavraFalada("", exibirGif: false);
        }

        private void ProcessarReconhecimento(object sender, SpeechRecognizedEventArgs e)
        {
            string palavraFalada = e.Result.Text;

            if (palavras.Contains(palavraFalada))
            {
                ExibirPalavraFalada(palavraFalada, exibirGif: true);
            }
        }

        private void ExibirPalavraFalada(string palavraFalada, bool exibirGif = false)
        {
            lblResultado.Text = palavraFalada;

            if (exibirGif)
            {

                try
                {
                    gif.Enabled = true;
                    gif.Paint += new PaintEventHandler(PictureBox1_Paint);
                    gif.Image = (Image)Resources.ResourceManager.GetObject(palavraFalada, culture);

                    FrameDimension dimension = new FrameDimension(gif.Image.FrameDimensionsList[0]);
                    QuantidadeFrame = gif.Image.GetFrameCount(dimension);

                }
                catch (System.Exception e)
                {


                }
            }
        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (FrameAtual == QuantidadeFrame)
            {
                gif.Enabled = false;
                gif.Image = null;
                gif.Paint -= new PaintEventHandler(PictureBox1_Paint);
                FrameAtual = 0;
            }
            FrameAtual++;
        }
    }
}
