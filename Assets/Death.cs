using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<GoWay>(out GoWay goWay))
        {
            Destroy(gameObject);
            Debug.Log("Вы умерли!");
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("Вы умерли!");
    }
}
