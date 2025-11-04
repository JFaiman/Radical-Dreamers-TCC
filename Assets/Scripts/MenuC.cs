using UnityEngine;

public class Menuc : MonoBehaviour
{
    [SerializeField] GameObject telaInicial;
    [SerializeField] GameObject telaOpcoes;


    
    void Start()
    {
        HideUI();
        telaInicial.SetActive(true);

    }

    void HideUI()
    { 
        telaInicial.SetActive(false);
        telaOpcoes.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HideUI();
            telaOpcoes.SetActive(true);
        }
    }

    public void Btn_Comeco()
    {
        Debug.Log("Liga Jogo");
    }

    public void Btn_Opcoes()
    {

    }

    public void Btn_Sair()
    {

    }
}
