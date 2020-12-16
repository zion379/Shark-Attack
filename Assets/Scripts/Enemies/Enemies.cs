using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Enemies
{
    int Health { get; set; }
    float speed { get; set; }

    void ApplyDamage(int damage);

    void Attack();

    void Move();
}
