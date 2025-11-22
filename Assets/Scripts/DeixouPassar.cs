using UnityEngine;

public class DeixouPassar : MonoBehaviour
{
    [SerializeField] AreaDeColisao passou;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        passou.PerderVida();
    }
}
