using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
     if(Input.GetKey(KeyCode.W))
        {
            _animator.SetBool("IsGoing",true);
            transform.Translate(0,_speed * Time.deltaTime,0);
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
            _animator.SetBool("IsGoing", true);
            transform.Translate(_speed * Time.deltaTime,0, 0);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            _animator.SetBool("IsGoing", true);
            transform.Translate(0,- _speed * Time.deltaTime, 0);
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            _animator.SetBool("IsGoing", true);
            transform.Translate(_speed * Time.deltaTime, 0, 0);         
            
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
            _animator.SetBool("IsGoing", false);
    }
}
