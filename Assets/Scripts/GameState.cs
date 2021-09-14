using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameState : MonoBehaviour
{
    [SerializeField]
    public MoveHandler moveHandler = new MoveHandler();

    // Use this for initialization
    void Start()
    {
        moveHandler.AddMove(new DominoLogic("welcome"));
        moveHandler.AddMove(new DominoLogic("to"));
        moveHandler.AddMove(new DominoLogic("the"));
        moveHandler.AddMove(new DominoLogic("jungle"));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            moveHandler.UndoMove();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            moveHandler.RedoMove();
        }
    }
}
