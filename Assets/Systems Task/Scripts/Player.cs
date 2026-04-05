using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    //variables for the player movement. 
    public Animator animatorController;
    public float speed = 5; 
    public Vector2 movement; 

    //variables for the freeze bar
    public Slider freezeBar;
    public SpriteRenderer player;

    public float freezeMax = 20;
    public float freezeValue = 0; 

    public bool checkHeat = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //setting the maximum of the freezing bar 

        freezeBar.maxValue = freezeMax;


    }

    // Update is called once per frame
    void Update()
    {
        //setting player movement

        transform.position += (Vector3)movement * speed * Time.deltaTime;

    //conditional to check either the increase or decrease of the freeze bar
        if (checkHeat == false)
        {
            FreezeUp();
        }
        else
        {
            HeatUp();
        }

    //conditional to slow down the player after a certain level of cold
        if (freezeValue > 16)
        {
            speed = 2; 
        }
        else
        {
            speed = 5;
        }

        
    }

    //Player Input
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        animatorController.SetFloat("horizontal", movement.x);
        animatorController.SetFloat("vertical", movement.y);
    }

    //To decrease the value of the freeze bar 
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

    //To increase the value of the freeze bar
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


