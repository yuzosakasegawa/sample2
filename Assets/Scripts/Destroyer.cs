using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public int point;

    public int initHP;  //耐久力の最大値
    private int currentHP;  //耐久力の現在地

    public AudioClip hitSE; //破壊されない場合のSE
    public AudioClip destroySE;  //破壊された場合のSE 

    public GameObject masterObj;

	// Use this for initialization
	void Start () {
        //boxの耐久力初期化
        this.currentHP = initHP;
	}
	
    private void OnCollisionEnter(Collision collision)
    {
        //ボールが接触するたびに耐久力を1ずつ減らします。
        this.currentHP -= 1;

        //壊れる場合
        if (this.currentHP<=0)
        {
            //破壊されるSEを再生
            AudioSource.PlayClipAtPoint(destroySE, transform.position);
            //スコア処理を追加
            FindObjectOfType<Score>().AddPoint(point);


            masterObj.GetComponent<GameMaster>().boxNum--;
            Destroy(gameObject);

        }
        //まだ壊れない場合
        else
        {
            //ボールを跳ね返すSEを再生
            AudioSource.PlayClipAtPoint(hitSE, transform.position);
        }

    }

}
