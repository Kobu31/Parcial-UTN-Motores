using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerog : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ENCONTRASTE UN FRAGMENTO");

            GameManager.Instance.AddJero(1); // A�adir puntuaci�n al morir
            Destroy(gameObject);
        }
    }
}
