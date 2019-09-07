using System;
using Xunit;

using VSC.Utils;

namespace VSC.Tests.Utils
{
    public class EnumExtensionsTester
    {
        public enum DBType
        {
            [EnumName(Name = "Database is not supported")]
            None = 0,
            [EnumName(Name = "MySql Database")]
            MySql = 1,
            [EnumName(Name = "PostgreSQL Database")]
            Postgres = 2,
            [EnumName(Name = "Oracle Database")]
            Oracle = 3
        }

        public enum DBTypeNoAttr
        {
            None = 0,
            MySql = 1,
            Postgres = 2,
            Oracle = 3
        }

        [Fact]
        public void TestEnumToString()
        {
            DBType noneType = DBType.None;
            Assert.Equal("Database is not supported", noneType.EnumToString());

            DBType mySqlType = DBType.MySql;
            Assert.Equal("MySql Database", mySqlType.EnumToString());

            DBType postgresType = DBType.Postgres;
            Assert.Equal("PostgreSQL Database", postgresType.EnumToString());

            DBType oracleType = DBType.Oracle;
            Assert.Equal("Oracle Database", oracleType.EnumToString());
        }

        [Fact]
        public void TestEnumWithNoAtribute()
        {
            DBTypeNoAttr noneType = DBTypeNoAttr.None;
            Assert.Equal(noneType.ToString(), noneType.EnumToString());

            DBTypeNoAttr mySqlType = DBTypeNoAttr.MySql;
            Assert.Equal(mySqlType.ToString(), mySqlType.EnumToString());

            DBTypeNoAttr postgresType = DBTypeNoAttr.Postgres;
            Assert.Equal(postgresType.ToString(), postgresType.EnumToString());

            DBTypeNoAttr oracleType = DBTypeNoAttr.Oracle;
            Assert.Equal(oracleType.ToString(), oracleType.EnumToString());
        }
    }
}
