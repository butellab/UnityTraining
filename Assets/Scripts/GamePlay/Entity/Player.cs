using GamePlay.Control;
using Service;

namespace GamePlay.Entity
{
    public class Player : Unit
    {
        protected override void Awake()
        {
            base.Awake();
            Locator.Register<IControllable>(this);
        }
    }
}