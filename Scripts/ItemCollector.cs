using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    //private int pendrive = 0;
    [SerializeField] private AudioSource collectingSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CollectiableItems"))
        {
            collectingSoundEffect.Play();
            Destroy(collision.gameObject);
        }
    }
}
