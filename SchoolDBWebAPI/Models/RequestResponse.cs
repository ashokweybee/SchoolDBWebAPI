﻿namespace SchoolDBWebAPI.Models
{
    public class RequestResponse
    {
        public object Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}