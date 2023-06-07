using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : Actions
{
    [SerializeField] int animDuration;
    public override void DoAnimation()
    {
        ActionsManager.instance.ExecuteActions();
        MarkExecuted();
        ActionsManager.instance.theObject.transform.DOShakePosition(animDuration, 1);        
    }
}
