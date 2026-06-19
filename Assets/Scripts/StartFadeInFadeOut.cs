using UnityEngine;

public class StartFadeInFadeOut : MonoBehaviour
{
    [SerializeField] GameObject studioLogo;
    [SerializeField] GameObject startScreen;

    private void Start()
    {
        studioLogo.SetActive(true);
        startScreen.SetActive(false);
    }
    public void Swap()
    {
        studioLogo.SetActive(false);
        startScreen.SetActive(true);
    }
}
