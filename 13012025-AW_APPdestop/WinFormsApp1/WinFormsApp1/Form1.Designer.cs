namespace WinFormsApp1
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
            start = new Button();
            Reset = new Button();
            Stop = new Button();
            czas = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(84, 155);
            start.Name = "start";
            start.Size = new Size(123, 63);
            start.TabIndex = 0;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(540, 155);
            Reset.Name = "Reset";
            Reset.Size = new Size(123, 63);
            Reset.TabIndex = 1;
            Reset.Text = "reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(302, 155);
            Stop.Name = "Stop";
            Stop.Size = new Size(123, 63);
            Stop.TabIndex = 1;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // czas
            // 
            czas.Location = new Point(84, 321);
            czas.Name = "czas";
            czas.Size = new Size(195, 23);
            czas.TabIndex = 2;
            czas.Text = "Wynik:";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(czas);
            Controls.Add(Stop);
            Controls.Add(Reset);
            Controls.Add(start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button Reset;
        private Button Stop;
        private TextBox czas;
        private System.Windows.Forms.Timer timer1;
    }
}
