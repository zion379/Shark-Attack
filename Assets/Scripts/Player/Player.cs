using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int Health = 100;

    public void ApplyDamage(int damage) 
    {
        Health -= damage; 
    }



    private void Move() 
    {
        // input system move.
    }

    public bool playerCanJumpOutOfWater;
    private void JumpOutOfWater() 
    {
        //  jump out of water
    }

    public void Dodge() 
    {
        // quick burst movements
    }

    public void Punch() 
    {
        // play punch animation and if shark is in distance due damage
    }

    public void Shoot() 
    {
        // shoot spear gun and instatiate spear
    }
}
