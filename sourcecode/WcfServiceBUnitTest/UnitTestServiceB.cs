﻿using System;
using System.ServiceModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfServiceBUnitTest
{
    [TestClass]
    public class UnitTestServiceB
    {
        /// <summary>
        /// Test the connection is OK to the Service A through service B
        /// </summary>
        [TestMethod]
        public void VerifyConnectionOK()
        {
            WcfServiceB.ServiceB srvB = new WcfServiceB.ServiceB();
            Assert.AreEqual(true, srvB.ConnectionOK());
        }

        /// <summary>
        /// Test the connection is NOK to the Service A through service B
        /// </summary>
        [TestMethod]
        public void VerifyConnectionNOK()
        {
            WcfServiceB.ServiceB srvB = new WcfServiceB.ServiceB(new Uri("https://DOES_NOT_EXIST"));
            Assert.AreEqual(false, srvB.ConnectionOK());
        }

    }
}
