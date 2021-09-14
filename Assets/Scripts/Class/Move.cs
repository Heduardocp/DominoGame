using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: ICommand
{
    [SerializeField]
    private Vector3 PositionToMoveTo;
    private string message;

    public Move(string message)
    {
        this.message = message;
    }

    
    public void Execute() {

        Debug.Log(message);

    }
    public void Undo() {
        Debug.Log(message);
    }

        
}
