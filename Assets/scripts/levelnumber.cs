using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class levelnumber : MonoBehaviour
{
    private TMP_Text level;
    private int levelnum;
    void Start()
    {
        level = GetComponent<TMP_Text>();
        levelnum = SceneManager.GetActiveScene().buildIndex;
        level.text = "LEVEL " + levelnum.ToString();
    }
    void Update()
    {
        
    }
}
