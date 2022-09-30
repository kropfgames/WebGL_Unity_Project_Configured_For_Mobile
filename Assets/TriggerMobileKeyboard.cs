using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using TMPro;

public class TriggerMobileKeyboard : MonoBehaviour 
{
   [SerializeField] public TMP_InputField InputField;
    private TouchScreenKeyboard keyboard;

    //Do this when the selectable UI object is selected.
    public void OpenMobileKeyboard()  {  
           Debug.Log("OnSelect input");
           keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);     
    } 
    public void ShowMobileInputInInputField() { //will break the input on desktop. only works on mobile.
        InputField.text = keyboard.text;
        Debug.Log("keyboard.text " + keyboard.text);
        Debug.Log("InputField.text " + InputField.text); 
    } 
}
