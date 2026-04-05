
using UnityEngine;

public class Options : MonoBehaviour
{
    //variables to input the sprite options
    public Sprite dialogue1; 
    public Sprite dialogue2; 
    public Sprite dialogue3; 

    //variable to get player script to reference freeze values
    public Player playerScript;

    public SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //getting the spriterenderer component at the beginning to change the sprites later on 
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void display()
    {
        //condiitonal to display a certain dialogue depending on the value of the freeze bar 
        if (playerScript.freezeValue > 15)
        {
            spriteRenderer.sprite = dialogue1;
        }
        else if (playerScript.freezeValue > 7)
        {
            spriteRenderer.sprite = dialogue2;
        }
        else
        {
            spriteRenderer.sprite = dialogue3;
        }
    }
}
