using System;
using System.IO;
using System.Windows.Forms;
using ChatBot.Model;

namespace ChatBot.Editor
{
    public partial class MainForm : Form
    {
        private Script _script;
        private string _filename;

        public MainForm()
        {
            InitializeComponent();

            NewScript();
        }

        private void NewScript()
        {
            Text = "Desafio Banco Carrefour ChatBot Editor - Novo arquivo";

            _filename = string.Empty;

            _script = new Script();
            _script.Start.Id = "start";
            _script.Start.Label = "Início";

            ReloadTree();
        }

        private void OpenScript(string filename)
        {
            Text = string.Concat("Desafio Banco Carrefour ChatBot Editor - ", Path.GetFileName(filename));

            _filename = filename;
            _script = Script.LoadFromFile(filename);
            ReloadTree();
        }

        private void SaveScript()
        {
            Text = string.Concat("Desafio Banco Carrefour ChatBot Editor - ", Path.GetFileName(_filename));
            _script.SaveToFile(_filename);
        }

        private void ReloadTree()
        {
            PagesTabControl.SelectedIndex = 0;

            ChoosePhraseTextBox.Text = _script.ChoosePhrase;
            ContinuePhraseTextBox.Text = _script.ContinuePhrase;
            RestartPhraseTextBox.Text = _script.RestartPhrase;

            GreetingsTextBox.Lines = _script.Greetings;
            UnknowTextBox.Lines = _script.Unknow;

            FlowTreeView.BeginUpdate();
            FlowTreeView.Nodes.Clear();
            
            AddTree(_script.Start);
            if (FlowTreeView.Nodes.Count > 0)
                FlowTreeView.SelectedNode = FlowTreeView.Nodes[0];
            
            FlowTreeView.ExpandAll();
            FlowTreeView.EndUpdate();
        }

        private void AddTree(Dialog dialog, TreeNode root = null)
        {
            if (root == null)
            {
                root = new TreeNode(string.Format("{0} ({1})", dialog.Label, dialog.Id)) { Tag = dialog };
                FlowTreeView.Nodes.Add(root);
            }
            else
            {
                var node = new TreeNode(string.Format("{0} ({1})", dialog.Label, dialog.Id)) { Tag = dialog };
                root.Nodes.Add(node);
                root = node;
            }

            foreach (var node in dialog.Dialogs)
            {
                AddTree(node, root);
            }
        }

        private void ApplyConfigButton_Click(object sender, EventArgs e)
        {
            _script.ChoosePhrase = ChoosePhraseTextBox.Text.Trim();
            _script.ContinuePhrase = ContinuePhraseTextBox.Text.Trim();
            _script.RestartPhrase = RestartPhraseTextBox.Text.Trim();

            _script.Greetings = GreetingsTextBox.Lines;
            _script.Unknow = UnknowTextBox.Lines;
        }

        private void FlowTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var dialog = (Dialog)e.Node.Tag;
            IdTextBox.Text = dialog.Id;
            LabelTextBox.Text = dialog.Label;
            PhrasesTextBox.Lines = dialog.Phrases;

            if (string.IsNullOrEmpty(dialog.Goto))
            {
                GotoCheckBox.Checked = false;
                GotoTextBox.Text = string.Empty;
                GotoTextBox.Enabled = false;
            }
            else
            {
                GotoCheckBox.Checked = true;
                GotoTextBox.Text = dialog.Goto;
                GotoTextBox.Enabled = true;
            }
        }

        private void GotoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GotoTextBox.Enabled = GotoCheckBox.Checked;
            if (!GotoTextBox.Enabled)
                GotoTextBox.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FlowTreeView.SelectedNode != null)
            {
                var dialog = (Dialog)FlowTreeView.SelectedNode.Tag;
                var child = new Dialog() { Label = "Novo diálogo" };
                dialog.Dialogs.Add(child);

                FlowTreeView.BeginUpdate();
                FlowTreeView.SelectedNode.Nodes.Clear();
                foreach (var node in dialog.Dialogs)
                    AddTree(node, FlowTreeView.SelectedNode);
                FlowTreeView.SelectedNode.ExpandAll();
                FlowTreeView.SelectedNode = FlowTreeView.SelectedNode.Nodes[FlowTreeView.SelectedNode.Nodes.Count - 1];
                FlowTreeView.EndUpdate();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (FlowTreeView.SelectedNode != null)
            {
                var dialog = (Dialog)FlowTreeView.SelectedNode.Tag;

                dialog.Id = IdTextBox.Text.Trim();
                dialog.Label = LabelTextBox.Text.Trim();
                dialog.Phrases = PhrasesTextBox.Lines;
                dialog.Goto = GotoCheckBox.Checked ? GotoTextBox.Text.Trim() : string.Empty;

                FlowTreeView.BeginUpdate();
                FlowTreeView.SelectedNode.Text = string.Format("{0} ({1})", dialog.Label, dialog.Id);
                FlowTreeView.EndUpdate();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FlowTreeView.SelectedNode != null && (FlowTreeView.Nodes.Count > 1 || !FlowTreeView.SelectedNode.Equals(FlowTreeView.Nodes[0])))
            {
                var dialog = (Dialog)FlowTreeView.SelectedNode.Tag;

                FlowTreeView.BeginUpdate();
                if (FlowTreeView.SelectedNode.Parent == null)
                {
                    _script.Start.Dialogs.Remove(dialog);
                    FlowTreeView.Nodes.Remove(FlowTreeView.SelectedNode);
                    FlowTreeView.SelectedNode = FlowTreeView.Nodes[0];
                }
                else
                {
                    var root = FlowTreeView.SelectedNode.Parent;
                    root.Nodes.Remove(FlowTreeView.SelectedNode);
                    FlowTreeView.SelectedNode = root;

                    var parent = (Dialog)root.Tag;
                    parent.Dialogs.Remove(dialog);
                }
                FlowTreeView.EndUpdate();
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewScript();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog()
            {
                Title = "Abrir arquivo...",
                Filter = "Arquivo de script|*.json",
                DefaultExt = ".json"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OpenScript(dialog.FileName);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_filename))
                SaveAsToolStripMenuItem_Click(sender, e);
            else
                SaveScript();

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog()
            {
                Title = "Salvar arquivo como...",
                Filter = "Arquivo de script|*.json",
                DefaultExt = ".json"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _filename = dialog.FileName;
                    SaveToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void PagesTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PagesTabControl.SelectedIndex == 2)
            {
                TestChatControl.LoadScript(_script);
            }
        }
    }
}
