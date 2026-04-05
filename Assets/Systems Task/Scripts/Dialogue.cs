
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
     //variable for the NPC sprite
    public SpriteRenderer NPC; 

    //boolean and UnityEvent variables to check proximity to NPC and conditionals based on such
    public bool nearNPC = false;

    public UnityEvent OnSpeak;

    public UnityEvent NotSpeak; 

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
        //condiitonal statement that checks if the player is within the bounds of the NPC
        if(NPC.bounds.Contains(transform.position) == true)
        {
            if (nearNPC == true)
            {
                
            }
            else
            {
                //UnityEvent for when the player is near the NPC
                OnSpeak.Invoke(); 
                nearNPC = true; 
            }
        }
        else
        {
            if (nearNPC == true)
            {
                //UnityEvent for when the player is away from the NPC
                NotSpeak.Invoke();
                nearNPC = false;
            }
            else
            {
                
            }
        }
    }


}
