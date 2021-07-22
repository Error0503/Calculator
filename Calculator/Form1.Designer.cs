
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




            for (int i = 0; i < 10; i++)
            {
                System.Windows.Forms.Button b = new Button();

                b.AutoSize = true;
                b.Location = new System.Drawing.Point(10, i * 50);
                b.Name = i + "button";
                b.TabIndex = i;
                b.Text = i + "";
                b.Click += new System.EventHandler(button_Click);
                Console.WriteLine("Button " + i + " created");

                Controls.Add(b);
            }







            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            /*
            foreach (Button b in numButtons)
            {
                Controls.Add(b);
                Console.WriteLine("Button added");
            }
            */

            Controls.Add(numButtons[3]);

            //this.Controls.Add(this.label1);
            //this.Controls.Add(this.button);

            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button[] numButtons = new System.Windows.Forms.Button[10];

        private void button_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(((Button) sender).Name + " was clicked");
        }
    }
}

