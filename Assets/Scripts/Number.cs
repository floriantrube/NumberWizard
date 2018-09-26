using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour {

    int min;
    int max;
    int guess;


    // Use this for initialization
    void Start() {

        min = 1;
        max = 1000;
        guess = 500;
        Debug.Log("Hallo, gib mir bitte ein Minimum und ein Maximum! ");
    }

        // Update is called once per frame
        void Update () {

            

            if (Input.GetKeyDown(KeyCode.DownArrow)) //kleiner
            {
                rechnen();
                max = guess;
                Debug.Log("max" + max);
            }

            else if (Input.GetKeyDown(KeyCode.UpArrow)) //groesser
            {
                rechnen();
                min = guess;
                Debug.Log("min" + min);
            }

            else if (Input.GetKeyDown(KeyCode.Return)) //gleich
            {
                Debug.Log("Gefunden");
            }

           // Debug.Log("min" + min);
            //Debug.Log("max" + max);

            

        }

    void rechnen()
    {
        guess = (min + max) / 2;
        Debug.Log("BIMT DAS D1 NUMBER MOIS? " + guess);
    }

}

