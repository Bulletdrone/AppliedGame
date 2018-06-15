using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentGiver : MinigameBase{
    FurnaceMiniGame fmg;

    void Awake ()
    {
        fmg = GameObject.Find("BlackSmith").GetComponent<FurnaceMiniGame>();
    }

    public void MakeCalculationNumbers (Formula f, MiniGameType mgt, Difficulty d) 
    {
        //Select the Minigame Type.
        switch(mgt)
        {
            case MiniGameType.Furnace:
                //Select the Forumula.
                switch (f)
                {
                    case Formula.Optellen:
                        int[] n;
                        int s0 = 0;
                        int s1 = 0;
                        int r0;
                        int r1;
                        switch (d)
                        {
                            case Difficulty.Easy:
                                scoreAmount = Random.Range(1, 51);
                                r0 = 1;
                                r1 = 51;
                                while (s0 + s1 != scoreAmount)
                                {
                                    s0 = Random.Range(r0, r1);
                                    s1 = Random.Range(r0, r1);
                                }
                                SetNumbersFurnace(s0, s1, r0, r1);
                                break;
                            case Difficulty.Normal:
                                scoreAmount = Random.Range(50, 101);
                                r0 = 50;
                                r1 = 101;
                                while (s0 + s1 != scoreAmount)
                                {
                                    s0 = Random.Range(r0, r1);
                                    s1 = Random.Range(r0, r1);
                                }
                                SetNumbersFurnace(s0, s1, r0, r1);
                                break;
                            case Difficulty.Hard:
                                scoreAmount = Random.Range(100, 501);
                                r0 = 100;
                                r1 = 501;
                                while (s0 + s1 != scoreAmount)
                                {
                                    s0 = Random.Range(r0, r1);
                                    s1 = Random.Range(r0, r1);
                                }
                                SetNumbersFurnace(s0, s1, r0, r1);
                                break;
                        }
                        break;
                    case Formula.Aftrekken:

                        break;
                    case Formula.Keer:

                        break;
                    case Formula.Delen:

                        break;
                }
                break;
        }
    }
    void SetNumbersFurnace (int s0, int s1, int r0, int r1)
    {
        fmg.calculationNumbers[0] = s0;
        fmg.calculationNumbers[1] = s1;
        fmg.calculationNumbers[2] = Random.Range(r0, r1);
        fmg.calculationNumbers[3] = Random.Range(r0, r1);
    }
}
