using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoLogic
{

    private MoveHandler moveHandler;
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
        moveHandler = new MoveHandler();
    }
    public bool CheckIfValidMove(ITile tile)
    {
       
        if (CheckIfValidTop(tile.top, tile.bot) || CheckIfValidBot(tile.top, tile.bot))
        {
            return true;
        }
    
        return false;
    }
    private bool CheckIfValidTop(int side1, int side2)
    {
        if (moveHandler.length == 0 ||side1 == topSide || side2 == topSide)
        {
            return true;
        }
        return false;
    }
    private bool CheckIfValidBot(int side1, int side2)
    {
        if (moveHandler.length == 0 ||side1 == botSide || side2 == botSide)
        {
            return true;
        }
        return false;
    }
    public void PlayTop()
    {


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