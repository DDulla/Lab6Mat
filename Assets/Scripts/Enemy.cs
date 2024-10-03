using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public float direction;

    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector3.forward * direction * speed * Time.deltaTime);
    }
}
