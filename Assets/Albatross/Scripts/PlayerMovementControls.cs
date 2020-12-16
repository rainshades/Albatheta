using UnityEngine;
using UnityEngine.InputSystem;

namespace Albatross
{
    public class PlayerMovementControls : CharacterMovementObject
    {
        [SerializeField]
        Transform Camera = null;

        public Vector2 MovementNormilized = Vector2.zero;

        Player Controls;

        public float turnSmoothTime = 0.1f;
        float turnSmoothVelocity;

        float targetAngle;
        float angle;

        Vector3 MoveDirection; 

        public float DashDistance = 4.0f;

        public bool Grounded { get => grounded; set => grounded = value; }

        public bool Flying { get => flying; set => grounded = value; }

        int jumps; 

        private void Awake()
        {
            ani = GetComponent<Animator>();

            MovementSettings = GetComponent<CharacterMovementData>();

            controller = GetComponent<CharacterController>();

            Controls = new Player();

            
        }


        private void Block_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            if (MovementForce != Vector3.zero && WalkState == WalkState.Running)
            {
                if (grounded)
                {
                    ani.Play("Roll");
                }
                else
                {
                    ani.Play("Flying");
                    flying = true; 
                    ani.SetBool("Flying", flying);
                }
                MovementForce = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward * DashDistance;
                //controller.Move(MoveDirection * Time.deltaTime * MovementSettings.Movement_speed);
            }
            else
            {
                GetComponent<CharacterCombat>().Block();
            }
        }

        private void Update()
        {
            Controls.PlayerControls.Movement.started += ctx => ani.SetBool("Moving", true);
            Controls.PlayerControls.Movement.started += ctx => WalkState = WalkState.Running;

            Controls.PlayerControls.Movement.performed += Movement_performed;
            Controls.PlayerControls.Movement.canceled += ctx => EndWalkState();

            Controls.PlayerControls.Jump.performed += ctx => Jump();
            Controls.PlayerControls.Block.performed += Block_performed;
        }

        private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {

            if (WalkState == WalkState.Running && !inDialog)
            {

                targetAngle = Mathf.Atan2(MovementForce.x, MovementForce.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
                angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                MovementNormilized = obj.ReadValue<Vector2>().normalized;

                MoveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                
                //MoveDirection = MoveDirection.normalized;
            }
            else
            {
                EndWalkState();
            }

            MovementForce = new Vector3(MovementNormilized.x, 0f, MovementNormilized.y).normalized;
        }

        bool canDoubleJump()
        {
            return jumps < 1; 
        }

        protected override void Jump()
        {
            if(grounded || canDoubleJump())
            {
                velocity.y = Mathf.Sqrt(MovementSettings.Jump_height * -2 * MovementSettings.Gravity);
                jumps++;
            }
        }


        public void EndWalkState()
        {
            ani.SetBool("Moving", false);
            MoveDirection = Vector3.zero; 
            
            WalkState = WalkState.nil; 
        }

        protected override void Movement()
        {
            float Speed = MovementSettings.Movement_speed;

            //Calc for controller here:


            /* Find a way to solve this redundance to improve performance
             * Locking it under an if reduces proformance  
             */

            if (KnockbackCounter <= 0)
            {
                if (grounded)
                {
                    flying = false;
                    ani.SetBool("Flying", flying);
                    jumps = 0; 
                }

                if (flying)
                {
                    Speed *= 1.5f; 
                }

                controller.Move(MoveDirection * Time.deltaTime * MovementSettings.Movement_speed);
            }
            else
            {
                KnockbackCounter -= Time.deltaTime;
            }
        }

        private void OnEnable()
        {
            Controls.Enable();
        }

        private void OnDisable()
        {
            Controls.Disable();
        }
    }
}