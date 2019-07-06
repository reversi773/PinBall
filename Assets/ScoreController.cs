using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    //得点を表示するテキスト
    private GameObject ScoreText;
    //score変数を設定
    int score = 0;
    //各オブジェクトと衝突した際の得点の値を設定
    public void ClashSmallCloud()
    {
        this.score += 30;
        Debug.Log(score);
    }
    public void ClashLargeCloud()
    {
        this.score += 10;
        Debug.Log(score);
    }
    public void ClashSmallStar ()
    {
        this.score += 40;
        Debug.Log(score);
    }
    public void ClashLargeStar()
    {
        this.score += 20;
        Debug.Log(score);
    }





	// Use this for initialization
	void Start () {
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
        this.ScoreText.GetComponent<Text>().text = this.score.ToString() + "score";
      
		
	}
}
