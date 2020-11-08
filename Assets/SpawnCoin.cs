using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private GameObject _coin;
    [SerializeField] private Camera _camera;
    private Vector3 _size;
    private void Start()
    {
        _size = new Vector3(8.5f,5.5f,0f);
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {      
        while (true)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-_size.x / 2, _size.x / 2), Random.Range(-_size.y / 2, _size.y / 2), Random.Range(-_size.z / 2, _size.z / 2));
            Instantiate(_coin,randomPosition,Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
