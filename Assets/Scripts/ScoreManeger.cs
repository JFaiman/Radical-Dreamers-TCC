using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;

public class ScoreManeger : MonoBehaviour
{
    public static ScoreManeger instance;

    [SerializeField] float[] allScores;
    [SerializeField] int[] lvlCleared;

    [SerializeField] int howManyLevelsDoWeHave;
    
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this);

        allScores[0] = PlayerPrefs.GetFloat("Pontos0");
        allScores[1] = PlayerPrefs.GetFloat("Pontos1");
        allScores[2] = PlayerPrefs.GetFloat("Pontos2");
        allScores[3] = PlayerPrefs.GetFloat("Pontos3");
        allScores[4] = PlayerPrefs.GetFloat("Pontos4");
        lvlCleared[0] = PlayerPrefs.GetInt("Lvl0Cleared");
        lvlCleared[1] = PlayerPrefs.GetInt("Lvl1Cleared");
        lvlCleared[2] = PlayerPrefs.GetInt("Lvl2Cleared");
    }
    
    public void UpdateScore(float score, int level)
    {
        if (score > allScores[level])
        {
            allScores[level] = score;
        }
    }

    public float ReturnScore(int level)
    {
        return allScores[level];
    }

    public void RecordScore()
    {
        PlayerPrefs.SetFloat("Pontos0", allScores[0]);
        PlayerPrefs.SetFloat("Pontos1", allScores[1]);
        PlayerPrefs.SetFloat("Pontos2", allScores[2]);
        PlayerPrefs.SetFloat("Pontos3", allScores[3]);
        PlayerPrefs.SetFloat("Pontos4", allScores[4]);
        PlayerPrefs.SetInt("Lvl0Cleared", lvlCleared[0]);
        PlayerPrefs.SetInt("Lvl1Cleared", lvlCleared[1]);
        PlayerPrefs.SetInt("Lvl2Cleared", lvlCleared[2]);
    }
    public int IsThisLvlCleared(int level)
    {
        /*for (int i = 0; i <= lvlCleared.Length; i++)
        {
            if (lvlCleared[i] == 0)
            {
                return i;
            }
        }
        return lvlCleared.Length;*/
        return lvlCleared[level];
    }

    public void UpdateLvlCleared(int i)
    {
        lvlCleared[i] = 1;
    }
}
