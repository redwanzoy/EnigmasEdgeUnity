using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePop : MonoBehaviour
{

    public GameObject MessagePopWindow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            MessagePopWindow.SetActive(true);
            Destroy(MessagePopWindow, 3f);

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
