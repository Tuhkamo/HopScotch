using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TappoScript : MonoBehaviour
{
    public static int ohjeNro = 0;

    public void Start()
    {
        ohjeNro = 0;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ruutu" || collision.gameObject.tag == "TuplaRuutu" || collision.gameObject.tag == "SamaRuutu")
        {
            GameObject.Find("SceneInfo").GetComponent<Text>().text = SceneManager.GetActiveScene().name;
            DontDestroyOnLoad(GameObject.Find("SceneInfo"));
            SceneManager.LoadScene("RuutuPutosi");
        }
        else if (collision.gameObject.tag == "Stop")
        {
            NopeusScript.nopeus = 0;
            switch (ohjeNro)
            {
                case 0:
                    GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "Vasemassa yläkulmassa näkyy pisteesi. Oikealla elämäsi.";
                    GameObject.Find("JatkaNappi").GetComponent<Button>().enabled = true;
                    GameObject.Find("JatkaNappi").GetComponent<Text>().enabled = true;
                    GameObject.Find("Pistemaara").GetComponent<Text>().enabled = true;
                    GameObject.Find("3_helaa").GetComponent<Image>().enabled = true;
                    GameObject.Find("2_helaa").GetComponent<Image>().enabled = true;
                    GameObject.Find("1_helaa").GetComponent<Image>().enabled = true;
                    GameObject.Find("ElamaNuoli").GetComponent<SpriteRenderer>().enabled = true;
                    GameObject.Find("PisteNuoli").GetComponent<SpriteRenderer>().enabled = true;
                    ohjeNro++;
                    break;

                case 1:
                    GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "Kokeile painaa laattaa! Siitä saa pisteitä. Numeron punainen väri kertoo järjestyksen.";
                    GameObject.Find("Ruutu").GetComponent<Button>().interactable = true;
                    ohjeNro++;
                    break;

                case 2:
                    GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "Mustia laattoja pitää painaa kaksi kertaa :O";
                    GameObject.Find("TuplaRuutu").GetComponent<Button>().interactable = true;
                    ohjeNro++;
                    break;

                case 3:
                    GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "Samalla numerolla merkittyjä laattoja pitää painaa yhtäaikaa.";
                    GameObject.Find("SamaRuutu").GetComponent<Button>().interactable = true;
                    GameObject.Find("SamaRuutu (1)").GetComponent<Button>().interactable = true;
                    ohjeNro++;
                    break;

                case 4:
                    GameObject.Find("OhjeTeksti").GetComponent<Text>().text = "Voi ei! D: Laatan numero on liian suuri. Katsotaan mitä tapahtuu kun sitä painaa.";
                    GameObject.Find("Laatta").GetComponent<Button>().interactable = true;
                    ohjeNro++;
                    break;
            }
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
