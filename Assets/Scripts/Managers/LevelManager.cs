using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private float timeSpentOnLevel;

    public bool finishedLevel;
    private int Level;
    private int totalItemsToCollect; // auto update.
    private int points;

    public float getLevelTime() 
    {
        return timeSpentOnLevel;
    }

    // level
    public int GetLevel() 
    {
        return Level;
    }

    public void SetLevel(int _level) 
    {
        Level = _level;
    }


}
