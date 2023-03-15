using System;
using System.Net.Http.Headers;
using System.Windows;
using System.Windows.Shapes;

public class Player
{
    #region Fields
    private int _wins;
	private string[,] _board;
	private bool _isTurn = false;
    #endregion
    #region Properties
    public int Wins { get { return _wins; } set { _wins = value; } }
	public string[,] board { get { return _board; } set { _board = value; } }
	public bool isTurn { get { return _isTurn; } set { _isTurn = value; } }
    #endregion

    public Player(string[,] b)
	{
		_board = b;
	}
	public void Update(string[,] b)
	{
		_board = b;
	}
	public bool Check_Win(bool P1Turn)
	{
		
		string val;
		if (P1Turn)
		{
			val = "X";
		}
		else
		{
			val = "O";
		}
		bool win = V_Win(val);
		return win;
	}
	private bool V_Win(string val)
	{
        int LWins = 0;
        #region Check all top line X positions
        for (int x = 0; x < 3; x++)
		{
			if (board[x, 0] == val)
			{
                #region Check all Y positions
                for (int y = 0; y < 3; y++)
				{
					if (board[x, y] == val)
					{
						LWins++;
					}
					else
					{
						break;
					}
				}
                #endregion
            }
        }
        #endregion
        if (LWins >= 3)
        {
            return true;
        }

        return false;
	}
	private bool H_Win(string val)
	{

	}
}
