namespace docce_spogliatoio_thread
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
            doccia1 = new Button();
            doccia2 = new Button();
            doccia3 = new Button();
            doccia4 = new Button();
            doccia5 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            provaT = new Label();
            SuspendLayout();
            // 
            // doccia1
            // 
            doccia1.Location = new Point(100, 100);
            doccia1.Name = "doccia1";
            doccia1.Size = new Size(75, 30);
            doccia1.TabIndex = 0;
            doccia1.Text = "Doccia 1";
            doccia1.UseVisualStyleBackColor = true;
            doccia1.Click += doccia1_Click;
            // 
            // doccia2
            // 
            doccia2.Location = new Point(200, 100);
            doccia2.Name = "doccia2";
            doccia2.Size = new Size(75, 30);
            doccia2.TabIndex = 1;
            doccia2.Text = "Doccia 2";
            doccia2.UseVisualStyleBackColor = true;
            // 
            // doccia3
            // 
            doccia3.Location = new Point(300, 100);
            doccia3.Name = "doccia3";
            doccia3.Size = new Size(75, 30);
            doccia3.TabIndex = 2;
            doccia3.Text = "Doccia 3";
            doccia3.UseVisualStyleBackColor = true;
            // 
            // doccia4
            // 
            doccia4.Location = new Point(400, 100);
            doccia4.Name = "doccia4";
            doccia4.Size = new Size(75, 30);
            doccia4.TabIndex = 3;
            doccia4.Text = "Doccia 4";
            doccia4.UseVisualStyleBackColor = true;
            // 
            // doccia5
            // 
            doccia5.Location = new Point(500, 100);
            doccia5.Name = "doccia5";
            doccia5.Size = new Size(75, 30);
            doccia5.TabIndex = 4;
            doccia5.Text = "Doccia 5";
            doccia5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 140);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 140);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 140);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 140);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 140);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // provaT
            // 
            provaT.AutoSize = true;
            provaT.Location = new Point(213, 274);
            provaT.Name = "provaT";
            provaT.Size = new Size(38, 15);
            provaT.TabIndex = 10;
            provaT.Text = "label6";
            provaT.Click += provaT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(provaT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(doccia5);
            Controls.Add(doccia4);
            Controls.Add(doccia3);
            Controls.Add(doccia2);
            Controls.Add(doccia1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button doccia1;
        private Button doccia2;
        private Button doccia3;
        private Button doccia4;
        private Button doccia5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label provaT;
    }
}
