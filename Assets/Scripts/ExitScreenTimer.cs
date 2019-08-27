using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScreenTimer : MonoBehaviour
{
    public float allowedTimeOutOfBounds;
    // Update is called once per frame
    void Update()
    {
        if(CheckOutOfBounds())
        {
            Debug.Log("Plane out of map bounds");
            StartCoroutine(OutOfBOundsReCheck(allowedTimeOutOfBounds));
        }
    }

    IEnumerator OutOfBOundsReCheck(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        Debug.Log("IEnumirator - Plane out of map bounds");
        if(CheckOutOfBounds()) 
        {
            //Lose Game
            Destroy(gameObject);
        }
    }

    bool CheckOutOfBounds()
    {
               if(transform.position.x > 30 || transform.position.x < -30 || transform.position.y > 16.8 || transform.position.y < -16.8)
        {
            return true;
        } 
        return false;
    }
}
