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

namespace MVP.UI.Clientes
{
    public partial class ClienteView : BaseView, IClienteView
    {

        private IClientePresenter<IClienteView> presenter;

        public ClienteView()
        {
            InitializeComponent();
            presenter = new ClientePresenter<IClienteView>();
            presenter.OnAttach(this);
        }

        public string Texto { get => texto.Text; set => texto.Text = value; }
    }
}
