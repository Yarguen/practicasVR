using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlJuego : MonoBehaviour
{
    public enemigos ValorAnim;
    public ControlMeta meta;
    public int ataque;
    public TextMeshProUGUI texto;
    public GameObject personaje,MsgPerdiste, MsgGanaste;
    public Transform posInicio;
    public float tiempoLimite, minutos, segundos;
    public bool Ganaste;
    // Update is called once per frame
    void Update()
    {
        tiempoLimite -= Time.deltaTime;
        minutos = System.Convert.ToInt32(tiempoLimite / 60 - 0.5);
        segundos = tiempoLimite % 60;
        if (segundos < 10)
            texto.text = "Timer: " + minutos.ToString("f0") + ":0" + segundos.ToString("f0");
        else
            texto.text = "Timer: " + minutos.ToString("f0") + ":" + segundos.ToString("f0");

        if(tiempoLimite<0)
        {
            perdiste();
        }

        Ganaste =meta.ganaste;
        if (Ganaste)
        {
            ganaste();
        }
        ataque = ValorAnim.valorAnim;

        if (ataque == 2)
        {
            reinicia();
        }


    }

    void reinicia()
    {
        personaje.transform.position = posInicio.position; 
    }

    void perdiste()
    {
        MsgPerdiste.SetActive(true);
        MsgGanaste.SetActive(false);
    }
    
    void ganaste()
    {
        MsgPerdiste.SetActive(false);
        MsgGanaste.SetActive(true);
    }

}
