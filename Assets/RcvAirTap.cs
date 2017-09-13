using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RcvAirTap : MonoBehaviour, IInputClickHandler {

    public GameObject original;
    public TextMesh alphabetTextMesh;

    List<GameObject> list = new List<GameObject>();

    public void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject text = GameObject.Instantiate(original);
        TypingText.Instance.alphabetTextMesh = alphabetTextMesh;

        text.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);
        list.Add(text);
        Debug.Log("AirTap");
    }

    // Use this for initialization
    void Start () {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
