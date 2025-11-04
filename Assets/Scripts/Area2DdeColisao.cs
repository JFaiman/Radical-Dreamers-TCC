using UnityEngine;

public class Area2DdeColisao : MonoBehaviour
{
    
    [SerializeField] Transform tr;
    [SerializeField] Collider[] colisoresPorPerto = new Collider[2];
    [SerializeField] float raioDeDeteccao = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        VerificarArea();
    }
    void VerificarArea()
    {
        Physics2D.OverlapCircle(tr.position, raioDeDeteccao);
        //Physics.OverlapSphereNonAlloc(tr.position, raioDeDeteccao, colisoresPorPerto);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, raioDeDeteccao);
    }
}
