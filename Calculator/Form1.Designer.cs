
using System;
using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
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
            //this.label1 = new System.Windows.Forms.Label();
            //this.button = new System.Windows.Forms.Button();
            //this.SuspendLayout();



            //this.label1.AutoSize = true;
            //this.label1.Location = new System.Drawing.Point(354, 225);
            //this.label1.Name = "label1";
            //this.label1.Size = new System.Drawing.Size(35, 13);
            //this.label1.TabIndex = 0;
            //this.label1.Text = "label1";



            //this.button.AutoSize = true;
            //this.button.Location = new System.Drawing.Point(100, 100);
            //this.button.Name = "button";
            //this.button.Size = new System.Drawing.Size(75, 23);
            //this.button.TabIndex = 0;
            //this.button.Text = "I\'m a button";
            //this.button.Click += new System.EventHandler(this.button_Click);




            /*
            for (int y = 2; y >= 0; y--)
            {
                for (int x = 2; x >= 0; x--)
                {
                    System.Windows.Forms.Button b = new Button();
                    b.AutoSize = true;
                    b.Size = new System.Drawing.Size(40, 40);
                    b.Location = new System.Drawing.Point(x * 40, y * 40);
                    b.Name = (x + y * 3) + 1 + "button";
                    b.TabIndex = (x + y * 3);
                    b.Text = (x + y * 3) + 1 + "";
                    b.Anchor = AnchorStyles.Top;
                    b.Click += new System.EventHandler(button_Click);
                    Console.WriteLine("Button " + (x + y * 3) + 1 + " created");
                    Controls.Add(b);
                }

            }
            */

            Label l = new Label();
            l.Location = new System.Drawing.Point(0, 0);
            l.Size = new System.Drawing.Size(4 * 40, 40);
            l.Name = "label";
            l.Text = "LABEL";
            l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Controls.Add(l);


            short n = 7;
            for (int y = 1; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Button b = new Button();
                    b.AutoSize = true;
                    b.Size = new System.Drawing.Size(40, 40);
                    b.Location = new System.Drawing.Point(x * 40, y * 40);
                    b.Name = n + "button";
                    b.Text = n + "";
                    b.Click += new System.EventHandler(button_Click);
                    Console.WriteLine("Button " + n + " created");

                    Controls.Add(b);
                    n++;
                }
                n -= 6;
            }

            Button b0 = new Button();
            b0.AutoSize = true;
            b0.Size = new System.Drawing.Size(40, 40);
            b0.Location = new System.Drawing.Point(1 * 40, 4 * 40);
            b0.Name = "0button";
            b0.Text = "0";
            b0.Click += new System.EventHandler(button_Click);
            Console.WriteLine("Button 0 created");

            Controls.Add(b0);

            String[] symbols = { "+", "-", "×", "÷" };

            for (int y = 1; y < 5; y++)
            {
                Button b = new Button();
                b.AutoSize = true;
                b.Size = new System.Drawing.Size(40, 40);
                b.Location = new System.Drawing.Point(3 * 40, y * 40);
                b.Name = symbols[y - 1] + "button";
                b.Text = symbols[y - 1] + "";
                b.Click += new System.EventHandler(button_Click);
                Console.WriteLine("Button " + symbols[y - 1] + " created");

                Controls.Add(b);
            }





            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);


            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button button;

        private void button_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name + " was clicked");
        }
    }
}

