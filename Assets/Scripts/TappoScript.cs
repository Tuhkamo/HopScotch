using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TappoScript : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ruutu" || collision.gameObject.tag == "TuplaRuutu" || collision.gameObject.tag == "SamaRuutu")
        {
            GameObject.Find("SceneInfo").GetComponent<Text>().text = SceneManager.GetActiveScene().name;
            DontDestroyOnLoad(GameObject.Find("SceneInfo"));
            SceneManager.LoadScene("RuutuPutosi");
        }
    }
    private void Update()
    {
        if (RuutuScript.elamiamenetetty == 3)
        {
            GameObject.Find("SceneInfo").GetComponent<Text>().text = SceneManager.GetActiveScene().name;
            DontDestroyOnLoad(GameObject.Find("SceneInfo"));
            SceneManager.LoadScene("ElamatLoppui");
        }
    }
}
