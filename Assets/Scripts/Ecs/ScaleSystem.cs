using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackECS.Systems;
using BlackECS;
using UnityEngine;

public class ScaleSystem : BaseSystem<ScaleComponent>
{
    public override int SystemUpdateOrder => 0;

    public override void OnUpdate(ScaleComponent component, float deltaTime)
    {
        component.owners.Value.localScale += Vector3.one * component.force.Value * deltaTime;

        component.timer.Value += deltaTime;

        if(component.timer.Value >= 5f)
        {
            this.DestroyEntity();
        }
    }
}
