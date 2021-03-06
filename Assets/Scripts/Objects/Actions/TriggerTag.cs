﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTag : MonoBehaviour {

	/* Triggers event when object with set name enters it */

	public string checkName;
    public string fireEvent;
    bool used;

    private void OnTriggerEnter(Collider other)
    {
        if (used) return;
        if (other.gameObject.name == checkName)
        {
            EventManager.instance.FireEvent(fireEvent);
            GetComponent<Collider>().enabled = false;
            used = true;
        }
    }
}
