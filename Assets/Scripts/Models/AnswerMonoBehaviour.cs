using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class AnswerMonoBehaviour : MonoBehaviour
    {
        #region Fields
        /// <summary>
        /// Answer identifier
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// Answer to display
        /// </summary>
        public string Value { get; set; }
        #endregion

    }
}
