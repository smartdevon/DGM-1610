using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehavior : MonoBehaviour
{
    public int number, total;

    void Start()
    {
        for (int i = 0; 1 < number; i++)
        {
            total += i;
            print(total);
        }
    }


}
