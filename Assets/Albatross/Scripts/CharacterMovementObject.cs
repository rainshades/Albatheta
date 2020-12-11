using UnityEngine;

namespace Albatross
{
    public class CharacterMovementObject : MonoBehaviour
    {
        protected CharacterController controller;

        protected Vector3 MovementForce = Vector3.zero;

        public JumpState JumpState = JumpState.nil;
        public WalkState WalkState = WalkState.nil;

        protected bool grounded;
        protected float Current_Jump_height;

        protected CharacterMovementData MovementSettings;
        protected Vector3 velocity;

        protected bool inDialog; 

        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundMask;

        protected Animator ani;

        public float KnockbackForce;
        public float KnockbackTimer;
        protected float KnockbackCounter;

        [SerializeField]
        protected GameObject PointChecker;

        protected bool flying = false;

        public bool Dialog { get => inDialog; set => inDialog = value; }

        void Start()
        {
            if (GetComponent<Animator>() != null)
                ani = GetComponent<Animator>();
            else
                ani = GetComponentInChildren<Animator>();

            MovementSettings = GetComponent<CharacterMovementData>();
        }


        void FixedUpdate()
        {
            inDialog = GameManager.Instance.inDialog; 

            if (!inDialog)
            {
                Gravity();
                Movement();
            }
        }

        
        protected void Gravity()
        {
            if(KnockbackCounter <= 0)
            {
                velocity.x = 0;
                velocity.z = 0; 
            }

            grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            ani.SetBool("Grounded", grounded);

            if (grounded)
            {
                flying = false; 
            }

            if (grounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            velocity.y += MovementSettings.Gravity * Time.deltaTime;
            if(controller != null) controller.Move(velocity * Time.deltaTime);
        }

        public virtual void Thrust()
        {
            controller.Move(Quaternion.Euler(0f, transform.eulerAngles.y, 0f) * Vector3.forward);
        }

        public void KnockBack(Vector3 Direction)
        {
            KnockbackCounter = KnockbackTimer;
            velocity = Direction * KnockbackForce * 4;
            velocity.y = KnockbackForce;
        }


        protected virtual void Jump()
        {
            if (grounded)
            {
                velocity.y = Mathf.Sqrt(MovementSettings.Jump_height * -2 * MovementSettings.Gravity);
            }
        }


        protected virtual void Movement()
        {

        }

    }
}