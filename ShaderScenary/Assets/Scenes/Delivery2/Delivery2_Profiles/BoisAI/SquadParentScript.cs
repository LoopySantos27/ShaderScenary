using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadParentScript : MonoBehaviour
{
    public GameObject target;//Target to follow
    public GameObject child_Prefab;//Children that will follow
    public List<GameObject> children; //Children

    // Start is called before the first frame update
    void Start()
    {
        children = new List<GameObject>();

        for(int i = 0; i< 12; i++)
        {
            //Appear the objects in a column
            Vector3 relative_Spawn = new Vector3(i % 2, transform.position.y, i / 2);
            GameObject temp = Instantiate(child_Prefab, transform.position + (relative_Spawn * 6.0f), transform.rotation);
            //temp.GetComponent<StateMachineBehaviour>().ta
            children.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (target.transform.position - transform.position).normalized * Time.deltaTime * 5.0f;
    }
}
