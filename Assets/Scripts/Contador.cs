using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Contador : MonoBehaviour
{
    [SerializeField]
    GameObject objetoTexto;
    [SerializeField]
    TextMeshProUGUI etiquetaTexto;
    [SerializeField]
    int cuenta = 0;

    [SerializeField]
    public TextMeshProUGUI contadorText;

    public void AumentarCuenta()
    {
        cuenta++;
        etiquetaTexto.text = cuenta.ToString();
       

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
       


    }

    

}