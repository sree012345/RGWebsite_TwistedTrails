using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class decider : MonoBehaviour
{
    public selecter selecter;
    public Animator deviceanimation;
    private bool lefted;
    public int intouch;
    private float timer;
    public float starttime;
    public GameObject winpanel;
    private GameObject papereffect;
    void Start()
    {
        papereffect = GameObject.Find("papereffect");
        papereffect.SetActive(false);
        starttime = 0.75f;
        lefted = false;
        intouch = 0;
        timer = starttime;
        winpanel.SetActive(false);
        selecter = GameObject.Find("Main Camera").GetComponent<selecter>();
        deviceanimation.enabled = false;
    }
    void Update()
    {
        if (intouch == 0 && lefted)
        {
            //  Debug.Log("ntg happens");
        }
        else if (intouch == 0 && lefted != true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
              
                winpanel.SetActive(true);
                PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex + 1);
                Destroy(selecter);
                papereffect.SetActive(true);
                deviceanimation.enabled = true;
              //  Audiomanager.Instance.BgAudio.enabled = false;

            }
        }
        else
        {
            timer = starttime;
        }
    }
    public void stillincontact()
    {
        intouch++;
    }
    public void onincontact()
    {
        intouch--;
    }
    public void lefteed()
    {
        lefted = true;
    }
    public void dropeed()
    {
        lefted = false;
    }

}
