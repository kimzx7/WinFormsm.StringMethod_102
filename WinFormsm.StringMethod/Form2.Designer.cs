namespace WinFormsm.StringMethod
{
    partial class Form2
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
            txtrate = new TextBox();
            label3 = new Label();
            USD_to_THB = new Button();
            THB_to_USD = new Button();
            txtUSD = new TextBox();
            txtTHB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtrate
            // 
            txtrate.Location = new Point(258, 257);
            txtrate.Multiline = true;
            txtrate.Name = "txtrate";
            txtrate.Size = new Size(254, 34);
            txtrate.TabIndex = 15;
            txtrate.Text = "33.89";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 260);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 14;
            label3.Text = "อัตราแลกเปลี่ยน USD กับ THB\r\n";
            // 
            // USD_to_THB
            // 
            USD_to_THB.Location = new Point(586, 155);
            USD_to_THB.Name = "USD_to_THB";
            USD_to_THB.Size = new Size(140, 61);
            USD_to_THB.TabIndex = 13;
            USD_to_THB.Text = "แปลงเป็นTHB";
            USD_to_THB.UseVisualStyleBackColor = true;
            USD_to_THB.Click += USD_to_THB_Click;
            // 
            // THB_to_USD
            // 
            THB_to_USD.Location = new Point(586, 53);
            THB_to_USD.Name = "THB_to_USD";
            THB_to_USD.Size = new Size(140, 61);
            THB_to_USD.TabIndex = 12;
            THB_to_USD.Text = "แปลงเป็นUSD";
            THB_to_USD.UseVisualStyleBackColor = true;
            THB_to_USD.Click += THB_to_USD_Click;
            // 
            // txtUSD
            // 
            txtUSD.Location = new Point(258, 172);
            txtUSD.Multiline = true;
            txtUSD.Name = "txtUSD";
            txtUSD.Size = new Size(254, 34);
            txtUSD.TabIndex = 11;
            // 
            // txtTHB
            // 
            txtTHB.Location = new Point(258, 70);
            txtTHB.Multiline = true;
            txtTHB.Name = "txtTHB";
            txtTHB.Size = new Size(254, 34);
            txtTHB.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 175);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 9;
            label2.Text = "ค่าเงินดอลลาร์สหรัฐ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 73);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "ค่าเงินบาท";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtrate);
            Controls.Add(label3);
            Controls.Add(USD_to_THB);
            Controls.Add(THB_to_USD);
            Controls.Add(txtUSD);
            Controls.Add(txtTHB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtrate;
        private Label label3;
        private Button USD_to_THB;
        private Button THB_to_USD;
        private TextBox txtUSD;
        private TextBox txtTHB;
        private Label label2;
        private Label label1;
    }
}