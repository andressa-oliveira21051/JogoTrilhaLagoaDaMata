using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaocarta : MonoBehaviour
{
    public GameObject Carta;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "peao")
        {
            Carta.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "peao")
        {
            Carta.SetActive(false);

        }
    }
}
