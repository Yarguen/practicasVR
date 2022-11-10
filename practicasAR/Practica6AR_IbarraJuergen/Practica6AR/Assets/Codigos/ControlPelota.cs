using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPelota : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "piso")
        {
            Object.Destroy(this.gameObject);
            print("Cocho");
        }
    }
    public bool activaPelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
