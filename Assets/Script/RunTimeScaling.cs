using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunTimeScaling : MonoBehaviour
{
    public static float HumidData;
    public GameObject[] raindrop = new GameObject[4];
        
    // Start is called before the first frame update
    void Start()
    {
        raindrop[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        HumidData = Weather.humidData;
        if (HumidData >= 25 && HumidData < 50) {
            raindrop[0].SetActive(true);
            raindrop[1].SetActive(true);
            raindrop[2].SetActive(false);
            raindrop[3].SetActive(false);            
        }
        else if (HumidData >= 50 && HumidData < 75) {
            raindrop[0].SetActive(true);
            raindrop[1].SetActive(true);
            raindrop[2].SetActive(true);
            raindrop[3].SetActive(false);         
        }        
        else if(HumidData >= 75.0) {
            for(int i = 0; i < raindrop.Length; i++) {
                raindrop[i].SetActive(true);
            }
        }            
    }
}
