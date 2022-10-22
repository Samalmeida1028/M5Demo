using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Component : MonoBehaviour
{
    /* this is the abstract function defining what a component is, we use this
     * to allow us to swap different "components" in our circuit
     * is kind of similar to how you can swap components on objects
     */
    public List<Component> input;
    public List<Component> output;
    public bool functionoutput;
    public abstract bool operating_function();
    public abstract void drawConnectionToInput();
}
