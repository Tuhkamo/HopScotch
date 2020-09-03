using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkanneriScript : MonoBehaviour
{
    public int ruutuNro = 1;
    public int input;

    public void OnTriggerExit2D(Collider2D other)
    {
        /* Vanhaa scriptiä, kokeilin eri tapoja laskea ruutujen määrää
         * if (gameObject.tag == "Ruutu")
         {
             ruutuNro++;
             Debug.Log(ruutuNro);
         }
         else if (gameObject.tag != "Ruutu")
         {
             Debug.Log("Hmm");
         }*/
        if (ruutuNro == input)
        {
            GameObject.Find("SceneInfo").GetComponent<Text>().text = SceneManager.GetActiveScene().name;
            DontDestroyOnLoad(GameObject.Find("SceneInfo"));
            SceneManager.LoadScene("VoittoScene");
        }
        Debug.Log(ruutuNro);
        GetComponent<AudioSource>().Play(0);
        ruutuNro++;
    }
}
