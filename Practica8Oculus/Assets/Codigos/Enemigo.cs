using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public Collider vista, cobertura;
    public Animator enemigoAnim;
    public int estado, valorAnim;
    public Transform posEnemy, posPersonaje;
    public bool persigue;
    public NavMeshAgent enemyNav;
    // Update is called once per frame
    void Update()
    {

        if (persigue)
        {
            enemyNav.destination = posPersonaje.position;
            valorAnim = 1;
            cobertura.enabled = true;
        }
        else
        {
            cobertura.enabled = false;
            enemyNav.destination = posEnemy.position;
        }
        enemigoAnim.SetInteger("estado", valorAnim);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "personaje")
        {
            persigue = true;
            cobertura.enabled = true;
            vista.enabled = false;
        }
        if(other.tag=="Player")
        {
            valorAnim = 2;
        }
       
    }
    public void OnTriggerExit(Collider other)
    {
        persigue = false;
        cobertura.enabled = false;
        vista.enabled = true;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Arrow")
        {
            valorAnim = 3;
        }
    }
}
