using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Algorithm;
using MessageBox = System.Windows.MessageBox;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;
using WinPoint = System.Drawing.Point;

namespace WpfWIndowApplication
{
    public partial class MainWindow : Window
    {
        private Graph graph;
        private Function separetFunction;
        private readonly List<WinPoint>[] points = new List<WinPoint>[2];

        private const int step = 21;

        private const int width = 500;

        private const int height = 420;

        Timer timer = new Timer();


        public MainWindow()
        {
            Clear();
            timer.Interval = 3000;
            timer.Tick+=TimerTick;
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            timer.Stop();
            Image.ToolTip = null;
        }

        private void Clear()
        {
            points[0] = new List<WinPoint>();
            points[1] = new List<WinPoint>();
        }

        private void TeachingButton_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            var potintials = new Potintials();
            var teaching = new WinPoint[2][];

            teaching[0] = new WinPoint[2];
            teaching[0][0] = new WinPoint(Point11XUpDown1.Value ?? 0, Point11YUpDown1.Value ?? 0);
            teaching[0][1] = new WinPoint(Point12XUpDown.Value ?? 0, Point12YUpDown.Value ?? 0);
            points[0].Add(teaching[0][0]);
            points[0].Add(teaching[0][1]);

            teaching[1] = new WinPoint[2];
            teaching[1][0] = new WinPoint(Point21XUpDown2.Value ?? 0, Point21YUpDown2.Value ?? 0);
            teaching[1][1] = new WinPoint(Point22XUpDown1.Value ?? 0, Point22YUpDown1.Value ?? 0);
            points[1].Add(teaching[1][0]);
            points[1].Add(teaching[1][1]);


            separetFunction = potintials.GetFunction(teaching);
            FunctionTextBlock.Text = "";
            if (!potintials.Warning)
            {
                FunctionTextBlock.Text = "Разделяющая функция: " + separetFunction;
                SelectButton.IsEnabled = true;
                graph = new Graph(separetFunction);
            }
            else
            {
                MessageBox.Show("Невозможно построить разделяющую функцию");
                graph = new Graph();
                SelectButton.IsEnabled = false;
            }

            Image.Source = new DrawingImage(graph.DrawingGroup);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    graph.AddPoint(teaching[i][j], i == 0);
                }
            }
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            var testPoint = new WinPoint(TestPointXIntegerUpDown.Value ?? 0,
                TestPointYIntegerUpDown.Value ?? 0);
            int classNumber = separetFunction.GetValue(testPoint) >= 0 ? 0 : 1;
            points[classNumber].Add(testPoint);
            SelectResultText.Text = "Класс " + (classNumber + 1);
            graph.AddPoint(testPoint, classNumber == 0);
        }

        private void Move_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (DrawToolTip(e, points[0], 1)) return;
            if (DrawToolTip(e, points[1], 2)) return;

        }

        private bool DrawToolTip(MouseEventArgs e, IEnumerable<WinPoint> list, int classNumber)
        {
            foreach (WinPoint point in list)
            {
                Point position = e.GetPosition(Image);
                if (Math.Abs(point.X*step + width/2 - position.X) < 10 &&
                    Math.Abs(height/2 - point.Y*step - position.Y) < 10)
                {
                    Image.ToolTip = String.Format("Класс:{0}\r\n({1};{2})", classNumber, point.X, point.Y);
                    timer.Start();
                    return true;
                }
            }
            return false;
        }
    }
}