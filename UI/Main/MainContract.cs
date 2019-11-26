using MVP.UI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.UI.Main
{
    public interface IMainView : IBaseView
    {
        string CaixaTexto { get; set; }
    }

    public interface IMainPresenter<V> : IBasePresenter<V> where V : IMainView
    {
        void DigitarTexto();
        void showTextMensage();
    }
}
