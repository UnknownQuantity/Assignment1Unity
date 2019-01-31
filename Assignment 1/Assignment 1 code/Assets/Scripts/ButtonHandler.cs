using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{


    public Text text;
    public GameObject spawntarget;
    

    public void TextPrinter ()
    {
        text.text = "Hello World";
        Debug.Log("Hello World");
    }

    public void Spawner()
    {
        Instantiate(spawntarget);
        
    }
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
