using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDGate : Gate
{
    
    override public bool logicFunction(){
        bool temp = true;
        foreach (Component c in input)
        {
            temp = (temp && c.functionoutput);
        }
        return temp;
    }
}
