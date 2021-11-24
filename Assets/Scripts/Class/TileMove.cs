using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : ICommand
{
  
    [SerializeField]
    private Tile tile;
    [SerializeField]
    private Player player;

    [SerializeField]
    private Transform snapPoint;

    [SerializeField]
    private EnumTileSide side;

    public TileMove(Player player, Tile tile, EnumTileSide side,Transform snapPoint)
    {
        this.player = player;
        this.tile = tile;
        this.side = side;
        this.snapPoint = snapPoint;

    }


    public void Execute()
    {

        Debug.Log($"Execute move");

    }
    public void Undo()
    {
        Debug.Log($"Undo move");
    }
}
