using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 10f;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("здоровье игрока:" + health);
    }

}
