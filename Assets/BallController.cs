using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
   
    GameObject director;


    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のScoreTextオブジェクトを取得
        this.director = GameObject.Find("ScoreText");
    }
    //Physicsが登録されているオブジェクトから衝突時に呼び出す
    private void OnCollisionEnter(Collision other)
      {
        if (other.gameObject.tag == "SmallStarTag")
        {

            this.director.GetComponent<ScoreController>().ClashSmallStar();
           
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            this.director.GetComponent<ScoreController>().ClashLargeStar();
          
        }
        else if (other.gameObject.tag =="SmallCloudTag")
        {
            this.director.GetComponent<ScoreController>().ClashSmallCloud();

        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.director.GetComponent<ScoreController>().ClashLargeCloud();
       
        }

        
    }
    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}

