using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameBase : MonoBehaviour {
    public enum MiniGameType {Furnace};
    public enum Difficulty {Easy, Normal, Hard };
    public enum Formula {Optellen, Aftrekken, Keer, Delen};
    public MiniGameType miniGameType;
    public Difficulty difficulty;
    public Formula formula;

    public int scoreAmount;
    public int opAmount;
    public int opCraftValue;

    public GameObject miniGamePrefab;
}
