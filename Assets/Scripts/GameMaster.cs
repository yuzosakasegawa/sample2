﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public int boxNum;
    public float nowTime;


	// Use this for initialization
	void Start () {
        nowTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        nowTime += Time.deltaTime;
        if (boxNum <= 0)
        {
            GameOver(nowTime.ToString("F0") + "秒でクリアできた！");     //F0小数点切り捨て
        }
	}

    public void GameOver(string sendMessage)
    {
        DataSender.resultMessage = sendMessage;
        SceneManager.LoadScene("Result");
    }


}




