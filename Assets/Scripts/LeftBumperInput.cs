using UnityEngine;
using UnityEngine.InputSystem;

using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperControl : MonoBehaviour
{

    int bumpLeftCooldown;
    Rigidbody2D flipperLeft;
    
    public GameObject rightBumper;
    
    InputAction bumpLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flipperLeft = GetComponent<Rigidbody2D>();

        flipperLeft.centerOfMass = (Vector2.zero);
        
        bumpLeft = InputSystem.actions.FindAction("Left1");
        bumpLeftCooldown = 45;
    }
    
    // Update is called once per frame
    void Update()
    {
        bumpLeftCooldown--;
        if (bumpLeft.IsPressed() && bumpLeftCooldown < 0)
        {
            flipperLeft.angularVelocity = 1200f;
        }

        else
        {
            flipperLeft.angularVelocity = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, 5f * Time.deltaTime);
        }
    }
}