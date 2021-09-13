using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    [SerializeField] private float force = 1000f;
    private Rigidbody _rb;
    private Vector3 _movement;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _movement = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal")).normalized;
        _rb.AddForce(_movement * force);
    }
}
