using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Speed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Calling the start method");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0.01f, 0, 0);
    }
}

