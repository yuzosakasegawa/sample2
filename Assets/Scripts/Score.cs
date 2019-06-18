using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //canvasを使う場合

public class Score : MonoBehaviour {

    //スコアを表示するUIの取得用
    public Text scoreText;
    //ハイスコアを表示するUIの取得用
    public Text highscoreText;
    //スコアのカウント用
    private int score;
    //ハイスコアのカウント用
    private int highscore;
    //PlayerPrefsで保存するためのキー
    private string highScoreKey = "highScore";

	void Start () {
        Initialize();		
	}
	
	void Update () {
        //スコアがハイスコアより大きくなればハイスコアを更新
        if (highscore < score)
        {
            highscore = score;
        }

        //現在のスコアとハイスコアを画面に表示する
        scoreText.text = score.ToString();          //text=コンポーネント
        highscoreText.text = highscore.ToString();  //Tostring=int型をstr型へ
    }

    //ゲーム開始前の状態に戻す
    private void Initialize()
    {
        //スコアを0に戻す
        score = 0;

        //ハイスコアを取得する。保存されてなければ0を取得する。
        highscore = PlayerPrefs.GetInt(highScoreKey, 0);    //Get=ロード、Set=セーブ
    }

    //ポイントの追加。修飾子をpublicにしているので外部より参照
    public void AddPoint (int point)
    {
        score += point;
    }

    //ハイスコアの保存
    public void Save()
    {
        //ハイスコアを保存する
        PlayerPrefs.SetInt(highScoreKey,highscore);
        PlayerPrefs.Save();

        //ゲーム開始前の状態に戻す
        Initialize();
    }

}
