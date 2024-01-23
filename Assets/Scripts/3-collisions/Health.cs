using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health;

    public void DecreaseHealth()
    {
        health -= 1;
    }

    public int GetHealth()
    {
        return health;
    }

    public void AddHealth()
    {
        health += 1;
    }


}
