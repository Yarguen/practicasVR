using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public Transform miraBala;
    public GameObject bala;
    public CharacterController personaje;
    public Vector3 velocidadPersonaje;
    public bool estaEnPiso;
    public float gravedad, aceleracionPersonaje, fuerzaSalto,fuerza;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var balas= Instantiate(bala, miraBala);
            balas.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerza * Time.deltaTime, ForceMode.Impulse);
        }
        estaEnPiso = personaje.isGrounded;
        if (estaEnPiso && velocidadPersonaje.y < 0)
        {
            velocidadPersonaje.y = 0;
        }

        Vector3 mueve = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        personaje.Move(mueve * Time.deltaTime * aceleracionPersonaje);

        if (mueve != Vector3.zero)
        {
            mueve=gameObject.transform.forward;
        }

        velocidadPersonaje.y += gravedad * Time.deltaTime;
        personaje.Move(velocidadPersonaje * Time.deltaTime);
    }
}
