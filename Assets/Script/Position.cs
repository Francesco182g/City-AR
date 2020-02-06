using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Position : MonoBehaviour
{
    public Text text;
    public Text text2;
    public Text compass;

    public float lat = 2;
    public float lon = 2;
        public void Start()
        {
        text = GameObject.Find("lat").GetComponent<Text>();
        text2 = GameObject.Find("lon").GetComponent<Text>();
        compass = GameObject.Find("bus").GetComponent<Text>();

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
            compass.text = Quaternion.Euler(0, -Input.compass.magneticHeading, 0).ToString();
            }
            else
                text.text = "gps off";
                //text2.text = "gps off";

    }
}
