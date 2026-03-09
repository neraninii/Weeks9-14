

using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInputs : MonoBehaviour
{
    public float speed = 5; 
    public Vector2 movement; 

    public Vector2 value;
    public AudioSource SFX;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += (Vector3)movement * speed * Time.deltaTime; 
        transform.position = movement;

        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = value.y * speed;
        transform.eulerAngles = newRotation;
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        //this is the same as Mouse.current.position.ReadValue()
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>()); 
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>(); 
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        value = context.ReadValue<Vector2>();
    }


    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("Attack! " + context.phase);
        if(context.performed == true)
        {
            SFX.Play();
        }
    }
}
