using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookShopControl.Components
{
    public partial class InputControl : UserControl
    {
        public int StartLength = 3;
        public int EndLength = 10;
        public InputControl()
        {
            InitializeComponent();
        }

        public string Value
        {
            set
            {
                myTextBox.Text = value.ToString();
            }
            get
            {
                if (myTextBox.Text.Length < StartLength || myTextBox.Text.Length > EndLength)
                {
                    throw new Exception("Вы ввели неверное значение, ваше значение меньше "+StartLength+" или больше "+EndLength+"!");
                }
                return myTextBox.Text;
            }
        }
    }
}
