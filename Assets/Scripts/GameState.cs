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
        moveHandler.AddMove(new Move("welcome"));
        moveHandler.AddMove(new Move("to"));
        moveHandler.AddMove(new Move("the"));
        moveHandler.AddMove(new Move("jungle"));

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
