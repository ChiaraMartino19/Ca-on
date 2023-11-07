using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    public Text cubosDerribadosText; 
    private int cubosDerribados = 0;
    private List<GameObject> cubosContados = new List<GameObject>();

    private void Start()
    {
        UpdateCubosDerribadosUI();
    }

    public void TryIncrementCubosDerribados(GameObject cubo)
    {
        if (!cubosContados.Contains(cubo))
        {
            cubosContados.Add(cubo);
            cubosDerribados++;
            UpdateCubosDerribadosUI();
        }
    }

    private void UpdateCubosDerribadosUI()
    {
        if (cubosDerribadosText != null)
        {
            cubosDerribadosText.text = "Cubos Derribados: " + cubosDerribados;
        }
    }
}

