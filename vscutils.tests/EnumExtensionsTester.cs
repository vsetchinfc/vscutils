using System;
using Xunit;

using VSC.Utils;

namespace vscutils.tests
{
    public class UnitTest1
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
    }
}
