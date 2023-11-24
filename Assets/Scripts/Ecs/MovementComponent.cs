using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlackECS.Components;

public class MovementComponent : IComponent
{
    public float speed;
    public ComponentDataField<Vector3> direction;
    public ComponentDataField<Transform> owner;
    public ComponentDataField<float> lifeTime;
}
