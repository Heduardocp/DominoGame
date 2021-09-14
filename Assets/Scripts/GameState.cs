using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameState : MonoBehaviour
{
    [SerializeField]
    public DominoLogic dominoLogic = new DominoLogic();
    // Use this for initialization
    void Start()
    {
        dominoLogic.AddMove(new Move("welcome"));
        dominoLogic.AddMove(new Move("to"));
        dominoLogic.AddMove(new Move("the"));
        dominoLogic.AddMove(new Move("jungle"));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            dominoLogic.UndoMove();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            dominoLogic.RedoMove();
        }
    }
}
