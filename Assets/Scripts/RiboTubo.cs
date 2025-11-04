using UnityEngine;

public class RiboTubo : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform tr;
    [SerializeField] float duracao = 3;
    [SerializeField] public KeyCode tecla;


    public void Ritmo(float velocidadeDoMovimento)
    {
        //force mode 2D 
        //rb.AddForce(tr.up * velocidadeDoMovimento, ForceMode2D.Force);
        rb.linearVelocity = tr.up * velocidadeDoMovimento;
        Destroy(gameObject, duracao);
    }

    public void VerificarImput(KeyCode input)
    {
        if (input == tecla)
        {
            Debug.Log("tecla correta");
            Destroy(gameObject);



        }

        else 
        {
            Debug.Log("tecla xxx");


        }
    
    }
}
