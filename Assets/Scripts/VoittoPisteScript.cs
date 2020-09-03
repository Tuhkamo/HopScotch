using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoittoPisteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("VoittoPisteet").GetComponent<Text>().text = "Pisteesi: " + Mathf.Round(VoittoInfoScript.voittoPisteet).ToString();
    }
}
