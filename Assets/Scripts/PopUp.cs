using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject popup;
    [SerializeField]
    float timeAnim;
    
    

    private void Start()
    {
        background.SetActive(false);
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyUp(KeyCode.Escape))

        {
            if (popup.activeSelf)
            {
                HidePopUp();
            }

            else
            {
                ShowPopUp();
            }
        }
    }

    public void ShowPopUp()
    {
        background.SetActive(true);
        popup.SetActive(true);
        LeanTween.moveLocalY(popup, -1100f, 0f);
        LeanTween.moveLocalY(popup, 0f, timeAnim).setEase(LeanTweenType.animationCurve);
    }

    public void HidePopUp()
    {
        LeanTween.moveLocalY(popup, -900f, timeAnim).setEase(LeanTweenType.animationCurve).setOnComplete(() =>
        {
            popup.SetActive(false);

        });
        LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 0f, timeAnim).setOnComplete(() =>
        {
            background.SetActive(false);
            LeanTween.alphaCanvas(background.GetComponent<CanvasGroup>(), 1f, timeAnim);

        });
            
        
        
    }

    
}
