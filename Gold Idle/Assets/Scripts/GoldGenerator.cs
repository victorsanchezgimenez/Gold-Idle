using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGenerator : MonoBehaviour
{
    
    DataBase dataBase;
    AddController addController; 
    
    public float nextTimeCall = 1f;
    


    void Awake()
    {
        if(dataBase == null)
        {
            dataBase = GameObject.FindGameObjectWithTag("DataBase").GetComponent<DataBase>();
        }

        if(addController == null)
        {
            addController = GameObject.FindGameObjectWithTag("AddController").GetComponent<AddController>();
        }
    }

   

    void Start() 
    {
        
        nextTimeCall = Time.time + 1f;
        
    }

    void Update()
    {
        if(addController.isPaused == false)
        {
            if (Time.time >= nextTimeCall)
            {
            
                StructureGoldGenerator();
                nextTimeCall  += 1f;
            }
        }
    }


    private void StructureGoldGenerator()
    {


        if (this.gameObject.tag == "StructureTwo")
        {
            dataBase.gold += dataBase.sTwoScore;
        }

        else if (this.gameObject.tag == "StructureThree")
        {
            dataBase.gold += dataBase.sThreeScore;
        }

        else if (this.gameObject.tag == "StructureFour")
        {
            dataBase.gold += dataBase.sFourScore;
        }

        else if (this.gameObject.tag == "StructureFive")
        {
            dataBase.gold += dataBase.sFiveScore;
        }

        else if (this.gameObject.tag == "StructureSix")
        {
            dataBase.gold += dataBase.sSixScore;
        }

        else if (this.gameObject.tag == "StructureSeven")
        {
            dataBase.gold += dataBase.sSevenScore;
        }

        else if (this.gameObject.tag == "StructureEight")
        {
            dataBase.gold += dataBase.sEightScore;
        }

        else if (this.gameObject.tag == "StructureNine")
        {
            dataBase.gold += dataBase.sNineScore;
        }

        else if (this.gameObject.tag == "StructureTen")
        {
            dataBase.gold += dataBase.sTenScore;
        }

        else
        {
            Debug.Log("Error tag not found");
        }

    }
}
