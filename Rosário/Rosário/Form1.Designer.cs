namespace Rosário
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 0;
            label1.Text = "Rosário";
            // 
            // button1
            // 
            button1.Location = new Point(177, 101);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "O que é o Rosário?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(340, 101);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 2;
            button2.Text = "Como rezar?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(475, 101);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 3;
            button3.Text = "Dias do terço";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(27, 15);
            button4.Name = "button4";
            button4.Size = new Size(139, 23);
            button4.TabIndex = 4;
            button4.Text = "Oferecimento do terço";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(172, 15);
            button5.Name = "button5";
            button5.Size = new Size(186, 23);
            button5.TabIndex = 5;
            button5.Text = "Três primeiras Ave-Marias";
            button5.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(61, 153);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(674, 233);
            tabControl1.TabIndex = 6;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(666, 205);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Orações";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(474, 44);
            button9.Name = "button9";
            button9.Size = new Size(109, 23);
            button9.TabIndex = 9;
            button9.Text = "Sinal da Cruz";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(252, 44);
            button8.Name = "button8";
            button8.Size = new Size(216, 23);
            button8.TabIndex = 8;
            button8.Text = "Oferecimento dos Mistérios Gloriosos";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(27, 44);
            button7.Name = "button7";
            button7.Size = new Size(219, 23);
            button7.TabIndex = 7;
            button7.Text = "Oferecimento dos Mistérios Dolorosos";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(364, 15);
            button6.Name = "button6";
            button6.Size = new Size(219, 23);
            button6.TabIndex = 6;
            button6.Text = "Oferecimento dos Mistérios Gozosos";
            button6.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(666, 205);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mistérios Gozosos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(666, 205);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mistérios Dolorosos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(666, 205);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mistérios Gloriosos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 441);
            Controls.Add(tabControl1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}
