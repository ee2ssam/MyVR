using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVR
{
    /// <summary>
    /// 게임중 메뉴를 관리하는 클래스
    /// </summary>
    public class GameMenuUI : MonoBehaviour
    {
        #region Variables
        //UI
        public GameObject playUI;
        public GameObject pausedUI;
        public GameObject sequenceUI;
        public GameObject gameoverUI;

        //인풋
        public InputActionProperty menuButton;

        //UI 위치 세팅
        public Transform head;          //xr 오리진의 헤드 위치 = 카메라 위치

        [SerializeField] private float distance = 2f;   //플레이어와 UI의 거리
        [SerializeField] private float height = 0f;      //플레이어의 눈으로 부터의 높이
        #endregion

        #region Unity Event Method
        private void Update()
        {
            if(menuButton.action.WasPressedThisFrame())
            {
                TogglePausedUI();
            }
        }
        #endregion

        #region Custom Method
        void TogglePausedUI()
        {
            playUI.SetActive(!playUI.activeSelf);
            pausedUI.SetActive(!pausedUI.activeSelf);

            //ui가 보인다
            if (playUI.activeSelf)
            {
                playUI.transform.position = head.position +
                    new Vector3(head.forward.x, height, head.forward.z).normalized * distance;
                Vector3 lookPosition = new Vector3(head.position.x, playUI.transform.position.y, 
                    head.position.z);
                playUI.transform.LookAt(lookPosition);
            }
        }

        public void ToggleGameOverUI()
        {
            playUI.SetActive(!playUI.activeSelf);
            gameoverUI.SetActive(!gameoverUI.activeSelf);

            //ui가 보인다
            if (playUI.activeSelf)
            {
                playUI.transform.position = head.position +
                    new Vector3(head.forward.x, height, head.forward.z).normalized * distance;
                Vector3 lookPosition = new Vector3(head.position.x, playUI.transform.position.y,
                    head.position.z);
                playUI.transform.LookAt(lookPosition);
            }
        }

        public void ToggleSequenceUI()
        {
            playUI.SetActive(!playUI.activeSelf);
            sequenceUI.SetActive(!sequenceUI.activeSelf);

            //ui가 보인다
            if (playUI.activeSelf)
            {
                playUI.transform.position = head.position +
                    new Vector3(head.forward.x, height, head.forward.z).normalized * distance;
                Vector3 lookPosition = new Vector3(head.position.x, playUI.transform.position.y,
                    head.position.z);
                playUI.transform.LookAt(lookPosition);
            }
        }
        #endregion
    }
}