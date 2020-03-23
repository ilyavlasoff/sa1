using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemAnalyze1
{
    class graphExplorer
    {
        private List<List<Int32>> matrix;
        private Int32 topsQuan;
        public graphExplorer(List<List<Int32>> _init)
        {
            matrix = _init;
            topsQuan = _init.Count;
        }

        public int bounds = 0;

        public List<List<KeyValuePair<int, int>>> AtoBMatrix()
        {
            List<List<KeyValuePair<int, int>>> Bmatrix = new List<List<KeyValuePair<int, int>>>();
            for (int i = 0; i != matrix.Count; ++i)
            {
                Bmatrix.Add(new List<KeyValuePair<int, int>>());
            }
            int num = 0;
            for (int i = 0; i != matrix.Count; ++i)
            {
                for (int j = 0; j != matrix[i].Count; ++j)
                {
                    Bmatrix[i].Add(new KeyValuePair<int, int>(num, 1));
                    Bmatrix[matrix[i][j]].Add(new KeyValuePair<int, int>(num, -1));
                    ++num;
                }
            }
            bounds = num;
            return Bmatrix;
        }

        public List<List<Int32>> getSetOfOutcomingPaths()
        {
            return matrix;
        }
    }
}
