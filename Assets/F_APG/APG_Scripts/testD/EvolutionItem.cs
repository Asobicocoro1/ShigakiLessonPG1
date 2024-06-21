using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvolutionItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController1>().Evolve();
            Destroy(gameObject);
        }
    }
}
