using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearGun : MonoBehaviour
{
    private float ammo;

    public void AddAmmo() 
    {
        ammo += 1;
    }

    public void SubtractAmmo() 
    {
        ammo -= 1;
    }
}
