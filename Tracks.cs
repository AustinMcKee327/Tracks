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
        public Polygon TrackOneInsideOne = new Polygon();
        Point InsideOne1 = new Point(300, 125);
        Point InsideOne2 = new Point(900, 125);
        Point InsideOne3 = new Point(1100, 325);
        Point InsideOne4 = new Point(1100, 525);
        Point InsideOne5 = new Point(900, 725);
        Point InsideOne6 = new Point(300, 725);
        Point InsideOne7 = new Point(100, 525);
        Point InsideOne8 = new Point(100, 325);
        PointCollection InsideOne = new PointCollection();
       
        /// <summary>
        ///Tracks and their layouts
        /// </summary>
        Canvas canvas;
        public Player player;
       
        public void Track1(Canvas c)
        {
            canvas = c;
            
            

        }
        public void Track2(Canvas c)
        {
            canvas = c;
            Polygon inside = new Polygon();
            Point TL = new Point(225, 150);
            Point TR = new Point(375, 150);
            Point MM = new Point(375, 525);
            Point MR = new Point(775, 525);
            Point BR = new Point(775, 725);
            Point BL = new Point(225, 725);
            PointCollection pointCollection = new PointCollection();
            pointCollection.Add(TL);
            pointCollection.Add(TR);
            pointCollection.Add(MM);
            pointCollection.Add(MR);
            pointCollection.Add(BR);
            pointCollection.Add(BL);
            inside.Points = pointCollection;
            inside.Fill = Brushes.Black;
            
            Polygon outside = new Polygon();
            Point OTL = new Point(100, 25);
            Point OTR = new Point(500, 25);
            Point OMM = new Point(500, 425);
            Point OMR = new Point(900,425);
            Point OBR = new Point(900,825);
            Point OBL = new Point(100,825);
            PointCollection collection = new PointCollection();
            collection.Add(OTL);
            collection.Add(OTR);
            collection.Add(OMM);
            collection.Add(OMR);
            collection.Add(OBR);
            collection.Add(OBL);
            outside.Points = collection;
            outside.Fill = Brushes.Purple;
            canvas.Children.Add(outside);
            canvas.Children.Add(inside);
            Rectangle finish = new Rectangle();
            finish.Height = 100;
            finish.Width = 25;
            finish.Fill = Brushes.White;
            canvas.Children.Add(finish);
            Canvas.SetTop(finish, 725);
            Canvas.SetLeft(finish, 500);

        }
        public void Track3(Canvas c)
        {
            canvas = c;
            Polygon OutsideU = new Polygon();
            Point OTL = new Point(25, 50);
            Point OTMR = new Point(325, 50);
            Point OML = new Point(325, 525);
            Point OMR = new Point(525, 525);
            Point OTML = new Point(525, 50);
            Point OTR = new Point(825, 50);
            Point OBR = new Point(825, 825);
            Point OBL = new Point(25, 825);
            PointCollection OutsideUpoints = new PointCollection();
            OutsideUpoints.Add(OTL);
            OutsideUpoints.Add(OTMR);
            OutsideUpoints.Add(OML);
            OutsideUpoints.Add(OMR);
            OutsideUpoints.Add(OTML);
            OutsideUpoints.Add(OTR);
            OutsideUpoints.Add(OBR);
            OutsideUpoints.Add(OBL);

            OutsideU.Points = OutsideUpoints;
            Canvas.SetLeft(OutsideU, 100);
            OutsideU.Fill = Brushes.Purple;
            canvas.Children.Add(OutsideU);
            Polygon insideU = new Polygon();
            Point TL = new Point(125,150);
            Point TMR = new Point(225, 150);
            Point ML = new Point(225, 625);
            Point MR = new Point(625, 625);
            Point TML = new Point(625, 150);
            Point TR = new Point(725, 150);
            Point BR = new Point(725, 725);
            Point BL = new Point(125, 725);
            PointCollection InsideUpoints = new PointCollection();
            InsideUpoints.Add(TL);
            InsideUpoints.Add(TMR);
            InsideUpoints.Add(ML);
            InsideUpoints.Add(MR);
            InsideUpoints.Add(TML);
            InsideUpoints.Add(TR);
            InsideUpoints.Add(BR);
            InsideUpoints.Add(BL);
            insideU.Points = InsideUpoints;
            insideU.Fill = Brushes.Black;
            Canvas.SetLeft(insideU, 100);
            canvas.Children.Add(insideU);

            

            Rectangle finish2 = new Rectangle();
            finish2.Height = 100;
            finish2.Width = 25;
            finish2.Fill = Brushes.White;
            canvas.Children.Add(finish2);
            Canvas.SetTop(finish2, 725);
            Canvas.SetLeft(finish2, 500);
        }

    }
}
