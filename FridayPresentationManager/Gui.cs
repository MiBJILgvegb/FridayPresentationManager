﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayPresentationManager
{
    internal class Gui
    {
        /*ComboBox*/
        public static void Add(ComboBox comboBox, string item) { comboBox.Items.Add(item); }
        public static void AddAsync(ComboBox comboBox, string item) { comboBox.Invoke(new Action(() => comboBox.Items.Add(item) ));  }
        public static void Fill(ComboBox comboBox, string[] strings) { foreach(string str in strings) { Add(comboBox, str); } }
        public static void Clear(ComboBox comboBox) { comboBox.Items.Clear(); }
        public static void SelectIndex(ComboBox comboBox, int index) { comboBox.SelectedIndex= index; }
        public static void SelectIndexAsync(ComboBox comboBox, int index) { comboBox.Invoke(new Action(() => comboBox.SelectedIndex = index));  }
        internal static int GetSelectedIndex(ComboBox comboBox) { return comboBox.SelectedIndex; }
        internal static string GetSelectedItem(ComboBox comboBox) { return comboBox.SelectedItem.ToString(); }
        internal static void Enable(ComboBox comboBox) { comboBox.Enabled = true; }
        public static void Disable(ComboBox comboBox) { comboBox.Enabled = false; }

        /*TextBox*/
        public static void Text(TextBox textBox,string text) { textBox.Text = text; }
        public static void TextAppend(TextBox textBox,string text) { textBox.Text += "\r\n"+text; }
        public static void TextAsync(TextBox textBox, string text) { textBox.Invoke(new Action(() => textBox.Text = text)); }
        public static void VisibleON(TextBox textBox) { textBox.Visible = true; }
        public static void VisibleOFF(TextBox textBox) { textBox.Visible = false; }
        public static void Clear(TextBox textBox) { textBox.Text=""; }

        /*ListView*/
        public static void Clear(ListView listview) { listview.Clear(); }
        private static void Add(ListView listview, ListViewItem lvi) { listview.Items.Add(lvi); }
        public static void Add(ListView listview, ListViewItem[] lvis)
        {
            foreach(ListViewItem lvi in lvis) { Add(listview, lvi); }
        }
        private static void SetView(ListView l, View view) { l.View = view; }
        private static void AddImageList_Small(ListView listview, ImageList il)
        {
            SetView(listview, View.SmallIcon);
            listview.SmallImageList = il;
        }
        private static void AddImageList_Large(ListView listview, ImageList il)
        {
            SetView(listview, View.LargeIcon);
            listview.LargeImageList = il;
        }
        public static void AddImageList(ListView listview, ImageList il, int lvilType)
        {
            switch (lvilType)
            {
                case 0:AddImageList_Small(listview, il); break;
                case 1:AddImageList_Large(listview, il); break;
            }
        }
        public static void SelectIndex(ListView l, int index)
        {
            l.Items[index].Selected = true;
            l.Items[index].EnsureVisible();
        }
        public static string GetSelectedText(ListView listview) { return listview.SelectedItems[0].Text; }
        public static string GetSelectedItemToolTip(ListView listview) { return listview.SelectedItems[0].ToolTipText; }
        public static bool IsSelectedItem(ListView listview) { return listview.SelectedItems.Count > 0; }

        /*Button*/
        public static void Enable(Button button) { button.Enabled = true; }
        public static void Disable(Button button) { button.Enabled = false; }

        /*GroupBox*/
        public static void VisibleON(GroupBox groupBox) { groupBox.Visible = true; }
        public static void VisibleOFF(GroupBox groupBox) { groupBox.Visible = false; }
        public static void SetTitle(GroupBox groupBox,string title) { groupBox.Text = title; }
        public static string GetTitle(GroupBox groupBox) { return groupBox.Text; }

        /*Any control*/
        public static void Focus(Control control) { control.Focus(); }

        /*CheckBox*/
        public static void Check(CheckBox checkBox) { checkBox.Checked = true; }
        public static void Uncheck(CheckBox checkBox) { checkBox.Checked = false; }
        public static bool IsChecked(CheckBox checkBox) { return checkBox.Checked; }
        public static void Enable(CheckBox checkBox) { checkBox.Enabled= true; }
        public static void Disable(CheckBox checkBox) { checkBox.Enabled= false; }

        /*RadioButton*/
        public static void Check(RadioButton radioButton) { radioButton.Checked = true; }
        public static void Uncheck(RadioButton radioButton) { radioButton.Checked = false; }
        public static bool IsChecked(RadioButton radioButton) { return radioButton.Checked; }

        /*PictureBox*/
        public static void SetPicture(PictureBox pictureBox,Image image) { pictureBox.Image = image; }

        /*ListBox*/
        public static void Clear(ListBox listBox) { listBox.Items.Clear(); }
        public static void ClearAsync(ListBox listBox) { listBox.Invoke(new Action(() => Clear(listBox))); }
        public static void Add(ListBox listBox, string item) { listBox.Items.Add(item); }
        public static void Add(ListBox listBox, string[] items) { foreach (string item in items) { Add(listBox, item); } }
        public static void AddAsync(ListBox listBox, string item) { listBox.Invoke(new Action(() => listBox.Items.Add(item))); }
        public static void AddAsync(ListBox listBox, string[] items) { foreach(string item in items) { AddAsync(listBox, item); } }
        public static string GetSelectedItem(ListBox listBox) { return listBox.SelectedItem.ToString(); }
        public static void Select(ListBox listBox,int index) { listBox.Invoke(new Action(() => listBox.SetSelected(index, true))); }
        public static void SelectAsync(ListBox listBox, int index) { listBox.Invoke(new Action(() => Select(listBox, index))); }
        internal static int GetSelectedIndexAsync(ListBox listBox) 
        {
            int count = 0;
            listBox.Invoke(new Action(() => count=listBox.SelectedItems.Count));
            if (count > 0) 
            {
                int index = -1;
                listBox.Invoke(new Action(() => index = listBox.SelectedIndex));
                return index;
            }
            return -1;
        }
        internal static int GetItemsCount(ListBox listBox) { return listBox.Items.Count; }
        /*TabPage*/
        public static void TitleAsync(TabPage tabPage,string title){ tabPage.Invoke(new Action(() => tabPage.Text=title)); }
    }
}
