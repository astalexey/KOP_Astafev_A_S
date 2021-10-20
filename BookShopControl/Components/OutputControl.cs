using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BookShopControl.Components
{
    public partial class OutputControl : UserControl
    {
        public OutputControl()
        {
            InitializeComponent();
        }

        private List<string> _order = new List<string>();

        /// <summary>
        /// Возвращает значение выбранного конечного элемента в виде строки. Если текущий элемент неконечный, то возвращается null
        /// </summary>
        public string GetChoosedLeafValue()
        {
            if (myTreeView.SelectedNode.Nodes.Count == 0)
            {
                return myTreeView.SelectedNode.Text;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Индекс выбранной ветки. При установке значения меньше 0 не выбрана ни одна ветка.
        /// При установке значения больше количества веток в корне, выбранная ветка остаётся прежней
        /// При отсутствии выбранного возвращается -1
        /// </summary>
        public int IndexChoosed
        {
            get
            {
                return myTreeView.SelectedNode?.Index ?? -1;
            }
            set
            {
                if (value < 0)
                {
                    myTreeView.SelectedNode = null;
                    return;
                }
                if (value < myTreeView.Nodes.Count)
                {
                    myTreeView.SelectedNode = myTreeView.Nodes[value];
                }
            }
        }

        /// <summary>
        /// Установка иерархии свойств. 
        /// </summary>
        /// <param name="order">Список свойств от важного к менее важному</param>
        public void SetOrder(List<string> order)
        {
            _order = order;
        }

        /// <summary>
        /// Добавление объекта со свойствами к дереву
        /// </summary>
        /// <param name="obj">Объект со свойствами</param>
        public void Add(Object obj)
        {
            Type type = obj.GetType();
            TreeNodeCollection currentNode = myTreeView.Nodes;
            foreach (string item in _order)
            {
                PropertyInfo info = type.GetProperty(item);
                if (info != null)
                {
                    string value;
                    if (info.Name == "Date")
                    {
                        value = info.GetValue(obj).ToString();
                        value = value.Substring(0, value.Length - 8);
                    }
                    else
                    {
                        value = info.GetValue(obj).ToString();
                    } 
                    TreeNode treeNode = new TreeNode(value)
                    {
                        Name = value
                    };
                    if (!currentNode.ContainsKey(value))
                    {
                        currentNode.Add(treeNode);
                    }
                    currentNode = currentNode[currentNode.IndexOfKey(value)].Nodes;
                }
            }
        }
    }
}
