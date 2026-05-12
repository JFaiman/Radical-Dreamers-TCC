using UnityEngine;

public class UiHpController : MonoBehaviour
{
    [SerializeField] GameObject[] Hp;
    int i;

    public void UpdateUI(int hpNumber)
    {
        i = 1;
        if (hpNumber <= 5)
        {
            foreach (GameObject show in Hp)
            {
                if (i <= hpNumber)
                {
                    show.SetActive(true);
                }
                else
                {
                    show.SetActive(false);
                }
                i++;
            }
        }
    }
}
