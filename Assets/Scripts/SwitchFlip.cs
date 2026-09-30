using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchFlip : MonoBehaviour
{
    
    Rigidbody2D flipBody;
    InputAction right;
    [SerializeField] float rotationForce;
    [SerializeField] float rotationSpeedLimit;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flipBody = GetComponent<Rigidbody2D>();
        right = InputSystem.actions.FindAction("Right");
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Mathf.Abs(flipBody.angularVelocity) < rotationSpeedLimit)
        {
            Debug.Log("Flipping");
            flipBody.AddTorque(rotationForce, ForceMode2D.Impulse);
        }
        
    }
}
