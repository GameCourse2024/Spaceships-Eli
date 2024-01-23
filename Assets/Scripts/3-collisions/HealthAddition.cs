using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAddition : MonoBehaviour
{
    [Tooltip("Probability of giving a life point (0 to 1)")]
    [Range(0f, 1f)]
    [SerializeField]
    private float lifeProbability = 0.5f;
   private void OnTriggerEnter2D(Collider2D other)
   {
       if(other.CompareTag("Laser"))
       {
            Health health1 = FindObjectOfType<Health>();
            if(health1 != null)
            {
                if (Random.value < lifeProbability)
                {
                    health1.AddHealth();
                    Debug.Log("Added player health, new health: " + health1.GetHealth());
                }
            }
       }
   }
}
