using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesCounter : MonoBehaviour
{
    private int cubosDerribados = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            
            cubosDerribados++;
             UIController uiController = FindObjectOfType<UIController>();
            if (uiController != null)
            {
                uiController.TryIncrementCubosDerribados(gameObject); 
            }
        }
    }
}
