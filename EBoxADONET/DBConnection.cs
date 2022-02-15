using System;
using System.Data.SqlClient;
using System.Xml;
using System.IO;

class DBConnection
{
    public static SqlConnection GetConnection()
    {
        String xmlString = System.IO.File.ReadAllText("mssql.xml");

        string username;
        string password;
        string schema;
        string host;

        using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
        {
            reader.ReadToFollowing("username");
            username = reader.ReadElementContentAsString();
            reader.ReadToFollowing("password");
            password = reader.ReadElementContentAsString();
            reader.ReadToFollowing("host");
            host = reader.ReadElementContentAsString();
            reader.ReadToFollowing("schema");
            schema = reader.ReadElementContentAsString();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = " + host + "; Initial Catalog =" + schema + "; User Id=" + username + "; Password=" + password);
        return conn;
    }
}