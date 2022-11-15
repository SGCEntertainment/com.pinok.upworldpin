using UnityEngine;
using Scenes = UnityEngine.SceneManagement.SceneManager;

class OrientationHelper
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    static void SetGameOrientation()
    {
        Screen.orientation = Scenes.sceneCount > 0 ? ScreenOrientation.AutoRotation : ScreenOrientation.Portrait;
    }
}