using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DominoLogic domino;


    // Start is called before the first frame update
    void Start()
    {
        domino = new DominoLogic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
