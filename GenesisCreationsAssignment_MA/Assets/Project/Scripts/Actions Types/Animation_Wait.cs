using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Wait : Actions
{
    [SerializeField] int animDuration;
    public override void DoAnimation_Wait()
    {
        MarkExecuting();
        ActionsManager.instance.theObject.transform.DOShakePosition(animDuration, 1).OnComplete(() =>
        {
            ActionsManager.instance.ExecuteActions();
            MarkExecuted();
        });
    }
}
