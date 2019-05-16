﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAudio : MonoBehaviour
{
    private static BGAudio instance = null;

    public static BGAudio Instance
    {
        get{return instance;}
    }

    public void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }else{
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
