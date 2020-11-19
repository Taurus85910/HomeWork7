using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coin;   
    private Vector3 _size;

    private void Start()
    {
        _size = new Vector3(5f,4f,0f);
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {      
        while (true)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-_size.x, _size.x), Random.Range(-_size.y, _size.y), Random.Range(-_size.z, _size.z));
            Instantiate(_coin,randomPosition,Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
