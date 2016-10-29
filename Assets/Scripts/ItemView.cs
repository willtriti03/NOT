﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemView : MonoBehaviour {
    public GameObject detail;
    public GameObject sp;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            detail.gameObject.SetActive(!detail.gameObject.active);
            detail.gameObject.GetComponent<ItemDetail>().SetData("뷁",sp.GetComponent<Image>().sprite);
        }
    }
}