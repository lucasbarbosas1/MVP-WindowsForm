using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.UI.Base
{
    public interface IBaseView
    {
        void ShowMessage(string message);
    }

    public interface IBasePresenter<V> where V : IBaseView
    {
        void OnAttach(V view);
        V GetContractView();
    }
}
