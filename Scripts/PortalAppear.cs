using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAppear : MonoBehaviour
{

    public GameObject PortalPopWindow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PortalPopWindow.SetActive(true);
        }
    }
    /*
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                MessagePopWindow.SetActive(false);
                Destroy(gameObject, 4f);
            }
        }
    */

}
