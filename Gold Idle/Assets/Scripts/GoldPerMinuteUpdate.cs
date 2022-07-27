using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldPerMinuteUpdate : MonoBehaviour
{
    [Header("DataBase")]
    public DataBase dataBase;

    [Header("Text Gold Per Minute")]
    public TMP_Text goldTextPerMinute;

    
    
    void Update()
    {
        goldTextPerMinute.text = dataBase.goldPerMinute.ToString() + " GOLD PER MINUTE";
    }
}
