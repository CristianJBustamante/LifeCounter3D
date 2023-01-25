using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] GameObject lifePanel;
    [SerializeField] GameObject colorPanel;
    [SerializeField] Sprite[] landsImage;
    [SerializeField] GameObject buttonConfig;
    Image background;




    void Start()
    {
        background = this.GetComponent<Image>();
    }


    public void ShowConfigurationColor()
    {
        lifePanel.SetActive(false);
        buttonConfig.SetActive(false);
        colorPanel.SetActive(true);
    }

    public void HideConfigurationColor()
    {
        colorPanel.SetActive(false);
        lifePanel.SetActive(true);
        buttonConfig.SetActive(true);
    }

    public void ChangeBackground(string color)
    {
        switch (color)
        {
            case "W":
                background.sprite = landsImage[0];
                HideConfigurationColor();
                break;
            case "R":
                background.sprite = landsImage[1];
                HideConfigurationColor();
                break;
            case "B":
                background.sprite = landsImage[2];
                HideConfigurationColor();
                break;
            case "U":
                background.sprite = landsImage[3];
                HideConfigurationColor();
                break;
            case "G":
                background.sprite = landsImage[4];
                HideConfigurationColor();
                break;
            case "L":
                background.sprite = landsImage[5];
                HideConfigurationColor();
                break;
        }
    }

}
