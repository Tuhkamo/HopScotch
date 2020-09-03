using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VoittoInfoScript : MonoBehaviour
{
    public static float voittoPisteet;

    // Start is called before the first frame update
    void Start()
    {
        voittoPisteet = 0;
    }

    // Update is called once per frame
    void Update()
    {
        voittoPisteet = RuutuScript.pisteet;
    }
}
