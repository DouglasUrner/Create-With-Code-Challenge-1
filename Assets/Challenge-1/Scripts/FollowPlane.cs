﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = plane.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position - offset;
    }
}
