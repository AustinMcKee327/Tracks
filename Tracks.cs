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


        }
        public void Track3(Canvas c) { }

        
    }
}
