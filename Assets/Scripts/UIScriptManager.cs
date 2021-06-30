using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScriptManager : MonoBehaviour
{
    public Text lat, lon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lat.text ="LAT: "+GPSLocation.latitude.ToString();
        lon.text ="LON: "+GPSLocation.longitude.ToString();
    }
}
