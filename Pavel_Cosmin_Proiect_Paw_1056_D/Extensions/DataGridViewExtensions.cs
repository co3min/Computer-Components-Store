using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavel_Cosmin_Proiect_Paw_1056_D.Extensions
{
    public static class DataGridViewExtensions
    {
        public static DataGridView RefreshDataGrid<T>(this DataGridView dataGrid, List<T> data)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = data;

            return dataGrid;
        }
        public static DataGridView AddColumn(this DataGridView dataGrid, int index, string textName,string propertyName)
        {
            dataGrid.ColumnCount++;
            dataGrid.Columns[index].HeaderText = textName;
            dataGrid.Columns[index].DataPropertyName = propertyName;
            return dataGrid;
        }

        public static DataGridView AddButtonColumn(this DataGridView dataGrid, string name, string textButton, string headerText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = textButton;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(buttonColumn);
            return dataGrid;
        }


    }
}
