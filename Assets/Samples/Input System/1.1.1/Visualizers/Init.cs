using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;
public class Init : MonoBehaviour
{
    float mousePosY = 0f;
    float mousePosX = 0f;
    public Texture2D textureToDisplay;
    // Start is called before the first frame update
    void Start()
    {
         Cursor.lockState = CursorLockMode.Locked;

        textureToDisplay = Resources.Load<Texture2D>("nut");
    }
    void OnGUI()
    {

        GUI.Label(new Rect(600, 50, 100, 20), "X Position: " + mousePosX.ToString(), new GUIStyle()
        {
            fontSize = 22,
            normal = new GUIStyleState() { textColor = Color.white }
        });
        GUI.Label(new Rect(600, 80, 100, 20), "Y Position: " + mousePosY.ToString(), new GUIStyle()
        {
            fontSize = 22,
            normal = new GUIStyleState() { textColor = Color.white}
        });
        GUI.Label(new Rect(10, 10, 100, 50), textureToDisplay);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            mousePosX = 0f;
            mousePosY = 0f;
        }
        mousePosX += Mouse.current.delta.x.ReadValue();
        mousePosY += Mouse.current.delta.y.ReadValue();
    }
}
