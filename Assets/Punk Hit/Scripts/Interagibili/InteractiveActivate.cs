using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveActivate : InteractiveBase {

    public UnityEvent activateActions;

    protected override void Interact() {
        activateActions.Invoke();
    }
}
