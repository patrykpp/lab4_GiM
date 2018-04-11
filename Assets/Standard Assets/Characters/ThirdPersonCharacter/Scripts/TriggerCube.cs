using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;


public class TriggerCube : MonoBehaviour {


    public Text countText;
    public Text winText;
    public Light lt ;
    public int licznik = 0;

    public void Start()
    {
        //lt = GetComponent<Light>();
        winText.text = "";
        countText.text = "";


    }

    public void Update()
    {
        countText.text = "Punkty: " + licznik.ToString();

    }

    public void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.CompareTag("Cube"))
        {
			lt.color = Color.white / 2.0F * Time.deltaTime;
			Destroy(other.gameObject);
			licznik++;
			Update();

			if (licznik > 4)
			{
				winText.text = "Wygrałeś !";
				Time.timeScale = 0;
			}


        }

    }
}

