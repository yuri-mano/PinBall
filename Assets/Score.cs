using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //�X�R�A��\������e�L�X�g
    private GameObject ScoreText;

    //�X�R�A�ϐ��̐錾
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        score = 0;

        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.ScoreText = GameObject.Find("ScoreText");
        SetScore();
    }

    //�Փ˂ŃX�R�A�\��
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
        //ToString���`����
        ScoreText.GetComponent<Text>().text = score.ToString();
    }
}
