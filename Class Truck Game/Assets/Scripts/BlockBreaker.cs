using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreaker : MonoBehaviour
{
    public GameObject block;
    // Start is called before the first frame update
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(block);
        }
    }

    // Update is called once per frame
}
