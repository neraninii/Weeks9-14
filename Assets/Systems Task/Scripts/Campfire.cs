using UnityEngine;
using UnityEngine.Events;


public class Campfire : MonoBehaviour
{

    //variable for the campfire sprite
    public SpriteRenderer logs; 

    //boolean and UnityEvent variables to check proximity to campfire and conditionals based on such
    public bool nearFire = false; 
    public UnityEvent OnHeat; 
    public UnityEvent NotHeat; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //condiitonal statement that checks if the player is within the bounds of the campfire

        if(logs.bounds.Contains(transform.position) == true)
        {
            if (nearFire == true)
            {
                
            }
            else
            {
                //UnityEvent for when the player is near the campfire 
                OnHeat.Invoke();
                nearFire = true;
                Debug.Log("entered heat");
            }


        }
        else
        {
            if(nearFire == true)
            {
                //UnityEvent for when the player is out of the campfire
                NotHeat.Invoke();
                nearFire = false;
                Debug.Log("exited heat");
            }
            else
            {
                
            }
        
        }
        
        
    }
    


}
