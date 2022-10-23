using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicGate : Component
{
    public Gate logicGate;
    public float prevTime = 0;
    public float delay = .01F;
    void Update()
    {
        logicGate.input = input;
        if(Time.time - prevTime > delay){
        prevTime = Time.time;
        operating_function();
        }
        drawConnectionToInput();

    }

    override public bool operating_function(){
        functionoutput = logicGate.logicFunction();
        return functionoutput;
    }
    override public void drawConnectionToInput(){
        foreach(Component i in input){
            Debug.DrawLine(gameObject.transform.position, i.gameObject.transform.position);
        }
    }

}
