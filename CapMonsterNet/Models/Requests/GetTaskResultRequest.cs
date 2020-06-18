﻿using CapMonsterNet.Models.CaptchaTasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapMonsterNet.Models.Requests
{
    public class GetTaskResultRequest : BaseRequest
    {
        /// <summary>
        /// ID which was obtained in createTask method.
        /// </summary>
        public int TaskId { get; set; }
    }
}
