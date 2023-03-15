using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

public class Game
{
    #region Fields
    private Player _player1;
	private Player _player2;
	private string[,] _board = { { "1", "2", "3", }, { "4", "5", "6", }, { "7", "8", "9", } };
    #endregion
    #region Properties
	public Player player1 { get { return _player1; } set { _player1 = value; } }
	public Player player2 { get { return _player2; } set { _player2 = value; } }
	public string[,] board { get { return _board; } set { _board = value; } }
    #endregion
    public Game()
	{
		Initilize();
		_player1 = new Player(board);
		_player2 = new Player(board);
		_player1.isTurn = true;

	}
	private void Initilize()
	{
		#region Test Code (displays board on startup)
		string list = "";
		int x = 0;
		foreach (string i in _board)
		{
			x++;
			list += i + ", ";
			if (x % 3 == 0)
			{
				list += "\n";
			}
		}
		MessageBox.Show(list);
        #endregion

    }
	public void Switch_player()
	{
		if (Winner())
		{
			MessageBox.Show("OMG");
		}
		if (_player1.isTurn)
		{
			_player2.isTurn = true;
			_player1.isTurn = false;
        }
		else
		{
			_player1.isTurn = true;
			_player2.isTurn = false;
		}
	}
	private bool Winner()
	{
		_player1.Update(_board);
		_player2.Update(_board);

        bool Win; 
		Win = _player1.Check_Win(_player1.isTurn) || _player2.Check_Win(_player1.isTurn);
		return Win;
	}
}
