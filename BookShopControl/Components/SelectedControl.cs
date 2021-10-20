using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookShopControl.Components
{
    public partial class SelectedControl : UserControl
    {
		//Список с выбором. 
		//Список заполняется через метод, передающий строку.

		public SelectedControl()
		{
			InitializeComponent();
			myComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public void FillComboBox(String str)
		{
			myComboBox.Items.Add(str);
			myComboBox.Refresh();
		}

		public void ClearCheckedList()
		{
			myComboBox.Items.Clear();
		}

		public string value
		{
			set
			{
				myComboBox.SelectedItem = value;
			}

			get
			{
				if (myComboBox.SelectedItem == null)
				{
					return null;
				}
				string selectedItems = myComboBox.SelectedItem.ToString();
				return selectedItems;
			}
		}
	}
}
