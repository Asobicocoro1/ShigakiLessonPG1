using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingGauge : MonoBehaviour
{
    public Image gaugeImage;
    public float fillSpeed = 1f;
    private bool isTiming = false;

    void Update()
    {
        if (isTiming)
        {
            gaugeImage.fillAmount = Mathf.PingPong(Time.time * fillSpeed, 1);
        }
        else
        {
            gaugeImage.fillAmount = 0;
        }
    }

    public void StartTiming()
    {
        isTiming = true;
    }

    public void StopTiming()
    {
        isTiming = false;
    }

    public float GetFillAmount()
    {
        return gaugeImage.fillAmount;
    }
}





