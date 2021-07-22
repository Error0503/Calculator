
using System;
using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        private Label l;

        private void InitializeComponent()
        {

            l = new Label();
            l.Location = new System.Drawing.Point(0, 0);
            l.Size = new System.Drawing.Size(4 * 80, 80);
            l.Name = "label";
            l.Text = "";
            l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            l.Font = new System.Drawing.Font("Arial", 30, System.Drawing.FontStyle.Regular);
            Controls.Add(l);


            short n = 7;
            for (int y = 1; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Button b = new Button();
                    b.AutoSize = true;
                    b.Size = new System.Drawing.Size(80, 80);
                    b.Location = new System.Drawing.Point(x * 80, y * 80);
                    b.Name = n + "button";
                    b.Text = n + "";
                    b.Click += new System.EventHandler(button_Click);
                    Console.WriteLine("Button " + n + " created");

                    Controls.Add(b);
                    n++;
                }
                n -= 6;
            }

            String[] symbols = { "C", "0", "=" };
            for (int x = 0; x < 3; x++)
            {
                Button b = new Button();
                b.AutoSize = true;
                b.Size = new System.Drawing.Size(80, 80);
                b.Location = new System.Drawing.Point(x * 80, 4 * 80);
                b.Name = symbols[x] + "button";
                b.Text = symbols[x] + "";
                b.Click += new System.EventHandler(button_Click);
                Console.WriteLine("Button " + symbols[x] + " created");

                Controls.Add(b);
            }


            String[] symbols2 = { "+", "-", "×", "÷" };
            for (int y = 1; y < 5; y++)
            {
                Button b = new Button();
                b.AutoSize = true;
                b.Size = new System.Drawing.Size(80, 80);
                b.Location = new System.Drawing.Point(3 * 80, y * 80);
                b.Name = symbols2[y - 1] + "button";
                b.Text = symbols2[y - 1] + "";
                b.Click += new System.EventHandler(button_Click);
                Console.WriteLine("Button " + symbols2[y - 1] + " created");

                Controls.Add(b);
            }





            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(4 * 80, 5 * 80);


            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button_Click(object sender, System.EventArgs e)
        {
            if (((Button)sender).Name.Equals("Cbutton"))
            {
                l.Text = "";
            }
            else
            {
                l.Text += ((Button)sender).Text;
            }
        }
    }
}

