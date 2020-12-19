using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public float points { get; private set; }
    public Game()
    {
        points = 0;
    }
    public void AddPoints(float _pointsToAdd)
    {
        points+= _pointsToAdd;
    }
    public void SubPoints()
    {
        points--;
    }
}
