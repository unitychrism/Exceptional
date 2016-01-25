using UnityEngine;
using System.Collections;

public class BadCubeController : MonoBehaviour {

	public string m_DoesntExist, m_ThisAlsoDoesntExist, m_BadVariable;

	// Use this for initialization
	void Start () {
		m_DoesntExist = "text string";

		m_ThisAlsoDoesntExist = "something else";
		m_BadVariable = "bad";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
