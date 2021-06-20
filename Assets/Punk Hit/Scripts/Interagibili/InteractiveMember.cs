using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveMember : InteractiveActivate {

    protected override void Interact() {
        base.Interact();
        Time.timeScale = 0;
    }
}
