using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RuutuScript : MonoBehaviour
{
    // Määritellään muuttujat

    public int ruutuNro;
    public int ruudunNro;
    public static int elamiamenetetty;

    public static float pisteet;
    float viive;

    Button nappi;

    bool painettu = false;

    // Start is called before the first frame update
    void Start()
    {
        // Määrittelee mitä tapahtuu kun Ruudun "nappi"-komponenttia painetaan
        nappi = GetComponent<Button>();
        nappi.onClick.AddListener(NappiPainettu);

        // Määrittelee Ruudun putoamisnopeuden
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -NopeusScript.nopeus);


        // Hakee Ruudun numeron sen "text"-komponentista
        ruudunNro = int.Parse(GetComponentInChildren<Text>().text);

        pisteet = 0;
        elamiamenetetty = 0;
        viive = 0.25f;
    }

     /*Kokeilin tapaa, jonka avulla rivit pitäisi painaa rivi kerrallaan, mutta en saanut sitä toimimaan
    
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ruutu") ;
        GetComponent<Button>().interactable = true;
    }*/
    

    // Update is called once per frame
    void Update()
    {
        // Tiedän, että GameObject.Findia ei pitäisi käyttää varsinkaan jos objectia etsitään stringin avulla, mutta en tiennyt paremmasta tavasta kun aloitin projektin tekoa
        // Etsii SkanneriScriptistä ruutuNro muuttujan ja tarkistaa onko kyseisen ruudun numero sama. ruutuNroa kasvatetaan aina kuin ruutu poistuu colliderista
        ruutuNro = GameObject.Find("RuutuSkanneri").GetComponent<SkanneriScript>().ruutuNro;

        if (ruudunNro == ruutuNro)
        {
            // Muutetaan ruudun text-komponentin väriä
            GetComponentInChildren<Text>().color = Color.red;
        }
    }


    // En ole kovin tyytyväinen tähän toteutustapaan ja tiedän, että se ei ole optimaalinen tai tehokas
    // NappiPainettu() tarkistaa munkätyyppistä ruutua painetaan, onko pelaajalla elämiä ja lisää pisteitä ruudun sijainnin perusteella
    public void NappiPainettu()
    {
        if (gameObject.tag == "Ruutu")
        {
            if (ruudunNro == ruutuNro)
            {
                pisteet += gameObject.transform.position.y * 100;
                GameObject.Find("Pistemaara").GetComponent<Text>().text = "Pisteet: " + Mathf.Round(pisteet).ToString();
                gameObject.SetActive(false);
            }
            else if (ruudunNro != ruutuNro)
            {
                if (elamiamenetetty == 0)
                {
                    GameObject.Find("3_helaa").SetActive(false);
                    elamiamenetetty++;
                }
                else if (elamiamenetetty == 1)
                {
                    GameObject.Find("2_helaa").SetActive(false);
                    elamiamenetetty++;
                }
                else if (elamiamenetetty == 2)
                {
                    GameObject.Find("1_helaa").SetActive(false);
                    elamiamenetetty++;

                }
            }
        }
        else if (gameObject.tag == "TuplaRuutu")
        {
            if (painettu == true && ruudunNro == ruutuNro)
            {
                pisteet += (gameObject.transform.position.y * 10) + 100;
                GameObject.Find("Pistemaara").GetComponent<Text>().text = "Pisteet: " + Mathf.Round(pisteet).ToString();
                gameObject.SetActive(false);
            }
            else if (ruudunNro == ruutuNro)
            {
                painettu = true;
            }
            else if (ruudunNro != ruutuNro)
            {
                if (elamiamenetetty == 0)
                {
                    GameObject.Find("3_helaa").SetActive(false);
                    elamiamenetetty++;
                }
                else if (elamiamenetetty == 1)
                {
                    GameObject.Find("2_helaa").SetActive(false);
                    elamiamenetetty++;
                }
                else if (elamiamenetetty == 2)
                {
                    GameObject.Find("1_helaa").SetActive(false);
                    elamiamenetetty++;

                }
            }
        }
        else if (gameObject.tag == "SamaRuutu")
        {
            if (ruudunNro == ruutuNro)
            {
                pisteet += gameObject.transform.position.y * 100;
                GameObject.Find("Pistemaara").GetComponent<Text>().text = "Pisteet: " + Mathf.Round(pisteet).ToString();
                StartCoroutine(LateCall());
                IEnumerator LateCall()
                {
                    yield return new WaitForSeconds(viive);

                    gameObject.SetActive(false);
                }
            }
            else if (ruudunNro > ruutuNro)
            {
                if (elamiamenetetty == 0)
                {
                    GameObject.Find("3_helaa").SetActive(false);
                    elamiamenetetty++;
                }
                else if (elamiamenetetty == 1)
                {
                    GameObject.Find("2_helaa").SetActive(false);
                    elamiamenetetty++;
                }
                else if (elamiamenetetty == 2)
                {
                    GameObject.Find("1_helaa").SetActive(false);
                    elamiamenetetty++;

                }
            }
            else if (ruudunNro < ruutuNro)
            {
                if (elamiamenetetty == 0)
                {
                    GameObject.Find("3_helaa").SetActive(false);
                    elamiamenetetty++;
                    gameObject.SetActive(false);
                }
                else if (elamiamenetetty == 1)
                {
                    GameObject.Find("2_helaa").SetActive(false);
                    elamiamenetetty++;
                    gameObject.SetActive(false);
                }
                else if (elamiamenetetty == 2)
                {
                    GameObject.Find("1_helaa").SetActive(false);
                    elamiamenetetty++;
                    gameObject.SetActive(false);
                }
            }
        }
    }
        
}
