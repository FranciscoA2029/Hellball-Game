using UnityEngine;
using UnityEngine.InputSystem;

public class RightBumperInput : MonoBehaviour
{
    int bumpRightCooldown;
    Rigidbody2D flipperRight;
    
    public GameObject rightBumper;
    
    InputAction bumpRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flipperRight = GetComponent<Rigidbody2D>();

        flipperRight.centerOfMass = (Vector2.zero);
        
        bumpRight = InputSystem.actions.FindAction("Right1");
        bumpRightCooldown = 45;
    }
    
    // Update is called once per frame
    void Update()
    {
        bumpRightCooldown--;
        if (bumpRight.IsPressed() && bumpRightCooldown < 0)
        {
            flipperRight.angularVelocity = -1200f;
        }

        else
        {
            flipperRight.angularVelocity = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, 5f * Time.deltaTime);
        }
    }
}
