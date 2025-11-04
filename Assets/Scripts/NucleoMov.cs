using UnityEngine;

public class NucleoMov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region Inputs
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("D");
        }
        #endregion
    }
}
