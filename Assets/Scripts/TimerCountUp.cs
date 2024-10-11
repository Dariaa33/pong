using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCountUp : MonoBehaviour
{
	private float StartTime;
	TextMeshProUGUI etiquetaTexto;
	
	void Start()
	{
		StartTime = Time.time;
	}
	void Update()
	{
		float TimerControl = Time.time - StartTime;
		string mins = ((int)TimerControl / 60).ToString("00");
		string segs = (TimerControl % 60).ToString("00");
		string milisegs = ((TimerControl * 100) % 100).ToString("00");

		string TimerString = string.Format("{00}:{01}:{02}", mins, segs, milisegs);

		etiquetaTexto.text = StartTime.ToString();

	}


    
}
