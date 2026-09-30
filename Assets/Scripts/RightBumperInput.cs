using UnityEngine;
using UnityEngine.InputSystem;

public class RightBumperInput : MonoBehaviour
{
    int bumpRightCooldown;
    
    
    
    public GameObject rightBumper;
    
    InputAction bumpRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bumpRight = InputSystem.actions.FindAction("Right1");
        bumpRightCooldown = 45;
    }

    // Update is called once per frame
    void Update()
    {
        bumpRightCooldown--;
        if (bumpRight.WasReleasedThisFrame() && bumpRightCooldown < 0)
        {
            bumpRightCooldown = 45;
            Debug.Log("Bumped RIGHT SIDE");
            
        }
    }
}
