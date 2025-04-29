using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Require Component
///     Defines what components must be attached to the game object
///     this script is also attached to. If the game object does not
///     have this component before adding the script, Unity will
///     automatically add it to the game object for you.
/// </summary>
[RequireComponent(typeof(Rigidbody))]

public class MouseMove : MonoBehaviour
{
    // Public variables (visible in inspector and to other scripts)
    public float moveSpeed;

    // Private variables (hidden in inspector and to other scripts)
    private Rigidbody rb;

    /// <summary>
    /// Start
    ///     Core Unity Method
    ///     Runs *before* the first frame update when this object is
    ///     loaded into the scene. This is best used for setting up
    ///     variable default values, checking if components or objects
    ///     exist, and obtaining any references to other objects or
    ///     scripts if required later on.
    /// </summary>
    void Start()
    {
        // Saves a reference to the 'Rigidbody' component on this object
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// FixedUpdate
    ///     Core Unity Method
    ///     Runs *after* the regular 'Update' method, and is designed
    ///     to be used for physics-based calculations and updates. This
    ///     method is run at a fixed update interval separate from the
    ///     game's frame-rate, which makes physics calculations more
    ///     consistent.
    /// </summary>
    void FixedUpdate()
    {
        // Get the player input from 'WSAD' keys using Unity Input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        // Create vector representing combined input direction
        Vector3 inputDirection = new Vector3(moveX, 0, moveZ);

        // Apply force to player object using input direction and speed
        rb.AddForce(inputDirection.normalized * moveSpeed);
    }
}
