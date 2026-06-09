namespace WinFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 392);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 16;
            label3.Text = "Já tem conta?";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 218);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 15;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 149);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 14;
            label1.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 27);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 27);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(285, 351);
            button1.Name = "button1";
            button1.Size = new Size(299, 38);
            button1.TabIndex = 11;
            button1.Text = "CRIAR CONTA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Zenit.Properties.Resources.Captura_de_ecrã_2026_06_01_140041;
            pictureBox1.Location = new Point(317, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 98);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 455);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 105);
            label5.Name = "label5";
            label5.Size = new Size(49, 220);
            label5.TabIndex = 9;
            label5.Text = "Z\r\nE\r\nN\r\nI\r\nT";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(19, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 66);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 27);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(246, 286);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 18;
            label4.Text = "Confirmar Senha";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private Label label4;
    }
}