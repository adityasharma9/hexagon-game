﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagonscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed = 3f;
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello");
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x<=.05f)
        {
            Destroy(gameObject);
        }

    }
}
