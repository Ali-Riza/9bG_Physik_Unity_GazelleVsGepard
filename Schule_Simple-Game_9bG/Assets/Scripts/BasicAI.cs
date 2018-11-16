using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public Transform gazellle;
    public Transform gepard;
    public float Distance;
    private Rigidbody rb;
    public Animation anim;

    float x;
    float y;
    float z;
    Vector3 pos;

    void Start()
    {
        Debug.Log("Start Game");

        x = Random.Range(-90, 0);
        y = 5;
        z = Random.Range(-50, 38);
        pos = new Vector3(x, y, z);
        gazellle.transform.position = pos;
    }


    void Update()
    {
        gepard.transform.LookAt(gazellle); //schau Target an
        gepard.transform.Translate(Vector3.forward * 15 * Time.deltaTime); //Bewege dich zum Target
        Distance = Vector3.Distance(gazellle.transform.position, gepard.transform.position);
        Debug.Log(Distance);
        if (Distance < 70) {
            Debug.Log("Distance < 70");
            gazellle.transform.LookAt(gepard);
            gazellle.transform.Rotate(0, 180, 0);
            gepard.transform.Translate(Vector3.forward * 30 * Time.deltaTime); //Bewege dich zum Target
            gazellle.transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        }

        if (Distance < 5) //if position_gepard zu position_gazelle <5{
        {
            Debug.Log("Distance < 5");

            x = Random.Range(-90, 0);
            y = 5;
            z = Random.Range(-50, 38);
            pos = new Vector3(x, y, z);
            gazellle.transform.position = pos;

            //gazellle.transform.position = Vector3.zero;
            //gepard.transform.position = Vector3.zero;
        }
    }
}


/*
 * if position_gepard zu position_gazelle <5{
 *      dann soll die gazelle stehenbleiben
 *      dann soll die animation vom geparden vom "rennen" auf "essen" wechseln.
 *      
 *      dann soll sich die gazelle zufällig irgendwo im Feld wieder teleportieren und alles beginnt von neu.
 * }
 *  
*/
