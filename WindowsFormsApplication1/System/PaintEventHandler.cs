using System.Windows.Forms;

namespace System
{
    internal class PaintEventHandler
    {
        private Action<object, PaintEventArgs> showButton_Click;

        public PaintEventHandler(Action<object, PaintEventArgs> showButton_Click)
        {
            this.showButton_Click = showButton_Click;
        }
    }
}