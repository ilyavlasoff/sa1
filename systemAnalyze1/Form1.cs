using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemAnalyze1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newValuesButton_Click_1(object sender, EventArgs e)
        {
            int tops = Convert.ToInt32(topsQuanUpDown.Value);
            int edges = Convert.ToInt32(edgesQuanUpDown.Value);
            if (tops <= 0 || edges <= 0)
            {
                MessageBox.Show("Неверные значения количества вершин или ребер", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            relationsMatrixView.RowCount = tops;
            relationsMatrixView.ColumnCount = tops;
            for(int i=0; i!= tops; ++i)
            {
                relationsMatrixView.Rows[i].HeaderCell.Value = $"{i}";
                relationsMatrixView.Columns[i].HeaderCell.Value = $"{i}";
            }
        }

        private void startCalcButton_Click(object sender, EventArgs e)
        {
            List<List<Int32>> matrixData = new List<List<int>>();
            foreach(DataGridViewRow row in relationsMatrixView.Rows)
            {
                List<Int32> mRow = new List<int>();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    Int32 value;
                    if (!Int32.TryParse(cell.Value.ToString(),out value))
                    {
                        MessageBox.Show("Заполните матрицу числовыми значениями", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    mRow.Add(value);
                }
            }
            graphExplorer ge;
            try
            {
                ge = new graphExplorer(matrixData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
