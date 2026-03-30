using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class Knight : MonoBehaviour
{
    public AudioSource SFX;
    public Animator animatorController;
    public CinemachineImpulseSource shake;
    public Vector2 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>(); 
        animatorController.SetBool("move", true);

    }

    public void Footsteps()
    {
        //Debug.Log("STEP!");
        SFX.Play();
    }

    public void Shaking()
    {
        shake.GenerateImpulse();
    }
}
