using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOTGate : Gate
{
    override public bool logicFunction(){
        foreach (Component c in input)
        {
            return !(c.functionoutput);
        }
        return false;
    }
}
