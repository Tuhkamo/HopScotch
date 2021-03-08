using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UudestaanScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Level1")
        {
            SceneManager.LoadScene("Level1");
        }
        else if (gameObject.name == "Level2")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (gameObject.name == "Level3")
        {
            SceneManager.LoadScene("Level3");
        }
        else if (gameObject.name == "Tutorial")
        {
            SceneManager.LoadScene("Tutorial");
        }
        else if (gameObject.name == "Credits")
        {
            SceneManager.LoadScene("Credits");
        }
        else
        {
            Debug.Log("Taso pelataan uudestaan");
            SceneManager.LoadScene(GameObject.Find("SceneInfo").GetComponent<Text>().text);
        }
    }
}
