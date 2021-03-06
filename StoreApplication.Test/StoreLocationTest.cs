﻿using StoreApplication.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StoreApplication.Test
{
    public class StoreLocationTest
    {
        StoreLocation store = new StoreLocation();

        [Fact]
        public void StoreAddressInfoIsEmptyThrowsException()
        {
            Assert.ThrowsAny<ArgumentException>(() => store.Address1 = "");
            Assert.ThrowsAny<ArgumentException>(() => store.City = "");
            Assert.ThrowsAny<ArgumentException>(() => store.State = "");
            Assert.ThrowsAny<ArgumentException>(() => store.Zip = "");
        }


        [Fact]
        public void StoreNameCannotBeEmpty()
        {
            Assert.ThrowsAny<ArgumentException>(() => store.Name = "");
        }

        


    }
}