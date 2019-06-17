using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SWINGS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 0, 5) }; // 1 секунда

        Coordinate[] coordinates = new Coordinate[]
        {
            #region gr1_0 - gr1_11
            //---------------------------- низ
            new Coordinate(600, 450, 0,
                           540, 450, 0),
            new Coordinate(540, 450, 0,
                           540, 450, 60),
            new Coordinate(540, 450, 60,
                           600, 450, 60),
            new Coordinate(600, 450, 60,
                           600, 450, 0),
            //----------------------------- бок
            new Coordinate(600, 450, 0,
                           600, 200, 0),
            new Coordinate(540, 450, 0,
                           540, 200, 0),
            new Coordinate(540, 450, 60,
                           540, 200, 60),
            new Coordinate(600, 450, 60,
                           600, 200, 60),
            //----------------------------- верх
            new Coordinate(600, 200, 0,
                           540, 200, 0),
            new Coordinate(540, 200, 0,
                           540, 200, 60),
            new Coordinate(540, 200, 60,
                           600, 200, 60),
            new Coordinate(600, 200, 60,
                           600, 200, 0),
            #endregion

            #region gr2_00 - gr2_11
            //---------------------------- низ
            new Coordinate(900, 450, 0,
                           840, 450, 0),
            new Coordinate(840, 450, 0,
                           840, 450, 60),
            new Coordinate(840, 450, 60,
                           900, 450, 60),
            new Coordinate(900, 450, 60,
                           900, 450, 0),
            //----------------------------- бок
            new Coordinate(900, 450, 0,
                           900, 200, 0),
            new Coordinate(840, 450, 0,
                           840, 200, 0),
            new Coordinate(840, 450, 60,
                           840, 200, 60),
            new Coordinate(900, 450, 60,
                           900, 200, 60),
            //----------------------------- верх
            new Coordinate(900, 200, 0,
                           840, 200, 0),
            new Coordinate(840, 200, 0,
                           840, 200, 60),
            new Coordinate(840, 200, 60,
                           900, 200, 60),
            new Coordinate(900, 200, 60,
                           900, 200, 0),
            #endregion

            #region gr3_00 - gr3_11
            //---------------------------- низ
            new Coordinate(900, 200, 0,
                           540, 200, 0),
            new Coordinate(540, 200, 0,
                           540, 200, 60),
            new Coordinate(540, 200, 60,
                           900, 200, 60),
            new Coordinate(900, 200, 60,
                           900, 200, 0),
            //----------------------------- бок
            new Coordinate(900, 200, 0,
                           900, 140, 0),
            new Coordinate(540, 200, 0,
                           540, 140, 0),
            new Coordinate(540, 200, 60,
                           540, 140, 60),
            new Coordinate(900, 200, 60,
                           900, 140, 60),
            //----------------------------- верх
            new Coordinate(900, 140, 0,
                           540, 140, 0),
            new Coordinate(540, 140, 0,
                           540, 140, 60),
            new Coordinate(540, 140, 60,
                           900, 140, 60),
            new Coordinate(900, 140, 60,
                           900, 140, 0),
            #endregion

            #region gr4_00 - gr4_11
            //---------------------------- низ
            new Coordinate(670, 350, 20,
                           650, 350, 20),
            new Coordinate(650, 350, 20,
                           650, 350, 40),
            new Coordinate(650, 350, 40,
                           670, 350, 40),
            new Coordinate(670, 350, 40,
                           670, 350, 20),
            //---------------------------- низ
            new Coordinate(670, 350, 20,
                           670, 200, 20),
            new Coordinate(650, 350, 20,
                           650, 200, 20),
            new Coordinate(650, 350, 40,
                           650, 200, 40),
            new Coordinate(670, 350, 40,
                           670, 200, 40),
            //---------------------------- низ
            new Coordinate(670, 200, 20,
                           650, 200, 20),
            new Coordinate(650, 200, 20,
                           650, 200, 40),
            new Coordinate(650, 200, 40,
                           670, 200, 40),
            new Coordinate(670, 200, 40,
                           670, 200, 20),

            #endregion

            #region gr5_00 - gr5_11
            //---------------------------- низ
            new Coordinate(790, 350, 20,
                           770, 350, 20),
            new Coordinate(770, 350, 20,
                           770, 350, 40),
            new Coordinate(770, 350, 40,
                           790, 350, 40),
            new Coordinate(790, 350, 40,
                           790, 350, 20),
            //---------------------------- низ
            new Coordinate(790, 350, 20,
                           790, 200, 20),
            new Coordinate(770, 350, 20,
                           770, 200, 20),
            new Coordinate(770, 350, 40,
                           770, 200, 40),
            new Coordinate(790, 350, 40,
                           790, 200, 40),
            //---------------------------- низ
            new Coordinate(790, 200, 20,
                           770, 200, 20),
            new Coordinate(770, 200, 20,
                           770, 200, 40),
            new Coordinate(770, 200, 40,
                           790, 200, 40),
            new Coordinate(790, 200, 40,
                           790, 200, 20),

            #endregion

            #region gr6_00 - gr6_11
            new Coordinate(810, 380, 10,
                           630, 380, 10),
            new Coordinate(630, 380, 10,
                           630, 380, 50),
            new Coordinate(630, 380, 50,
                           810, 380, 50),
            new Coordinate(810, 380, 50,
                           810, 380, 10),
            //-----------------------------
            new Coordinate(810, 380, 10,
                           810, 350, 10),
            new Coordinate(630, 380, 10,
                           630, 350, 10),
            new Coordinate(630, 380, 50,
                           630, 350, 50),
            new Coordinate(810, 380, 50,
                           810, 350, 50),
            //-----------------------------
            new Coordinate(810, 350, 10,
                           630, 350, 10),
            new Coordinate(630, 350, 10,
                           630, 350, 50),
            new Coordinate(630, 350, 50,
                           810, 350, 50),
            new Coordinate(810, 350, 50,
                           810, 350, 10),

            #endregion


            new Coordinate(720, 200, 30, 
                           720,200,30),


            // Координаты-помощники
            new Coordinate(100, 500, 0,
                           180, 500, 0),
            new Coordinate(100, 500, 0,
                           100, 420, 0),
            new Coordinate(100, 500, 0,
                           100, 500, 80)
        }; // массив координат всех линий

        Vector vector = new Vector(715.0, 320.0); // вектор поворота модели

        double Z_Zero, Y_Zero;

        double StartPosY, EndPosY, NewPosY;


        MyMatrix PointRotation = new MyMatrix(1, 0, 0,
                                              0, 1, 0,
                                              0, 0, 1);



        public MainWindow()
        {
            InitializeComponent();
        }


        // кнопки
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            // считываем клавишу и в зависимости от неё крутим качели по X,Y,Z
            
            switch (e.Key)
            {
                case Key.W:
                    RotateElementX(-0.03, vector);
                    break;

                case Key.S:
                    RotateElementX(0.03, vector);
                    break;

                case Key.A:
                    RotateElementY(-0.03, vector);
                    break;

                case Key.D:
                    RotateElementY(0.03, vector);
                    break;

                case Key.Q:
                    RotateElementZ(0.03, vector);
                    break;

                case Key.E:
                    RotateElementZ(-0.03, vector);
                    break;
            }
        }






        #region повороты по осям
        //СДЕЛАНО
        /// <summary>
        /// ПОВОРОТ ОТНОСИТЕЛЬНО X
        /// </summary>
        /// <param name="line">Линия, которую следует повернуть</param>
        private void RotateElementX(double alpha, Vector vec)
        {
            List<Line> lines = new List<Line>()
            {
                gr1_00, gr1_01, gr1_02, gr1_03, gr1_04, gr1_05, gr1_06, gr1_07, gr1_08, gr1_09, gr1_10, gr1_11,
                gr2_00, gr2_01, gr2_02, gr2_03, gr2_04, gr2_05, gr2_06, gr2_07, gr2_08, gr2_09, gr2_10, gr2_11,
                gr3_00, gr3_01, gr3_02, gr3_03, gr3_04, gr3_05, gr3_06, gr3_07, gr3_08, gr3_09, gr3_10, gr3_11,
                gr4_00, gr4_01, gr4_02, gr4_03, gr4_04, gr4_05, gr4_06, gr4_07, gr4_08, gr4_09, gr4_10, gr4_11,
                gr5_00, gr5_01, gr5_02, gr5_03, gr5_04, gr5_05, gr5_06, gr5_07, gr5_08, gr5_09, gr5_10, gr5_11,
                gr6_00, gr6_01, gr6_02, gr6_03, gr6_04, gr6_05, gr6_06, gr6_07, gr6_08, gr6_09, gr6_10, gr6_11,

                fulc,

                helperX, helperY, helperZ
            };
            
            double x1, y1, z1, x2, y2, z2;
            double Xx1, Xx2, Yy1, Yy2, Zz1, Zz2;

            MyMatrix X_Matrix = new MyMatrix(1, 0, 0,
                                              0, Math.Cos(alpha), Math.Sin(alpha),
                                              0, -Math.Sin(alpha), Math.Cos(alpha));


            PointRotation *= X_Matrix;


            for (int i = 0; i < coordinates.Length; i++)
            {
                // x1, y1, z1, x2, y2, z2 - изначальные координаты со смещением на vec
                // vec - вектор, относительно которой крутим фигуру (начало координат)
                
                if (i < coordinates.Length - 3)
                {
                    x1 = coordinates[i].X1 - vec.X;
                    y1 = coordinates[i].Y1 - vec.Y;
                    z1 = coordinates[i].Z1;
                    x2 = coordinates[i].X2 - vec.X;
                    y2 = coordinates[i].Y2 - vec.Y;
                    z2 = coordinates[i].Z2;
                }
                else
                {
                    x1 = coordinates[i].X1 - 100.0;
                    y1 = coordinates[i].Y1 - 500.0;
                    z1 = coordinates[i].Z1;
                    x2 = coordinates[i].X2 - 100.0;
                    y2 = coordinates[i].Y2 - 500.0;
                    z2 = coordinates[i].Z2;
                }


                //--------------------------------------------------------------------------- расчёт точек в 3D
                
                MultiplyVector(ref x1, ref y1, ref z1, PointRotation);
                MultiplyVector(ref x2, ref y2, ref z2, PointRotation);

                Xx1 = x1; Yy1 = y1; Zz1 = z1;
                Xx2 = x2; Yy2 = y2; Zz2 = z2;


                //--------------------------------------------------------------------------- расчёт точек в 3D


                // смещение на vec (к исходной точке)
                if (i < coordinates.Length - 3)
                {
                    Xx1 += vec.X;
                    Yy1 += vec.Y;
                    Xx2 += vec.X;
                    Yy2 += vec.Y;
                }
                else
                {
                    Xx1 += 100.0;
                    Yy1 += 500.0;
                    Xx2 += 100.0;
                    Yy2 += 500.0;
                }
                // смещение на vec (к исходной точке)


                // подстановка новых координат к точкам линий
                // d1, d2, z1, z2 = 0

                
                lines[i].X1 = Xx1;
                lines[i].Y1 = Yy1;

                lines[i].X2 = Xx2;
                lines[i].Y2 = Yy2;

                
            }



        }

        // СДЕЛАНО
        /// <summary>
        /// ПОВОРОТ ОТНОСИТЕЛЬНО Y
        /// </summary>
        /// <param name="grok">Линия, которую следует повернуть</param> 
        private void RotateElementY(double alpha, Vector vec)
        {
            double x1, y1, z1, x2, y2, z2;
            double Xx1, Xx2, Yy1, Yy2, Zz1, Zz2;

            MyMatrix MatrixY = new MyMatrix(Math.Cos(alpha), 0, -Math.Sin(alpha),
                                            0,               1,               0,
                                            Math.Sin(alpha), 0, Math.Cos(alpha));


            PointRotation *= MatrixY;

            List<Line> lines = new List<Line>()
            {
                gr1_00, gr1_01, gr1_02, gr1_03, gr1_04, gr1_05, gr1_06, gr1_07, gr1_08, gr1_09, gr1_10, gr1_11,
                gr2_00, gr2_01, gr2_02, gr2_03, gr2_04, gr2_05, gr2_06, gr2_07, gr2_08, gr2_09, gr2_10, gr2_11,
                gr3_00, gr3_01, gr3_02, gr3_03, gr3_04, gr3_05, gr3_06, gr3_07, gr3_08, gr3_09, gr3_10, gr3_11,
                gr4_00, gr4_01, gr4_02, gr4_03, gr4_04, gr4_05, gr4_06, gr4_07, gr4_08, gr4_09, gr4_10, gr4_11,
                gr5_00, gr5_01, gr5_02, gr5_03, gr5_04, gr5_05, gr5_06, gr5_07, gr5_08, gr5_09, gr5_10, gr5_11,
                gr6_00, gr6_01, gr6_02, gr6_03, gr6_04, gr6_05, gr6_06, gr6_07, gr6_08, gr6_09, gr6_10, gr6_11,

                fulc,

                helperX, helperY, helperZ
            };

            


            for (int i = 0; i < coordinates.Length; i++)
            {

                // x1, y1, z1, x2, y2, z2 - изначальные координаты со смещением на vec
                // vec - вектор, относительно которой крутим фигуру (начало координат)

                if (i < coordinates.Length - 3)
                {
                    x1 = coordinates[i].X1 - vec.X;
                    y1 = coordinates[i].Y1 - vec.Y;
                    z1 = coordinates[i].Z1;
                    x2 = coordinates[i].X2 - vec.X;
                    y2 = coordinates[i].Y2 - vec.Y;
                    z2 = coordinates[i].Z2;
                }
                else
                {
                    x1 = coordinates[i].X1 - 100.0;
                    y1 = coordinates[i].Y1 - 500.0;
                    z1 = coordinates[i].Z1;
                    x2 = coordinates[i].X2 - 100.0;
                    y2 = coordinates[i].Y2 - 500.0;
                    z2 = coordinates[i].Z2;
                }


                //--------------------------------------------------------------------------- расчёт точек в 3D

                

                MultiplyVector(ref x1, ref y1, ref z1, PointRotation);
                MultiplyVector(ref x2, ref y2, ref z2, PointRotation);
                

                Xx1 = x1; Yy1 = y1; Zz1 = z1;
                Xx2 = x2; Yy2 = y2; Zz2 = z2;
                //--------------------------------------------------------------------------- расчёт точек в 3D


                // смещение на vec (к исходной точке)
                if (i < coordinates.Length - 3)
                {
                    Xx1 += vec.X;
                    Yy1 += vec.Y;
                    Xx2 += vec.X;
                    Yy2 += vec.Y;
                }
                else
                {
                    Xx1 += 100.0;
                    Yy1 += 500.0;
                    Xx2 += 100.0;
                    Yy2 += 500.0;
                }
                // смещение на vec (к исходной точке)

                
                // подстановка новых координат к точкам линий
                // d1, d2, z1, z2 = 0
                lines[i].X1 = Xx1;
                lines[i].Y1 = Yy1;

                lines[i].X2 = Xx2;
                lines[i].Y2 = Yy2;

            }


        }

        // СДЕЛАНО
        /// <summary>
        /// ПОВОРОТ ОТНОСИТЕЛЬНО ОСИ Z
        /// </summary>
        /// <param name="line">Линия, которую следует повернуть</param>
        private void RotateElementZ(double alpha, Vector vec)
        {
            List<Line> lines = new List<Line>()
            {
                gr1_00, gr1_01, gr1_02, gr1_03, gr1_04, gr1_05, gr1_06, gr1_07, gr1_08, gr1_09, gr1_10, gr1_11,
                gr2_00, gr2_01, gr2_02, gr2_03, gr2_04, gr2_05, gr2_06, gr2_07, gr2_08, gr2_09, gr2_10, gr2_11,
                gr3_00, gr3_01, gr3_02, gr3_03, gr3_04, gr3_05, gr3_06, gr3_07, gr3_08, gr3_09, gr3_10, gr3_11,
                gr4_00, gr4_01, gr4_02, gr4_03, gr4_04, gr4_05, gr4_06, gr4_07, gr4_08, gr4_09, gr4_10, gr4_11,
                gr5_00, gr5_01, gr5_02, gr5_03, gr5_04, gr5_05, gr5_06, gr5_07, gr5_08, gr5_09, gr5_10, gr5_11,
                gr6_00, gr6_01, gr6_02, gr6_03, gr6_04, gr6_05, gr6_06, gr6_07, gr6_08, gr6_09, gr6_10, gr6_11,

                fulc,

                helperX, helperY, helperZ
            };

            double x1, y1, z1, x2, y2, z2, Z;
            double Xx1, Xx2, Yy1, Yy2, Zz1, Zz2;

            MyMatrix Z_Matrix = new MyMatrix(Math.Cos(alpha),  Math.Sin(alpha), 0,
                                             -Math.Sin(alpha), Math.Cos(alpha), 0,
                                             0,                0,               1);


            PointRotation *= Z_Matrix;


            for (int i = 0; i < coordinates.Length; i++)
            {

                // x1, y1, z1, x2, y2, z2 - изначальные координаты со смещением на vec
                // vec - вектор, относительно которой крутим фигуру (начало координат)

                if (i < coordinates.Length - 3)
                {
                    x1 = coordinates[i].X1 - vec.X;
                    y1 = coordinates[i].Y1 - vec.Y;
                    z1 = coordinates[i].Z1;
                    x2 = coordinates[i].X2 - vec.X;
                    y2 = coordinates[i].Y2 - vec.Y;
                    z2 = coordinates[i].Z2;
                }
                else
                {
                    x1 = coordinates[i].X1 - 100.0;
                    y1 = coordinates[i].Y1 - 500.0;
                    z1 = coordinates[i].Z1;
                    x2 = coordinates[i].X2 - 100.0;
                    y2 = coordinates[i].Y2 - 500.0;
                    z2 = coordinates[i].Z2;
                }


                //--------------------------------------------------------------------------- расчёт точек в 3D
                
                               
                MultiplyVector(ref x1, ref y1, ref z1, PointRotation);
                MultiplyVector(ref x2, ref y2, ref z2, PointRotation);

                Xx1 = x1; Yy1 = y1; Zz1 = z1;
                Xx2 = x2; Yy2 = y2; Zz2 = z2;
                //--------------------------------------------------------------------------- расчёт точек в 3D


                // смещение на vec (к исходной точке)
                if (i < coordinates.Length - 3)
                {
                    Xx1 += vec.X;
                    Yy1 += vec.Y;
                    Xx2 += vec.X;
                    Yy2 += vec.Y;
                }
                else
                {
                    Xx1 += 100.0;
                    Yy1 += 500.0;
                    Xx2 += 100.0;
                    Yy2 += 500.0;
                }
                // смещение на vec (к исходной точке)
                
                // подстановка новых координат к точкам линий
                // d1, d2, z1, z2 = 0
                lines[i].X1 = Xx1;
                lines[i].Y1 = Yy1;

                lines[i].X2 = Xx2;
                lines[i].Y2 = Yy2;

                
            }


        }
        #endregion



        private void SwingX(double alpha)
        {
            List<Line> lines = new List<Line>()
            {
                gr4_00, gr4_01, gr4_02, gr4_03, gr4_04, gr4_05, gr4_06, gr4_07, gr4_08, gr4_09, gr4_10, gr4_11,
                gr5_00, gr5_01, gr5_02, gr5_03, gr5_04, gr5_05, gr5_06, gr5_07, gr5_08, gr5_09, gr5_10, gr5_11,
                gr6_00, gr6_01, gr6_02, gr6_03, gr6_04, gr6_05, gr6_06, gr6_07, gr6_08, gr6_09, gr6_10, gr6_11,

                fulc
            };

            double x1, y1, z1, x2, y2, z2;
            double Xx1, Xx2, Yy1, Yy2, Zz1, Zz2;

            MyMatrix X_Matrix = new MyMatrix(1,               0,               0,
                                             0, Math.Cos(alpha), Math.Sin(alpha),
                                             0, -Math.Sin(alpha), Math.Cos(alpha));

            double X = 720.0,
                   Y = 200.0,
                   Z = 30.0;

            Line lnk = new Line()
            {
                Height = 700,
                Width = 1100,
                Stroke = Brushes.MediumPurple,
                StrokeThickness = 10,
                X1 = 715,
                Y1 = 200,
                X2 = 725,
                Y2 = 200
            };

            myCanvas.Children.Add(lnk);

            
            // SwingMat (поворот)
            for (int i = 36, k = 0; i < coordinates.Length - 3; i++, k++)
            {

                // x1, y1, z1, x2, y2, z2 - изначальные координаты со смещением на vec
                // vec - вектор, относительно которой крутим фигуру (начало координат)

                x1 = coordinates[i].X1 - X;
                y1 = coordinates[i].Y1 - Y;
                z1 = coordinates[i].Z1 - Z;
                x2 = coordinates[i].X2 - X;
                y2 = coordinates[i].Y2 - Y;
                z2 = coordinates[i].Z2 - Z;

                //--------------------------------------------------------------------------- расчёт точек в 3D

                MultiplyVector(ref x1, ref y1, ref z1, X_Matrix);
                //MultiplyVector(ref x1, ref y1, ref z1, PointRotation);


                MultiplyVector(ref x2, ref y2, ref z2, X_Matrix);
                //MultiplyVector(ref x2, ref y2, ref z2, PointRotation);


                Xx1 = x1; Yy1 = y1; Zz1 = z1;
                Xx2 = x2; Yy2 = y2; Zz2 = z2;

                //--------------------------------------------------------------------------- расчёт точек в 3D


                // смещение на vec (к исходной точке)

                Xx1 += X;
                Yy1 += Y;
                Zz1 += Z;
                Xx2 += X;
                Yy2 += Y;
                Zz2 += Z;

                // смещение на vec (к исходной точке)

                //---------------------- изменение изначальных
                coordinates[i].X1 = Xx1;
                coordinates[i].Y1 = Yy1;
                coordinates[i].Z1 = Zz1;
                coordinates[i].X2 = Xx2;
                coordinates[i].Y2 = Yy2;
                coordinates[i].Z2 = Zz2;

                //---------------------- изменение изначальных
                
                
            }

            Z_Zero = coordinates[36].Z1;
            Y_Zero = coordinates[36].Y1;

            EndPosY = Math.Truncate(EndPosY);
            StartPosY = Math.Truncate(StartPosY);

            Ordinates.Foreground = Brushes.White;
            Ordinates.Text = $"Y: {Math.Round(coordinates[36].Y1, 2)}\n" +
                             $"Z: {Math.Round(coordinates[36].Z1, 2)}\n\n" +
                             $"Sart: {Math.Truncate(StartPosY)} | End: {Math.Truncate(EndPosY)}";

        }






        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartPosY = Y_Zero;

            NewPosY = Y_Zero;

            if (Z_Zero-20 > 0) EndPosY = Y_Zero - 14.0;
            else EndPosY = Y_Zero + 14.0;

            EndPosY = Math.Truncate(EndPosY);
            StartPosY = Math.Truncate(StartPosY);

            if (EndPosY > StartPosY)
            {
                timer.Tick -= Timer_TickFront;
                timer.Tick -= Timer_TickBack;

                timer.Tick += Timer_TickFront;
            }
            else
            {
                timer.Tick -= Timer_TickFront;
                timer.Tick -= Timer_TickBack;

                timer.Tick += Timer_TickBack;
            }

            ORDT.Foreground = Brushes.White;
            ORDT.Text += $"\nStart: {Math.Round(StartPosY, 1)} | End: {Math.Round(EndPosY, 1)} | Z_Zero: {Math.Round(Z_Zero, 2)}";

            timer.Start();

        }

        double k = 0.01;

        /// <summary>
        /// ВПРАВО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_TickFront(object sender, object e)
        {
            NewPosY = Y_Zero;
            NewPosY = Math.Truncate(NewPosY);

            if ((Math.Round(NewPosY) == Math.Round(EndPosY)) && Z_Zero > 0)
            {
                ORDT.Text = "Front";

                timer.Tick -= Timer_TickBack;
                timer.Tick -= Timer_TickFront;

                NewPosY = EndPosY;
                EndPosY = StartPosY;
                StartPosY = NewPosY;


                timer.Tick += Timer_TickBack;
            }
            else
            {
                SwingX(-0.02);
                RotateElementX(0, vector);
            }
            
        }

        /// <summary>
        /// ВЛЕВО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_TickBack(object sender, object e)
        {
            NewPosY = Y_Zero;
            NewPosY = Math.Truncate(NewPosY);

            if ((Math.Round(NewPosY) == Math.Round(EndPosY)) && Z_Zero < 0)
            {
                ORDT.Text = "Back";

                timer.Tick -= Timer_TickBack;
                timer.Tick -= Timer_TickFront;

                NewPosY = EndPosY;
                EndPosY = StartPosY;
                StartPosY = NewPosY;

                

                timer.Tick += Timer_TickFront;
            }
            else
            {
                SwingX(0.02);
                RotateElementX(0, vector);
            }
        }

        private void Input_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            timer.Tick -= Timer_TickFront;
            timer.Tick -= Timer_TickBack;

            SwingX(input.Value);
            RotateElementX(0, vector);
        }






        /// <summary>
        /// Умножение координат вектора (X,Y,Z)
        /// </summary>
        /// <param name="X">координата X</param>
        /// <param name="Y">координата Y</param>
        /// <param name="Z">координата Z</param>
        /// <param name="matrix">матрица</param>
        private void MultiplyVector(ref double X, ref double Y, ref double Z, MyMatrix matrix) // умножение вектора на матрицу
        {

            double newX = matrix.A11 * X + matrix.A12 * Y + matrix.A13 * Z;
            double newY = matrix.A21 * X + matrix.A22 * Y + matrix.A23 * Z;
            double newZ = matrix.A31 * X + matrix.A32 * Y + matrix.A33 * Z;

            X = newX; Y = newY; Z = newZ;
        }
    }
}
