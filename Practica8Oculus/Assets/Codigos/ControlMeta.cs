using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMeta : MonoBehaviour
{
    public bool ganaste;
    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        ganaste = true;
    }
}

