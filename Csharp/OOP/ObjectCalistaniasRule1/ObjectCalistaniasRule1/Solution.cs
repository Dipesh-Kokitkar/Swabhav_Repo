using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectCalistaniasRule1
{
    public class Solution
    {
        private int[,] _array;

        public Solution() {
            _array = new int[3,3];
        }

        public void ArrayIntaliztion()
        {
            CollectRow();
           
        }

        public void CollectRow() {
            for (int i = 0; i < 3; i++) {
                CollectRow(i);
            }
        }

        public void CollectRow(int row) {
            for (int j = 0; j < 3; j++) {
                _array[row,j] = Check(row, j);
            }
        }
        public int Check(int i,int j) {
            if (i == j)
                return 1;
            return 0;
        }
        public bool IsDiagonal()
        {
            for (int i = 0; i < 3; i++)
                if (_array[i,i] == 1)
                    return true;
            return false;
        }
    }
}
