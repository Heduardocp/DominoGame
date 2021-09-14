using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoLogic
{
    [SerializeField]
    private Vector3 PositionToMoveTo;
    private string message;

    public DominoLogic()
    {
      
    }

    
    public void Execute() {

        Debug.Log(message);

    }
    public void Undo() {
        Debug.Log(message);
    }

        
}
