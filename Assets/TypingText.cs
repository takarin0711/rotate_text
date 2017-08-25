using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TypingText : MonoBehaviour
{
    TypingSystem ts;
    public String text;
    public TextMesh alphabetTextMesh;

    void UpdateText()
    {
        alphabetTextMesh.text = "<color=white>" + ts.GetInputedKey() + "</color>" + ts.GetRestKey();
        //alphabetTextMesh.text = "aiueo";
    }

    // Use this for initialization
    void Start()
    {
        ts = new TypingSystem();
        ts.SetInputString("");
        UpdateText();

    }

    // Update is called once per frame
    void Update()
    {
        DownKeyCheck();
    }

    void DownKeyCheck()
    {
        if (Input.anyKeyDown)
        {
            string[] keys = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "-", };
            foreach (string key in keys)
            {
                if (Input.GetKeyDown(key))
                {
                    //処理を書く
                    // alphabetTextMesh.text = alphabetTextMesh.text + "<color=white>" + key + "</color>";
                    text = text + key;
                    alphabetTextMesh.text = "<color=white>" + text + "</color>";
                    Debug.Log(key);
                    break;
                }
                else if (Input.GetKeyDown("backspace"))
                {
                    if (text.ToString() != "")
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    Debug.Log(text);
                    alphabetTextMesh.text = "<color=white>" + text + "</color>";
                    break;
                }
            }
        }
    }
}
