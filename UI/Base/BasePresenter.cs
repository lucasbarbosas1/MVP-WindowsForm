using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.UI.Base
{
    public class BasePresenter<V> : IBasePresenter<V> where V : IBaseView
    {
        private V view;


        public void OnAttach(V view)
        {
            this.view = view;
        }


        public V GetContractView()
        {
            return view;
        }
    }
}
