using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(Boid))]
public class BoidCohesionBehaviour : MonoBehaviour
{

    private Boid boid;
    public float radius;
    
    void Start()
    {
        boid = GetComponent<Boid>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check the closest boids and acced their component
        var boids = FindObjectsOfType<Boid>();
        var average = Vector3.zero;
        var found = 0;

        foreach(var boid in boids.Where(b => b != boid))
        {
            var difference = boid.transform.position - this.transform.position;
            if(difference.magnitude < radius)
            {
                average += difference;
                found += 1;
            }
        }
        //If there are some, move in this direction
        if(found > 0)
        {
            average = average / found;
            boid.velocity += Vector3.Lerp(Vector3.zero, average, boid.velocity.magnitude / radius);

        }
    }
}
