using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

namespace Albatross
{
    public class NPCMovementObject : CharacterMovementObject
    {
        [SerializeField]
        protected GameObject Target;

        [SerializeField]
        protected List<GameObject> PossibleTargets = new List<GameObject>();

        NavMeshAgent agent; 

        public float DetectionRadius = .04f;
        public LayerMask DetectionLayers;
        protected Vector3 Destination = Vector3.zero;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            controller = null; 
        }

        private void Update()
        {
            Detection();
            TargetSelection();
        }

        protected override void Movement()
        {
            if (Target != null && KnockbackCounter <= 0 && grounded)
            {
                transform.LookAt(new Vector3(Target.transform.position.x, transform.position.y, Target.transform.position.z));

                ani.SetBool("Moving", true);

              agent.SetDestination(Target.transform.position);
                
            }
            else
            {
                KnockbackCounter -= Time.deltaTime;
            }
        }

        void Detection()
        {
            Collider[] PTC = Physics.OverlapSphere(PointChecker.transform.position, DetectionRadius, DetectionLayers);

            foreach (Collider C in PTC)
            {
                if (!PossibleTargets.Contains(C.gameObject))
                {
                    PossibleTargets.Add(C.gameObject);
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            if (PointChecker == null)
                return;

            Gizmos.DrawWireSphere(PointChecker.transform.position, DetectionRadius);
        }

        protected virtual void TargetSelection()
        {

        }
    }
}