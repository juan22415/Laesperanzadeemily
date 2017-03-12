using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnpoint : MonoBehaviour {

    public Transform[] spawnpoints;
    public int maxrandom;
    private Transform mytransform;
    public int current;

    // Use this for initialization
    void Start () {
        current = Random.Range(0, maxrandom);
        mytransform = GetComponent<Transform>();
        mytransform.position= spawnpoints[current].position;



		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
