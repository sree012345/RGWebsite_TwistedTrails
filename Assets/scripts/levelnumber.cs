using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class levelnumber : MonoBehaviour
{
    private Text level;
    private int levelnum;
    void Start()
    {
        level = GetComponent<Text>();
        levelnum = SceneManager.GetActiveScene().buildIndex;
        level.text = "LEVEL " + levelnum.ToString();
    }
    void Update()
    {
        
    }
}
