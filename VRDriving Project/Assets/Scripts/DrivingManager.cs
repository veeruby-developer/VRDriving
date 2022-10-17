using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivingManager : MonoBehaviour
{
    public Text msg;
    bool SeatBeltUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.name == "LeftHand" || gameObject.name == "RightHand" && other.name == "SeatBeltUp")
        {
            SeatBeltUp = true;
            msg.text = "Seatbeltup is true";
        }
        if (gameObject.name == "LeftHand" || gameObject.name == "RightHand" && other.name == "SeatBeltDown" && SeatBeltUp == true)
        {
            Debug.Log("SeatBelt");
        }
    }
}
