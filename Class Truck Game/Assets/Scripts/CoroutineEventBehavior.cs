using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineEventBehavior : MonoBehaviour
{
    public UnityEvent startEvent;
    public int number, maxNumber;
    public float holdTime = 1f;
    private WaitForSeconds wfsObj;
    
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(holdTime);

        while (number < maxNumber)
        {
            startEvent.Invoke();
            yield return wfsObj;
            number++;
        }
        
    }

}
