using System.Windows.Forms;

namespace CompileTools
{
    public class Window : Form
    {
        private System.ComponentModel.IContainer components = null;
        private string FileName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Window()
        {
            FileName = System.Environment.GetCommandLineArgs()[0];
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Name = "Window";
            this.ResumeLayout(false);

        }
    }
}
