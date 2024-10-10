using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCountUp : MonoBehaviour
{
    [SerializeField]
    GameObject objetoTexto;
    [SerializeField]
    TextMeshProUGUI etiquetaTexto;
    int startTime = 0;
    float currentTime;
    [SerializeField]
    public TextMeshProUGUI timerText;
    public void AumentarCuenta()
    {
        currentTime = ;
        etiquetaTexto.text = currentTime.ToString();
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
