
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
	partial class Form1
	{
		private Label l;
		private int num1, num2;
		private char operation;


		private void Test(object sender, EventArgs e)
        {
			Console.WriteLine("Henlo?");
        }

		private void InitializeComponent()
		{
			GridLayout gl = new GridLayout();

			gl.AddComponent(new Label());
			gl.GetComponent(0).Text = "Hello World from x:10 y:10";
			gl.GetComponent(0).Name = "Test label";
			gl.GetComponent(0).Click += Test;
			Controls.Add(gl.GetComponent(0));
			Console.WriteLine(gl);

			
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
			

			//AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			//AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(4 * 80, 5 * 80);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			//MinimizeBox = false;
			StartPosition = FormStartPosition.CenterScreen;


			Name = "Calculator";
			Text = "Calculator";
			ResumeLayout(false);
			PerformLayout();

		}

		private void button_Click(object sender, System.EventArgs e)
		{
			if (((Button)sender).Name.Equals("Cbutton"))
			{
				l.Text = "";
			}
			else if (((Button)sender).Name.Equals("=button"))
			{
				try
				{
					num2 = Int32.Parse(l.Text);
					switch (operation)
					{
						case '+':
							int result = num1 + num2;
							Console.WriteLine(result);
							l.Text = result + "";
							break;
						case '-':
							result = num1 - num2;
							Console.WriteLine(result);
							l.Text = result + "";
							break;
						case '×':
							result = num1 * num2;
							Console.WriteLine(result);
							l.Text = result + "";
							break;
						case '÷':
							if (num2 != 0)
							{
								double res = (double)num1 / (double)num2;
								res = Math.Round(res, 10);
								Console.WriteLine(res);
								l.Text = res + "";
							} else
							{
								l.Text = "Err";
							}
							break;
						default:
							Console.WriteLine("Hmst");
							break;
					}
					num1 = Int32.Parse(l.Text);
				}
				catch (System.FormatException) { }
			}
			else if (((Button)sender).Text.Equals("+") || ((Button)sender).Text.Equals("-") || ((Button)sender).Text.Equals("×") || ((Button)sender).Text.Equals("÷"))
			{
				try
				{
					num1 = Int32.Parse(l.Text);
				}
				catch (System.FormatException) { }
				operation = Char.Parse(((Button)sender).Text);
				l.Text = "";
			}
			else
			{
				l.Text += ((Button)sender).Text;
			}
		}
	}
}

