using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //スコアを表示するテキスト
    private GameObject ScoreText;

    //スコア変数の宣言
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        score = 0;

        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
        SetScore();
    }

    //衝突でスコア表示
    void OnCollisionEnter(Collision collision)

    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "LargeCloudTag")
        {
            score += 200;
        }

        else if (yourTag == "SmallCloudTag")
        {
            score += 150;
        }

        else if (yourTag == "LargeStarTag")
        {
            score += 100;
        }

        else if (yourTag == "SmallStarTag")
        {
            score += 50;
        }
        SetScore();
    }

    void SetScore()
    {
        //ToStringが～する
        ScoreText.GetComponent<Text>().text = score.ToString();
    }
}
