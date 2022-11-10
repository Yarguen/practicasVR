using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{
    public GameObject pelota;
    public Transform inicioPelota;
    public GameObject pelotaActiva;
    public GameObject ReiniciaBoton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        print("ganaste");
    }
    void Update()
    {
        if (pelotaActiva == null)
            perdio();

    }
    public void reinicia()
    {
        pelotaActiva = Instantiate(pelota, inicioPelota);
        ReiniciaBoton.SetActive(false);
    }

    public void perdio()
    {
        ReiniciaBoton.SetActive(true);
    }
}
