using System;
using System.Collections;
using UnityEngine;

namespace Br.Weapon
{
    public class GunPistol : GunBase, IGun
    {
        [SerializeField] private float timeBetweenShots;
        private bool isShoot;

        private void Awake()
        {
            isShoot = true;
            MyTransform = transform.parent;
        }

        public void Charger()
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        { 
            if(isShoot)
            {
                isShoot = false;

                StartCoroutine(CountShoot());
            }
        }

        public IEnumerator CountShoot()
        {
            int _count = AmountBulletsShot;

            do
            {
                GameObject _bullet = Instantiate(TypeBullets, PointFire.position, MyTransform.rotation);

                var angle = _bullet.transform.eulerAngles.magnitude * Mathf.Deg2Rad;

                float _CurrentRecoil = RecoilGunFree;

                float _XSpeed = Mathf.Cos(angle) + UnityEngine.Random.Range(-_CurrentRecoil, _CurrentRecoil);
                float _YSpeed = Mathf.Sin(angle) + UnityEngine.Random.Range(-_CurrentRecoil, _CurrentRecoil);

                _bullet.GetComponent<Rigidbody2D>().velocity = (new Vector2(_XSpeed, _YSpeed) * SpeedBullet);

                Destroy(_bullet, 2f);

                yield return new WaitForSeconds(timeBetweenShots);

                _count--;

            } while (_count > 0);

            yield return new WaitForSeconds(ShootingTime);

            isShoot = true;
        }
    }
}

