using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerators : MonoBehaviour {
	public GameObject[] vsagataves;
	public float laikaIntervals = 1.0f;
	float minPoz, maxPoz;
	Transform trubarsTransform;
	// Use this for initialization
	void Start () {
		trubarsTransform = GetComponent<Transform>();
	}
	
	public void SagatavotVirtulus(bool pos)
	{
		if (pos)
			StartCoroutine(Generate());
		else
			StopAllCoroutines();
	}
	IEnumerator Generate()
	{
		while (true)
		{
			minPoz=trubarsTransform.position.x - 20;
            maxPoz = trubarsTransform.position.x + 20;
			var cip=Random.Range(minPoz, maxPoz);
			var poz=new Vector3(cip, transform.position.y);
			GameObject virtulis = Instantiate(vsagataves[Random.Range(0, vsagataves.Length)], poz,
				Quaternion.identity, trubarsTransform);
            yield return new WaitForSeconds(laikaIntervals);
		}
	}
}
