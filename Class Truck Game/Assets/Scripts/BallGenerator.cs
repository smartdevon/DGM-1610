using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ball;
    int mudCount = 1;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (mudCount < 10)
        {
            yield return new WaitForSeconds(0.5f);
            Instantiate(ball);
            mudCount++;
        }
    }
}
