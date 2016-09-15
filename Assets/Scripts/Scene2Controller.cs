using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Do not obfuscate the name of this class
/// </summary>
public class Scene2Controller : BahaviorEventBinder
{
    public Scene2Controller()
    {
        OnEnableExecuted += Scene2Controller_OnEnableExecuted;
        OnDisableExecuted += Scene2Controller_OnDisableExecuted;
    }

    private void Scene2Controller_OnEnableExecuted()
    {
        var myPrefab = Resources.Load<GameObject>("MyPrefab");

        // Add instantiate a gameObject
        GameObject.Instantiate(myPrefab, new Vector3(), Quaternion.identity);

    }

    private void Scene2Controller_OnDisableExecuted()
    {
        OnEnableExecuted -= Scene2Controller_OnEnableExecuted;
        OnDisableExecuted -= Scene2Controller_OnDisableExecuted;
    }

}
