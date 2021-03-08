using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialNappiScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Start);

        NopeusScript.nopeus = 2;
        GameObject.Find("JatkaNappi").GetComponent<Button>().enabled = false;
        GameObject.Find("JatkaNappi").GetComponent<Text>().enabled = false;
        GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "";

        switch (TappoScript.ohjeNro)
        {
            case 1:
                GameObject.Find("ElamaNuoli").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("PisteNuoli").GetComponent<SpriteRenderer>().enabled = false;
                break;

            case 5:
                SceneManager.LoadScene("Valikko");
                break;

            default:
                GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "";
                break;
        }
    }
}
