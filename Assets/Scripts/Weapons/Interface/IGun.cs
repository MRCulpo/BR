using System.Collections;

namespace Br.Weapon
{
    public interface IGun
    {
        void Shoot();
        void Charger();
        IEnumerator CountShoot();
    }
}
