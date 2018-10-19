﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRaycast : MonoBehaviour {

    public GameObject explosion;
    public Camera MainCamera;
    private RaycastHit hit;


	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MOUSE BUTTON");
            if (Physics.Raycast(MainCamera.ScreenPointToRay(Input.mousePosition), out hit, 100.0f))
            {
                Instantiate(explosion, hit.point, Quaternion.identity);
            }
        }
	}
}