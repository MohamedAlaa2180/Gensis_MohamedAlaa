using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : Actions
{
    [SerializeField] float moveDuration;
    public override void DoCameraMove()
    {
      //  DOTween.KillAll();
        ActionsManager.instance.ExecuteActions();
        MarkExecuted();
        ActionsManager.instance.theCamera.DOMoveX(-15, moveDuration).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            ActionsManager.instance.theCamera.DOMoveX(0, moveDuration).SetEase(Ease.InOutSine);
        });
    }
}
