namespace WinFormsm.StringMethod
{
    partial class Form4
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 426);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(309, 101);
            button1.Name = "button1";
            button1.Size = new Size(154, 81);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.PeachPuff;
            label1.Location = new Point(509, 15);
            label1.Name = "label1";
            label1.Size = new Size(259, 423);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(309, 227);
            button2.Name = "button2";
            button2.Size = new Size(154, 81);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}