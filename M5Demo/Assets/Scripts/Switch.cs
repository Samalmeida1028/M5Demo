using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Component
{
    public bool switch_input;
    public Sprite switchOn;
    public Sprite switchOff;
    SpriteRenderer spriteRenderer;
    public KeyCode keypress;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        operating_function();
        
    }

    override public bool operating_function(){
        if(Input.GetKey(keypress)){
            switch_input = true;
        }
        else{
            switch_input = false;
        }
        if(switch_input){
            spriteRenderer.sprite = switchOn;
            functionoutput = true;
        }
        else{
            spriteRenderer.sprite = switchOff;
            functionoutput = false;
        }
        return functionoutput;
    }
    override public void drawConnectionToInput(){
        foreach(Component i in input){
            Debug.DrawLine(gameObject.transform.position, i.gameObject.transform.position, Color.black, 1f);
        }
    }
}
