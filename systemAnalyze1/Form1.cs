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

        public int count = 0;

        private void newValuesButton_Click_1(object sender, EventArgs e)
        {
            count = Convert.ToInt32(topsQuanUpDown.Value);
            if (count <= 0 )
            {
                MessageBox.Show("Неверные значения количества вершин или ребер", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            relationsMatrixView.RowCount = count;
            relationsMatrixView.ColumnCount = count;
            for(int i=0; i!= count; ++i)
            {
                relationsMatrixView.Rows[i].HeaderCell.Value = $"{i}";
                relationsMatrixView.Columns[i].HeaderCell.Value = $"{i}";
            }
        }

        private void startCalcButton_Click(object sender, EventArgs e)
        {
            List<List<int>> inputValues = new List<List<int>>();
            for (int i = 0; i != count; ++i)
            {
                DataGridViewRow curRow = relationsMatrixView.Rows[i];
                List<int> curList = new List<int>();
                for (int j = 0; j != count; ++j)
                {
                    try
                    {
                        int val = 0;
                        if (!Int32.TryParse(curRow.Cells[j].Value.ToString(), out val))
                        {
                            MessageBox.Show("неверные значения");
                            return;
                        }
                        if (val == 1)
                            curList.Add(j);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return;
                    }
                }

                inputValues.Add(curList);
            }
            graphExplorer ge;
            try
            {
                ge = new graphExplorer(inputValues);
                showRenamedMatrix(ge);
                showG(ge);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void showG(graphExplorer ge)
        {
            List<List<int>> g = ge.getSetOfOutcomingPaths();
            string s = "";
            for(int i=0; i!= g.Count; ++i)
            {
                s += i.ToString() + ": {";
                foreach (int val in g[i])
                    s += val.ToString() + " ";
                s += "} \n";
            }
            setsBox.Text = s;
        }

        private void showRenamedMatrix(graphExplorer oper)
        {
            List<List<KeyValuePair<int, int>>> matrix = oper.AtoBMatrix();
            int bounds = oper.bounds;
            incidentMatrixView.Rows.Clear();
            incidentMatrixView.Columns.Clear();
            for (int i = 0; i != bounds; i++)
                incidentMatrixView.Columns.Add(new DataGridViewTextBoxColumn());
            for (int i = 0; i != matrix.Count; ++i)
            {
                DataGridViewRow curRow = new DataGridViewRow();
                for (int j = 0; j != bounds; ++j)
                {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    if (matrix[i].Contains(new KeyValuePair<int, int>(j, 1)))
                        cell.Value = 1;
                    else if (matrix[i].Contains(new KeyValuePair<int, int>(j, -1)))
                        cell.Value = -1;
                    else cell.Value = 0;
                    curRow.Cells.Add(cell);
                }
                incidentMatrixView.Rows.Add(curRow);
                incidentMatrixView.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int j = 0; j != bounds; ++j)
            {
                incidentMatrixView.Columns[j].HeaderCell.Value = j.ToString();
            }
        }
    }
}
