using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVR
{
    /// <summary>
    /// 인풋 받아서 손 애니메이션 구현
    /// </summary>
    public class AnimateHandOnInput : MonoBehaviour
    {
        #region Variables
        //참조
        private Animator animator;

        //인풋
        public InputActionProperty pinchAnimationAction;
        public InputActionProperty gripAnimationAction;

        //애니 파라미터
        private string grip = "Grip";
        private string trigger = "Trigger";
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            //인풋 처리
            float triggerValue = pinchAnimationAction.action.ReadValue<float>();
            float gripValue = gripAnimationAction.action.ReadValue<float>();

            animator.SetFloat(trigger, triggerValue);
            animator.SetFloat(grip, gripValue);
        }
        #endregion

    }
}
