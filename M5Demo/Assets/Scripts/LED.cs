using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : Component
{
    public UnityEngine.Rendering.Universal.Light2D light;
    // the led takes advantage of unity 2d lighting to show an led "light"
    void Start(){

    }
    void Update()
    {
        operating_function();
        if(functionoutput){
            light.intensity = 1;
        }
        else{
            light.intensity = 0;
        }
        drawConnectionToInput();
    }

    override public bool operating_function(){
        foreach(Component c in input){
            if(c.functionoutput){
                functionoutput = true;
            }
            else{
                functionoutput = false;
            }
        }
        return true;
    }

    override public void drawConnectionToInput(){
        foreach(Component i in input){
            Debug.DrawLine(gameObject.transform.position,i.gameObject.transform.position);
        }
    }
}
