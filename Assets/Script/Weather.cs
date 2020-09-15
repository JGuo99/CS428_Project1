using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using TMPro;

public class Weather : MonoBehaviour
{
    public GameObject tempTextObject;
    public GameObject windTextObject;


    public static float humidData;
    public static float windDirectData;
    public static float windSpeedData;
    string url = "http://api.openweathermap.org/data/2.5/weather?id=4887398&appid=90474f2848e4e949e1544e2adde31bff&units=imperial";

    void Start()
    {

    // wait a couple seconds to start and then refresh every 30 seconds
       InvokeRepeating("GetDataFromWeb", 2f, 30f);
   }

   void GetDataFromWeb()
   {

       StartCoroutine(GetRequest(url));
   }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            var data = webRequest.downloadHandler.text;

            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the weather data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);
                Debug.Log(data);
                print(data);
            }
            var N = JSON.Parse(data);           
            string temp = N["main"]["temp"].Value;

            string humid = N["main"]["humidity"].Value;
            humidData = System.Convert.ToSingle(humid);
            
            string windDirect = N["wind"]["deg"].Value;
            windDirectData = System.Convert.ToSingle(windDirect);

            string windSpeed = N["wind"]["speed"].Value;

            tempTextObject.GetComponent<TextMeshPro>().text = temp + "F\n\n" + humid + "%";
            windTextObject.GetComponent<TextMeshPro>().text = windSpeed + "mph";
        }
    }    
}
