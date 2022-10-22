using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock: Component
{
    public float period;
    public float dutycycle;
    public float prevTime;
    public float cycle;
    bool tempFunctionout;
    void Start()
    {
        prevTime = Time.time;
        tempFunctionout = false;
    }
    void FixedUpdate()
    {
        operating_function();
        
    }

    override public bool operating_function(){
        float deltaTime = Time.time - prevTime;
        cycle = (float)period*dutycycle;
        if(deltaTime < period){
            if(deltaTime < cycle){
                functionoutput = true;
                tempFunctionout = functionoutput;
            }
            else{
                functionoutput = false;
                tempFunctionout = functionoutput;
            }
        }
        else{
            prevTime = Time.time;
            functionoutput = tempFunctionout;
        }
        return functionoutput;
    }

    override public void drawConnectionToInput(){
        foreach(Component i in input){
            Debug.DrawLine(gameObject.transform.position, i.gameObject.transform.position);
        }
    }
}