using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOTGate : Gate
{
    bool output;
    override public bool logicFunction(){

        foreach (Component c in input)
        {
            output = c.functionoutput;

        }

        return !output;
    }
}
