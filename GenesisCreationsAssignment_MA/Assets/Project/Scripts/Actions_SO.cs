using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ActionsSO", order = 1)]
public class Actions_SO : ScriptableObject
{
    public List<Actions> actionsSequence;

}
