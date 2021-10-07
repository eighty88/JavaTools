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
        private GroupBox groupBoxDependency;
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
            list.Add("JDK 16.0.2 (バンドルされたJDK)");
            foreach (string str in JavaRegistry.getJDKs())
            {
                list.Add("JDK " + str.Split('$')[0] + " (" + str.Split('$')[1] + ")");
            }
            checkedListBoxJDK.Items.AddRange(list.ToArray());
            checkedListBoxJDK.SetItemChecked(0, true);
        }

        private void InitializeComponent()
        {
            this.groupBoxJDK = new System.Windows.Forms.GroupBox();
            this.checkedListBoxJDK = new System.Windows.Forms.CheckedListBox();
            this.groupBoxDependency = new System.Windows.Forms.GroupBox();
            this.groupBoxJDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxJDK
            // 
            this.groupBoxJDK.Controls.Add(this.checkedListBoxJDK);
            this.groupBoxJDK.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxJDK.Location = new System.Drawing.Point(12, 97);
            this.groupBoxJDK.Name = "groupBoxJDK";
            this.groupBoxJDK.Size = new System.Drawing.Size(335, 394);
            this.groupBoxJDK.TabIndex = 0;
            this.groupBoxJDK.TabStop = false;
            this.groupBoxJDK.Text = "JDKの設定";
            // 
            // checkedListBoxJDK
            // 
            this.checkedListBoxJDK.BackColor = System.Drawing.Color.Ivory;
            this.checkedListBoxJDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxJDK.CheckOnClick = true;
            this.checkedListBoxJDK.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBoxJDK.FormattingEnabled = true;
            this.checkedListBoxJDK.Location = new System.Drawing.Point(6, 46);
            this.checkedListBoxJDK.Name = "checkedListBoxJDK";
            this.checkedListBoxJDK.Size = new System.Drawing.Size(323, 340);
            this.checkedListBoxJDK.TabIndex = 0;
            this.checkedListBoxJDK.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxJDK_ItemCheck);
            // 
            // groupBoxDependency
            // 
            this.groupBoxDependency.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxDependency.Location = new System.Drawing.Point(353, 97);
            this.groupBoxDependency.Name = "groupBoxDependency";
            this.groupBoxDependency.Size = new System.Drawing.Size(419, 394);
            this.groupBoxDependency.TabIndex = 1;
            this.groupBoxDependency.TabStop = false;
            this.groupBoxDependency.Text = "依存関係";
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxDependency);
            this.Controls.Add(this.groupBoxJDK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.groupBoxJDK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void checkedListBoxJDK_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedListBoxJDK.ItemCheck -= checkedListBoxJDK_ItemCheck;

            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBoxJDK.Items.Count; i++)
                {
                    if (e.Index != i)
                    {
                        this.checkedListBoxJDK.SetItemChecked(i, false);
                    }
                }
            }
            else
            {
                e.NewValue = CheckState.Checked;
            }

            checkedListBoxJDK.ItemCheck += checkedListBoxJDK_ItemCheck;
        }
    }
}
