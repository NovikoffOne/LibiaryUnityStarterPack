using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BlackECS.Components;

public class ScaleComponent : IComponent
{
    public ComponentDataField<Transform> owners;
    public ComponentDataField<float> force;
    public ComponentDataField<float> timer;
}
