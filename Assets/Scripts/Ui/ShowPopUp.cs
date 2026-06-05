using UnityEngine;

public class ShowPopUp : MonoBehaviour
{
    [SerializeField] GameObject Button;

    public void Down()
    {
        Button.SetActive(true);
    }

    public void Up()
    {
        Button.SetActive(false);
    }
}
