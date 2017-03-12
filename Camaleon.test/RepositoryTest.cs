using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using MongoDB.Bson;

namespace Camaleon.test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var x = new Camaleon.lib.Repository("ticker_data");
        }

        [TestMethod]
        public void GetAllTest()
        {
            var x = new Camaleon.lib.Repository("ticker_data");
            var y = x.Query().Where(z => z["success"] == true).ToList();
        }

        [TestMethod]
        public void InsertTest()
        {
            var db = new Camaleon.lib.Repository("DataTest");
            var data = new BsonDocument
                {
                    { "name", "joachim" }
                };

            db.Insert(data);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var db = new Camaleon.lib.Repository("DataTest");
            var data = db.Query().FirstOrDefault();
            data["name"] = "joachim modificado" ;

            db.Save(data);
        }

        [TestMethod]
        public void DeleteTest()
        {
            var db = new Camaleon.lib.Repository("DataTest");
            var data = db.Query().FirstOrDefault();

            db.Delete(data);
        }
    }
}
