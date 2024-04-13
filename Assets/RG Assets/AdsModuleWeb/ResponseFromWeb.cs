using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResponseFromWeb : MonoBehaviour
{
   // public GameObject errorPopup;

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
        print("PauseGame");
        AudioListener.pause = true;
        Time.timeScale = 0;
    }

    public void UnPauseFunction(string param)
    {
        print("UnpauseGame");
        Time.timeScale = 1;
        AudioListener.pause = false;
    }

}
