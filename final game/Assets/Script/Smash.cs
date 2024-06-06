using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smash : MonoBehaviour
{
    public GameObject SmashEffect;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(SmashEffect, transform.position, Quaternion.identity);
    }
}

