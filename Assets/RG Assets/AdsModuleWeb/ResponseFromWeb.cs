using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseFromWeb : MonoBehaviour
{
    private bool isPause = false;

    public void MyFunction(string param)
    {
        print("param" + param);
        //  errorPopup.SetActive(true);
        Application.Quit();
    }

    public void errorPopupOkayBtnClicked()
    {
        //errorPopup.SetActive(false);
    }

    public void PauseFunction(string param)
    {
        if (!isPause)
        {
            print("PauseGame");
            isPause = true;
            print("isPause" + isPause);
            PlayerPrefs.SetFloat("TT127_Pause", Time.timeScale);
            print("time" + PlayerPrefs.GetFloat("TT127_Pause"));
            AudioListener.pause = true;
            Time.timeScale = 0;
        }
    }

    public void UnPauseFunction(string param)
    {
        if (isPause)
        {
            print("UnpauseGame");
            print("PauseGame");
            isPause = false;
            print("PauseGame");
            print("time" + PlayerPrefs.GetFloat("TT127_Pause"));
            Time.timeScale = PlayerPrefs.GetFloat("TT127_Pause");
            AudioListener.pause = false;
        }
    }

}
