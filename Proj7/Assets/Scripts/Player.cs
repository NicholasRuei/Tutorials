﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Forwards")) * Time.deltaTime * speed);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // WRITE CODE BELOW HERE ------------------------------





        // ----------------------------------------------------
	}
}
