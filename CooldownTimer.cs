using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CooldownTimer : MonoBehaviour {
    private float cdTime;
    private float nextTime;
    private int numberOfFinishedCds;

    public CooldownTimer(float time)
    {
        this.cdTime = time;
        this.nextTime = Time.time + this.cdTime;
        this.numberOfFinishedCds = 0;
    }

    public bool IsCoolDownFinished()
    {
        if(Time.time >= this.nextTime)
        {
            this.nextTime = Time.time + this.cdTime;
            numberOfFinishedCds++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public float SecondsToNextCdFinish()
    {
        this.IsCoolDownFinished();
        return nextTime - Time.time;
    }
    
    public int NumberOfCds()
    {
        return this.numberOfFinishedCds;
    }
}
