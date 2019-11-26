using MVP.UI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.UI.Main
{
    class MainPresenter<V> : BasePresenter<V>,
        IMainPresenter<V> where V : IMainView
    {

        public void DigitarTexto()
        {
            GetContractView().CaixaTexto = "Ola Mundo";
        }

        public void showTextMensage()
        {
            GetContractView().ShowMessage("Texto: " + GetContractView().CaixaTexto);
        }
    }
}
