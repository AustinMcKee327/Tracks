using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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

namespace Sprint_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    enum GameState { MainMenu,Loading,TrackSelection,Time,GameOn}
    
    public partial class MainWindow : Window
    {
        //globals 
        Stopwatch timer = new Stopwatch();
        public DispatcherTimer gametimer = new DispatcherTimer();
        Tracks t = new Tracks();                                        //calls tracks
        public static int trackNum;                                     //pulls from TrackSelection window
        public int LapCounter = 0;
        GameState gameState = new GameState();
        Player p1;                                                      //player 1
        Player p2;                                                      //player 2 
        public static string angle ="";                                 //angle debugging
        public static double facing = 0;   
        public static double facingactual = 0;
        public string speed = "";


        public MainWindow()
        {   
            InitializeComponent();                                      //start window
            gameState = GameState.MainMenu;                             //start timer
            gametimer.Tick += Gametimer_Tick;                           //timer update
            gametimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 120);  //timer updates at 120fps           
        }

        private void Gametimer_Tick(object sender, EventArgs e)
        {
            angle = facing.ToString();                                                //angle debugging
            lblcomputedangle.Content ="Computed Angle:"+facingactual.ToString();
            speed = p1.speed.ToString();
            lblangle.Content = "Angle :" +angle;
            lblspeed.Content = "Speed :" + speed;
            lblGameState.Content = "Game State :" + gameState.ToString();
            
            if (gameState == GameState.MainMenu)                                        //if on the main/start menu
            {
                lblTime.Visibility = Visibility.Hidden;
                instructions.Visibility = Visibility.Hidden;                            //puase menu, shows buttons, hides 
                mainMenu.Visibility = Visibility.Visible;                               
            }
            else if (gameState == GameState.GameOn)
            {

                p1.update(gameScreen);
                t.checkColide(p1);
                timer.Start();
                lblTime.Content = timer.Elapsed;
                
                if (Keyboard.IsKeyToggled(Key.Space) == false)
                {
                    gameState = GameState.Loading;
                    instructions.Visibility = Visibility.Visible;
                }
                if (Keyboard.IsKeyDown(Key.R))
                {
                    LapCounter = 3;
                }
                if (t.checkLap(p1) == true)
                {
                    LapCounter++;
                }

            }
            else if (gameState == GameState.Loading)
            {
                gameState = GameState.Loading;
                instructions.Visibility = Visibility.Visible;
                timer.Stop();
                if (Keyboard.IsKeyToggled(Key.Space)==true)
                {
                    gameState = GameState.GameOn;
                    instructions.Visibility = Visibility.Hidden;
                }
        

            }
            if(LapCounter == 3)
                {
                    gameState = GameState.Time;
                    
                }
            else if (gameState == GameState.Time)
            {
                timer.Stop();
                try
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter("BestTimes.txt",false);
                    sw.WriteLine(timer.Elapsed.ToString());
                    sw.Flush();
                    sw.Close();
                    LapCounter = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
            
            
            if (Keyboard.IsKeyToggled(Key.P))
            {           
                gameInfo.Visibility = Visibility.Visible;                             
            }
            else { gameInfo.Visibility = Visibility.Hidden; }
                     
            if (Keyboard.IsKeyDown(Key.Q))
            {   timer.Stop();
                timer.Reset();
                gameScreen.Children.Clear();
                instructions.Visibility = Visibility.Hidden;
                mainMenu.Visibility=Visibility.Visible;
                gameState = GameState.MainMenu;
               
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gameState = GameState.TrackSelection;
            TrackSelection TS = new TrackSelection();
            TS.ShowDialog();
        }       //opens track select window


        private void startGame_Click(object sender, RoutedEventArgs e)
        {
            p1= new Player();
            gameState = GameState.Loading;
            gametimer.Start();

            switch (trackNum) //switches, allows default and used for testing because I'm lazy. I have to click 3 less buttons to start testing
            {
                case 1:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    t.Track1(gameScreen);
                    p1.drawPlayer(gameScreen);
                    break;
                case 2:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;                   
                    t.Track2(gameScreen);
                    p1.drawPlayer(gameScreen);
                    break;
                case 3:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    t.Track3(gameScreen);
                    p1.drawPlayer(gameScreen);
                    
                    break;
                default:
                    gameState = GameState.Loading;
                    mainMenu.Visibility = Visibility.Hidden;
                    t.Track2(gameScreen);
                    p1.drawPlayer(gameScreen);
                    break;
            } //tracks are called here
            
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            gameState = GameState.Loading;
        }

        private void HighScores_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader Scores = new System.IO.StreamReader("BestTimes.txt");
            MessageBox.Show(Scores.ReadLine());

            
        }
    }
}