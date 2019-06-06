using System;

namespace ObjectCalistaniasRule1
{
    public class Voilation
    {
        int[,] arr;

        public Voilation() {
            arr = new int[3,3];
        }

        public void ArrayIntaliztion() {

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (i == j)
                        arr[i,j] = 1;
                    else
                        arr[i,j] = 0;
                }
            }
        }

        public bool IsDiagonal() {
            for (int i = 0; i < 3; i++) {
                if (arr[i,i] == 1)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
