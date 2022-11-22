using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ControlJuego : MonoBehaviour
{
    public ControlNivel NivelCodigo;
    public bool ganaste,perdiste;
    public GameObject NivelObjeto,TextoGanaste;
    public GameObject Nivel1,Nivel2,Nivel3;
    public Transform posNivel;
    public int nivelActivo;
    public GameObject despliegaPelota;
    public float tiempoLimite,minutos,segundos;
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tiempoLimite -= Time.deltaTime;
        minutos = System.Convert.ToInt32(tiempoLimite/60-0.5);
        segundos = tiempoLimite % 60;
        texto.text = "Timer: " + minutos.ToString("f0") + ":" + segundos.ToString("f0");
        perdiste = NivelCodigo.perdiste;
        ganaste = NivelCodigo.ganaste;
        if (ganaste)
        {
            nivelActivo++;
            if(nivelActivo==1)
                instanciaNivel(Nivel2);
            if (nivelActivo == 2)
                instanciaNivel(Nivel3);
            if (nivelActivo > 2)
            {
                TextoGanaste.SetActive(true);
                GanasteJuego();
            }

            ganaste = false;
        }

        if (perdiste)
        {
            if (nivelActivo > 0)
            {
                instanciaNivel(Nivel1);
                nivelActivo = 0;
            }

        }

        if (tiempoLimite < 0)
            perdisteJuego();
     }

    public void perdisteJuego()
    {
        Application.Quit();
    }
    public IEnumerator GanasteJuego() {
        yield return new WaitForSeconds(10);
        Application.Quit();
        
    }
    public void instanciaNivel(GameObject nivel)
    {

        Object.Destroy(NivelObjeto);
        NivelObjeto = Instantiate(nivel,posNivel);
        NivelCodigo = NivelObjeto.GetComponent<ControlNivel>();
        NivelCodigo.reinicia();
    }
}
