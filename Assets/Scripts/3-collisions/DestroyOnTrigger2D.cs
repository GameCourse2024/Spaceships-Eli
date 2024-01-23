using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == triggeringTag && enabled) 
        {
            if(this.gameObject.tag == "Player")
            {
                Health health1 = GetComponent<Health>();
                if(health1 != null)
                {
                    if(health1.GetHealth() > 1)
                    {
                        health1.DecreaseHealth();
                        Debug.Log("Crashed with player, decreasing health, new health: " + health1.GetHealth());
                    }
                    else
                    {
                        Debug.Log("Ran out of life points");
                        Destroy(this.gameObject);
                    }
                }
                
            }
            else
            {
                Destroy(this.gameObject);
            }
            
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
