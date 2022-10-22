using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gate : MonoBehaviour
{
    public List<Component> input;

    public abstract bool logicFunction();
}
