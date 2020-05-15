using System;

namespace Lab1.Entities
{
    public class MatrixEntity {
        private int [,] data;
        public int x {get; private set;}
        public int y {get; private set;}

        public MatrixEntity (int [,] data) {
            this.data = data;
            this.x = data.GetLength(1);
            this.y = data.GetLength(0);
        }

        public MatrixEntity multy(MatrixEntity m) {
            if (m != null && x == m.y) {
                int [,] resultData = new int[y, m.x];
                for(int i = 0; i < y; i++) {
                    for(int ii = 0; ii < m.x; ii++) {
                        int sum = 0;
                        for(int iii = 0; iii < x; iii++) {
                            sum += data[i,iii] * m.data[iii, ii];
                        }
                        resultData[i, ii] = sum;
                    }
                }
                return new MatrixEntity(resultData);
            } else {
                throw new Exception("Matrix are not equals");
            }
        }

        public void print() {
            for (int i = 0; i < y; i++) {
                for (int ii = 0; ii < x; ii++) {
                    Console.Write(data[i,ii] + " ");
                }
                Console.WriteLine();
            }
        }
    }    
}