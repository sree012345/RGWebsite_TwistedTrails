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

}
