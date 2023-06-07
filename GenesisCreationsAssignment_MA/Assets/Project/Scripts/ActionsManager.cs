using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public enum ActionType { Animation , Animation_Wait , Clip , Clip_Wait , CameraMove , CameraMove_Wait}

public class ActionsManager : MonoBehaviour
{
    [Header("Elements")]
    public Actions_SO actionSO;
    public GameObject theObject;
    public Transform content;
    public AudioSource audioSource;
    public Transform theCamera;
    public TextMeshProUGUI actionCounterText;

    public List<Actions> createdActions;
    //public Action ExecuteAction;

    public int currentActionIndex = 0;

    public static ActionsManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Multiple instances of " + this.GetType().Name + " #1", gameObject);
            Debug.LogError("Multiple instances of " + instance.GetType().Name + " #2", instance.gameObject);
        }
    }

   // private void OnEnable() => ExecuteAction += ExecuteActions;

   // private void OnDisable() => ExecuteAction -= ExecuteActions;

    private void Start()
    {
        CreateActions();
        ExecuteActions();
    }

    void CreateActions()
    {
        foreach(Actions action in actionSO.actionsSequence)
        {
            Actions createdAction = Instantiate(action , content);
            createdActions.Add(createdAction);
        }
    }

    public void ExecuteActions()
    {
        if (currentActionIndex < createdActions.Count)
        {
            actionCounterText.text = "Actions : " + (currentActionIndex + 1) + " / " + createdActions.Count;
            currentActionIndex++;
            createdActions[currentActionIndex-1].StartAction();
            
        }
        else
        {
            actionCounterText.text = "Actions are all executed...Thank you";
        }
    }
}
