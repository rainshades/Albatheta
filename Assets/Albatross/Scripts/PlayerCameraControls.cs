using UnityEngine;
using Cinemachine;

namespace Albatross
{
    public class PlayerCameraControls : MonoBehaviour
    {

        [SerializeField]
        CinemachineTargetGroup targetGroup = null;
        [SerializeField]
        CinemachineFreeLook FreeLook = null;
        Player Controls = null;
        [SerializeField]
        Transform CenterPoint = null;
        public float LockOnRange = 0.5f;
        public LayerMask LockOnLayers;
        [SerializeField]
        Transform CameraNeutralPoint = null; 

        public static Transform Enemy;

        void Awake()
        {
            Controls = new Player();

            Controls.CameraControls.CameraLock.performed += ctx => CameraLock();
        }

        private void Update()
        {
            if (FreeLook.LookAt == targetGroup.transform)
            {
                Collider[] Enemies = Physics.OverlapSphere(CenterPoint.position, LockOnRange, LockOnLayers);

                if (Enemies.Length == 0)
                {
                    LockOff();
                }
            }
        }


        void CameraLock()
        {
            if(FreeLook.LookAt == targetGroup.transform)
            {
                LockOff();
            }
            else
            {
                float radius = 3.6f;
                
                Collider[] Enemies = Physics.OverlapSphere(CenterPoint.position, LockOnRange, LockOnLayers);

                float Targetpos = 0;

                foreach (Collider enemy in Enemies)
                {
                    float Dot = Vector3.Dot(transform.position, enemy.transform.position);
                    if (Dot > Targetpos)
                    {
                        Targetpos = Dot;
                        Enemy = enemy.transform;
                    }
                    targetGroup.AddMember(enemy.transform, Targetpos, radius--);
                }

                EnemyUIHealthCheck.Instance.LastEnemyAttacked = Enemy.gameObject;

                FreeLook.LookAt = targetGroup.transform;
            }
        }

        void LockOff()
        {
            FreeLook.LookAt = CameraNeutralPoint;
            foreach(CinemachineTargetGroup.Target target in targetGroup.m_Targets)
            {
                targetGroup.RemoveMember(target.target);
            }
            
            Enemy = null;
            
            EnemyUIHealthCheck.Instance.LastEnemyAttacked = null;
            
        }

        private void OnEnable()
        {
            Controls.Enable();
        }

        private void OnDisable()
        {
            Controls.Disable();
        }

        private void OnDrawGizmosSelected()
        {
            if (CenterPoint == null)
                return;

            Gizmos.DrawWireSphere(CenterPoint.position, LockOnRange);

        }
    }
}