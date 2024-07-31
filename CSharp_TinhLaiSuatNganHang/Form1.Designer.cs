namespace CSharp_TinhLaiSuatNganHang
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            lbKQ = new ListBox();
            panel2 = new Panel();
            txtMoney = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txtYear = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txtRate = new TextBox();
            label4 = new Label();
            butSubmit = new Button();
            butExit = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Edwardian", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(99, 7);
            label1.Name = "label1";
            label1.Size = new Size(632, 51);
            label1.TabIndex = 0;
            label1.Text = "Chương trình tính lãi suất ngân hàng SacomBank";
            // 
            // lbKQ
            // 
            lbKQ.FormattingEnabled = true;
            lbKQ.ItemHeight = 18;
            lbKQ.Location = new Point(419, 80);
            lbKQ.Name = "lbKQ";
            lbKQ.Size = new Size(391, 346);
            lbKQ.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMoney);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 53);
            panel2.TabIndex = 2;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(147, 14);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(237, 26);
            txtMoney.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(119, 18);
            label2.TabIndex = 0;
            label2.Text = "Nhập số tiền gửi:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtYear);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1, 139);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 53);
            panel3.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(147, 14);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(237, 26);
            txtYear.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 17);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 0;
            label3.Text = "Nhập số năm gửi:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtRate);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(1, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(412, 53);
            panel4.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(147, 14);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(237, 26);
            txtRate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 0;
            label4.Text = "Nhập số lãi suất:";
            // 
            // butSubmit
            // 
            butSubmit.Location = new Point(46, 341);
            butSubmit.Name = "butSubmit";
            butSubmit.Size = new Size(141, 46);
            butSubmit.TabIndex = 3;
            butSubmit.Text = "Tính";
            butSubmit.UseVisualStyleBackColor = true;
            butSubmit.Click += butSubmit_Click;
            // 
            // butExit
            // 
            butExit.Location = new Point(228, 341);
            butExit.Name = "butExit";
            butExit.Size = new Size(139, 46);
            butExit.TabIndex = 4;
            butExit.Text = "Thoát";
            butExit.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(812, 436);
            Controls.Add(butExit);
            Controls.Add(butSubmit);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lbKQ);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình tính lãi suất ngân hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox lbKQ;
        private Panel panel2;
        private TextBox txtMoney;
        private Label label2;
        private Panel panel3;
        private TextBox txtYear;
        private Label label3;
        private Panel panel4;
        private TextBox txtRate;
        private Label label4;
        private Button butSubmit;
        private Button butExit;
        private ErrorProvider errorProvider1;
    }
}
