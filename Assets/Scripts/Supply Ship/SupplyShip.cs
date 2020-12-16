using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplyShip : MonoBehaviour
{
    //Supply items[]; supply items of type supply
    private int Health;

    private float boatTimeLimit;

    private float speed;


    //speed
    public void setSpeed(float _speed) 
    {
        speed = _speed;
    }

    // boat time
    public void setBoatTime(float time) 
    {
        boatTimeLimit = time;
    }

    public float getBoatTime() 
    {
        return boatTimeLimit;
    }

    // health
    public void setHealth(int _Health) 
    {
        Health = _Health;
    }

    public void ApplyDamage(int damage) 
    {
        Health -= damage;
    }

    // actions
    private void Break() 
    {
        // play explode animation delete object
    }

    private void Destroy() 
    {
        // destroy game object
    }

    private void Leave() 
    {
        // leave game scene, then destory game object.
    }
}
