using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORGate : Gate
{
    override public bool logicFunction(){
        bool temp = false;
        foreach (Component c in input)
        {
            temp = temp || c.functionoutput;
        }
        return temp;
    }
}
