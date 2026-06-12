using UnityEngine;
using UnityEngine.UI;

public class LevelsCleared : MonoBehaviour
{
    [SerializeField] GameObject[] Buttonslevels;
    int i;    

    void Start()
    {
        foreach (var button in Buttonslevels)
        {
            button.SetActive(false);
        }
        Buttonslevels[0].SetActive(true);
        for (i = 0; i < Buttonslevels.Length; i++)
        {
            if(ScoreManeger.instance.IsThisLvlCleared(i) != 0)
            {
                Buttonslevels[i+1].SetActive(true);
            }
        }
    }       
}
