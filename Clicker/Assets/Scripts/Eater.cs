using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eater : Enemy
{
    public override Enemy Clone()
    {
        Debug.Log("Clone eater");
        return (Eater)MemberwiseClone();
    }
}


