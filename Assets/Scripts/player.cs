﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

         public float speed = 3f;


     Rigidbody2D rigidbody2d;
 
     void Awake () {
         rigidbody2d = GetComponent<Rigidbody2D> ();
     }
 
     void FixedUpdate () {
         if (Input.GetKey (KeyCode.LeftArrow))
             rigidbody2d.velocity = new Vector2 (speed * -1, 0f);
         if (Input.GetKey (KeyCode.RightArrow))
             rigidbody2d.velocity = new Vector2 (speed, 0f);
             
     }
}
