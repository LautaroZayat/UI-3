using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LOGINMANAGER : MonoBehaviour
{

    public InputField Inputcontraseña;

    public string contraseña = "hola";

    public void Button_Pressed()
    {
        if (Inputcontraseña.text == contraseña)
        {
            Debug.Log("Access granted");
        }
        else 
        {
            Debug.Log("Access denied");
        }
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
