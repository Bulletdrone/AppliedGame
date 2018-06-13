using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameBase : MonoBehaviour {
    public enum Formula {Optellen, Aftrekken, Keer, Delen};
    public Formula formula;

    public int scoreAmount;
    public int opAmount;
    public int opCraftValue;
}
