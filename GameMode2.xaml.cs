using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ChessFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameMode2 : Page
    {
        
        DispatcherTimer Player1Timer = new DispatcherTimer();
        DispatcherTimer Player2Timer = new DispatcherTimer();
        private int player1min =7;
        private int player1secs=30;
        private int player2min = 7;
        private int player2secs = 30;

        public GameMode2()
        {
            this.InitializeComponent();
          
           Player1Timer.Interval = new TimeSpan(0, 0,1 );
            Player1Timer.Tick += player1_Tick;

            Player2Timer.Interval = new TimeSpan(0, 0, 1);
            Player2Timer.Tick += player2_Tick;
            
        }

        void player1_Tick(object sender, object e)
        {


            player1secs--;
            Player1CountDown.Text = string.Format("{0}:{1}", player1min, player1secs);
            if (player1secs < 10)
            {
                
                Player1CountDown.Text = string.Format("{0}:0{1}", player1min, player1secs);
                if (player1secs == 0)
                {
                    player1secs = 60;
                    player1min--;
                }
            }

            if (player1min == 0)
            {
                
                Player1CountDown.Text = string.Format("{0}:{1}", player1min, player1secs);
                if (player1secs == 0)
                {
                    Player1Timer.Stop();
                }
            }

        }
        private void player2_Tick(object sender, object e)
        {
            player2secs--;
            Player2CountDown.Text = string.Format("{0}:{1}", player2min, player2secs);
            if (player2secs < 10)
            {
                
                Player2CountDown.Text = string.Format("{0}:0{1}", player2min, player2secs);
                if (player2secs == 0)
                {
                    player2secs = 60;
                    player2min--;
                }
            }


            if (player2min == 0)
            {
                player2secs--;
                Player2CountDown.Text = string.Format("{0}:{1}", player2min, player2secs);
                if (player2secs == 0)
                {
                    Player2Timer.Stop();
                }
            }
        }


        private void Player1EndTurnTimer(object sender, RoutedEventArgs e)
        {
            Player1Timer.Stop();
            Player2Timer.Start();
        }
        private void Player2EndTurnTimer(object sender, RoutedEventArgs e)
        {
            Player2Timer.Stop();
            Player1Timer.Start();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

  

        private void txtPlayer1CountDown_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            Player1Timer.Start();
        }
    }
}
