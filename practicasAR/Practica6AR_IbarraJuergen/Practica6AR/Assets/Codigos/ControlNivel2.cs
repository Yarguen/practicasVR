using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNivel2 : MonoBehaviour
{
    public GameObject pelota;
    public Transform inicioPelota;
    public GameObject pelotaActiva;
    public bool ganaste;
    public bool perdiste;
    public int NivelActivo = 1;
    // Start is called before the first frame update
    void Start()
    {
        perdiste = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        reinicia();
        ganaste = true;
        //NivelActivo++;

    }
    void Update()
    {
        if (pelotaActiva == null)
        {
            perdiste = true;
            //reinicia();
        }
    }
    public void reinicia()
    {
        pelotaActiva = Instantiate(pelota, inicioPelota);
        //ReiniciaBoton.SetActive(false);
    }

    //public void perdio()
    //{
    //    ReiniciaBoton.SetActive(true);
    //}
}