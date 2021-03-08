using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JatkaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("SceneInfo").GetComponent<Text>().text == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (GameObject.Find("SceneInfo").GetComponent<Text>().text == "Level2")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (GameObject.Find("SceneInfo").GetComponent<Text>().text == "Level3")
        {
            SceneManager.LoadScene("Credits");
        }
    }
}