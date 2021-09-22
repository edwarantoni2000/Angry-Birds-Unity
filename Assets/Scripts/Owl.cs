using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Owl : Bird
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;

        if (col.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }
}
