using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AddController : MonoBehaviour
{

    public DataBase dataBase;
    public GameObject addNotification;
    DateTime currentDate;
    DateTime lastDate;

    public bool isPaused = false;
    private bool pausado = false;

    void Awake() 
    {
        addNotification.SetActive(false);    
    }




    void OnApplicationPause(bool paused)
    {
        if(pausado)
        {
            PlayerPrefs.SetInt("gold", dataBase.gold);
            PlayerPrefs.SetInt("goldPerMinute", dataBase.goldPerMinute);
            PlayerPrefs.SetString("lastDate", System.DateTime.Now.ToBinary().ToString());
            isPaused = true;
            Debug.Log("Entra aqui");
            
        }
        else
        {
            if(PlayerPrefs.HasKey("lastDate"))
            {
                currentDate = System.DateTime.Now;
                long temp = Convert.ToInt64(PlayerPrefs.GetString("lastDate"));
                lastDate = DateTime.FromBinary(temp);
                TimeSpan difference  = currentDate.Subtract(lastDate);
                print("difference " + difference);

            }
            dataBase.gold = PlayerPrefs.GetInt("gold");
            dataBase.goldPerMinute = PlayerPrefs.GetInt("goldPerMinute");
            isPaused = false;
            
        }
    }

    void Update() 
    {
        if(!pausado)
        {
            pausado = true;
            PlayerPrefs.SetInt("gold", dataBase.gold);
            PlayerPrefs.SetInt("goldPerMinute", dataBase.goldPerMinute);
            PlayerPrefs.SetString("lastDate", System.DateTime.Now.ToBinary().ToString());
            isPaused = true;
            Debug.Log("Entra");
        }
    }
}
