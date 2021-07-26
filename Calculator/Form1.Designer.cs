
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator
{
	partial class Form1
	{
		private GridLayout gl;
		private int num1, num2;
		private char operation;

		private void InitializeComponent()
		{
			gl = new GridLayout(5, 4, 80, 80);

			gl.AddComponent(new Label());
			gl.GetComponent(0).Name = "display";
			gl.GetComponent(0).Size = new Size(4 * 80, 80);
			gl.GetComponent(0).Text = "";
			((Label)gl.GetComponent(0)).TextAlign = ContentAlignment.MiddleRight;
			gl.GetComponent(0).Font = new Font("Arial", 30, FontStyle.Regular);

			gl.AddComponent(new Label());
			gl.GetComponent(1).Location = new Point(1000, 1000);
			gl.AddComponent(new Label());
			gl.GetComponent(2).Location = new Point(1000, 1000);
			gl.AddComponent(new Label());
			gl.GetComponent(3).Location = new Point(1000, 1000);

			String[] symbols = { "7", "8", "9", "÷", "4", "5", "6", "×", "1", "2", "3", "-", "C", "0", "=", "+"};
			for (int i = 0; i < symbols.Length; i++)
			{
				gl.AddComponent(new Button());
				gl.GetComponent(i + 4).Name = symbols[i] + "button";
				gl.GetComponent(i + 4).Text = symbols[i] + "";
				gl.GetComponent(i + 4).Click += button_Click;
			}
			
			gl.GetComponents().ForEach(component => Controls.Add(component));

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

		private void Form1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void button_Click(object sender, System.EventArgs e)
		{
			
			if (((Button)sender).Name.Equals("Cbutton"))
			{
				gl.GetComponent(0).Text = "";
			}
			else if (((Button)sender).Name.Equals("=button"))
			{
				try
				{
					num2 = Int32.Parse(gl.GetComponent(0).Text);
					switch (operation)
					{
						case '+':
							int result = num1 + num2;
							Console.WriteLine(result);
							gl.GetComponent(0).Text = result + "";
							break;
						case '-':
							result = num1 - num2;
							Console.WriteLine(result);
							gl.GetComponent(0).Text = result + "";
							break;
						case '×':
							result = num1 * num2;
							Console.WriteLine(result);
							gl.GetComponent(0).Text = result + "";
							break;
						case '÷':
							if (num2 != 0)
							{
								double res = (double)num1 / (double)num2;
								res = Math.Round(res, 10);
								Console.WriteLine(res);
								gl.GetComponent(0).Text = res + "";
							} else
							{
								gl.GetComponent(0).Text = "Err";
							}
							break;
						default:
							Console.WriteLine("Hmst");
							break;
					}
					num1 = Int32.Parse(gl.GetComponent(0).Text);
				}
				catch (System.FormatException) { }
			}
			else if (((Button)sender).Text.Equals("+") || ((Button)sender).Text.Equals("-") || ((Button)sender).Text.Equals("×") || ((Button)sender).Text.Equals("÷"))
			{
				try
				{
					num1 = Int32.Parse(gl.GetComponent(0).Text);
				}
				catch (System.FormatException) { }
				operation = Char.Parse(((Button)sender).Text);
				gl.GetComponent(0).Text = "";
			}
			else
			{
				gl.GetComponent(0).Text += ((Button)sender).Text;
			}
			
		}
	}
}

