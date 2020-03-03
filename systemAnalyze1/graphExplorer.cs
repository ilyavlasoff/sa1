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
            if (!verifyRelationMatrix(_init)) throw new Exception("Wrong matrix");
            matrix = _init;
            topsQuan = _init.Count;
        }

        private Boolean verifyRelationMatrix(List<List<Int32>> _m)
        {
            foreach (List<Int32> _line in _m)
            {
                if (_line.Count != _m.Count) return false;
                if (!_line.All(value => value == 1 || value == 0)) return false;
            }
            return true;
        }

        public List<List<KeyValuePair<int, int>>> getIncidentsMatrix()
        {
            List<List<KeyValuePair<int, int>>> resp = new List<List<KeyValuePair<int, int>>>();
            for(Int32 i =0; i!= topsQuan; ++i)
            {
                for(Int32 j=0; j!= topsQuan; ++j)
                {
                    if (matrix[i][j] == 1)
                    {
                        List<KeyValuePair<int, int>> line = new List<KeyValuePair<int, int>>(topsQuan);
                        line.Add(new KeyValuePair<int, int>(i, -1));
                        line.Add(new KeyValuePair<int, int>(j, 1));
                        resp.Add(line);
                    }
                }
            }
            return resp;
        }

        public List<List<Int32>> getSetOfOutcomingPaths()
        {
            List<List<Int32>> resp = new List<List<int>>();
            foreach(List<Int32> line in matrix)
            {
                List<Int32> respLine = new List<int>();
                for(Int32 i=0; i!= topsQuan; ++i)
                {
                    if (line[i] == 1)
                        respLine.Add(i);
                }
                resp.Add(respLine);
            }
            return resp;
        }
    }
}
