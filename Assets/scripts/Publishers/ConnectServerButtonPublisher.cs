using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RosSharp.RosBridgeClient;
using RosSharp.RosBridgeClient.MessageTypes.Std;
using UnityEditor;
using System;
using static AbstractPublisher;

public class ConnectServerButtonPublisher : AbstractPublisher
{
    protected override void Start()
    {
        Topic = "/" + userRegister.GetTopicName();
        base.Start();
        message = new RosSharp.RosBridgeClient.MessageTypes.Std.String();
    }

    public override void PublisherAction()
    {
        Debug.Log($"{this.Topic} is speaking");
        PublishMessage($"connect");
    }
}