using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Tic_Tac_toe__WPF_
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game _g = new Game();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _0_0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_0_0.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[0, 0] = "X";
                    _0_0.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[0, 0] = "O";
                    _0_0.Content = "O";
                    _g.Switch_player();
                }
            }
            
        }

        private void _1_0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_1_0.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[1, 0] = "X";
                    _1_0.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[1, 0] = "O";
                    _1_0.Content = "O";
                    _g.Switch_player();
                }
            }
        }

        private void _2_0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_2_0.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[2, 0] = "X";
                    _2_0.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[2, 0] = "O";
                    _2_0.Content = "O";
                    _g.Switch_player();
                }
            }
            
        }

        private void _0_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_0_1.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[0, 1] = "X";
                    _0_1.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[0, 1] = "O";
                    _0_1.Content = "O";
                    _g.Switch_player();
                }
            }
            
            
        }

        private void _1_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_1_1.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[1, 1] = "X";
                    _1_1.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[1, 1] = "O";
                    _1_1.Content = "O";
                    _g.Switch_player();
                }
            }
            
        }

        private void _2_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_2_1.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[2, 1] = "X";
                    _2_1.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[2, 1] = "O";
                    _2_1.Content = "O";
                    _g.Switch_player();
                }
            }
            
        }

        private void _0_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_0_2.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[0, 2] = "X";
                    _0_2.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[0, 2] = "O";
                    _0_2.Content = "O";
                    _g.Switch_player();
                }
            }
            
        }

        private void _1_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_1_2.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[1, 2] = "X";
                    _1_2.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[1, 2] = "O";
                    _1_2.Content = "O";
                    _g.Switch_player();
                }
            }
            
        }

        private void _2_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((string)_2_2.Content == null)
            {
                if (_g.player1.isTurn)
                {
                    _g.board[2, 2] = "X";
                    _2_2.Content = "X";
                    _g.Switch_player();
                }
                else
                {
                    _g.board[2, 2] = "O";
                    _2_2.Content = "O";
                    _g.Switch_player();
                }
            }
            

        }
    }
}
