using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
   [Header("Total Gold")]
   public int gold;

   [Header("Gold Making Per Minute")]
   public int goldPerMinute;

   [Header("Total number of each structure")]
   public int structureOne;
   public int structureTwo;
   public int structureThree;
   public int structureFour;
   public int structureFive;
   public int structureSix;
   public int structureSeven;
   public int structureEight;
   public int structureNine;
   public int structureTen;

   [Header("Extra score for each stucture")]
   public int sOneScore = 5;
   public int sTwoScore = 5;
   public int sThreeScore = 5;
   public int sFourScore = 5;
   public int sFiveScore = 5;
   public int sSixScore = 5;
   public int sSevenScore = 5;
   public int sEightScore = 5;
   public int sNineScore = 5;
   public int sTenScore = 5;


   private void Awake() 
   {

      gold = PlayerPrefs.GetInt("gold");

      goldPerMinute = PlayerPrefs.GetInt("goldPerMinute"); 

      structureOne = PlayerPrefs.GetInt("structureOne");
      structureTwo = PlayerPrefs.GetInt("structureTwo");   
      structureThree = PlayerPrefs.GetInt("structureThree");   
      structureFour = PlayerPrefs.GetInt("structureFour");   
      structureFive = PlayerPrefs.GetInt("structureFive");   
      structureSix = PlayerPrefs.GetInt("structureSix");   
      structureSeven = PlayerPrefs.GetInt("structureSeven");   
      structureEight = PlayerPrefs.GetInt("structureEight");   
      structureNine = PlayerPrefs.GetInt("structureNine"); 
      structureTen = PlayerPrefs.GetInt("structureTen");


   }
   
}
