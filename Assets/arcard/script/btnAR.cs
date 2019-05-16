using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnAR : MonoBehaviour
{
    public AudioSource voice1;
    public GameObject Panel,Sound,Pause;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActiveS = Sound.activeSelf;
            Sound.SetActive(!isActiveS);
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            bool isActiveP = Pause.activeSelf;
            Pause.SetActive(!isActiveP);
        }else{
            voice1.Stop();
        }
    }
}
