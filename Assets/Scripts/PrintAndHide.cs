using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;

    public Renderer rend;

    private int blueTerminator;

    // Start is called before the first frame update
    void Start()
    {
        blueTerminator = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if (gameObject.tag.Equals("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag.Equals("Blue") && i == blueTerminator)
        {
            rend.enabled = false;
        }
    }
}
