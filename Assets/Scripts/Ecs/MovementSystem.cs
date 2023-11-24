using System.Text;
using System.Threading.Tasks;
using BlackECS.Systems;
using BlackECS;
using UnityEngine;

public class MovementSystem : BaseSystem<MovementComponent>
{
    public override int SystemUpdateOrder => 0;

    public override void OnUpdate(MovementComponent component, float deltaTime)
    {
        if (Input.GetKey(KeyCode.D))
        {
            component.owner.Value.Translate(component.direction.Value * component.speed * deltaTime);
        }

        component.lifeTime.Value += deltaTime;

        if(component.lifeTime.Value >= 5f)
        {
            this.TransitToComponent<ScaleComponent>(x =>
            {
                x.owners.Value = component.owner.Value;
                x.force.Value = Random.Range(-3, 3);
            });
        }
    }
}
