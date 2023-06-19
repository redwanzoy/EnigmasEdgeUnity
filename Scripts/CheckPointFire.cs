using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointFire : MonoBehaviour
{

    public GameObject CheckFire;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CheckFire.SetActive(true);
        }
    }
   /*     private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                MessagePopWindow.SetActive(false);
            }
        }
   */

}
