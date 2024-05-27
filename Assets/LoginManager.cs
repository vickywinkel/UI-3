using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string contrasena = "hola";
    public InputField contra; 
    public void BotonAceptar()
    {
        if (contra.text == contrasena)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}
