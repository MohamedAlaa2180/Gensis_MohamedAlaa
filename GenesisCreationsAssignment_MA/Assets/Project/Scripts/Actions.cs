using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class Actions : MonoBehaviour
{
    [SerializeField] protected ActionType actionType;

    public void StartAction()
    {
        switch(actionType)
        {
            case ActionType.Animation:
                DoAnimation();
                break;
            case ActionType.Animation_Wait:
                DoAnimation_Wait();
                break;
            case ActionType.Clip:
                DoClip();
                break;
            case ActionType.Clip_Wait:
                DoClip_Wait();
                break;
            case ActionType.CameraMove:
                DoCameraMove();
                break;
            case ActionType.CameraMove_Wait:
                DoCameraMove_Wait();
                break;
        }
    }

    public virtual void DoAnimation() { }

    public virtual void DoAnimation_Wait() { }

    public virtual void DoClip() { }

    public virtual void DoClip_Wait() { }

    public virtual void DoCameraMove() { }

    public virtual void DoCameraMove_Wait() { }

    public void MarkExecuted()
    {
        Image img = GetComponent<Image>();
        img.color = Color.red;
    }

    public void MarkExecuting()
    {
        Image img = GetComponent<Image>();
        img.color = Color.green;
    }
}
