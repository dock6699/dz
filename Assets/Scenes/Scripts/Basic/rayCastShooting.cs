﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastShooting : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        Debug.DrawRay(transform.position, transform.up, Color.red);

        if (hit)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
