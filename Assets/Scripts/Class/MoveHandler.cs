using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveHandler<T> where T:ICommand
{

    private List<T> moveList = new List<T>();
    private int index;



    public void AddMove(T command)
    {


        //this is add move over old moves and delete them.
        //if (index < moveList.Count) {
        //    moveList.RemoveRange(index, moveList.Count - index);
        //}

        moveList.Add(command);
        command.Execute();
        index++;
    }
    public int length
    {
        get => moveList.Count;
    }
    public void UndoMove()
    {
        if (moveList.Count == 0)
        {
            return;
        }
        if (index > 0)
        {
            moveList[index - 1].Undo();
            index--;
        }
    }
    public void RedoMove()
    {
        if (moveList.Count == 0)
        {
            return;
        }
        if (index < moveList.Count)
        {
            index++;
            moveList[index - 1].Execute();
        }
    }
}