﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float moveSpeed = 600f;
    float movement = 0f;
    void Update()
    {
       movement = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.deltaTime * -moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
    }
}
