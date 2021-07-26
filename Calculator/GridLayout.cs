using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

public class GridLayout
{
	private List<Control> components;
	private ushort rows, cols;
	private int gridWidth = 100, gridHeight = 100;

	public GridLayout()
	{
		components = new List<Control>();
	}

	public GridLayout(ushort rows, ushort cols)
	{
		this.rows = rows;
		this.cols = cols;

		components = new List<Control>();
		components.Capacity = rows * cols;
	}

	public GridLayout(ushort rows, ushort cols, int gridWidth, int gridHeight)
	{
		this.rows = rows;
		this.cols = cols;
		this.gridWidth = gridWidth;
		this.gridHeight = gridHeight;

		components = new List<Control>();
		components.Capacity = rows * cols;
	}

	public void AddComponent(Control component)
	{
		component.Size = new Size(1, 1);
		components.Add(component);
	}

	public void Set(Control component, int index)
	{
		components[index] = component;
	}

	public void Remove(int index)
	{
		components[index] = null;
	}

	public void SetGridWidth(int width)
	{
		gridWidth = width;
	}
	public void SetGridHeight(int height)
	{
		gridWidth = height;
	}

	public Control GetComponent(int index)
	{
		return components[index];
	}

	public List<Control> GetComponents()
	{

		int i = 0;
		for (int y = 0; y < rows; y++)
		{
			for (int x = 0; x < cols; x++)
			{
				try
				{
					if (components[i].Size.Width == 1)
					{
						components[i].Location = new Point(x * gridWidth, y * gridHeight);
						components[i].Size = new Size(gridWidth, gridHeight);
						components[i].TabStop = false;
					}

				}
				catch (NullReferenceException) { }
				catch (ArgumentOutOfRangeException) { }
				i++;
			}
		}


		return components;
	}

	override
	public string ToString()
	{
		string re = "GridLayout\n\tRows: " + rows + "\n\tCols: " + cols + "\n\tWidth: " + gridWidth + "\n\tHeight: " + gridHeight + "\n\tComponents: {";

		foreach (Control component in components)
		{
			re += component.Name + "; ";
		}

		re = re.Remove(re.Length - 1) + "}";
		return re;
	}
}
