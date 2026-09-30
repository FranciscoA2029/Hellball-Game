using UnityEngine;
using UnityEngine.InputSystem;

public class LeftBumperInput : MonoBehaviour
{
    int bumpLeftCooldown;
    
    public GameObject leftBumper;
    
    InputAction bumpLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bumpLeft = InputSystem.actions.FindAction("Left1");
        bumpLeftCooldown = 45;
    }

    // Update is called once per frame
    void Update()
    {
        bumpLeftCooldown--;
        
        if (bumpLeft.WasReleasedThisFrame() && bumpLeftCooldown < 0)
        {
            bumpLeftCooldown = 45;
            Debug.Log("Bumped LEFT SIDE");
        }
    }
}
