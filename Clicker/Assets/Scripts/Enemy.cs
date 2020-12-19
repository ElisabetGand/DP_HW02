using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy 
{
    public abstract Enemy Clone();
    public float pointsToAdd { 
        get {
            return 0.5f;
        }}
}


