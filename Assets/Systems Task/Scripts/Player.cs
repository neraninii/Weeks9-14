using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Animator animatorController;
    public float speed = 5; 
    public Vector2 movement; 

    public Slider freezeBar;
    public SpriteRenderer player;

    public float freezeMax = 20;
    public float freezeValue = 0; 

    public bool checkHeat = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        freezeBar.maxValue = freezeMax;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position += (Vector3)movement * speed * Time.deltaTime;

        if (checkHeat == false)
        {
            FreezeUp();
        }
        else
        {
            HeatUp();
        }

        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        animatorController.SetFloat("horizontal", movement.x);
        animatorController.SetFloat("vertical", movement.y);
    }

    public void HeatUp()
    {
        freezeValue -= Time.deltaTime; 
        freezeBar.value = freezeValue;
        checkHeat = true; 

        if (freezeValue < -2)
        {
            freezeValue = -1; 
        }


    }

    public void FreezeUp()
    {
        freezeValue += Time.deltaTime;
        freezeBar.value = freezeValue;
        checkHeat = false; 

        if (freezeValue > 22)
        {
            freezeValue = 21; 
        }
    }
}


