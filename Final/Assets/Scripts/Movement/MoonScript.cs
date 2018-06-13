using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour
{

	public float Speed = 5;

			void Update () {
				Vector3 position = this.transform.position;
				position.z--;
				this.transform.position = position;
				
		}

		void OnTriggerEnter(Collider co)
		{
			Debug.Log(co.gameObject.name + " " + co.gameObject.tag);
			if (co.gameObject.tag == "Player")
				if (co.name == "Player")
				{
					Destroy(co.gameObject);
				}
		}
	}