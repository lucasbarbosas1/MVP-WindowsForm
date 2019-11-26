using MVP.UI.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.UI.Main
{
    public partial class MainView : BaseView, IMainView
    {

        private readonly IMainPresenter<IMainView> presenter;

        public string CaixaTexto
        {
            get { return texto.Text; }
            set { texto.Text = value; }
        }

        public MainView()
        {
            InitializeComponent();
            presenter = new MainPresenter<IMainView>();
            presenter.OnAttach(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage("Mensagem da Main View");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.DigitarTexto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.showTextMensage();
        }
    }
}
