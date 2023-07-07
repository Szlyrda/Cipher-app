namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sourceLabel1 = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.symetricCipherButton = new System.Windows.Forms.Button();
            this.symetricDecipherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.MaximumSize = new System.Drawing.Size(300, 300);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 300);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 81);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 300);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(594, 400);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 5;
            this.saveFile.Text = "Zapisz plik";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(104, 400);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(113, 23);
            this.loadFile.TabIndex = 7;
            this.loadFile.Text = "Wczytaj plik";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // sourceLabel1
            // 
            this.sourceLabel1.AutoSize = true;
            this.sourceLabel1.Location = new System.Drawing.Point(105, 446);
            this.sourceLabel1.Name = "sourceLabel1";
            this.sourceLabel1.Size = new System.Drawing.Size(12, 15);
            this.sourceLabel1.TabIndex = 9;
            this.sourceLabel1.Text = "?";
            this.sourceLabel1.Click += new System.EventHandler(this.sourceLabel1_Click);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(105, 472);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(12, 15);
            this.destinationLabel.TabIndex = 10;
            this.destinationLabel.Text = "?";
            this.destinationLabel.Click += new System.EventHandler(this.destinationLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Źródło:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zapis:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Szyfruj Cezara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.scipherFileButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Deszyfruj Cezara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.descipherFileButton_Click);
            // 
            // symetricCipherButton
            // 
            this.symetricCipherButton.Location = new System.Drawing.Point(363, 247);
            this.symetricCipherButton.Name = "symetricCipherButton";
            this.symetricCipherButton.Size = new System.Drawing.Size(96, 38);
            this.symetricCipherButton.TabIndex = 14;
            this.symetricCipherButton.Text = "Szyfruj asymetrycznie";
            this.symetricCipherButton.UseVisualStyleBackColor = true;
            this.symetricCipherButton.Click += new System.EventHandler(this.asymetricCipherButton_Click);
            // 
            // symetricDecipherButton
            // 
            this.symetricDecipherButton.Location = new System.Drawing.Point(363, 291);
            this.symetricDecipherButton.Name = "symetricDecipherButton";
            this.symetricDecipherButton.Size = new System.Drawing.Size(96, 38);
            this.symetricDecipherButton.TabIndex = 15;
            this.symetricDecipherButton.Text = "Deszyfruj asymetrycznie";
            this.symetricDecipherButton.UseVisualStyleBackColor = true;
            this.symetricDecipherButton.Click += new System.EventHandler(this.asymetricDecipherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.symetricDecipherButton);
            this.Controls.Add(this.symetricCipherButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.sourceLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button saveFile;
        private Button loadFile;
        private OpenFileDialog openFileDialog1;
        private Label sourceLabel1;
        private Label destinationLabel;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button symetricCipherButton;
        private Button symetricDecipherButton;
    }
}