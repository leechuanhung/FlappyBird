using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 1.5f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + Vector3.left* Time.deltaTime;
    }
}
