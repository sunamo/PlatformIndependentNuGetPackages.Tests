using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Json.Tests
{

    [TestFixture]
    public class JsonObjectTests
    {
        private class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }


        [Test]
        public void Can_convert_to_type()
        {
            var bag = JsonParser.InitializeBag();
            bag["name"] = "Bob";
            bag["age"] = 21;

            var jsonObject = new JsonObject(bag);
            var person1 = jsonObject.Convert<Person>();
            var person2 = jsonObject.Convert(typeof(Person)) as Person;
            dynamic jsonObject3 = jsonObject;
            var person3 = (Person)jsonObject3;

            Assert.IsNotNull(person1);
            Assert.AreEqual("Bob", person1.Name);
            Assert.AreEqual(21, person1.Age);
            Assert.IsNotNull(person2);
            Assert.AreEqual("Bob", person2.Name);
            Assert.AreEqual(21, person2.Age);
            Assert.IsNotNull(person3);
            Assert.AreEqual("Bob", person3.Name);
            Assert.AreEqual(21, person3.Age);
        }

        #region Can_serialize
        [Test]
        public void Can_serialize_simple_example()
        {
            const string expected = @"{""name"":""spot""}";
            var dog = new Dog { Name = "spot" };

            var actual = JsonParser.Serialize(dog);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_serialize_simple_example2()
        {
            const string expected = @"{""name"":""spot""}";
            var dog = new ExternalLoginResult { IdUser= 1, Sc = "au1skm2qhjbwhmu4z0qwcpiv"};

            var actual = JsonParser.Serialize(dog);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_serialize_strings_with_characters_to_escape()
        {
            const string expected = @"{""name"":""Ba\""\/\\\b\f\n\r\tr""}";
            var dog = new Dog { Name = "Ba\"/\\\b\f\n\r\tr" };
            var actual = JsonParser.Serialize(dog);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_serialize_with_numbers()
        {
            const string expected = @"{""quantity"":8902,""cost"":45.33,""value"":-0.01063}";
            var instance = new
            {
                quantity = 8902,
                cost = 45.33,
                value = -1.063E-02
            };
            var actual = JsonParser.Serialize(instance);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_serialize_with_anonymous_types()
        {
            const string expected = @"{""array"":{""quantity"":8902,""cost"":45.33,""value"":-0.01063}}";
            var instance = new
            {
                array = new { quantity = 8902, cost = 45.33, value = -1.063E-02 }
            };
            var actual = JsonParser.Serialize(instance);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Can_serialize_with_dates()
        {
            var instance = new
            {
                now = DateTime.UtcNow
            };
            var actual = JsonParser.Serialize(instance);
            Trace.WriteLine(actual);
        }
        #endregion
    }

}
