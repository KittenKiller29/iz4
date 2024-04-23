namespace iz4
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
            tv1 = new TreeView();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tv1
            // 
            tv1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tv1.Location = new Point(502, 9);
            tv1.Margin = new Padding(3, 4, 3, 4);
            tv1.Name = "tv1";
            tv1.Size = new Size(551, 420);
            tv1.TabIndex = 0;
            tv1.AfterSelect += tv1_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 28);
            label1.TabIndex = 2;
            label1.Text = "Какой тип отдыха вас интересует?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(12, 51);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(193, 32);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Активный отдых";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(12, 91);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(415, 32);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Пляжный отдых и водные пазвлечения";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(12, 131);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(209, 32);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Культурный отдых";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(12, 171);
            checkBox4.Margin = new Padding(3, 4, 3, 4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(209, 32);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Культурный отдых";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 197);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 210);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 219);
            textBox1.TabIndex = 9;
            textBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 441);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(tv1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tv1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}