using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XORGate : Gate
{       //this is just the logic function for XOR gates
    override public bool logicFunction(){
        int internalcount = 0;
        foreach (Component c in input)
        {
            if(c.functionoutput)
            internalcount++;
        }
        return ((internalcount % 2)==1);
    }
}
