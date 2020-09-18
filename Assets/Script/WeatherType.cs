using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeatherType : MonoBehaviour
{
    public static string weatherType = Weather.weatherType;
    public GameObject[] type = new GameObject[9];
    public GameObject[] statusText = new GameObject[2];
    private int iterate = 0;

    void Start()
    {
        // InvokeRepeating("UpdateType", 0f, 30f);  //Update Type every 30sec
        UpdateType();
    }
    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("right")) {
            iterate += 1;
            if(iterate == 10) {
                iterate = 0;
            }
        } 
        else if (Input.GetKeyDown("left")) {
            iterate -= 1;
            if (iterate == -1) {
                iterate = 9;
            }
        }

        if (iterate == 1) {
            type[0].SetActive(true);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);
        }
        else if (iterate == 2) {
            type[0].SetActive(false);
            type[1].SetActive(true);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }        
        else if (iterate == 3) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(true);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (iterate == 4) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(true);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (iterate == 5) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(true);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (iterate == 6) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(true);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);;        
        }
        else if (iterate == 7) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(true);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (iterate == 8) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(true);
            type[8].SetActive(false);
        }
        else if (iterate == 9) {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(true);        
        }else if (iterate == 0){
            UpdateType();
        }
        // Debug.Log(iterate);
        statusText[0].GetComponent<TextMeshPro>().text = "Counter: " + iterate + "\n0 = Current Weather";
        statusText[1].GetComponent<TextMeshPro>().text = "Counter: " + iterate + "\n0 = Current Weather";
    }

    void UpdateType()
    { 
        weatherType = Weather.weatherType;
        if (weatherType == "clear sky") {
            type[0].SetActive(true);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);
        }
        else if (weatherType == "few clouds") {
            type[0].SetActive(false);
            type[1].SetActive(true);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }        
        else if (weatherType == "scattered clouds") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(true);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (weatherType == "broken clouds") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(true);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (weatherType == "shower rain") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(true);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (weatherType == "rain") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(true);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(false);;        
        }
        else if (weatherType == "thunderstorm") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(true);
            type[7].SetActive(false);
            type[8].SetActive(false);        
        }
        else if (weatherType == "snow") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(true);
            type[8].SetActive(false);
        }
        else if (weatherType == "mist" || weatherType == "smoke") {
            type[0].SetActive(false);
            type[1].SetActive(false);
            type[2].SetActive(false);
            type[3].SetActive(false);
            type[4].SetActive(false);
            type[5].SetActive(false);
            type[6].SetActive(false);
            type[7].SetActive(false);
            type[8].SetActive(true);        
        }
    }
}
