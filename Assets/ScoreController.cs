using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
    //Text用変数
    GameObject  scoreText;
    //スコア計算用変数
    private int score = 0;
    public void GetLargeStar(){
        this.score += 50;
    }
    public void GetLargeCloud()  {
        this.score += 200;
    }
    public void GetSmallCloud(){
        this.score += 100;
    }
    // Use this for initialization
    void Start () {
        this.scoreText = GameObject.Find("ScoreText");
	}	
	// Update is called once per frame
	void Update () {
        //this.scoreText.GetComponent<Text>().text = this.score.ToString() + "point";
	}
}
