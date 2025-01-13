namespace Zadanie
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Wynik = new TextBox();
            dodawanie = new Button();
            odejmowanie = new Button();
            Mnożenie = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 54);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "LIczba1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 108);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "LIczba2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Wynik
            // 
            Wynik.Location = new Point(31, 310);
            Wynik.Name = "Wynik";
            Wynik.Size = new Size(204, 23);
            Wynik.TabIndex = 4;
            // 
            // dodawanie
            // 
            dodawanie.Location = new Point(41, 202);
            dodawanie.Name = "dodawanie";
            dodawanie.Size = new Size(75, 23);
            dodawanie.TabIndex = 5;
            dodawanie.Text = "+";
            dodawanie.UseVisualStyleBackColor = true;
            dodawanie.Click += dodawanie_Click;
            // 
            // odejmowanie
            // 
            odejmowanie.Location = new Point(187, 202);
            odejmowanie.Name = "odejmowanie";
            odejmowanie.Size = new Size(75, 23);
            odejmowanie.TabIndex = 6;
            odejmowanie.Text = "-";
            odejmowanie.UseVisualStyleBackColor = true;
            odejmowanie.Click += odejmowanie_Click;
            // 
            // Mnożenie
            // 
            Mnożenie.Location = new Point(353, 202);
            Mnożenie.Name = "Mnożenie";
            Mnożenie.Size = new Size(75, 23);
            Mnożenie.TabIndex = 7;
            Mnożenie.Text = "*";
            Mnożenie.UseVisualStyleBackColor = true;
            Mnożenie.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mnożenie);
            Controls.Add(odejmowanie);
            Controls.Add(dodawanie);
            Controls.Add(Wynik);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox Wynik;
        private Button dodawanie;
        private Button odejmowanie;
        private Button Mnożenie;
    }
}
