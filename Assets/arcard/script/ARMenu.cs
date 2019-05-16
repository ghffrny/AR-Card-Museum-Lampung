using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMenu : MonoBehaviour
{
    private Vector3 GUIsF;

    public GameObject arBadik, arPerisai, arTapis, arKrakatau, arGong;
    public float speedRotation = 50f;
    bool statusRotation = true;

    private void Update()
    {
        if(statusRotation == true)
        {
            arBadik.transform.Rotate(Vector3.back ,speedRotation * Time.deltaTime);
            arPerisai.transform.Rotate(Vector3.back ,speedRotation * Time.deltaTime);
            arTapis.transform.Rotate(Vector3.back ,speedRotation * Time.deltaTime);
            arKrakatau.transform.Rotate(Vector3.back ,speedRotation * Time.deltaTime);
            arGong.transform.Rotate(Vector3.back ,speedRotation * Time.deltaTime);
        }
    }
}
