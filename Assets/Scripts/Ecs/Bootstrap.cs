using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlackECS;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Transform[] _cubes;

    private void Start()
    {
        World.RegistrationSystem<MovementSystem>();
        World.RegistrationSystem<ScaleSystem>();

        for (int i = 0; i < _cubes.Length; i++)
        {
            World
            .CreateEntity()
            .AddComponent<MovementComponent>(x =>
            {
                x.owner.Value = _cubes[i];
                x.speed = 5f;
                x.direction.Value = Vector3.one * Random.Range(-10, 10);
            });
        }
    }
}
