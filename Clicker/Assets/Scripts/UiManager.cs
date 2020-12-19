using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    Text points;
    public static UiManager instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void OnClickAdd()
    {
        GameManager.instance.AddPoints();
    }
    public void OnClickSpray()
    {
       GameManager.instance.KillEnemy();
    }
    public void UpdatePoints(float _points)
    {
        Debug.Log(_points);
        //points.text = _points.ToString();
    }
}
