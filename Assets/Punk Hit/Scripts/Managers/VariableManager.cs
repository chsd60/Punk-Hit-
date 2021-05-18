using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Variables))]
public class VariableManager : MonoBehaviour
{
    private Variables sceneVariables;

    private void Start()
    {
        sceneVariables = GetComponent<Variables>();

        // Tramite sceneVariables.declarations ho accesso alle variabili di Visual Scripting
    }

    public int GetPoints()
    {
        return sceneVariables.declarations.Get<int>("punti");
    }

    public void SetPoints(int points)
    {
        sceneVariables.declarations.Set("punti", points);
    }

    public void AddPoints(int points)
    {
        SetPoints(GetPoints() + points);
    }

    public bool GetFan(int index)
    {
        return sceneVariables.declarations.Get<List<bool>>("listaFan")[index];
    }

    public void SetFan(int index, bool value = true)
    {
        sceneVariables.declarations.Get<List<bool>>("listaFan")[index] = value;
    }
}
