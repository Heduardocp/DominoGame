using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHandler : MonoBehaviour
{

    


    [SerializeField]
    private ConnectPoint top;
    [SerializeField]
    private ConnectPoint bot;
    [SerializeField]
    private ConnectPoint right;
    [SerializeField]
    private ConnectPoint left;

    private void ConnectGeneric(ConnectPoint self, ConnectPoint to) {

        
    }
    public void ConnectBot(ConnectPoint to) {

        ConnectGeneric(bot, to);
    }
   

}
