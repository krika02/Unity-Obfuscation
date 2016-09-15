using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Do not obfuscate the name of this class
/// </summary>
public class Scene1Controller : BahaviorEventBinder
{
    public Scene1Controller()
    {
        OnEnableExecuted += Scene1Controller_OnEnableExecuted;
        OnDisableExecuted += Scene1Controller_OnDisableExecuted;
    }

    private void Scene1Controller_OnEnableExecuted()
    {
        new MyMonoBahaviorRegistrator().Registrate();

        // Done registrating all prefabs, go to next scene
        SceneManager.LoadScene("Scene2");
    }

    private void Scene1Controller_OnDisableExecuted()
    {
        OnEnableExecuted -= Scene1Controller_OnEnableExecuted;
        OnDisableExecuted -= Scene1Controller_OnDisableExecuted;
    }
}