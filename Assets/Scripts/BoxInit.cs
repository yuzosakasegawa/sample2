﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour {

    public GameObject [] boxObjPrefab;
    public GameObject boxesObj;

    void Awake() {
        GameObject masterObj = GameObject.Find("Master");
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                int randomValue = Random.Range(0, boxObjPrefab.Length);
                GameObject g = Instantiate(boxObjPrefab[randomValue], boxesObj.transform);
                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
