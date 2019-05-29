using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SWINGS
{
    class MyMatrix
    {
        public double A11, A12, A13,
                      A21, A22, A23,
                      A31, A32, A33;


        public MyMatrix(double a11, double a12, double a13,
                        double a21, double a22, double a23,
                        double a31, double a32, double a33)
        {
            A11 = a11; A12 = a12; A13 = a13;
            A21 = a21; A22 = a22; A23 = a23;
            A31 = a31; A32 = a32; A33 = a33;
        }


        /// <summary>
        /// Умножение матриц 3х3
        /// </summary>
        /// <param name="matrix1">матрица 1</param>
        /// <param name="matrix2">матрица 2</param>
        /// <returns></returns>
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2) // умножение матрицы на матрицу
        {
            double A11 = matrix1.A11 * matrix2.A11 + matrix1.A12 * matrix2.A21 + matrix1.A13 * matrix2.A31;
            double A21 = matrix1.A21 * matrix2.A11 + matrix1.A22 * matrix2.A21 + matrix1.A23 * matrix2.A31;
            double A31 = matrix1.A31 * matrix2.A11 + matrix1.A32 * matrix2.A21 + matrix1.A33 * matrix2.A31;

            double A12 = matrix1.A11 * matrix2.A12 + matrix1.A12 * matrix2.A22 + matrix1.A13 * matrix2.A32;
            double A22 = matrix1.A21 * matrix2.A12 + matrix1.A22 * matrix2.A22 + matrix1.A23 * matrix2.A32;
            double A32 = matrix1.A31 * matrix2.A12 + matrix1.A32 * matrix2.A22 + matrix1.A33 * matrix2.A32;

            double A13 = matrix1.A11 * matrix2.A13 + matrix1.A12 * matrix2.A23 + matrix1.A13 * matrix2.A33;
            double A23 = matrix1.A21 * matrix2.A13 + matrix1.A22 * matrix2.A23 + matrix1.A23 * matrix2.A33;
            double A33 = matrix1.A31 * matrix2.A13 + matrix1.A32 * matrix2.A23 + matrix1.A33 * matrix2.A33;


            return new MyMatrix(A11, A12, A13,
                                A21, A22, A23,
                                A31, A32, A33);

        }





        public override string ToString()
        {
            return $"{A11} {A12} {A13}\n" +
                   $"{A21} {A22} {A23}\n" +
                   $"{A31} {A32} {A33}\n";
        }






    }
}
