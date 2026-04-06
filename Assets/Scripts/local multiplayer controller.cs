using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class localmultiplayercontroller : MonoBehaviour
{
    public localmultiplayermanager manager;
    public PlayerInput playerInput;
    public Vector2 movementInput;
    public float speed = 5; 

    Coroutine attackCoroutine; 

    public AudioSource SFX;

    public AnimationCurve curve;

    public TrailRenderer trail;

    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movementInput * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {


        if(context.performed)
        {

            if (attackCoroutine != null)
            {
                StopCoroutine(attackCoroutine);
            }


            attackCoroutine = StartCoroutine(Squeeze());

            SFX.Play();  

        
            
            Debug.Log("Player " + playerInput.playerIndex + " Attack!");
            manager.PlayerAttacking(playerInput);
        }

    }


    IEnumerator Squeeze()
    {
        float t = 0; 
        transform.localScale = Vector2.one;

        while(t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector2.one * 1f * curve.Evaluate(t);
            yield return null; 
        }
    }

    public void emitting()
    {
            speed = 8;
            trail.emitting = true; 
    }



}

