using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{

    public int life;
    public int modifier;
    public int modificationCounter;

    public TMPro.TMP_Text txtLife;
    public TMPro.TMP_Text txtModifier;

    public VideoManager videoManager;

    bool cut;


    void Start()
    {
        life = 20;
        modifier = 0;
        modificationCounter = 0;
        UpdateText();
    }

    public void AddLife()
    {
        life++;
        modifier++;
        modificationCounter++;
        UpdateText();
        StartCoroutine(ShowModifier());
    }

    public void SubtractLife()
    {
        life--;
        modifier--;
        modificationCounter++;
        UpdateText();
        StartCoroutine(ShowModifier());
    }

    public void UpdateText()
    {
        txtLife.text = life.ToString();
        if (life <= 0) txtLife.color = Color.red;
        else txtLife.color = Color.white;
        if (modifier > 0) txtModifier.text = "+" + modifier.ToString();
        else txtModifier.text = modifier.ToString();
    }

    IEnumerator ShowModifier()
    {
        int modif = modificationCounter;
        Color c = txtModifier.color;
        txtModifier.color = new Color(c.r, c.g, c.b, 255);
        yield return new WaitForSeconds(3f);
        if (modif == modificationCounter)
        {
            if (modifier != 0 && !videoManager.disable)
            {
                videoManager.gameObject.SetActive(true);
                if (modifier < 0) videoManager.PlayVideo(0);
                else videoManager.PlayVideo(1);
            }
            txtModifier.color = new Color(c.r, c.g, c.b, 0);
            modifier = 0;
            modificationCounter = 0;
        }
    }



}
