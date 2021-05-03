using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    const string BORDER = "BORDER";

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == BORDER)
        {
           // Debug.Log("Border!");
            Destroy(this.gameObject, .5f);
        }
    }


}
