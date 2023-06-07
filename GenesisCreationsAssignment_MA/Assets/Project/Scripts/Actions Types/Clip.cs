using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clip : Actions
{
    [SerializeField] AudioClip clip;
    float length;
    float timer = 0;
    public override void DoClip()
    {
        ActionsManager.instance.audioSource.clip = clip;
        ActionsManager.instance.audioSource.Play();
        ActionsManager.instance.ExecuteActions();
        MarkExecuted();
    }
}
