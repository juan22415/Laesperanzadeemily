﻿using UnityEngine;
using System.Collections;

public class bengaldestroy : MonoBehaviour {

    private float timer=5;

    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if (timer<0)
        {
            Destroy(gameObject);
        }


	
	}
}
