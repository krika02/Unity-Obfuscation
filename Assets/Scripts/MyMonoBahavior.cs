using UnityEngine;

/// <summary>
/// Everything in this class can be obfuscated
/// </summary>
public class MyMonoBahavior : BahaviorEventBinder
{
    private float _v = 0.1f;
    private SpriteRenderer _renderer;

    public MyMonoBahavior()
    {
        OnEnableExecuted += MyMonoBahavior_OnEnableExecuted;
        OnUpdateExecuted += MyMonoBahavior_OnUpdateExecuted;
        OnDisableExecuted += MyMonoBahavior_OnDisableExecuted;
    }

    private void MyMonoBahavior_OnEnableExecuted()
    {
        _renderer = transform.GetComponent<SpriteRenderer>();
    }

    private void MyMonoBahavior_OnUpdateExecuted()
    {
        var pos = transform.position;

        if (!_renderer.isVisible)
        {
            _v = _v * -1;
        }

        transform.position = new Vector3(pos.x + _v, pos.y,pos.z);
    }

    private void MyMonoBahavior_OnDisableExecuted()
    {
        OnEnableExecuted -= MyMonoBahavior_OnEnableExecuted;
        OnUpdateExecuted -= MyMonoBahavior_OnUpdateExecuted;
        OnDisableExecuted -= MyMonoBahavior_OnDisableExecuted;
    }
}