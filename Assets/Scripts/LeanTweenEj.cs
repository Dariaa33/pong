using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenEj : MonoBehaviour
{
    [SerializeField]
    float sizeToscale = 2f;
    [SerializeField]
    float durationAnim = 0.75f;
    [SerializeField]
    float finalYPose = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalY(gameObject, 0.5f, durationAnim).setEase(LeanTweenType.easeInOutElastic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
