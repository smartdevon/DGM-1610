using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int coinValue = 2;
    public IntData coinCount;
    public Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D()
    {
        coinCount.value += coinValue;
        counterText.text = coinCount.value.ToString();
        gameObject.SetActive(false);
    }
}
