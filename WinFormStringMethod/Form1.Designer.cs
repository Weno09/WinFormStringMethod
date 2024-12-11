namespace WinFormStringMethod
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
            txtFullname = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSplitName = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(184, 64);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(370, 27);
            txtFullname.TabIndex = 0;
            txtFullname.Text = "นาย พิสิษฐ์ ฮาบละคร!!!";
            txtFullname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(184, 183);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(215, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(184, 234);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(184, 296);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 27);
            txtLastName.TabIndex = 3;
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(632, 64);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(94, 29);
            btnSplitName.TabIndex = 4;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 68);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 5;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 183);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 6;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 234);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 7;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 296);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "นามสกุล";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSplitName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSplitName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
