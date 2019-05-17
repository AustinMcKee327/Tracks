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
        /// Ethan Hunter
        ///Tracks and their layouts
        /// </summary>
        Canvas canvas;
        public Polygon wallinner = new Polygon();
        public Polygon wallouter = new Polygon();
        public Point wallpoint1 = new Point();
        public Point wallpoint2 = new Point();
        public Point wallpoint3 = new Point();
        public Point wallpoint4 = new Point();
        public Point wallpoint5 = new Point();
        public Point wallpoint6 = new Point();
        public PointCollection wallPoints = new PointCollection();
        public Point wallpoint1out = new Point();
        public Point wallpoint2out = new Point();
        public Point wallpoint3out = new Point();
        public Point wallpoint4out = new Point();
        Rectangle startLine = new Rectangle();
        
        /// <summary>
        /// Austin McKee
        /// 
        /// Each track is points and polygons used for walls
        /// </summary>
        /// <param name="c">
        /// same for all tracks, c = gameScreen in mainwindow.xaml.cs
        /// </param>
        public void Track1(Canvas c)
        {
            canvas = c;
            Polygon OutsideT = new Polygon();
            Point OBL = new Point(300, 825);
            Point OMML = new Point(300, 500);
            Point OML = new Point(100, 500);
            Point OTL = new Point(100, 100);
            Point OTR = new Point(900, 100);
            Point OMR = new Point(900, 500);
            Point OMMR = new Point(700, 500);
            Point OBR = new Point(700, 825);
            PointCollection OutsideTP = new PointCollection();
            OutsideTP.Add(OBL);
            OutsideTP.Add(OMML);
            OutsideTP.Add(OML);
            OutsideTP.Add(OTL);
            OutsideTP.Add(OTR);
            OutsideTP.Add(OMR);
            OutsideTP.Add(OMMR);
            OutsideTP.Add(OBR);
            OutsideT.Points = OutsideTP;
            OutsideT.Fill = Brushes.Purple;
            canvas.Children.Add(OutsideT);
            Polygon InsideT = new Polygon();
            Point BL = new Point(400, 725);
            Point MML = new Point(400, 400);
            Point ML = new Point(200, 400);
            Point TL = new Point(200, 200);
            Point TR = new Point(800, 200);
            Point MR = new Point(800, 400);
            Point MMR = new Point(600, 400);
            Point BR = new Point(600,725);
            PointCollection InsideTP = new PointCollection();
            InsideTP.Add(BL);
            InsideTP.Add(MML);
            InsideTP.Add(ML);
            InsideTP.Add(TL);
            InsideTP.Add(TR);
            InsideTP.Add(MR);
            InsideTP.Add(MMR);
            InsideTP.Add(BR);
            InsideT.Points = InsideTP;
            InsideT.Fill = Brushes.Black;
            canvas.Children.Add(InsideT);
            
            Rectangle finish = new Rectangle();
            finish.Height = 100;
            finish.Width = 25;
            finish.Fill = Brushes.White;
            canvas.Children.Add(finish);
            Canvas.SetTop(finish, 725);
            Canvas.SetLeft(finish, 500);
            
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
            Point OMR = new Point(900, 425);
            Point OBR = new Point(900, 825);
            Point OBL = new Point(100, 825);
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
            Point TL = new Point(125, 150);
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



            Rectangle finish = new Rectangle();
            finish.Height = 100;
            finish.Width = 25;
            finish.Fill = Brushes.White;
            canvas.Children.Add(finish);
            Canvas.SetTop(finish, 725);
            Canvas.SetLeft(finish, 500);
        }

        /// <summary>
        /// Ethan Hunter
        /// </summary>
        /// <param name="p"></param>
        public void checkColide(Player p)
        {
            if((p.position.X+22>=wallpoint1.X  &&
                p.position.Y+28>=wallpoint1.Y &&
                p.position.Y + 28 <= wallpoint2.Y &&
                p.position.X +22 <= wallpoint4.X)
                ||
                (p.position.X >= wallpoint1.X &&
                p.position.Y >= wallpoint1.Y &&
                p.position.Y <= wallpoint2.Y &&
                p.position.X <= wallpoint4.X))   
            {               
                p.speed = 2;
            }
            
            
        }
        public bool checkLap(Player p)
        {
            Point finishone = new Point(500, 725);
            Point finishtwo = new Point(525, 825);
            if (p.position.X + 22 >= finishone.X && p.position.X <= finishtwo.X)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

}
