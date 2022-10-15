using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }
     
    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal");
        Vector3 direction = new (move * _speed * Time.deltaTime, 0, 0);
        transform.Translate(direction);
    }
}
