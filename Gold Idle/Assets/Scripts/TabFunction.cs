using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabFunction : MonoBehaviour
{
    [Header("DataBase Object")]
    public DataBase dataBase;

    [Header("Standard score per hit")]
    public int standardScoreHit = 1;


    
    
    public void OnClickTabGold()
    {
        if(dataBase.structureOne > 0)
            dataBase.gold += dataBase.structureOne * dataBase.sOneScore * standardScoreHit;

        else
            dataBase.gold += standardScoreHit;

    }
}
