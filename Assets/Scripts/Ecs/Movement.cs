using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_direction * _speed * Time.deltaTime);
        }
    }
}
