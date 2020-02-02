using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Position : MonoBehaviour
{
    public Text text;
    public Text text2;

    public float lat = 2;
    public float lon = 2;
        public void Start()
        {
        text = GetComponent<Text>();
        text2 = GetComponent<Text>();
        // turn on location services, if available 
        Input.location.Start();
        }

        public void Update()
        {

            //Do nothing if location services are not available
            if (Input.location.isEnabledByUser)
            {
                float lat = Input.location.lastData.latitude;
                float lon = Input.location.lastData.longitude;



                text.text = "lat: " + lat;
                text2.text = "lon: " + lon;

            }
            else
                text.text = "gps off";
        }


    }
