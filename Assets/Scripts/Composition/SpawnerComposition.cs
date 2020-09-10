using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerComposition : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject pelletPrefab;

    // Start is called before the first frame update
    void Start()
    {
		CreateNewObject();
    }

    void Update()
	{
        
	}

    // Update is called once per frame
    void CreateNewObject()
    {
        int whichObject = Random.Range(0, 4);

        // one in three times this will be a car
        if (whichObject == 0)
        {
            GameObject newCar = (GameObject)Instantiate(carPrefab);
            newCar.transform.position = transform.position;
            newCar.GetComponent<MoveTowards>().SetDirection(transform.forward);
		}
        else if(whichObject == 1)
        {
            GameObject newPellet = (GameObject)Instantiate(pelletPrefab);
            newPellet.transform.position = transform.position;
            newPellet.GetComponent<MoveTowards>().SetDirection(transform.forward);
		}

        // call it again every 1 to 2 seconds
        float randomTime = Random.Range(1f, 2f);
        Invoke("CreateNewObject", randomTime);
    }
}
