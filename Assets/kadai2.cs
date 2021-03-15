using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arrays = { 5, 10, 15, 20, 25 };

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(arrays[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
