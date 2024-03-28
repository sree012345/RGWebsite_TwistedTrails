using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void LevelOver(string message , string gameId , string levelNo);

    [DllImport("__Internal")]
    private static extern void ShowAds(string message);


    public void SomeMethod()
    {
        print("sendMessageToReact");
#if UNITY_WEBGL == true && UNITY_EDITOR == false
  print("sendMessageToReact1");
  Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of the scene
        string sceneName = currentScene.name;
    LevelOver ("Level Completed" , "1" , "");
#endif
    }

    public void ShowAdvertisement()
    {
        print("sendMessageToReact");
#if UNITY_WEBGL == true && UNITY_EDITOR == false
  print("sendMessageToReact1");
    ShowAds ("Show Advertisement");
#endif
    }
}