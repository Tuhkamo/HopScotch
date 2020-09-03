using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NopeusScript : MonoBehaviour
{
    public float input;
    public static float nopeus;
    void Awake()
    {
        // Scriptin tarkoitus on määritellä kuinka nopeasti ruudut putoavat
        nopeus = input;
    }
}
