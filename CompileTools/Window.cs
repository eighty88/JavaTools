using System.Windows.Forms;

namespace CompileTools
{
    public class Window : Form
    {
        private System.ComponentModel.IContainer components = null;
        private string fileName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Window(string fileName)
        {
            this.fileName = fileName;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }
    }
}
