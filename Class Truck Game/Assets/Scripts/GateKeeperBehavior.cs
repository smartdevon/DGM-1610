using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKeeperBehavior : MonoBehaviour
{
    public BoolData keyObj;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (keyObj.value)
        {
            print(message: true);
        }
        else
        {
            print(message: false);
        }
    }
}
