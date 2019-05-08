///EthanHunter 314243
///5/3/2019
///Tracks and their layouts, 


using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sprint_2
{

    public class Tracks
    {
        /// <summary>
        ///Tracks and their layouts
        /// </summary>
        Canvas canvas;
        Rectangle wall1 = new Rectangle();
        Rectangle wall2 = new Rectangle();
        Rectangle wall3 = new Rectangle();
        Rectangle wall4 = new Rectangle();

        Point wall1Pos = new Point();
        Point wall2Pos = new Point();
        Point wall3Pos = new Point();
        Point wall4Pos = new Point();
        public void Track1(Canvas c)
        {
            canvas = c;
            
            Polygon TrackOneInsideOne = new Polygon();
            Point InsideOne1 = new Point(300,300);
            Point InsideOne2 = new Point(900,300);
            Point InsideOne3 = new Point(1100,500);
            Point InsideOne4 = new Point(1100,700);
            Point InsideOne5 = new Point(900, 900);
            Point InsideOne6 = new Point(300, 900);
            Point InsideOne7 = new Point(100, 700);
            Point InsideOne8 = new Point(100, 500);
            PointCollection InsideOne = new PointCollection();
            InsideOne.Add(InsideOne1);
            InsideOne.Add(InsideOne2);
            InsideOne.Add(InsideOne3);
            InsideOne.Add(InsideOne4);
            InsideOne.Add(InsideOne5);
            InsideOne.Add(InsideOne6);
            InsideOne.Add(InsideOne7);
            InsideOne.Add(InsideOne8);
            TrackOneInsideOne.Points = InsideOne;
            TrackOneInsideOne.Stroke = Brushes.Green;
            TrackOneInsideOne.StrokeThickness = 200;
            c.Children.Add(TrackOneInsideOne);
            //Polygon TrackOneInsideTwo = new Polygon();
            //Point InsideTwo1 = new Point(300, 400);
            //Point InsideTwo2 = new Point(900, 400);
            //Point InsideTwo3 = new Point(1000, 500);
            //Point InsideTwo4 = new Point(1000, 700);
            //Point InsideTwo5 = new Point(900, 800);
            //Point InsideTwo6 = new Point();
            //Point InsideTwo7 = new Point();
            //Point InsideTwo8 = new Point();
            //PointCollection InsideTwo = new PointCollection();
            //InsideTwo.Add(InsideTwo1);
            //InsideTwo.Add(InsideTwo2);
            //InsideTwo.Add(InsideTwo3);
            //InsideTwo.Add(InsideTwo4);
            //InsideTwo.Add(InsideTwo5);
            //InsideTwo.Add(InsideTwo6);
            //InsideTwo.Add(InsideTwo7);
            //InsideTwo.Add(InsideTwo8);
            //TrackOneInsideTwo.Points = InsideTwo;
            //TrackOneInsideTwo.Fill = Brushes.Blue;
            //c.Children.Add(TrackOneInsideTwo);
        }
        public void Track2(Canvas c)
        {
            canvas = c;
            wall1.Height = 10;
            wall1.Width = 100;
            wall1Pos.Y = 300;
            wall1Pos.X = 200;
            wall1.Fill = Brushes.Aqua;
            canvas.Children.Add(wall1);
            Canvas.SetLeft(wall1, wall1Pos.X);
            Canvas.SetTop(wall1, wall1Pos.Y);
            
        }
        public void Track3(Canvas c) { }
    }
}
