﻿using System.Collections.Generic;
using IdentityServer4.Models;

namespace AuthServer
{
    public static class Config
    {

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                
                new ApiResource("resource_api1")
                {
                    Scopes = {"api.read", "api1.write", "api1.update"}
                },
                new ApiResource("resource_api2")
                {
                    Scopes = {"api2.read", "api2.write", "api2.update"}
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("api1.read", "API 1 icin okuma izni"),
                new ApiScope("api1.write", "API 1 icin yazma izni"),
                new ApiScope("api1.update", "API 1 icin güncelleme izni"),

                new ApiScope("api2.read", "API 2 icin okuma izni"),
                new ApiScope("api2.write", "API 2 icin yazma izni"),
                new ApiScope("api2.update", "API 2 icin güncelleme izni")
            };
        }
    }
}