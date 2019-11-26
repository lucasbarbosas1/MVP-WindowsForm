using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.UI.Base
{
    public partial class BaseView : Form, IBaseView
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
