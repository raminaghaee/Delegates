using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class MessageBox_Delegate : Form
    {
        public MessageBox_Delegate()
        {
            InitializeComponent();
        }
        MessageBoxHandler messageBoxHandle = new MessageBoxHandler();

        private void radButton1_Click(object sender, EventArgs e)
        {
            messageBoxHandle.ShowMessage = messageBoxHandle.ShowMessageBox;
            messageBoxHandle.ShowMessage("This is a normal MessageBox");
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            messageBoxHandle.ShowMessage = messageBoxHandle.ShowErrorBox;
            messageBoxHandle.ShowMessage("This is an error MessageBox");
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            messageBoxHandle.ShowMessage = messageBoxHandle.ShowWarningBox;
            messageBoxHandle.ShowMessage("This is a warning MessageBox");
        }
    }
}
