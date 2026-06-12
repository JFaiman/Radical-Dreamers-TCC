using UnityEngine;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    void Start()
    {
        Invoke("GoToGame", 136);
    }

    void GoToGame()
    {
        SceneManager.LoadScene("PreTutorial");
    }

    public void Skip()
    {
        SceneManager.LoadScene("PreTutorial");
    }
}
