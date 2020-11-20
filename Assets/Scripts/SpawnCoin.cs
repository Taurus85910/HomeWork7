using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private float _delay;
    [SerializeField] private Vector3 _spawnSize;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {      
        while (true)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-_spawnSize.x, _spawnSize.x), Random.Range(-_spawnSize.y, _spawnSize.y), Random.Range(-_spawnSize.z, _spawnSize.z));
            Instantiate(_coin,randomPosition,Quaternion.identity);
            yield return new WaitForSeconds(_delay);
        }
    }
}
