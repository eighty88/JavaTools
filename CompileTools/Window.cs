﻿using JavaToolsLib.RegistryLib;
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
        private Button buttonRemoveJDK;
        private Button buttonAddJDK;
        private ListBox listBoxDependencies;
        private Button buttonRemoveDependencies;
        private Button buttonAddDependencies;
        private Button buttonURLDependencies;
        private Button buttonCompile;
        private Button buttonSaveFile;
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
            this.buttonRemoveJDK = new System.Windows.Forms.Button();
            this.buttonAddJDK = new System.Windows.Forms.Button();
            this.checkedListBoxJDK = new System.Windows.Forms.CheckedListBox();
            this.groupBoxDependency = new System.Windows.Forms.GroupBox();
            this.listBoxDependencies = new System.Windows.Forms.ListBox();
            this.buttonAddDependencies = new System.Windows.Forms.Button();
            this.buttonRemoveDependencies = new System.Windows.Forms.Button();
            this.buttonURLDependencies = new System.Windows.Forms.Button();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.groupBoxJDK.SuspendLayout();
            this.groupBoxDependency.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxJDK
            // 
            this.groupBoxJDK.Controls.Add(this.buttonRemoveJDK);
            this.groupBoxJDK.Controls.Add(this.buttonAddJDK);
            this.groupBoxJDK.Controls.Add(this.checkedListBoxJDK);
            this.groupBoxJDK.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxJDK.Location = new System.Drawing.Point(12, 85);
            this.groupBoxJDK.Name = "groupBoxJDK";
            this.groupBoxJDK.Size = new System.Drawing.Size(335, 406);
            this.groupBoxJDK.TabIndex = 0;
            this.groupBoxJDK.TabStop = false;
            this.groupBoxJDK.Text = "JDKの設定";
            // 
            // buttonRemoveJDK
            // 
            this.buttonRemoveJDK.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRemoveJDK.Location = new System.Drawing.Point(299, 24);
            this.buttonRemoveJDK.Name = "buttonRemoveJDK";
            this.buttonRemoveJDK.Size = new System.Drawing.Size(30, 30);
            this.buttonRemoveJDK.TabIndex = 2;
            this.buttonRemoveJDK.Text = "－";
            this.buttonRemoveJDK.UseVisualStyleBackColor = true;
            // 
            // buttonAddJDK
            // 
            this.buttonAddJDK.FlatAppearance.BorderSize = 0;
            this.buttonAddJDK.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddJDK.Location = new System.Drawing.Point(263, 24);
            this.buttonAddJDK.Name = "buttonAddJDK";
            this.buttonAddJDK.Size = new System.Drawing.Size(30, 30);
            this.buttonAddJDK.TabIndex = 1;
            this.buttonAddJDK.Text = "+";
            this.buttonAddJDK.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxJDK
            // 
            this.checkedListBoxJDK.BackColor = System.Drawing.Color.Ivory;
            this.checkedListBoxJDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxJDK.CheckOnClick = true;
            this.checkedListBoxJDK.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkedListBoxJDK.FormattingEnabled = true;
            this.checkedListBoxJDK.Location = new System.Drawing.Point(6, 60);
            this.checkedListBoxJDK.Name = "checkedListBoxJDK";
            this.checkedListBoxJDK.Size = new System.Drawing.Size(323, 340);
            this.checkedListBoxJDK.TabIndex = 0;
            this.checkedListBoxJDK.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxJDK_ItemCheck);
            // 
            // groupBoxDependency
            // 
            this.groupBoxDependency.Controls.Add(this.buttonURLDependencies);
            this.groupBoxDependency.Controls.Add(this.buttonRemoveDependencies);
            this.groupBoxDependency.Controls.Add(this.buttonAddDependencies);
            this.groupBoxDependency.Controls.Add(this.listBoxDependencies);
            this.groupBoxDependency.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxDependency.Location = new System.Drawing.Point(353, 85);
            this.groupBoxDependency.Name = "groupBoxDependency";
            this.groupBoxDependency.Size = new System.Drawing.Size(419, 406);
            this.groupBoxDependency.TabIndex = 1;
            this.groupBoxDependency.TabStop = false;
            this.groupBoxDependency.Text = "依存関係";
            // 
            // listBoxDependencies
            // 
            this.listBoxDependencies.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxDependencies.FormattingEnabled = true;
            this.listBoxDependencies.ItemHeight = 24;
            this.listBoxDependencies.Location = new System.Drawing.Point(6, 60);
            this.listBoxDependencies.Name = "listBoxDependencies";
            this.listBoxDependencies.Size = new System.Drawing.Size(407, 340);
            this.listBoxDependencies.TabIndex = 0;
            // 
            // buttonAddDependencies
            // 
            this.buttonAddDependencies.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddDependencies.Location = new System.Drawing.Point(347, 24);
            this.buttonAddDependencies.Name = "buttonAddDependencies";
            this.buttonAddDependencies.Size = new System.Drawing.Size(30, 30);
            this.buttonAddDependencies.TabIndex = 1;
            this.buttonAddDependencies.Text = "+";
            this.buttonAddDependencies.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDependencies
            // 
            this.buttonRemoveDependencies.Font = new System.Drawing.Font("メイリオ", 12F);
            this.buttonRemoveDependencies.Location = new System.Drawing.Point(383, 24);
            this.buttonRemoveDependencies.Name = "buttonRemoveDependencies";
            this.buttonRemoveDependencies.Size = new System.Drawing.Size(30, 30);
            this.buttonRemoveDependencies.TabIndex = 2;
            this.buttonRemoveDependencies.Text = "－";
            this.buttonRemoveDependencies.UseVisualStyleBackColor = true;
            // 
            // buttonURLDependencies
            // 
            this.buttonURLDependencies.Font = new System.Drawing.Font("メイリオ", 12F);
            this.buttonURLDependencies.Location = new System.Drawing.Point(257, 24);
            this.buttonURLDependencies.Name = "buttonURLDependencies";
            this.buttonURLDependencies.Size = new System.Drawing.Size(84, 30);
            this.buttonURLDependencies.TabIndex = 3;
            this.buttonURLDependencies.Text = "+ (URL)";
            this.buttonURLDependencies.UseVisualStyleBackColor = true;
            // 
            // buttonCompile
            // 
            this.buttonCompile.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonCompile.Location = new System.Drawing.Point(609, 511);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(150, 30);
            this.buttonCompile.TabIndex = 2;
            this.buttonCompile.Text = "コンパイルする";
            this.buttonCompile.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonSaveFile.Location = new System.Drawing.Point(403, 511);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(200, 30);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.Text = "設定をファイルに出力";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonCompile);
            this.Controls.Add(this.groupBoxDependency);
            this.Controls.Add(this.groupBoxJDK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Window_Load);
            this.groupBoxJDK.ResumeLayout(false);
            this.groupBoxDependency.ResumeLayout(false);
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

        private void Window_Load(object sender, System.EventArgs e)
        {

        }
    }
}
