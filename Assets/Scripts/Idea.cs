using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Idea
{
    [TextArea]
    public string idea;
    public string designDocEntry;
    public bool appealsToClient;
    public string clientResponse;
}
