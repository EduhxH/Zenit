namespace WinFormsApp4
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 204);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(277, 84);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(259, 204);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(542, 84);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(254, 204);
            listBox3.TabIndex = 3;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-13, 378);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 73);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(562, 4);
            button3.Name = "button3";
            button3.Size = new Size(247, 66);
            button3.TabIndex = 2;
            button3.Text = "Relatórios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(290, 4);
            button2.Name = "button2";
            button2.Size = new Size(247, 66);
            button2.TabIndex = 1;
            button2.Text = "Tarefas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(17, 3);
            button1.Name = "button1";
            button1.Size = new Size(247, 66);
            button1.TabIndex = 0;
            button1.Text = "Kanban Board";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "Clima";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 6;
            label2.Text = "Projetos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(542, 61);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 7;
            label3.Text = "Feriados";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}