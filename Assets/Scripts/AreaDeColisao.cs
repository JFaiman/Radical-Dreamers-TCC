using UnityEngine;

public class AreaDeColisao : MonoBehaviour
{
    [SerializeField] Transform tr;
    [SerializeField] Collider2D[] colisoresPorPerto;
    [SerializeField] float raioDeDeteccao = 2;
    [SerializeField] int vida = 3;
    [SerializeField] PauseMenu menu;
    bool acertou;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            VerificarArea(KeyCode.A);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            VerificarArea(KeyCode.S);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            VerificarArea(KeyCode.D);

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            VerificarArea(KeyCode.F);

        }
        if(vida <= 0)
        {
            menu.Perdeu();
        }
    }
    void VerificarArea(KeyCode input)
    {       
        colisoresPorPerto = Physics2D.OverlapCircleAll(tr.position, raioDeDeteccao);

        if(colisoresPorPerto.Length == 0)
        {
            vida--;
        }

        foreach (Collider2D colisor in colisoresPorPerto)
        {

            if (colisor.gameObject.GetComponentInParent<RiboTubo>())
            {
                acertou = colisor.gameObject.GetComponentInParent<RiboTubo>().VerificarImput(input);
            }
            if (!acertou)
            {
                vida--;
            }
        }
    }

    public void PerderVida()
    {
        vida--;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, raioDeDeteccao);
    }
}
