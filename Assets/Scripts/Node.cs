using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using Assets.Scripts.DataStructures;
using UnityEngine;
using Assets.Scripts;

public class Node : MonoBehaviour
{
    public Node Parent;
    public Locomotion.MoveDirection ProducedBy;
    public BoardInfo tab;
    public CellInfo celda;
    public float cost;
    public float heuristica;

    //devuelve si la celda que se va a expandir esta en los limites del tablero y es walkable.
    public bool sePuedeExpandir(){ 
        //Se puede optimizar
        if (celda.ColumnId <= tab.NumColumns && celda.RowId <= tab.NumRows)  
            return false;
        if (celda.Walkable != true)
            return false;
        return true;
    }






      /*
    Nodo:
    parent
    producedBy
    coste
    heuristica
    bool expandirHijos(){
        if(nosalirsedeltablero != true || infoCell != walkable)
            return false;
        ;
    }*/
}
