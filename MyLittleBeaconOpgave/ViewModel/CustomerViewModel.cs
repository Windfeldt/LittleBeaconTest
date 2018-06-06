using System;
using System.ComponentModel;
using Xamarin.Forms;
using MyLittleBeaconOpgave.Models;
using System.Collections.ObjectModel;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using MyLittleBeaconOpgave.Data;


namespace MyLittleBeaconOpgave.ViewModel
{



    class CustomerViewModel : INotifyPropertyChanged
    {

        public ListView defaultListe = null;
        public ListView liste { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public CustomerViewModel()
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            //DefaultListeCommand = new Command(DefaultListeMetode);
            DownloadCommand = new Command(DowloadCommandMetode);
        }

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opgave.gz");
        string filePath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opgave.db");

        //public Command DefaultListeCommand { get; }
        public Command DownloadCommand { get; }
        public List<Customer> customerlist;



        //public ListView DefaultListe
        //{
        //    get { return defaultListe; }
        //    set
        //    {
        //        defaultListe = value;
        //        OnpropertyChanged("DefaultListe");
        //    }

        //}

        public List<Customer> Customerlist
        {

            get { return customerlist; }
            set
            {
                customerlist = value;
                OnpropertyChanged("Customerlist");
            }

        }



        //public void DefaultListeMetode(){}


        public void DowloadCommandMetode()
        {

            // WebClient client = new WebClient();

            if (File.Exists(filePath))
            {
                var finfo = new FileInfo(filePath);

                //  Decompress(finfo);

                App.CustomerController.GetCustomer();

                Customerlist = App.CustomerController.tablelist;



                return;
            }
            else
            {

                //client.DownloadFile("http://poopeiko.dk/opgave.gz", Directorypath);
                try
                {
                    string url = @"http://poopeiko.dk/opgave.gz";
                    // Create an instance of WebClient
                    WebClient client = new WebClient();

                    client.DownloadFileCompleted += Client_DownloadFileCompleted;


                    client.DownloadFileAsync(new Uri(url), filePath);

                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }

        }


        public void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);
                newFileName += ".db";
                using (FileStream decompressedFileStream = File.Create(filePath1))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }

            }
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!File.Exists(filePath))
            {
                // No file
                return;
            }

            // Extract
            var finfo = new FileInfo(filePath);

            Decompress(finfo);

        }
    }
}
#region old code
//using System;
//using MyLittleBeaconOpgave.Models;
//using System.Collections.ObjectModel;
//using System.Net;
//using System.IO;
//using System.IO.Compression;
//using System.ComponentModel;

//namespace MyLittleBeaconOpgave.ViewModel
//{
//    public class CustomerViewModel
//    {

//        public CustomerViewModel()
//        {
//        }

//        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opgave.gz");
//        string filePathDb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "opgave.db");

//        public async void Handle_Clicked(object sender, System.EventArgs e)
//        {
//            // WebClient client = new WebClient();

//            if (File.Exists(filePath))
//            {
//                var finfo = new FileInfo(filePath);

//                Decompress(finfo);


//                return;
//            }


//            //client.DownloadFile("http://poopeiko.dk/opgave.gz", Directorypath);
//            try
//            {
//                string url = @"http://poopeiko.dk/opgave.gz";
//                // Create an instance of WebClient
//                WebClient client = new WebClient();

//                client.DownloadFileCompleted += Client_DownloadFileCompleted;


//                client.DownloadFileAsync(new Uri(url), filePath);

//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }


//        public static void Decompress(FileInfo fileToDecompress)
//        {
//            using (FileStream originalFileStream = fileToDecompress.OpenRead())
//            {
//                string currentFileName = fileToDecompress.FullName;
//                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

//                using (FileStream decompressedFileStream = File.Create(newFileName))
//                {
//                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
//                    {
//                        decompressionStream.CopyTo(decompressedFileStream);
//                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
//                    }
//                }
//            }
//        }



//        // List<Customer> cuss = App.CustomerController.GetCustomer();
//        //hej.ItemsSource = cuss;


//        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
//        {
//            if (!File.Exists(filePath))
//            {
//                // No file
//                return;
//            }

//            // Extract
//            var finfo = new FileInfo(filePathDb);

//            Decompress(finfo);
//        }
//    }
//}
#endregion
