using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using System;
using TMPro;

public class Cutscene1 : MonoBehaviour
{
    [Serializable]
    public class Subtitles
    {
        public string[] subs;
    }

    [Serializable]
    public class Instructions
    {
        public GameObject[] insts;
    }

    public Animator michael;
    public Animator trevor;
    public Animator female;
    public Animator brad;
    public Animator npc_female;
    public Animator npc_males;
    public Animator npc_male2;
    public Animator npc_male3;
    public Animator npc_seq1;
    public Animator doors1;
    public Animator doors2;
    public Animator doors3;
    public Animator garageDoor;
}
