using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int currentLevel;

    private int rocketItemsCollected;
    public int totalPartsToCollect;

    private int totalPoints;

    private int totatlDeaths;

    // level
    public void setCurrentLevel(int _currentLevel)
    {
        currentLevel = _currentLevel;
    }

    public int GetCurrentLevel()
    {
        return currentLevel;

    }

    // Rocket parts
    public void AddCollectedRocketPart() 
    {
        rocketItemsCollected++;
    }

    public void PlayerDead() 
    {
        // stop game
        // que death menu
    }

    public void AddToTotalPoints(int points) 
    {
        totalPoints += points;
    }

    public void pause() 
    {
        // stop game
        // show pause menu
    }

    // death
    public void AddDeath() 
    {
        totatlDeaths += 1;
    }
}
