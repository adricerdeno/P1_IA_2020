using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using Assets.Scripts.DataStructures;
using UnityEngine;

namespace Assets.Scripts.SampleMind
{
    public class RandomMind : AbstractPathMind {
        private Stack<Locomotion.MoveDirection> currentPlan;

        public override void Repath()
        {
            // declarar Stack de Locomotion.MoveDirection de los movimientos hasta llegar al objetivo

            public override void Repath()
        {
            // limpiar Stack 
        
        }

        public override Locomotion.MoveDirection GetNextMove(BoardInfo boardInfo, CellInfo currentPos, CellInfo[] goals)
        {
            // si la Stack no está vacía, hacer siguiente movimient
            if (...)
            {
                // devuelve siguiente movimient (pop the Stack)
            }

            // calcular camino, devuelve resultado de A*
            var searchResult = Search(boardInfo, currentPos, goals);//lista de nodos
            //currentPlan lista de moviminetos

            // recorre searchResult and copia el camino a currentPlan
            while (searchResult.Parent != null)
            {
                currentPlan.Push(searchResult.ProducedBy);//ProducedBy = direccion en la que avanzo
                searchResult = searchResult.Parent;
            }

            // returns next move (pop Stack)
            if (currentPlan.Any())
                return currentPlan.Pop();

            return Locomotion.MoveDirection.None;

            //var val = Random.Range(0, 4);
            //if (val == 0) return Locomotion.MoveDirection.Up;
            //if (val == 1) return Locomotion.MoveDirection.Down;
            //if (val == 2) return Locomotion.MoveDirection.Left;
            //return Locomotion.MoveDirection.Right;
        }
        private Node Search(BoardInfo board, CellInfo start, CellInfo[] goals)
        {
            // crea una lista vacía de nodos
            
            var open = new List<Node>();

            // node inicial
            var n = new...

            // añade nodo inicial a la lista
            open.Add(n);

            // mientras la lista no esté vacia
            while (open.Any())
            {
                // mira el primer nodo de la lista

                // si el primer nodo es goal, returns current node

                // expande vecinos (calcula coste de cada uno, etc)y los añade en la lista

                // ordena lista
            }
            return null;
        }
    }
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