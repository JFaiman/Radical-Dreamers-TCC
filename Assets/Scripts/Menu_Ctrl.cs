using UnityEngine;

public class Menu_Ctrl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject telaInicial;

    [SerializeField] GameObject telaOpcoes;

    void Start()
    {
        AtivarTela(0);
    }
    
    
    private void Update()
    {
       
    }

    void EsconderTelas()
    
    {
        telaInicial.SetActive(false);
        telaOpcoes.SetActive(false);

    }

    public void AtivarTela(int indiceTela)
    
    {
        EsconderTelas();

        switch (indiceTela)
        {
            case 0:
            
                telaInicial.SetActive (true);

                break;

            case 1:

                telaOpcoes.SetActive(true);

                break;  

            case 99:



                break;


        }


    }

    
}
