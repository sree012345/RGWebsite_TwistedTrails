using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    
        //StartCoroutine(LoadSceneMode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(PlayerPrefs.GetInt("level127", 1));
    }
}
