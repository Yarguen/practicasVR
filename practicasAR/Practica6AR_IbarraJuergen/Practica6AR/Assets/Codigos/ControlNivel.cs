using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNivel : MonoBehaviour
{
    public GameObject pelota;
    public Transform inicioPelota;
    public GameObject pelotaActiva;
    public bool ganaste, perdiste, primera;
    // Start is called before the first frame update
    void Start()
    {
        perdiste = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        ganaste = true;

    }
    void Update()
    {
        if (primera)
        {
            primera = false;
            reinicia();
        }
        if (perdiste && pelotaActiva != null)
            perdiste = false;
        if (pelotaActiva == null)
        {
            perdio();
        }
       
    }
    //Funcion para desplegar pelotas 
    public void reinicia()
    {
        pelotaActiva = Instantiate(pelota, inicioPelota);
    }

    public void perdio()
    {
        perdiste = true;
        reinicia();
    }
}
