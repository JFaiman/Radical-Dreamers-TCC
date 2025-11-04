using UnityEngine;

public class AreaDeColisao : MonoBehaviour
{

    [SerializeField] Transform tr;
    [SerializeField] Collider2D[] colisoresPorPerto;
    [SerializeField] float raioDeDeteccao = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) 
        {
            VerificarArea(KeyCode.F1);

        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            VerificarArea(KeyCode.F2);

        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            VerificarArea(KeyCode.F3);

        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            VerificarArea(KeyCode.F4);

        }
    }

    private void FixedUpdate()
    {
       
    }
    void VerificarArea(KeyCode input)
    {
       
        colisoresPorPerto = Physics2D.OverlapCircleAll(tr.position, raioDeDeteccao);


        foreach (Collider2D colisor in colisoresPorPerto) 
        {
            
            if (colisor.gameObject.GetComponentInParent<RiboTubo>())
            {
                colisor.gameObject.GetComponentInParent<RiboTubo>().VerificarImput(input);
            }
           
        }
        
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, raioDeDeteccao);
    }
}
