using UnityEngine;

namespace Br.Weapon
{
    [System.Serializable]
    public class GunBase : MonoBehaviour
    {
        /// <summary>
        /// Quantidade de Balas que podem ser carregadas
        /// </summary>
        [SerializeField]private int maxBullets;
        /// <summary>
        /// Quantidade de Balas que pode estar no cartucho
        /// </summary>
        [SerializeField] private int maxBulletsCharger;

        /// <summary>
        /// Quantidade de Balas que esta carregada atualmmente
        /// </summary>
        private int currentMaxBullets;
        /// <summary>
        /// Quantidade de Balas que esta no cartucho atualmente
        /// </summary>
        private int currentMaxBulletsCharger;

        /// <summary>
        /// Quantidade de balas que deve ser executadas em um disparo
        /// </summary>
        [SerializeField] private int amountBulletsShot;

        /// <summary>
        /// Velocidade das Balas
        /// </summary>
        [SerializeField] private float speedBullet;

        /// <summary>
        /// Tempo de cada disparo
        /// </summary>
        [SerializeField] private float shootingTime;

        /// <summary>
        /// GameObject dos tipos das balas
        /// </summary>
        [SerializeField] private GameObject typeBullets;

        /// <summary>
        /// Transform da ponta onde vai sair a bala
        /// </summary>
        [SerializeField] private Transform pointFire;

        /// <summary>
        /// Referencia do meu transform
        /// </summary>
        private Transform myTransform;

        /// <summary>
        /// Recoil da arma livre
        /// </summary>
        [SerializeField] private float recoilGunFree;
        /// <summary>
        /// Recoil da arma Mirando
        /// </summary>
        [SerializeField] private float recoilGunLooking;


        public int MaxBullets
        {
            get
            {
                return maxBullets;
            }

            set
            {
                maxBullets = value;
            }
        }

        public int MaxBulletsCharger
        {
            get
            {
                return maxBulletsCharger;
            }

            set
            {
                maxBulletsCharger = value;
            }
        }

        public int CurrentMaxBullets
        {
            get
            {
                return currentMaxBullets;
            }

            set
            {
                currentMaxBullets = value;
            }
        }

        public int CurrentMaxBulletsCharger
        {
            get
            {
                return currentMaxBulletsCharger;
            }

            set
            {
                currentMaxBulletsCharger = value;
            }
        }

        public int AmountBulletsShot
        {
            get
            {
                return amountBulletsShot;
            }

            set
            {
                amountBulletsShot = value;
            }
        }

        public float SpeedBullet
        {
            get
            {
                return speedBullet;
            }

            set
            {
                speedBullet = value;
            }
        }

        public GameObject TypeBullets
        {
            get
            {
                return typeBullets;
            }

            set
            {
                typeBullets = value;
            }
        }

        public float RecoilGunFree
        {
            get
            {
                return recoilGunFree;
            }

            set
            {
                recoilGunFree = value;
            }
        }

        public float RecoilGunLooking
        {
            get
            {
                return recoilGunLooking;
            }

            set
            {
                recoilGunLooking = value;
            }
        }

        public Transform PointFire
        {
            get
            {
                return pointFire;
            }

            set
            {
                pointFire = value;
            }
        }

        public Transform MyTransform
        {
            get
            {
                return myTransform;
            }

            set
            {
                myTransform = value;
            }
        }

        public float ShootingTime
        {
            get
            {
                return shootingTime;
            }

            set
            {
                shootingTime = value;
            }
        }

        ///// <summary>
        ///// Dano que causa da Bala
        ///// </summary>
        //private int m_DamageBullet;
    }
}
