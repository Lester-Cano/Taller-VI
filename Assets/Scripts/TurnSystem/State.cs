using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    protected TurnSystem TurnSystem;

    public State(TurnSystem turnSystem)
    {
        TurnSystem = turnSystem;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator CheckState()
    {
        yield break;
    }

    public virtual IEnumerator Think()
    {
        yield break;
    }
}
