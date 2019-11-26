using MVP.UI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.UI.Clientes
{

    public interface IClienteView : IBaseView
    {
        string Texto { get; set; }
    }

    public interface IClientePresenter<V>:IBasePresenter<V> where V : IClienteView
    {

    }
}
