namespace GameScriptCreator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCreateScene = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtSceneName = new System.Windows.Forms.TextBox();
            this.btnCreateDialogue = new System.Windows.Forms.Button();
            this.txtDialogueText = new System.Windows.Forms.TextBox();
            this.lstScenes = new System.Windows.Forms.ListBox();
            this.lstDialogues = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateScene
            // 
            this.btnCreateScene.Location = new System.Drawing.Point(27, 56);
            this.btnCreateScene.Name = "btnCreateScene";
            this.btnCreateScene.Size = new System.Drawing.Size(98, 46);
            this.btnCreateScene.TabIndex = 0;
            this.btnCreateScene.Text = "CreateScene";
            this.btnCreateScene.UseVisualStyleBackColor = true;
            this.btnCreateScene.Click += new System.EventHandler(this.btnCreateScene_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(668, 71);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 82);
            this.checkedListBox1.TabIndex = 1;
            // 
            // txtSceneName
            // 
            this.txtSceneName.Location = new System.Drawing.Point(152, 71);
            this.txtSceneName.Name = "txtSceneName";
            this.txtSceneName.Size = new System.Drawing.Size(100, 31);
            this.txtSceneName.TabIndex = 2;
            // 
            // btnCreateDialogue
            // 
            this.btnCreateDialogue.Location = new System.Drawing.Point(289, 56);
            this.btnCreateDialogue.Name = "btnCreateDialogue";
            this.btnCreateDialogue.Size = new System.Drawing.Size(86, 46);
            this.btnCreateDialogue.TabIndex = 3;
            this.btnCreateDialogue.Text = "button2";
            this.btnCreateDialogue.UseVisualStyleBackColor = true;
            this.btnCreateDialogue.Click += new System.EventHandler(this.btnCreateDialogue_Click);
            // 
            // txtDialogueText
            // 
            this.txtDialogueText.Location = new System.Drawing.Point(409, 71);
            this.txtDialogueText.Name = "txtDialogueText";
            this.txtDialogueText.Size = new System.Drawing.Size(100, 31);
            this.txtDialogueText.TabIndex = 4;
            // 
            // lstScenes
            // 
            this.lstScenes.FormattingEnabled = true;
            this.lstScenes.ItemHeight = 25;
            this.lstScenes.Location = new System.Drawing.Point(152, 136);
            this.lstScenes.Name = "lstScenes";
            this.lstScenes.Size = new System.Drawing.Size(120, 154);
            this.lstScenes.TabIndex = 5;
            // 
            // lstDialogues
            // 
            this.lstDialogues.FormattingEnabled = true;
            this.lstDialogues.ItemHeight = 25;
            this.lstDialogues.Location = new System.Drawing.Point(409, 136);
            this.lstDialogues.Name = "lstDialogues";
            this.lstDialogues.Size = new System.Drawing.Size(120, 154);
            this.lstDialogues.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(668, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(558, 178);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 49);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstDialogues);
            this.Controls.Add(this.lstScenes);
            this.Controls.Add(this.txtDialogueText);
            this.Controls.Add(this.btnCreateDialogue);
            this.Controls.Add(this.txtSceneName);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnCreateScene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreateScene;
        private CheckedListBox checkedListBox1;
        private TextBox txtSceneName;
        private Button btnCreateDialogue;
        private TextBox txtDialogueText;
        private ListBox lstScenes;
        private ListBox lstDialogues;
        private Button button3;
        private TextBox textBox3;
    }
}