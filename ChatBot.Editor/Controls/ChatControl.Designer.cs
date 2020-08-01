namespace ChatBot.Editor.Controls
{
    partial class ChatControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DialogsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.Location = new System.Drawing.Point(3, 658);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(834, 20);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageTextBox_KeyPress);
            // 
            // ChatRichTextBox
            // 
            this.ChatRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ChatRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.ChatRichTextBox.Name = "ChatRichTextBox";
            this.ChatRichTextBox.ReadOnly = true;
            this.ChatRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ChatRichTextBox.Size = new System.Drawing.Size(834, 652);
            this.ChatRichTextBox.TabIndex = 1;
            this.ChatRichTextBox.Text = "";
            // 
            // DialogsFlowLayoutPanel
            // 
            this.DialogsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogsFlowLayoutPanel.Location = new System.Drawing.Point(3, 624);
            this.DialogsFlowLayoutPanel.Name = "DialogsFlowLayoutPanel";
            this.DialogsFlowLayoutPanel.Size = new System.Drawing.Size(834, 31);
            this.DialogsFlowLayoutPanel.TabIndex = 2;
            this.DialogsFlowLayoutPanel.Visible = false;
            // 
            // ChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ChatRichTextBox);
            this.Controls.Add(this.DialogsFlowLayoutPanel);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "ChatControl";
            this.Size = new System.Drawing.Size(840, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.RichTextBox ChatRichTextBox;
        private System.Windows.Forms.FlowLayoutPanel DialogsFlowLayoutPanel;
    }
}
