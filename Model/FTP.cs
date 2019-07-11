using System;
using System.IO;
using System.Xml.Linq;
using FluentFTP;

namespace Model
{
    class FTP
    {
        FtpClient client;
        private string user;
        private string password;
        private string host;
        private int port;
        string pathLocalXML = @"Data\Export.xml";
        string pathRemoteXML = @"Export.xml";
        string pathLocalDat = @"Data\Tests.dat";
        string pathRemoteDat = @"Tests.dat";
        string pathLocalResult = @"Data\Results.xml";
        string pathRemoteResult = @"Results.xml";

        public FTP()
        {
            UpdateSettings();
        }

        /// <summary>
        /// Установка данных для коннекта по FTP из файла
        /// </summary>
        void UpdateSettings()
        {
            try
            {
                XDocument xdoc = XDocument.Load(Path.Combine(Environment.CurrentDirectory, @"Data\Setting.xml"));
                XElement setting = xdoc.Element("Setting").Element("FTP");
                host = setting.Attribute("Ip").Value;
                port = Convert.ToInt32(setting.Attribute("Port").Value);
                user = setting.Attribute("Username").Value;
                password = setting.Attribute("Password").Value;
            }
            catch
            {
                host = "31.193.90.212";
                user = "education";
                password = "qG2BwS4M";
                port = 13021;
            }
        }

        public bool UpdateUploadXMLresult(Result res, string id)
        {
            try
            {
                using (client = new FtpClient(host, port, user, password))
                {
                    client.Connect();
                    File.Delete(pathLocalResult);
                    using (Stream fileStream = File.OpenWrite(pathLocalResult))
                    {
                        client.Download(fileStream, pathRemoteResult);
                    }

                    XDocument xdoc = XDocument.Load(pathLocalResult);
                    xdoc.Element("Offers").Add(new XElement("Offer", new XAttribute("Code", id),
                        new XAttribute("Theme1", res.r1.ToString()),
                        new XAttribute("Theme2", res.r2.ToString()),
                        new XAttribute("Theme3", res.r3.ToString()),
                        new XAttribute("Theme4", res.r4.ToString()),
                        new XAttribute("DateTimeTest", DateTime.Now.ToString("dd.MM.yyyy hh:mm"))
                        ));
                    xdoc.Save(pathLocalResult);

                    using (Stream fileStream = File.OpenRead(pathLocalResult))
                    {
                        client.Upload(fileStream, pathRemoteResult);
                    }
                    client.Disconnect();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UploadDat()
        {
            try
            {
                using (client = new FtpClient(host, port, user, password))
                {
                    client.Connect();
                    using (Stream fileStream = File.OpenRead(pathLocalDat))
                    {
                        client.Upload(fileStream, pathRemoteDat);
                    }
                    client.Disconnect();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DownloadXMLs()
        {
            try
            {
                using (client = new FtpClient(host, port, user, password))
                {
                    File.Delete(pathLocalResult);
                    File.Delete(pathLocalXML);
                    client.Connect();
                    using (Stream fileStream = File.OpenWrite(pathLocalXML))
                    {
                        client.Download(fileStream, pathRemoteXML);
                    }
                    using (Stream fileStream = File.OpenWrite(pathLocalResult))
                    {
                        client.Download(fileStream, pathRemoteResult);
                    }
                    client.Disconnect();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DownloadDat()
        {
            try
            {
                using (client = new FtpClient(host, port, user, password))
                {
                    client.Connect();
                    using (Stream fileStream = File.OpenWrite(pathLocalDat))
                    {
                        client.Download(fileStream, pathRemoteDat);
                    }
                    client.Disconnect();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
