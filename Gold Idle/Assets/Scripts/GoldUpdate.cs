using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldUpdate : MonoBehaviour
{
    [Header("DataBase")]
    public DataBase dataBase;

    [Header("Text Gold")]
    public TMP_Text goldText;
    
    

    
    void Update()
    {
        goldText.text = dataBase.gold.ToString();
    }

}
