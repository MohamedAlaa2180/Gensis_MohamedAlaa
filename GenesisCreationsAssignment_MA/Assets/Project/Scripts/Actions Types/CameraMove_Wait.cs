using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove_Wait : Actions
{
    [SerializeField] float moveDuration;
    public override void DoCameraMove_Wait()
    {
        MarkExecuting();
        ActionsManager.instance.theCamera.DOMoveX(-15, moveDuration).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            ActionsManager.instance.theCamera.DOMoveX(0, moveDuration).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                ActionsManager.instance.ExecuteActions();
                MarkExecuted();
            });
        });
    }
}
