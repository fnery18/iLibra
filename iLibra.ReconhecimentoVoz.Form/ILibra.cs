using iLibra.ReconhecimentoVoz.Reconhecimento;
using System;
using System.Windows.Forms;

namespace iLibra.ReconhecimentoVoz.Forms
{
    public partial class ILibra : Form
    {
        public Reconhece Reconhecimento { get; }

        public ILibra()
        {
            InitializeComponent();
            Reconhecimento = new Reconhece(ondeExibirResultado: LblPalavra, ondeExibirGif: ImgPalavra);
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PanelLibraCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ILibra_Load(object sender, EventArgs e)
        {

        }
    }
}
