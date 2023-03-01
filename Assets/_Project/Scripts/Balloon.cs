using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Balloon : MonoBehaviour
{
    public float _speed = 1f;

    private void Start()
    {
        var scale = Random.Range(1, 4f);

        if (scale < 2f)
        {
            _speed = 10f;
        }
        
        if (scale >= 2f && scale < 3f)
        {
            _speed = 3f;
        }
        
        if (scale >= 3f)
        {
            _speed = 1f;
        }
        
        transform.localScale = new Vector3(scale, scale, scale);
    }

    private void Update()
    {
        transform.Translate(Vector3.up * (Time.deltaTime * _speed), Space.World);
        
        if (transform.position.y > 10f)
        {
            Destroy(gameObject);
        }
    }
}
