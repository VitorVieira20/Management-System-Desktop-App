using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ManagementSystem.Pages.Dashboard
{
    public static class UIHelper
    {
        /// <summary>
        /// Shows multiple controls.
        /// </summary>
        /// <param name="controls">Array of controls to show.</param>
        public static void ShowComponents(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = true;
            }
        }

        /// <summary>
        /// Hides multiple controls.
        /// </summary>
        /// <param name="controls">Array of controls to hide.</param>
        public static void HideComponents(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = false;
            }
        }

        public static void SearchListView(ListView listView, string searchText)
        {
            foreach (ListViewItem item in listView.Items)
            {
                item.BackColor = item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(subItem => subItem.Text.ToLower().Contains(searchText)) ? SystemColors.Highlight : listView.BackColor;
            }
        }

        public static void SortListView(ListView listView, int columnIndex, bool ascending)
        {
            listView.ListViewItemSorter = new ListViewItemComparer(columnIndex, ascending);
        }

        private class ListViewItemComparer : System.Collections.IComparer
        {
            private int col;
            private bool order;

            public ListViewItemComparer(int column, bool order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                return order ? returnVal : -returnVal;
            }
        }
    }
}
