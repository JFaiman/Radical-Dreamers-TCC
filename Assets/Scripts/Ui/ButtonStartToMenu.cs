using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartToMenu : MonoBehaviour
{
    public void Btn_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
