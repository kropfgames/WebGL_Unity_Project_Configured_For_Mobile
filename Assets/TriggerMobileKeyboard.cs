using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;// Required when using Event data.
using TMPro;

public class TriggerMobileKeyboard : MonoBehaviour, 
ISelectHandler// required interface when using the OnSelect method.
{
   [SerializeField] public TMP_InputField InputField;
 
    //Do this when the selectable UI object is selected.
    public void OnSelect(BaseEventData eventData)
    {  
            Debug.Log("InputField.isFocused");
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);    
    }
}
