namespace WinFormsm.StringMethod
{
    partial class Form3
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
            btn1 = new Button();
            txt_in_int = new TextBox();
            label1 = new Label();
            txt_out = new Label();
            comboBox1 = new ComboBox();
            txt_in_str = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(30, 248);
            btn1.Name = "btn1";
            btn1.Size = new Size(154, 63);
            btn1.TabIndex = 0;
            btn1.Text = "รูปแบบที่1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // txt_in_int
            // 
            txt_in_int.Location = new Point(30, 41);
            txt_in_int.Multiline = true;
            txt_in_int.Name = "txt_in_int";
            txt_in_int.Size = new Size(152, 34);
            txt_in_int.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "ใส่ขนาดที่จะสร้าง";
            // 
            // txt_out
            // 
            txt_out.BackColor = Color.PeachPuff;
            txt_out.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_out.Location = new Point(212, 30);
            txt_out.Name = "txt_out";
            txt_out.Size = new Size(359, 389);
            txt_out.TabIndex = 5;
            txt_out.Text = "โปรดใส่ขนาดและเลือกรูปแบบ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // txt_in_str
            // 
            txt_in_str.Location = new Point(28, 124);
            txt_in_str.Multiline = true;
            txt_in_str.Name = "txt_in_str";
            txt_in_str.Size = new Size(152, 34);
            txt_in_str.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(txt_in_str);
            Controls.Add(comboBox1);
            Controls.Add(txt_out);
            Controls.Add(label1);
            Controls.Add(txt_in_int);
            Controls.Add(btn1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private TextBox txt_in_int;
        private Label label1;
        private Label txt_out;
        private ComboBox comboBox1;
        private TextBox txt_in_str;
    }
}