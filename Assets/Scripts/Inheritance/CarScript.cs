using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MovingObjectScript
{
    public bool fast = false; 

    public void OnMouseDown()
    {
        fast = !fast;
        if (fast)
        {
            SetSpeed(300f);
        }
        else
        {
            SetSpeed(100f);
        }
    }

}
