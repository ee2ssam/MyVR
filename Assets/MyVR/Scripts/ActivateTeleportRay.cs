using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVR
{
    /// <summary>
    /// Activate 버튼을 누르면 텔레포트레이 활성화로 사용할 수 있게 한다
    /// </summary>
    public class ActivateTeleportRay : MonoBehaviour
    {
        #region Variables
        public GameObject leftTeleportRay;
        public GameObject rightTeleportRay;

        //Activate 버튼 인풋
        public InputActionProperty leftActivate;
        public InputActionProperty rightActivate;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            //Activate 버튼 인풋
            float leftValue = leftActivate.action.ReadValue<float>();
            float rightValue = rightActivate.action.ReadValue<float>();

            //텔레포트레이 활성화/비활성환
            leftTeleportRay.SetActive(leftValue > 0.1f);
            rightTeleportRay.SetActive(rightValue > 0.1f);

        }
        #endregion
    }
}