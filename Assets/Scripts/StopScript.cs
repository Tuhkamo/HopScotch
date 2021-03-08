using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class StopScript : MonoBehaviour
{

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -NopeusScript.nopeus);

        if (gameObject.transform.position.y < 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
