using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Clip_Wait : Actions
{
    [SerializeField] AudioClip clip;
    float length;
    float timer = 0;
    public override void DoClip_Wait()
    {
        MarkExecuting();
        ActionsManager.instance.audioSource.clip = clip;
        ActionsManager.instance.audioSource.Play();
        length = clip.length;
        DOTween.To(() => timer, x => timer = x, 1, length).OnComplete(() => {
            ActionsManager.instance.ExecuteActions();
            MarkExecuted();
        });
    }
}
