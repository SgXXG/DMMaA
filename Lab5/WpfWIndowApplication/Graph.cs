using System;
using System.Drawing;
using System.Windows.Media;
using Algorithm;
using Color = System.Windows.Media.Color;
using Pen = System.Windows.Media.Pen;

namespace WpfWIndowApplication
{
    public class Graph
    {
        private const int step = 21;

        private const int width = 500;

        private const int height = 420;

        private readonly GeometryGroup firstClass;

        private readonly GeometryGroup secondClass;
        private readonly Function separetingFunction;


        public Graph(Function separetingFunction) : this()
        {
            this.separetingFunction = separetingFunction;
            DrawingGroup.Children.Add(DrawFunction());
        }

        public Graph()
        {
            DrawingGroup = CreateDrawingGroup();
            firstClass = AddEmptyClass(Colors.Green);
            secondClass = AddEmptyClass(Colors.Blue);
        }

        public DrawingGroup DrawingGroup { get; private set; }

        private DrawingGroup CreateDrawingGroup()
        {
            var result = new DrawingGroup();
            result.Children.Add(AddAxes());
            return result;
        }

        public void AddPoint(Point newPoint, bool toFirstClass)
        {
            GeometryGroup currentClass = toFirstClass ? firstClass : secondClass;
            currentClass.Children.Add(
                new EllipseGeometry(
                    new System.Windows.Point(newPoint.X*step + width/2, height/2 - newPoint.Y*step),
                    3, 3));
        }

        private GeometryDrawing DrawFunction()
        {
            var functioin = new GeometryGroup();
            var prevPoint = new System.Windows.Point(0,
                height/2 - separetingFunction.GetY(-width/2/step)*step);
            for (double x = -width/2/step; x < width/2/step; x += 0.01)
            {
                var nextPoint = new System.Windows.Point(width/2 + x*step,
                    height/2 - separetingFunction.GetY(x)*step);
                try
                {
                    if (Math.Abs(nextPoint.Y - prevPoint.Y) < height &&
                        IsLineInGraph(nextPoint, prevPoint))
                    {
                        functioin.Children.Add(new LineGeometry(prevPoint, nextPoint));
                    }
                }
                catch (OverflowException)
                {
                }
                prevPoint = nextPoint;
            }
            var functionBrush = new SolidColorBrush(Colors.Red);
            var functionDrawing = new GeometryDrawing(functionBrush, new Pen(functionBrush, 3),
                functioin);
            return functionDrawing;
        }

        private static bool IsLineInGraph(System.Windows.Point nextPoint,
            System.Windows.Point prevPoint)
        {
            return nextPoint.Y > 0 && nextPoint.Y < height && prevPoint.Y > 0 &&
                   prevPoint.Y < height;
        }

        private static GeometryDrawing AddAxes()
        {
            var axes = new GeometryGroup();
            axes.Children.Add(new LineGeometry(new System.Windows.Point(0, height/2),
                new System.Windows.Point(width, height/2)));
            axes.Children.Add(new LineGeometry(new System.Windows.Point(width/2, 0),
                new System.Windows.Point(width/2, height)));
            var axesBrush = new SolidColorBrush(Colors.Black);
            var geometryDrawing = new GeometryDrawing(axesBrush, new Pen(axesBrush, 1), axes);
            return geometryDrawing;
        }

        private GeometryGroup AddEmptyClass(Color color)
        {
            var classGroup = new GeometryGroup();
            var brush = new SolidColorBrush(color);
            var geometryDrawing = new GeometryDrawing(brush, new Pen(brush, 5), classGroup);
            DrawingGroup.Children.Add(geometryDrawing);
            return classGroup;
        }
    }
}