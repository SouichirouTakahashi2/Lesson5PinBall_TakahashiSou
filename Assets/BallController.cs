using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性があるz軸の最大値														
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト														
    private GameObject gameoverText;

    GameObject scoreText;

    private int score = 0;


    // Use this for initialization														
    void Start()
    {
        //シーンの中のgameoverTextプロジェクトを取得														
        this.gameoverText = GameObject.Find("GameOverText");

        //スコアをTextに反映														
        this.scoreText = GameObject.Find("ScoreText");
    }
    // Update is called once per frame													
    void Update()
    {
        //ボールが画面外に出た場合												

        if (this.transform.position.z < this.visiblePosZ)

        {//GameoverTextにゲームオーバーを表示														
            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }
    }

  

    void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("hit"); 壁に当たったら表示する

        if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 50;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.score += 100;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.score += 200;
        }



        this.scoreText.GetComponent<Text>().text = this.score.ToString() + "point";
    }
}



