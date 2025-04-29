using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Public variables
    public int points;

    // Private variables

    /// <summary>
    /// OnTriggerEnter
    ///     Core Unity Method
    ///     This method runs only on frames where another object
    ///     with a Collider component enters the Collider of this
    ///     game object. 
    ///     Requires the Collider component on this game object to
    ///     be set as 'Trigger' otherwise it will act as a physical
    ///     object.
    /// </summary>
    void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;

        if(tag == "Player")
        {
            Debug.Log(gameObject.name + " collected. " + points + " points received!");
            Destroy(gameObject);
        }
    }
}
