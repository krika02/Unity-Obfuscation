using UnityEngine;

/// <summary>
/// Do not obfuscate loose typed methods (Update,OnEnable and OnDisable)
/// </summary>
public class BahaviorEventBinder : MonoBehaviour
{
    public event UpdateExecutedDelegate OnUpdateExecuted;
    public delegate void UpdateExecutedDelegate();

    public event OnEnableDelegate OnEnableExecuted;
    public delegate void OnEnableDelegate();

    public event OnDisableDelegate OnDisableExecuted;
    public delegate void OnDisableDelegate();

    public event OnTriggerEnter2Delegate OnTriggerEnter2DExecuted;
    public delegate void OnTriggerEnter2Delegate(Collider2D col);

    public event OnTriggerExit2DDelegate OnTriggerExit2DExecuted;
    public delegate void OnTriggerExit2DDelegate(Collider2D col);

    void Update()
    {
        if (OnUpdateExecuted != null)
        {
            OnUpdateExecuted();
        }
    }

    void OnEnable()
    {
        if (OnEnableExecuted != null)
        {
            OnEnableExecuted();
        }
    }

    void OnDisable()
    {
        if (OnDisableExecuted != null)
        {
            OnDisableExecuted();
        }
    }
}