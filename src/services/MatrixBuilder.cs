using System;
using Lab1.Entities;

namespace Lab1.Services
{
    public class MatrixEntityBuilder {
        public MatrixEntity build (int x, int y) {
            int [,] data = new int [y,x];
            Random r = new Random();
            for(int i = 0; i < y; i ++) {
                for (int ii = 0; ii < x; ii++) {
                    data[i,ii] = r.Next(-1000, 1000);
                }
            }
            return new MatrixEntity(data);
        }
    }
}