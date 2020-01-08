using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class DoorsMonoBehaviour : MonoBehaviour
    {
        #region Fields
        /// <summary>
        /// Know if one of the doors is opened
        /// </summary>
        public bool HasOneOpened
        {
            get
            {
                bool isOpened = false;
                if (this.doors != null)
                {
                    isOpened = this.doors.Any(x => x.IsOpened);
                }
                return isOpened;
            }
        }

        /// <summary>
        /// Door objects
        /// </summary>
        public List<DoorMonoBehaviour> doors;
        #endregion
    }
}
