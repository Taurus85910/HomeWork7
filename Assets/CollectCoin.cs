using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private int _coinCount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Rotation>(out Rotation rotation))
        {
            Destroy(collision.gameObject);
            _coinCount += 1;
            Debug.Log($"{_coinCount} Монет");
        }
    }
}
