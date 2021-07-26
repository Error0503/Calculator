
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
			SetStyle(ControlStyles.Selectable, false);

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

			String[] symbols = { "7", "8", "9", "÷", "4", "5", "6", "×", "1", "2", "3", "-", "C", "0", "=", "+" };
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

			gl.GetComponent(0).KeyPress += KeyPressListener;
			gl.GetComponent(0).KeyDown += KeyDownListener;

			Name = "Calculator";
			Text = "Calculator";
			ResumeLayout(false);
			PerformLayout();

			gl.GetComponent(0).Focus();
		}

		private void KeyDownListener(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back && e.Shift)
			{
				gl.GetComponent(0).Text = "";
			}
			else if (e.KeyCode == Keys.Enter)
			{
				Evaluate();
			}
		}

		private void KeyPressListener(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case (char)Keys.D0:
				case (char)Keys.D1:
				case (char)Keys.D2:
				case (char)Keys.D3:
				case (char)Keys.D4:
				case (char)Keys.D5:
				case (char)Keys.D6:
				case (char)Keys.D7:
				case (char)Keys.D8:
				case (char)Keys.D9:
					gl.GetComponent(0).Text += e.KeyChar;
					break;
				case '+':
				case '-':
				case '×':
				case '÷':
				case '*':
				case '/':
					try
					{
						num1 = int.Parse(gl.GetComponent(0).Text);
					}
					catch (System.FormatException) { }
					operation = e.KeyChar;
					gl.GetComponent(0).Text = "";
					break;
				case (char)Keys.Back:
					if (gl.GetComponent(0).Text.Length > 0) gl.GetComponent(0).Text = gl.GetComponent(0).Text.Remove(gl.GetComponent(0).Text.Length - 1);
					break;
			}
		}

		private void button_Click(object sender, System.EventArgs e)
		{
			if (((Button)sender).Name.Equals("Cbutton"))
			{
				gl.GetComponent(0).Text = "";
			}
			else if (((Button)sender).Name.Equals("=button"))
			{
				Evaluate();
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
			gl.GetComponent(0).Focus();
		}

		private void Evaluate()
		{
			try
			{
				num2 = int.Parse(gl.GetComponent(0).Text);
				long result = 0;
				switch (operation)
				{
					case '+':
						result = num1 + num2;
						gl.GetComponent(0).Text = result + "";
						break;
					case '-':
						result = num1 - num2;
						gl.GetComponent(0).Text = result + "";
						break;
					case '×':
					case '*':
						result = num1 * num2;
						gl.GetComponent(0).Text = result + "";
						break;
					case '÷':
					case '/':
						if (num2 != 0)
						{
							double res = (double)num1 / (double)num2;
							res = Math.Round(res, 10);
							gl.GetComponent(0).Text = res + "";
						}
						else
						{
							gl.GetComponent(0).Text = "Err";
						}
						break;
				}
				if (result > int.MaxValue) gl.GetComponent(0).Text = "Err";
				num1 = int.Parse(gl.GetComponent(0).Text);
			}
			catch (System.FormatException) { }
			catch (System.OverflowException) { gl.GetComponent(0).Text = "Err"; }
		}
	}
}

