namespace ChatBot.Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PagesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UnknowTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GreetingsTextBox = new System.Windows.Forms.TextBox();
            this.ApplyConfigButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FlowTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.GotoTextBox = new System.Windows.Forms.TextBox();
            this.GotoCheckBox = new System.Windows.Forms.CheckBox();
            this.PhrasesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoosePhraseTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RestartPhraseTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ContinuePhraseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TestChatControl = new ChatBot.Editor.Controls.ChatControl();
            this.PagesTabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagesTabControl
            // 
            this.PagesTabControl.Controls.Add(this.tabPage3);
            this.PagesTabControl.Controls.Add(this.tabPage1);
            this.PagesTabControl.Controls.Add(this.tabPage2);
            this.PagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagesTabControl.Location = new System.Drawing.Point(0, 24);
            this.PagesTabControl.Name = "PagesTabControl";
            this.PagesTabControl.SelectedIndex = 0;
            this.PagesTabControl.Size = new System.Drawing.Size(784, 487);
            this.PagesTabControl.TabIndex = 0;
            this.PagesTabControl.SelectedIndexChanged += new System.EventHandler(this.PagesTabControl_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ContinuePhraseTextBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.RestartPhraseTextBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.ChoosePhraseTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.UnknowTextBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.GreetingsTextBox);
            this.tabPage3.Controls.Add(this.ApplyConfigButton);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(776, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuração";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UnknowTextBox
            // 
            this.UnknowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnknowTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnknowTextBox.Location = new System.Drawing.Point(11, 285);
            this.UnknowTextBox.Multiline = true;
            this.UnknowTextBox.Name = "UnknowTextBox";
            this.UnknowTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnknowTextBox.Size = new System.Drawing.Size(757, 109);
            this.UnknowTextBox.TabIndex = 4;
            this.UnknowTextBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensagens de dúvidas:";
            // 
            // GreetingsTextBox
            // 
            this.GreetingsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingsTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingsTextBox.Location = new System.Drawing.Point(11, 135);
            this.GreetingsTextBox.Multiline = true;
            this.GreetingsTextBox.Name = "GreetingsTextBox";
            this.GreetingsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GreetingsTextBox.Size = new System.Drawing.Size(757, 109);
            this.GreetingsTextBox.TabIndex = 3;
            this.GreetingsTextBox.WordWrap = false;
            // 
            // ApplyConfigButton
            // 
            this.ApplyConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyConfigButton.Location = new System.Drawing.Point(645, 430);
            this.ApplyConfigButton.Name = "ApplyConfigButton";
            this.ApplyConfigButton.Size = new System.Drawing.Size(123, 23);
            this.ApplyConfigButton.TabIndex = 1;
            this.ApplyConfigButton.Text = "Aplicar";
            this.ApplyConfigButton.UseVisualStyleBackColor = true;
            this.ApplyConfigButton.Click += new System.EventHandler(this.ApplyConfigButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagens de apresentação:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FlowTreeView);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edição";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FlowTreeView
            // 
            this.FlowTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FlowTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowTreeView.FullRowSelect = true;
            this.FlowTreeView.HideSelection = false;
            this.FlowTreeView.Location = new System.Drawing.Point(3, 3);
            this.FlowTreeView.Name = "FlowTreeView";
            this.FlowTreeView.Size = new System.Drawing.Size(770, 267);
            this.FlowTreeView.TabIndex = 0;
            this.FlowTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FlowTreeView_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.ApplyButton);
            this.panel1.Controls.Add(this.GotoTextBox);
            this.panel1.Controls.Add(this.GotoCheckBox);
            this.panel1.Controls.Add(this.PhrasesTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IdTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LabelTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 188);
            this.panel1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(134, 160);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Excluir";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(5, 160);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Novo";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(642, 160);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(123, 23);
            this.ApplyButton.TabIndex = 5;
            this.ApplyButton.Text = "Aplicar";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // GotoTextBox
            // 
            this.GotoTextBox.Location = new System.Drawing.Point(83, 114);
            this.GotoTextBox.Name = "GotoTextBox";
            this.GotoTextBox.Size = new System.Drawing.Size(283, 20);
            this.GotoTextBox.TabIndex = 4;
            // 
            // GotoCheckBox
            // 
            this.GotoCheckBox.AutoSize = true;
            this.GotoCheckBox.Location = new System.Drawing.Point(20, 114);
            this.GotoCheckBox.Name = "GotoCheckBox";
            this.GotoCheckBox.Size = new System.Drawing.Size(59, 17);
            this.GotoCheckBox.TabIndex = 3;
            this.GotoCheckBox.Text = "Ir para:";
            this.GotoCheckBox.UseVisualStyleBackColor = true;
            this.GotoCheckBox.CheckedChanged += new System.EventHandler(this.GotoCheckBox_CheckedChanged);
            // 
            // PhrasesTextBox
            // 
            this.PhrasesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhrasesTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhrasesTextBox.Location = new System.Drawing.Point(83, 33);
            this.PhrasesTextBox.Multiline = true;
            this.PhrasesTextBox.Name = "PhrasesTextBox";
            this.PhrasesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PhrasesTextBox.Size = new System.Drawing.Size(682, 75);
            this.PhrasesTextBox.TabIndex = 2;
            this.PhrasesTextBox.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mensagens:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(482, 7);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(283, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Identificador:";
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Location = new System.Drawing.Point(83, 7);
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.Size = new System.Drawing.Size(283, 20);
            this.LabelTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rótulo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TestChatControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teste";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.NewToolStripMenuItem.Text = "&Novo";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.OpenToolStripMenuItem.Text = "A&brir...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SaveToolStripMenuItem.Text = "&Salvar";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.SaveAsToolStripMenuItem.Text = "Salvar &como...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ChoosePhraseTextBox
            // 
            this.ChoosePhraseTextBox.Location = new System.Drawing.Point(131, 24);
            this.ChoosePhraseTextBox.Name = "ChoosePhraseTextBox";
            this.ChoosePhraseTextBox.Size = new System.Drawing.Size(283, 20);
            this.ChoosePhraseTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Texto de escolha:";
            // 
            // RestartPhraseTextBox
            // 
            this.RestartPhraseTextBox.Location = new System.Drawing.Point(131, 50);
            this.RestartPhraseTextBox.Name = "RestartPhraseTextBox";
            this.RestartPhraseTextBox.Size = new System.Drawing.Size(283, 20);
            this.RestartPhraseTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Texto para recomeçar:";
            // 
            // ContinuePhraseTextBox
            // 
            this.ContinuePhraseTextBox.Location = new System.Drawing.Point(131, 76);
            this.ContinuePhraseTextBox.Name = "ContinuePhraseTextBox";
            this.ContinuePhraseTextBox.Size = new System.Drawing.Size(283, 20);
            this.ContinuePhraseTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Texto para retornar:";
            // 
            // TestChatControl
            // 
            this.TestChatControl.BackColor = System.Drawing.SystemColors.Window;
            this.TestChatControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestChatControl.Location = new System.Drawing.Point(3, 3);
            this.TestChatControl.Name = "TestChatControl";
            this.TestChatControl.Size = new System.Drawing.Size(770, 455);
            this.TestChatControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.PagesTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafio Banco Carrefour ChatBot Editor";
            this.PagesTabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl PagesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox UnknowTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GreetingsTextBox;
        private System.Windows.Forms.Button ApplyConfigButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView FlowTreeView;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LabelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox GotoTextBox;
        private System.Windows.Forms.CheckBox GotoCheckBox;
        private System.Windows.Forms.TextBox PhrasesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private Controls.ChatControl TestChatControl;
        private System.Windows.Forms.TextBox RestartPhraseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ChoosePhraseTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ContinuePhraseTextBox;
        private System.Windows.Forms.Label label8;
    }
}

