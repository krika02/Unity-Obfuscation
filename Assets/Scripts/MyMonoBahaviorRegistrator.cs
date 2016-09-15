using UnityEngine;

/// <summary>
/// Everything in this class can be obfuscated
/// </summary>
public class MyMonoBahaviorRegistrator
{
    public void Registrate()
    {
        var gm = Resources.Load<GameObject>("MyPrefab");
        var s = gm.GetComponent<MyMonoBahavior>();
        if (s == null)
        {
            s = gm.AddComponent<MyMonoBahavior>();
        }
    }
}
