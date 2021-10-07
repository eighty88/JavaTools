using JavaToolsLib.RegistryLib;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CompileTools
{
    public class Window : Form
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxJDK;
        private CheckedListBox checkedListBoxJDK;
        private TextBox textBox1;
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

            Text = "Javaをコンパイルする - " + fileName;
            List<string> list = new List<string>();
            foreach (string str in JavaRegistry.getJDKs())
            {
                list.Add(str.Split('$')[0] + " (" + str.Split('$')[1] + ")");
            }
            checkedListBoxJDK.Items.AddRange(list.ToArray());
        }

        private void InitializeComponent()
        {
            this.groupBoxJDK = new System.Windows.Forms.GroupBox();
            this.checkedListBoxJDK = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxJDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxJDK
            // 
            this.groupBoxJDK.Controls.Add(this.checkedListBoxJDK);
            this.groupBoxJDK.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxJDK.Location = new System.Drawing.Point(12, 101);
            this.groupBoxJDK.Name = "groupBoxJDK";
            this.groupBoxJDK.Size = new System.Drawing.Size(340, 448);
            this.groupBoxJDK.TabIndex = 0;
            this.groupBoxJDK.TabStop = false;
            this.groupBoxJDK.Text = "JDKの設定";
            // 
            // checkedListBoxJDK
            // 
            this.checkedListBoxJDK.CheckOnClick = true;
            this.checkedListBoxJDK.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBoxJDK.FormattingEnabled = true;
            this.checkedListBoxJDK.Location = new System.Drawing.Point(6, 58);
            this.checkedListBoxJDK.Name = "checkedListBoxJDK";
            this.checkedListBoxJDK.Size = new System.Drawing.Size(328, 384);
            this.checkedListBoxJDK.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 299);
            this.textBox1.TabIndex = 1;
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxJDK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.groupBoxJDK.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
