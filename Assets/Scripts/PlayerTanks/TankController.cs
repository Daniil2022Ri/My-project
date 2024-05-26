
using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerTanks
{
    public class TankController : MonoBehaviour
    {
        [Header("Settings Body and Head Player")]
        [SerializeField] private CharacterController controller;
        [SerializeField] private Transform towerTank;
        [SerializeField] private Transform towerTankWeapon;
        [SerializeField] private Transform bodyTankPlayer;

        [Header("Settings wheels Player")] 
        [SerializeField] private Transform [] wheelsTanksPlayer;

        [SerializeField][Range(0f,120f)] private float speedRotationWheels;

        private Vector3 _moving;

        [Header("Settings Moving Tank ")]
        [SerializeField][Range(0f,30f)] private float  moveSpeedTanksGround;

        [SerializeField] [Range(0f, 130f)] private float rotationSpeedTanksBody;
       

        [Header("Limitation of angles Tower and Weapon Tank ")] 
        
        [SerializeField] private float offsetHorizontalTower;
        
        [SerializeField] private float offsetVerticalWeapon;

        [SerializeField][Range(0f,120f)] private float moveSpeedTowerTank;

        [SerializeField] [Range(0f, 120f)] private float moveSpeedTowerWeaponTank;
        
        private Vector3 _rotationTowerTank; 
        private Vector3 _rotationTowerWeaponTank;
        private Vector3 _movingPlayerTank;
        private Vector3 _rotationBodyTank;

        private void Start()
        {
            controller.GetComponent<CharacterController>();
            
        }

        private void Update()
        {
            _rotationTower();
            _movingTank();
            

        }

        private void _rotationTower()
        {
            _rotationTowerTank.y = Input.GetAxis("Mouse X") * moveSpeedTowerTank * Time.deltaTime;
            _rotationTowerWeaponTank.x = Input.GetAxis("Mouse Y") * -moveSpeedTowerWeaponTank * Time.deltaTime;

            towerTank.transform.Rotate(_rotationTowerTank);
            towerTankWeapon.transform.Rotate(_rotationTowerWeaponTank);
        }

        private void _movingTank()
        {
            _rotationBodyTank.y = Input.GetAxis("Horizontal") * rotationSpeedTanksBody * Time.deltaTime;
            
            float _forwardMove = Input.GetAxis("Vertical") * moveSpeedTanksGround * Time.deltaTime;

            _movingPlayerTank = transform.forward * _forwardMove;
            
            controller.Move(_movingPlayerTank);
            
            bodyTankPlayer.transform.Rotate(_rotationBodyTank);

            
                _rotationWheelsPlayer();
            
            
        }

        private void _rotationWheelsPlayer()
        {
            float speed = Input.GetAxis("Vertical");

            if (speed > 0 && speed < 0)
            {
                
            
                 foreach (Transform value in wheelsTanksPlayer)
                    {
                        value.Rotate(Vector3.right * speedRotationWheels);
                    }
            
            }
        }

    }
}
