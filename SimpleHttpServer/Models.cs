﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace SimpleHttpServer
{
    public class RequestModel
    {

        public string Function { get; set; }

        public string Data { get; set; }

        public string HashString { get; set; }
    }
    public class ResponseModel
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public string HashString { get; set; }
    }

    public class RouteResult
    {
        public object Handler { get; set; }
    }

    public class RouteInfo
    {
        public Type Action { get; set; }

        public MethodInfo Method { get; set; }

        public HttpMethod HttpVers { get; set; }

        public ParameterInfo[] ParameterInfos { set; get; }

        public string[] Segments { get; set; }

        public string AbsoluteUrl { get; set; }
    }
}
