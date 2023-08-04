//using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayPresentationManager
{
    internal class FormToGui
    {
        internal static void MainWindowFolderFilter_Add(string item) { Gui.Add(MainWindow.mainWindow.cbPresentationByYearsFilter, item); }
        internal static void MainWindowFolderFilter_AddAsync(string item) { Gui.AddAsync(MainWindow.mainWindow.cbPresentationByYearsFilter, item); }
        internal static void MainWindowFolderFilter_Add(string[] items, bool order = true)
        {
            int i = 0;
            if (!order) i = items.Count() - 1;
            for (int z = 0; z < items.Count(); z++)
            {
                if (items[i].Length > 0) { MainWindowFolderFilter_Add(items[i]); }
                if (order) { i++; }
                else { i--; }
            }
        }
        internal static void MainWindowFolderFilter_AddAsync(string[] items, bool order = true)
        {
            int i = 0;
            if (!order) i = items.Count() - 1;
            for (int z = 0; z < items.Count(); z++)
            {
                if (items[i].Length > 0) { MainWindowFolderFilter_AddAsync(items[i]); }
                if (order) { i++; }
                else { i--; }
            }
        }
        internal static void MainWindowFolderList_SelectItem(int index)
        {
            if (Gui.GetItemsCount(MainWindow.mainWindow.lbPresentationsDatesList) > 0)
            {
                Gui.Select(MainWindow.mainWindow.lbPresentationsDatesList, 0);
            }
        }
    }
}