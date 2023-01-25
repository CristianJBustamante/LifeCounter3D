using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeModifier : MonoBehaviour
{
    
    public LifeManager lifeManager;

    [SerializeField] bool isPlus;


    public void ChangeLife(){
        if(isPlus) lifeManager.AddLife();
        else lifeManager.SubtractLife();
    }

}
