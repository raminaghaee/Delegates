using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public delegate void ShowMessageDelegate(string message);
    public class MessageBoxHandler
    {
        public ShowMessageDelegate ShowMessage;

        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarningBox(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
