using UnityEngine;
using System;

public abstract class Response : MonoBehaviour
{
    protected string TruncateId(string message)
    {
        string[] splitMessage = message.Split(' ');
        return splitMessage[1];
    }
    public abstract void ResponseToMessage(string response);
}