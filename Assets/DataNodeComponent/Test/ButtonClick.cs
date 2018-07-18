using GameFramework.DataNode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework;
using UnityGameFramework.Runtime;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick() {
        UGFDataNode.Component.SetData<VarString>("Test.Name", "Test1");

        IDataNode testNode = UGFDataNode.Component.GetNode("Test");

        UGFDataNode.Component.SetData<VarInt>("Level", 20, testNode);

        UGFDataNode.Component.SetData<VarBool>("Test", true);

        Debug.Log("Test:" + UGFDataNode.Component.GetData("Test"));
        Debug.Log("Name:" + UGFDataNode.Component.GetData("Test.Name"));
        Debug.Log("Level:" + UGFDataNode.Component.GetData("Test.Level"));


    }
}
