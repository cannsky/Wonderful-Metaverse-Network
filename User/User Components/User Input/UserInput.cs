using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WonderfulMetaverseNetwork.User
{
    public class UserInput
    {
        public class UserInputState
        {
            public float angle;
            public float targetAngle;
            public Vector3 direction;
            public Vector3 moveDirection;
        }

        UserInputState userInputState;

        public Transform transform;
        public Transform camera;
        public CharacterController controller;

        public float speed = 6f;
        public float turnSmoothTime = 0.1f;
        float turnSmoothVelocity;

        public UserInput(Transform transform, CharacterController controller, Transform camera)
        {
            this.transform = transform;
            this.controller = controller;
            this.camera = camera;
            userInputState = new UserInputState();
        }

        public int CheckInput()
        {
            userInputState.direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
            if (userInputState.direction.magnitude >= 0.1f) return Move();
            else return 0;
        }

        public int Move()
        {
            userInputState.targetAngle = Mathf.Atan2(userInputState.direction.x, userInputState.direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            userInputState.angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, userInputState.targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, userInputState.angle, 0f);
            userInputState.moveDirection = Quaternion.Euler(0f, userInputState.targetAngle, 0f) * Vector3.forward;
            controller.Move(userInputState.moveDirection.normalized * speed * Time.deltaTime);
            return 1;
        }
    }
}