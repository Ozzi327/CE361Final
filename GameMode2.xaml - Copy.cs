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
       
        public string player1piece;
        public string player1movex;
        public string player2movex;
        public string player1movey;
        public string player2movey;
        public double p1x;
        public double p2x;
        public double p1y;
        public double p2y;
        
           

        public int player1x;
        public int player1y;

        public GameMode2()
        {
            this.InitializeComponent();
          
           Player1Timer.Interval = new TimeSpan(0, 0,1 );
            Player1Timer.Tick += player1_Tick;

            Player2Timer.Interval = new TimeSpan(0, 0, 1);
            Player2Timer.Tick += player2_Tick;
             Thickness positionbk1 = BlackKnight1.Margin;
             Thickness positionbk2 = BlackKnight2.Margin;


        }

        void player1_Tick(object sender, object e)
        {


            player1secs--;
            Player1CountDown.Text = string.Format("{0}:{1}", player1min, player1secs);
            if (player1secs < 10 && player1min >= 1)
            {
                
                Player1CountDown.Text = string.Format("{0}:0{1}", player1min, player1secs);
                if (player1secs == 0 )
                {
                    player1secs = 59;
                    player1min--;
                }
            }

            if (player1min == 0)
            {
                if (player1secs < 10)
                {
                    Player1CountDown.Text = string.Format("{0}:0{1}", player1min, player1secs);
                    if (player1secs == 0)
                    {
                        Player1Timer.Stop();
                        this.Frame.Navigate(typeof(Player2Win));
                    }
                }
            }

        }
        private void player2_Tick(object sender, object e)
        {
            player2secs--;
            Player2CountDown.Text = string.Format("{0}:{1}", player2min, player2secs);
            if (player2secs < 10 && player2min>=1)
            {
                
                Player2CountDown.Text = string.Format("{0}:0{1}", player2min, player2secs);
                if (player2secs == 0)
                {
                    player2secs = 59;
                    player2min--;
                }
            }


            if (player2min == 0)
            {
                if (player2secs < 10)
                {
                   
                    Player2CountDown.Text = string.Format("{0}:0{1}", player2min, player2secs);
                    if (player2secs == 0)
                    {
                        Player2Timer.Stop();
                        this.Frame.Navigate(typeof(Player1Win));
                    }
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


        
        private void txtPlayer1CountDown_TextChanged(object sender, TextChangedEventArgs e)
        {
  
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            Player1Timer.Start();
        }

        private void Player2Move_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Player2PieceChosen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Player2MoveX_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void Player2MoveY_TextChanged(object sender, TextChangedEventArgs e)
        {


            

        }
        private void Player1Move_TextChanged(object sender, TextChangedEventArgs e)
        {

            
            





        }

        private void Player1PieceChosen_TextChanged(object sender, TextChangedEventArgs e)
        {


            

            if (Player1MoveY.Text == "2")
            {
                p1y = 2.0;
            }
            if (Player1MoveY.Text == "3")
            {
                p1y = 3.0;
            }
            if (Player1MoveY.Text == "4")
            {
                p1y = 4.0;
            }
            if (Player1MoveY.Text == "5")
            {
                p1y = 5.0;
            }
            if (Player1MoveY.Text == "6")
            {
                p1y = 6.0;
            }
            if (Player1MoveY.Text == "7")
            {
                p1y = 7.0;
            }
            if (Player1MoveY.Text == "8")
            {
                p1y = 8.0;
            }
            else
                p1y = 0.0;
        
        }
        private void Player1MoveY_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (Player1MoveY.Text == "2")
            {
                p1y = 2.0;
            }







        }

        private void Player1Done_Click(object sender, RoutedEventArgs e)
        {

            p1x = 0;
            p1y = 0;

            if (Player1Move.Text == "-1")
            {
                p1x = -1.0;
            }
            if (Player1Move.Text == "-2")
            {
                p1x = -2.0;
            }
            if (Player1Move.Text == "-3")
            {
                p1x = -3.0;
            }
            if (Player1Move.Text == "-4")
            {
                p1x = -4.0;
            }
            if (Player1Move.Text == "-5")
            {
                p1x = -5.0;
            }
            if (Player1Move.Text == "-6")
            {
                p1x = -6.0;
            }
            if (Player1Move.Text == "-7")
            {
                p1x = 7.0;
            }
            if (Player1Move.Text == "-8")
            {
                p1x = -8.0;
            }
            if (Player1Move.Text == "1")
                {
                    p1x = 1.0;
                }
                if (Player1Move.Text == "2")
                {
                    p1x = 2.0;
                }
                if (Player1Move.Text == "3")
                {
                    p1x = 3.0;
                }
                if (Player1Move.Text == "4")
                {
                    p1x = 4.0;
                }
                if (Player1Move.Text == "5")
                {
                    p1x = 5.0;
                }
                if (Player1Move.Text == "6")
                {
                    p1x = 6.0;
                }
                if (Player1Move.Text == "7")
                {
                    p1x = 7.0;
                }
                if (Player1Move.Text == "8")
                {
                    p1x = 8.0;
                }

            if (Player1MoveY.Text == "-1")
            {
                p1y = 1.0;
            }
            if (Player1MoveY.Text == "-2")
            {
                p1y = 2.0;
            }
            if (Player1MoveY.Text == "-3")
            {
                p1y = 3.0;
            }
            if (Player1MoveY.Text == "-4")
            {
                p1y = 4.0;
            }
            if (Player1MoveY.Text == "-5")
            {
                p1y = 5.0;
            }
            if (Player1MoveY.Text == "-6")
            {
                p1y = 6.0;
            }
            if (Player1MoveY.Text == "-7")
            {
                p1y = 7.0;
            }
            if (Player1MoveY.Text == "-8")
            {
                p1y = 8.0;
            }

            if (Player1MoveY.Text == "1")
                {
                    p1y = -1.0;
                }
                if (Player1MoveY.Text == "2")
                {
                    p1y = -2.0;
                }
                if (Player1MoveY.Text == "3")
                {
                    p1y = -3.0;
                }
                if (Player1MoveY.Text == "4")
                {
                    p1y = -4.0;
                }
                if (Player1MoveY.Text == "5")
                {
                    p1y = -5.0;
                }
                if (Player1MoveY.Text == "6")
                {
                    p1y = -6.0;
                }
                if (Player1MoveY.Text == "7")
                {
                    p1y = -7.0;
                }
                if (Player1MoveY.Text == "8")
                {
                    p1y = -8.0;
                }
            
            if (Player1PieceChosen.Text == "BR1")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness rk1 = BlackRook1.Margin;
                Rook bkr1 = new Rook("Rook", rk1, rk1, false);
                bkr1.Move(p1x, p1y, rk1, BlackRook1);
                GamePiece gpiece = new GamePiece("Rook", rk1, rk1, false);
                gpiece.checkmove(rk1, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1,BlackRook1, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BR2")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                
                Thickness rk2 = BlackRook2.Margin;
                Rook bkr2 = new Rook("Rook", rk2, rk2, false);
                bkr2.Move(p1x, p1y, rk2, BlackRook2);
                GamePiece gpiece = new GamePiece("Rook", rk2, rk2, false);
                gpiece.checkmove(rk2, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackRook2, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BKN1")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;

                Thickness kn1 = BlackKnight1.Margin;
                Knight bkn1 = new Knight("Knight", kn1, kn1, false);
                bkn1.Move(p1x, p1y, kn1, kn1,BlackKnight1);
                GamePiece gpiece = new GamePiece("Knight", kn1, kn1, false);
                gpiece.checkmove(kn1, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackKnight1, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BKN2")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness kn1 = BlackKnight2.Margin;
                Knight bkn1 = new Knight("Knight", kn1, kn1, false);
                bkn1.Move(p1x, p1y, kn1, kn1, BlackKnight2);
                GamePiece gpiece = new GamePiece("Rook", kn1, kn1, false);
                gpiece.checkmove(kn1, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackKnight2, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BK")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;

                Thickness bk1 = BlackKing.Margin;
                King bkn1 = new King("King", bk1, bk1, false);
                bkn1.Move(p1x, p1y, bk1, bk1, BlackKing);
                GamePiece gpiece = new GamePiece("King", bk1, bk1, false);
                gpiece.checkmove(bk1, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackKing, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BQ")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bq = BlackQueen.Margin;
                Queen bkn1 = new Queen("Queen", bq, bq, false);
                bkn1.Move(p1x, p1y, bq, bq, BlackQueen);
                GamePiece gpiece = new GamePiece("Queen", bq, bq, false);
                gpiece.checkmove(bq, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackQueen, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BB1")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Bishop bkn1 = new Bishop("Bishop", bb1, bb1, false);
                bkn1.Move(p1x, p1y, bb1, bb1, BlackBishop1);
                GamePiece gpiece = new GamePiece("Bishop", bb1, bb1, false);
                gpiece.checkmove(bb1, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackBishop1, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BB2")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Bishop bkn1 = new Bishop("Bishop", bb2, bb2, false);
                bkn1.Move(p1x, p1y, bb2, bb2, BlackBishop2);
                GamePiece gpiece = new GamePiece("Bishop", bb2, bb2, false);
                gpiece.checkmove(bb2, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackBishop2, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BP1")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp1, bp1, false);
                bkn1.Move(p1x, p1y, bp1, bp1, BlackPawn1);
                GamePiece gpiece = new GamePiece("Pawn", bp1, bp1, false);
                gpiece.checkmove(bp1, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn1, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BP2")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp2, bp2, false);
                bkn1.Move(p1x, p1y, bp2, bp2, BlackPawn2);
                GamePiece gpiece = new GamePiece("Pawn", bp2, bp2, false);
                gpiece.checkmove(bp2, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn2, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BP3")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Pawn bkn1 = new Pawn("Pawn", bp3, bp3, false);
                bkn1.Move(p1x, p1y, bp3, bp3, BlackPawn3);
                GamePiece gpiece = new GamePiece("Pawn", bp3, bp3, false);
                gpiece.checkmove(bp3, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn3, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BP4")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp4, bp4, false);
                bkn1.Move(p1x, p1y, bp4, bp4, BlackPawn4);
                GamePiece gpiece = new GamePiece("Pawn", bp4, bp4, false);
                gpiece.checkmove(bp4, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn4, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }

            if (Player1PieceChosen.Text == "BP5")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp5, bp5, false);
                bkn1.Move(p1x, p1y, bp5, bp5, BlackPawn5);
                GamePiece gpiece = new GamePiece("Pawn", bp5, bp5, false);
                gpiece.checkmove(bp5, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn5, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BP6")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp6, bp6, false);
                bkn1.Move(p1x, p1y, bp6, bp6, BlackPawn6);
                GamePiece gpiece = new GamePiece("Pawn", bp6, bp6, false);
                gpiece.checkmove(bp6, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn6, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }
            if (Player1PieceChosen.Text == "BP7")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;

                Thickness bp7 = BlackPawn7.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp7, bp7, false);
                bkn1.Move(p1x, p1y, bp7, bp7, BlackPawn7);
                GamePiece gpiece = new GamePiece("Pawn", bp7, bp7, false);
                gpiece.checkmove(bp7, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn7, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);

            }
            if (Player1PieceChosen.Text == "BP8")

            {
                Thickness gkn1 = GreyKnight1.Margin;
                Thickness gkn2 = GreyKnight2.Margin;
                Thickness grk1 = GreyRook1.Margin;
                Thickness grk2 = GreyRook2.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Thickness gkg = GreyKing.Margin;
                Thickness gq = GreyQueen.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Pawn bkn1 = new Pawn("Bishop", bp8, bp8, false);
                bkn1.Move(p1x, p1y, bp8, bp8, BlackPawn8);
                GamePiece gpiece = new GamePiece("Pawn", bp8, bp8, false);
                gpiece.checkmove(bp8, gkn1, gkn2, grk1, grk2, gp1, gp2, gp3, gp4, gp5, gp6, gp7, gp8, gkg, gq, gb2, gb1, BlackPawn8, GreyKnight1, GreyKnight2, GreyRook1, GreyRook2, GreyPawn1, GreyPawn2, GreyPawn3, GreyPawn4, GreyPawn5, GreyPawn6, GreyPawn7, GreyPawn8, GreyKing, GreyQueen, GreyBishop2, GreyBishop1);
            }










        }

        private void Player2Done_Click(object sender, RoutedEventArgs e)
        {
            if (Player2MoveX.Text == "-1")
            {
                p1x = -1.0;
            }
            if (Player2MoveX.Text == "-2")
            {
                p1x = -2.0;
            }
            if (Player2MoveX.Text == "-3")
            {
                p1x = -3.0;
            }
            if (Player2MoveX.Text == "-4")
            {
                p1x = -4.0;
            }
            if (Player2MoveX.Text == "-5")
            {
                p1x = -5.0;
            }
            if (Player2MoveX.Text == "-6")
            {
                p1x = -6.0;
            }
            if (Player2MoveX.Text == "-7")
            {
                p1x = -7.0;
            }
            if (Player2MoveX.Text == "-8")
            {
                p1x = -8.0;
            }
            if (Player2MoveX.Text == "1")
            {
                p1x = 1.0;
            }
            if (Player2MoveX.Text == "2")
            {
                p1x = 2.0;
            }
            if (Player2MoveX.Text == "3")
            {
                p1x = 3.0;
            }
            if (Player2MoveX.Text == "4")
            {
                p1x = 4.0;
            }
            if (Player2MoveX.Text == "5")
            {
                p1x = 5.0;
            }
            if (Player2MoveX.Text == "6")
            {
                p1x = 6.0;
            }
            if (Player2MoveX.Text == "7")
            {
                p1x = 7.0;
            }
            if (Player2MoveX.Text == "8")
            {
                p1x = 8.0;
            }

            if (Player2MoveY.Text == "-1")
            {
                p1y = 1.0;
            }
            if (Player2MoveY.Text == "-2")
            {
                p1y = 2.0;
            }
            if (Player2MoveY.Text == "-3")
            {
                p1y = 3.0;
            }
            if (Player2MoveY.Text == "-4")
            {
                p1y = 4.0;
            }
            if (Player2MoveY.Text == "-5")
            {
                p1y = 5.0;
            }
            if (Player2MoveY.Text == "-6")
            {
                p1y = 6.0;
            }
            if (Player2MoveY.Text == "-7")
            {
                p1y = 7.0;
            }
            if (Player2MoveY.Text == "-8")
            {
                p1y = 8.0;
            }

            if (Player2MoveY.Text == "1")
            {
                p1y = -1.0;
            }
            if (Player2MoveY.Text == "2")
            {
                p1y = -2.0;
            }
            if (Player2MoveY.Text == "3")
            {
                p1y = -3.0;
            }
            if (Player2MoveY.Text == "4")
            {
                p1y = -4.0;
            }
            if (Player2MoveY.Text == "5")
            {
                p1y = -5.0;
            }
            if (Player2MoveY.Text == "6")
            {
                p1y = -6.0;
            }
            if (Player2MoveY.Text == "7")
            {
                p1y = -7.0;
            }
            if (Player2MoveY.Text == "8")
            {
                p1y = -8.0;
            }

            if (Player2PieceChosen.Text == "GR1")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;

                Thickness rk1 = GreyRook1.Margin;
                Rook bkr1 = new Rook("Rook", rk1, rk1, false);
                bkr1.Move(p1x, p1y, rk1, GreyRook1);
                GamePiece piece1 = new GamePiece("Rook", rk1, rk1, true);
                piece1.checkmove(rk1, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyRook1, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);

            }
            if (Player2PieceChosen.Text == "GR2")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness rk2 = GreyRook2.Margin;
                Rook bkr2 = new Rook("Rook", rk2, rk2, false);
                bkr2.Move(p1x, p1y, rk2, GreyRook2);
                GamePiece piece1 = new GamePiece("Rook", rk2, rk2, true);
                piece1.checkmove(rk2, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyRook2, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GKN1")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness kn1 = GreyKnight1.Margin;
                Knight gkn1 = new Knight("Knight", kn1, kn1, false);
                gkn1.Move(p1x, p1y, kn1, kn1, GreyKnight1);
                GamePiece piece1 = new GamePiece("Rook", kn1, kn1, true);
                piece1.checkmove(kn1, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyKnight1, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GKN2")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness kn1 = GreyKnight2.Margin;
                Knight gkn1 = new Knight("Knight", kn1, kn1, false);
                gkn1.Move(p1x, p1y, kn1, kn1, GreyKnight2);
                GamePiece piece1 = new GamePiece("Rook", kn1, kn1, true);
                piece1.checkmove(kn1, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyKnight2, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GK")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness bk1 = GreyKing.Margin;
                King gkn1 = new King("King", bk1, bk1, false);
                gkn1.Move(p1x, p1y, bk1, bk1, GreyKing);
                GamePiece piece1 = new GamePiece("Rook", bk1, bk1, true);
                piece1.checkmove(bk1, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyKing, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GQ")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gq = GreyQueen.Margin;
                Queen gkn1 = new Queen("Queen", bq, bq, false);
                gkn1.Move(p1x, p1y, gq, gq, GreyQueen);
                GamePiece piece1 = new GamePiece("Rook", gq, gq, true);
                piece1.checkmove(gq, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyQueen, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GB1")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gb1 = GreyBishop1.Margin;
                Bishop gkn1 = new Bishop("Pawn", bb1, bb1, false);
                gkn1.Move(p1x, p1y, gb1, gb1, GreyBishop1);
                GamePiece piece1 = new GamePiece("Rook", gb1, gb1, true);
                piece1.checkmove(gb1, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyBishop1, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GB2")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gb2 = GreyBishop2.Margin;
                Bishop gkn1 = new Bishop("Pawn", bb2, bb2, false);
                gkn1.Move(p1x, p1y, gb2, gb2, GreyBishop2);
                GamePiece piece1 = new GamePiece("Rook", gb2, gb2, true);
                piece1.checkmove(gb2, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyBishop2, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP1")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp1 = GreyPawn1.Margin;
                Pawn gkn1 = new Pawn("Bishop", bp1, bp1, false);
                gkn1.Move(p1x, p1y, gp1, gp1, GreyPawn1);
                GamePiece piece1 = new GamePiece("Rook", gp1, gp1, true);
                piece1.checkmove(gp1, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn1, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP2")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp2 = GreyPawn2.Margin;
                Pawn gkn1 = new Pawn("Bishop", bp2, bp2, false);
                gkn1.Move(p1x, p1y, gp2, gp2, GreyPawn2);
                GamePiece piece1 = new GamePiece("Rook", gp2, gp2, true);
                piece1.checkmove(gp2, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn2, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP3")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp3 = GreyPawn3.Margin;
                Pawn gkn1 = new Pawn("Pawn", gp3, gp3, false);
                gkn1.Move(p1x, p1y, gp3, gp3, GreyPawn3);
                GamePiece piece1 = new GamePiece("Rook", gp3, gp3, true);
                piece1.checkmove(gp3, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn3, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP4")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp4 = GreyPawn4.Margin;
                Pawn gkn1 = new Pawn("Pawn", bp4, bp4, false);
                gkn1.Move(p1x, p1y, gp4, gp4, GreyPawn4);
                GamePiece piece1 = new GamePiece("Rook", gp4, gp4, true);
                piece1.checkmove(gp4, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn4, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }

            if (Player2PieceChosen.Text == "GP5")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp5 = GreyPawn5.Margin;
                Pawn gkn1 = new Pawn("Pawn", bp5, bp5, false);
                gkn1.Move(p1x, p1y, gp5, gp5, GreyPawn5);
                GamePiece piece1 = new GamePiece("Rook", gp5, gp5, true);
                piece1.checkmove(gp5, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn5, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP6")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp6 = GreyPawn6.Margin;
                Pawn gkn1 = new Pawn("Pawn", bp6, bp6, false);
                gkn1.Move(p1x, p1y, gp6, gp6, GreyPawn6);
                GamePiece piece1 = new GamePiece("Rook", gp6, gp6, true);
                piece1.checkmove(gp6, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn6, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP7")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp7 = GreyPawn7.Margin;
                Pawn gkn1 = new Pawn("Pawn", bp7, bp7, false);
                gkn1.Move(p1x, p1y, gp7, gp7, GreyPawn7);
                GamePiece piece1 = new GamePiece("Rook", gp7, gp7, true);
                piece1.checkmove(gp7, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn7, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
            if (Player2PieceChosen.Text == "GP8")

            {
                Thickness bkn2 = BlackKnight2.Margin;
                Thickness bkn1 = BlackKnight1.Margin;
                Thickness brk1 = BlackRook1.Margin;
                Thickness brk2 = BlackRook2.Margin;
                Thickness bp1 = BlackPawn1.Margin;
                Thickness bp2 = BlackPawn2.Margin;
                Thickness bp3 = BlackPawn3.Margin;
                Thickness bp4 = BlackPawn4.Margin;
                Thickness bp5 = BlackPawn5.Margin;
                Thickness bp6 = BlackPawn6.Margin;
                Thickness bp7 = BlackPawn7.Margin;
                Thickness bp8 = BlackPawn8.Margin;
                Thickness bkg = BlackKing.Margin;
                Thickness bq = BlackQueen.Margin;
                Thickness bb2 = BlackBishop2.Margin;
                Thickness bb1 = BlackBishop1.Margin;
                Thickness gp8 = GreyPawn8.Margin;
                Pawn gkn1 = new Pawn("Pawn", bp8, bp8, false);
                gkn1.Move(p1x, p1y, gp8, gp8, GreyPawn8);
                GamePiece piece1 = new GamePiece("Rook", gp8, gp8, true);
                piece1.checkmove(gp8, bkn2, bkn1, brk1, brk2, bp1, bp2, bp3, bp4, bp5, bp6, bp7, bp8, bkg, bq, bb2, bb1, GreyPawn8, BlackKnight2, BlackKnight1, BlackRook1, BlackRook2, BlackPawn1, BlackPawn2, BlackPawn3, BlackPawn4, BlackPawn5, BlackPawn6, BlackPawn7, BlackPawn8, BlackKing, BlackQueen, BlackBishop2, BlackBishop1);
            }
        }
    }
}
