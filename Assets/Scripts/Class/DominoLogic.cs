using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoLogic
{

    private MoveHandler moveHandler = new MoveHandler();
    private int _topSide;
    public int topSide
    {
        get => _topSide;
    }

    private int _botSide;
    public int botSide
    {
        get => _botSide;
    }
    public DominoLogic()
    {

    }
    public bool CheckIfValidMove(ITile tile)
    {
        if (moveHandler.length == 0)
        {
            return true;
        }
        if (tile.top == topSide || tile.top == botSide)
        {
            return true;
        }
        if (tile.bot == topSide || tile.bot == botSide)
        {
            return true;
        }
        return false;
    }
    public void AddMove(ICommand move)
    {
        moveHandler.AddMove(move);
    }
    public void UndoMove()
    {
        moveHandler.UndoMove();
    }
    public void RedoMove()
    {
        moveHandler.RedoMove();
    }

}