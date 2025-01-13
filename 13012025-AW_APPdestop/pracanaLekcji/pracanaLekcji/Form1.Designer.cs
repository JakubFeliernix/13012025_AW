namespace pracanaLekcji
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
            dodawanie = new Button();
            Odejmowanie = new Button();
            Mnożenie = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // dodawanie
            // 
            dodawanie.Location = new Point(56, 189);
            dodawanie.Name = "dodawanie";
            dodawanie.Size = new Size(99, 44);
            dodawanie.TabIndex = 0;
            dodawanie.Text = "+";
            dodawanie.UseVisualStyleBackColor = true;
            dodawanie.Click += dodawanie_Click;
            // 
            // Odejmowanie
            // 
            Odejmowanie.Location = new Point(217, 189);
            Odejmowanie.Name = "Odejmowanie";
            Odejmowanie.Size = new Size(99, 44);
            Odejmowanie.TabIndex = 1;
            Odejmowanie.Text = "-";
            Odejmowanie.UseVisualStyleBackColor = true;
            Odejmowanie.Click += button2_Click;
            // 
            // Mnożenie
            // 
            Mnożenie.Location = new Point(372, 189);
            Mnożenie.Name = "Mnożenie";
            Mnożenie.Size = new Size(99, 44);
            Mnożenie.TabIndex = 2;
            Mnożenie.Text = "*";
            Mnożenie.UseVisualStyleBackColor = true;
            Mnożenie.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 134);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "Liczba1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 83);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Liczba1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 300);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "Wynik:";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Mnożenie);
            Controls.Add(Odejmowanie);
            Controls.Add(dodawanie);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dodawanie;
        private Button Odejmowanie;
        private Button Mnożenie;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
    }
}
