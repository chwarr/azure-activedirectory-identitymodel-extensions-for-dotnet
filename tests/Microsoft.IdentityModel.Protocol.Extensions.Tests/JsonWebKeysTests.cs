//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using Microsoft.IdentityModel.Protocols;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IdentityModel.Test;

namespace Microsoft.IdentityModel.Test
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class JsonWebKeysTests
    {
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassSetup(TestContext testContext)
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        [TestProperty("TestCaseID", "6dc1a5b5-d458-44ba-aa29-50ada648d191")]
        [Description("Tests: Constructors")]
        public void JsonWebKeys_Constructors()
        {
            JsonWebKeys jsonWebKeys = new JsonWebKeys();
            Assert.IsTrue(IsDefaultJsonWebKeys(jsonWebKeys));

            // null string, nothing to add
            RunJsonWebsKeyTest((string)null, jsonWebKeys, ExpectedException.NoExceptionExpected);

            // null dictionary, nothing to add
            RunJsonWebsKeyTest((IDictionary<string, object>)null, jsonWebKeys, ExpectedException.NoExceptionExpected, false);

            RunJsonWebsKeyTest(SharedData.JsonWebKeysString1,  SharedData.JsonWebKeysExpected1, ExpectedException.NoExceptionExpected);
            RunJsonWebsKeyTest(SharedData.JsonWebKeysBadFormatingString, null, ExpectedException.ArgumentException());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="compareTo"></param>
        /// <param name="expectedException"></param>
        /// <param name="asString"> this is useful when passing null for parameter 'is' and 'as' don't contain type info.</param>
        /// <returns></returns>
        private JsonWebKeys RunJsonWebsKeyTest(object obj, JsonWebKeys compareTo, ExpectedException expectedException, bool asString = true)
        {
            JsonWebKeys jsonWebKeys = null;
            try
            {
                if (obj is string)
                {
                    jsonWebKeys = new JsonWebKeys(obj as string);
                }
                else if (obj is IDictionary<string, object>)
                {
                    jsonWebKeys = new JsonWebKeys(obj as IDictionary<string, object>);
                }
                else
                {
                    if (asString)
                    {
                        jsonWebKeys = new JsonWebKeys(obj as string);
                    }
                    else
                    {
                        jsonWebKeys = new JsonWebKeys(obj as IDictionary<string, object>);
                    }
                }
                expectedException.ProcessNoException();
            }
            catch (Exception ex)
            {
                expectedException.ProcessException(ex);
            }

            if (compareTo != null)
            {
                Assert.IsTrue(IdentityComparer.AreEqual<JsonWebKeys>(jsonWebKeys, compareTo, CompareContext.Default), "jsonWebKeys created from: " + (obj == null ? "NULL" : obj.ToString() + " did not match expected."));
            }

            return jsonWebKeys;
        }

        [TestMethod]
        [TestProperty("TestCaseID", "ae4aac50-6410-49c3-8cd1-92d81681e8b9")]
        [Description("Tests: Defaults")]
        public void JsonWebKeys_Defaults()
        {
        }

        [TestMethod]
        [TestProperty("TestCaseID", "bffd5933-f161-4fb1-aaae-bb6ad8787972")]
        [Description("Tests: GetSets")]
        public void JsonWebKeys_GetSets()
        {
        }

        [TestMethod]
        [TestProperty("TestCaseID", "c8d70600-a3ac-4c88-bd9d-2140481d4cf7")]
        [Description("Tests: Publics")]
        public void JsonWebKeys_Publics()
        {
        }

        private bool IsDefaultJsonWebKeys(JsonWebKeys jsonWebKeys)
        {
            if (jsonWebKeys.Keys == null)
                return false;

            if (jsonWebKeys.Keys.Count != 0)
                return false;

            return true;
        }
    }
}