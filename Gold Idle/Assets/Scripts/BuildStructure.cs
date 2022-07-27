using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildStructure : MonoBehaviour
{
    
    [Header("DataBase")]
    public DataBase dataBase;

    [Header("Cost of constructions")]
    public int costOne = 100;
    public int costTwo = 100;
    public int costThree = 100;
    public int costFour = 100;
    public int costFive = 100;
    public int costSix = 100;
    public int costSeven = 100;
    public int costEight = 100;
    public int costNine = 100;
    public int costTen = 100;

    [Header("Prefabs constructions")]
    public GameObject prefabStructureTwo;
    public GameObject prefabStructureThree;
    public GameObject prefabStructureFour;
    public GameObject prefabStructureFive;
    public GameObject prefabStructureSix;
    public GameObject prefabStructureSeven;
    public GameObject prefabStructureEight;
    public GameObject prefabStructureNine;
    public GameObject prefabStructureTen;

    [Header("Transform construction handler")]
    public Transform transformParent;



    public void OnClickStructureOne()
    {
        if(dataBase.gold >= costOne)
        {
            dataBase.gold -= costOne;
            dataBase.structureOne ++;
            PlayerPrefs.SetInt("structureOne", dataBase.structureOne);
        }
        else
        {
            Debug.Log("Nothing");
        }
    }

    public void OnClickStructureTwo()
    {
        if(dataBase.gold >= costTwo)
        {
            GameObject structure = Instantiate(prefabStructureTwo, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costTwo;
            dataBase.goldPerMinute += dataBase.sTwoScore * 60; 
            dataBase.structureTwo ++;
            PlayerPrefs.SetInt("structureTwo", dataBase.structureTwo);
        }
        else
        {
            Debug.Log("Nothing");
        }
    }
    
    public void OnClickStructureThree()
    {
        if(dataBase.gold >= costThree)
        {
            GameObject structure = Instantiate(prefabStructureThree, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costThree;
            dataBase.goldPerMinute += dataBase.sThreeScore * 60; 
            dataBase.structureThree ++;
            PlayerPrefs.SetInt("structureThree", dataBase.structureThree);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
        
    }
    
    public void OnClickStructureFour()
    {
        if(dataBase.gold >= costFour)
        {
            GameObject structure = Instantiate(prefabStructureFour, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costFour;
            dataBase.goldPerMinute += dataBase.sFourScore * 60; 
            dataBase.structureFour ++;
            PlayerPrefs.SetInt("structureFour", dataBase.structureFour);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
        
    }
    
    public void OnClickStructureFive()
    {
        if(dataBase.gold >= costFive)
        {
            GameObject structure = Instantiate(prefabStructureFive, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costFive;
            dataBase.goldPerMinute += dataBase.sFiveScore * 60; 
            dataBase.structureFive ++;
            PlayerPrefs.SetInt("structureFive", dataBase.structureFive);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
    }
    
    public void OnClickStructureSix()
    {
        if(dataBase.gold >= costSix)
        {
            GameObject structure = Instantiate(prefabStructureSix, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costSix;
            dataBase.goldPerMinute += dataBase.sSixScore * 60; 
            dataBase.structureSix ++;
            PlayerPrefs.SetInt("structureSix", dataBase.structureSix);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
    }
    
    public void OnClickStructureSeven()
    {
        if(dataBase.gold >= costSeven)
        {
            GameObject structure = Instantiate(prefabStructureSeven, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costSeven;
            dataBase.goldPerMinute += dataBase.sSevenScore * 60; 
            dataBase.structureSeven ++;
            PlayerPrefs.SetInt("structureSeven", dataBase.structureSeven);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
        
    }
    
    public void OnClickStructureEight()
    {
        if(dataBase.gold >= costEight)
        {
            GameObject structure = Instantiate(prefabStructureEight, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costEight;
            dataBase.goldPerMinute += dataBase.sEightScore * 60; 
            dataBase.structureEight ++;
            PlayerPrefs.SetInt("structureEight", dataBase.structureEight);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
        
    }

    public void OnClickStructureNine()
    {
        if(dataBase.gold >= costNine)
        {
            GameObject structure = Instantiate(prefabStructureNine, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costNine;
            dataBase.goldPerMinute += dataBase.sNineScore * 60; 
            dataBase.structureNine ++;
            PlayerPrefs.SetInt("structureNine", dataBase.structureNine);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
    }

    public void OnClickStructureTen()
    {
        if(dataBase.gold >= costTen)
        {
            GameObject structure = Instantiate(prefabStructureTen, new Vector3 (0,0,0), Quaternion.identity) as GameObject;
            structure.transform.parent = GameObject.Find("StructureHandler").transform;
            dataBase.gold -= costTen;
            dataBase.goldPerMinute += dataBase.sTenScore * 60; 
            dataBase.structureTen ++;
            PlayerPrefs.SetInt("structureTen", dataBase.structureTen);
        }
        else
        {
           Debug.Log("Nothing"); 
        }
    }
}
