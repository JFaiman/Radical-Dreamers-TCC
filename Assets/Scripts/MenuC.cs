using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuc : MonoBehaviour
{
    [SerializeField] GameObject telaInicial;
    [SerializeField] GameObject telaMenu;


    
    void Start()
    {
        HideUI();
        telaInicial.SetActive(true);

    }

    void HideUI()
    { 
        telaInicial.SetActive(false);
        telaMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HideUI();
            telaMenu.SetActive(true);
        }
    }

    public void Btn_Comeco()
    {
        SceneManager.LoadScene("Story");
    }

    public void Btn_Opcoes()
    {

    }

    public void Btn_Sair()
    {
        Application.Quit();
    }
}
