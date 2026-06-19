using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField] TMP_Text[] Scores;
    int i = 0;
    float score;
    
    
    void Start()
    {
        ScoreManeger.instance.RecordScore();
        score = ScoreManeger.instance.ReturnScore(i);
        Scores[0].text = "Tutorial = " + score;
        for (i = 1; i < Scores.Length; i++)
        {
            score = ScoreManeger.instance.ReturnScore(i);
            Scores[i].text = "Level " + i + " = " + score;
        }
    }
}
