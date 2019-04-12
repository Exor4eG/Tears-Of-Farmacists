using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    public class Data
    {
        public TestData testData;
        public User user = null;
        public Result curResult;
        FTP FTP = new FTP();
        XDocument export;
        XDocument results;
        public bool downloadedFiles = false;
        public bool uploaded = false;
        public int choose = 0;

        public async void DownloadAllAsync()
        {
            downloadedFiles = await Task.Run(() => DownloadAll());
        }

        public async void UploadXMLAsync()
        {
            uploaded = await Task.Run(() => UploadXML());
        }

        /// <summary>
        /// Загрузка всех файлов
        /// </summary>
        public bool DownloadAll()
        {
            if(DownloadDat() & DownloadXML())
            {
                downloadedFiles = true;
            }
            return downloadedFiles;
        }

        /// <summary>
        /// Чтение XML файлов c данными по фармацевтам и результатами
        /// </summary>
        public void ReadXml()
        {
            export = XDocument.Load(@"Data\Export.xml");
            results = XDocument.Load(@"Data\Results.xml");
        }

        /// <summary>
        /// Чтение XDoc обьекта с результатами и запись в объект юзера
        /// </summary>
        public void ReadResults()
        {
            foreach (XElement res in results.Element("Offers").Elements("Offer"))
            {
                XAttribute code = res.Attribute("Code");
                if (code.Value == user.id)
                {
                    user.results.Add(new Result(
                        res.Attribute("Theme1").Value,
                        res.Attribute("Theme2").Value,
                        res.Attribute("Theme3").Value,
                        res.Attribute("Theme4").Value,
                        res.Attribute("DateTimeTest").Value)
                        );
                }
            }
        }

        /// <summary>
        /// Чтение dat файла
        /// </summary>
        public void Deserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"Data\Tests.dat", FileMode.OpenOrCreate))
            {
                testData = (TestData)formatter.Deserialize(fs);
            }
        }

        /// <summary>
        /// Запись в dat файл
        /// </summary>
        public void Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"Data\Tests.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, testData);
            }
        }

        /// <summary>
        /// Загрузка файла XML с FTP 
        /// </summary>
        public bool DownloadXML()
        {
            bool downloaded = false;
            for (int i = 0; i < 5; i++)
            {
                downloaded = FTP.DownloadXMLs();
                if (downloaded)
                    break;
                Thread.Sleep(500);
            }
            return downloaded;
        }

        /// <summary>
        /// Выгрузка XML файла на FTP
        /// </summary>
        public bool UploadXML()
        {
            bool downloaded = false;
            for (int i = 0; i < 10; i++)
            {
                downloaded = FTP.UpdateUploadXMLresult(curResult, user.id);
                if (downloaded)
                    break;
                Thread.Sleep(1000);
            }
            return downloaded;
        }

        /// <summary>
        /// Загрузка dat файла с FTP
        /// </summary>
        public bool DownloadDat()
        {
            bool downloaded = false;
            for (int i = 0; i < 5; i++)
            {
                downloaded = FTP.DownloadDat();
                if (downloaded)
                    break;
                Thread.Sleep(500);
            }
            return downloaded;
        }

        /// <summary>
        /// Выгрузка dat и xml файлов на FTP
        /// </summary>
        public bool UploadDat()
        {
            bool downloaded = false;
            for (int i = 0; i < 5; i++)
            {
                downloaded = FTP.UploadDat();
                if (downloaded)
                    break;
                Thread.Sleep(1000);
            }
            return downloaded;
        }

        /// <summary>
        /// Авторизация фармацевта
        /// </summary>
        /// <param Имя пользователя="nameU"></param>
        /// <param Пароль="passU"></param>
        /// <returns>Статус логирования</returns>
        public bool Login(string nameU, string passU)
        {
            bool logined = false;
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(passU));
            string hash = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            hash = @"\x" + hash;
            hash = hash.ToLower();

            foreach (XElement farmacer in export.Element("Offers").Elements("Offer"))
            {
                XAttribute name = farmacer.Attribute("Name");
                XAttribute pass = farmacer.Attribute("Password");

                if (nameU == name.Value && pass.Value == hash)
                {
                    XAttribute code = farmacer.Attribute("Code");
                    user = new User(nameU, code.Value);
                    logined = true;
                    break;
                }
            }
            return logined;
        }
    }
}
