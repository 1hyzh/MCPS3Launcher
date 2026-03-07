namespace MCConsolesLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(164, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Launch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Download";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(267, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(267, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(267, 155);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Add Server";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(227, 23);
            progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Ready!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 14);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 9;
            label3.Text = "IP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 57);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 10;
            label4.Text = "port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 108);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 12;
            label5.Text = "Server Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(267, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 23);
            textBox4.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(348, 155);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 13;
            button4.Text = "Clear Servers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 191);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Minecarft Consoles Launcher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button button4;
    }
}
