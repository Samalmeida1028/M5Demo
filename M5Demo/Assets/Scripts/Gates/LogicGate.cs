using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicGate : Component
{
    public Gate logicGate;
    void Update()
    {
        logicGate.input = input;
        operating_function();
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
