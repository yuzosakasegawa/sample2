﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour {

    public Text resultMessageText;

    void Start ()
        {
            resultMessageText.text = DataSender.resultMessage;
        }
	
	// Update is called once per frame
	void Update () {
		
	}
}
