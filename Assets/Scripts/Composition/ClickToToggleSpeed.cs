using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveTowards))]
public class ClickToToggleSpeed : MonoBehaviour
{
    bool fast;
    MoveTowards moveTowards;

    public void Start()
    {
        moveTowards = GetComponent<MoveTowards>();
        fast = false;
    }

    public void OnMouseDown()
    {
        fast = !fast;
        if (fast)
        {
            moveTowards.SetSpeed(8f);
        }
        else
        {
            moveTowards.SetSpeed(3f);
        }

    }
}
