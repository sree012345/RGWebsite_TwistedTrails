using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    public static ui Instance;
    public GameObject helppanel;
    public AudioSource sounds;
    public AudioSource plugInSound;
    public static int  addNo;

    public GameObject play;
    public GameControllerScript GameControllerScriptAds;
   

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
        }

        GameObject.Find("Plane").transform.localScale=new Vector3(5, 4, 7);
        GameObject.Find("Sphere").SetActive(false);

        if(PlayerPrefs.GetInt("Playbtn127")==0)
        {
            play.SetActive(true);
        }
        else
        {
            play.SetActive(false);
            PlayerPrefs.SetInt("Playbtn127", 0);
        }

    }
    public void nextlevel()
    {
        PlayerPrefs.SetString("NextLevel127", "1");
        GameControllerScriptAds.SomeMethod();
        PlayNextLevelMessageFromWeb();



    }
    
    public void restart()
    {
        PlayerPrefs.SetInt("Playbtn127", 1);
        PlayerPrefs.SetString("Restart127", "2");
        GameControllerScriptAds.SomeMethod();
        PlayNextLevelMessageFromWeb(); 
    }

    //public void onplaybuttonclicked()
    //{
    //    PlayerPrefs.SetString("Play127", "3");
    //    GameControllerScriptAds.SomeMethod();
    //}

     
    public void PlayNextLevelMessageFromWeb()
    {
        if (PlayerPrefs.GetString("Restart127") == "2")
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetString("Restart127", "");

        }
        else if (PlayerPrefs.GetString("NextLevel127")== "1")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetString("NextLevel127", "");

        }
        //{
        //    //if (addNo == 1)
        //    //{
        //    //    addNo = 0;
        //    //    //AdManager.instance.ShowAd();
        //    //}
        //    //else
        //    //    addNo++;
        //   // Debug.Log(addNo);
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        //}

    }




    public void looplevel()
    {
        PlayerPrefs.SetInt("level127", 1);
        SceneManager.LoadScene(1);
    }
    public void helppanelon()
    {
        helppanel.SetActive(true);
    }
    public void closehelppanel()
    {
        helppanel.SetActive(false);
    }
    public void PrivacyPolicy()
    {
        Application.OpenURL("https://seepeegames.blogspot.com/2020/01/privacy-policy-this-privacy-policy.html#more");
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && helppanel)
        {
            Debug.Log("on to off");
            helppanel.SetActive(false);
        }
    }
    

}
