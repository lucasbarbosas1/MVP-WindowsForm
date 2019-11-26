using MVP.UI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.UI.Clientes
{
    class ClientePresenter<V> : BasePresenter<V>,
        IClientePresenter<V> where V : IClienteView
    {

    }
}
