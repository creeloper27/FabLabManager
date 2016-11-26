using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabLabManager {
    class FablabDB {

        public static string directoryData    = "Data";
        public static string fileSubscribers  = "FabLabSubscribers.txt";
        public static string fileCourses      = "FabLabCourses.txt";
        public static string fileParticipates = "FabLabParticipates.txt";
        public static char separator          = ';';


        public static void startController() {
            checkDataDirExist();
            if (Directory.Exists(directoryData)) {
                checkFileSubscriberExist();
                checkFileCoursesExist();
                checkFilePartecipatesExist();
            }
        }

        private static void checkDataDirExist() {
            if (!Directory.Exists(directoryData))
                Directory.CreateDirectory("Data");
        }

        private static void checkFileSubscriberExist() {
            if (File.Exists(directoryData + "/" + fileSubscribers)) {
            } else {
                fileSubscribersCreate();
            }
        }

        private static void checkFileCoursesExist() {
            if (File.Exists(directoryData + "/" + fileCourses)) {
            } else {
                fileCoursesCreate();
            }
        }

        private static void checkFilePartecipatesExist() {
            if (File.Exists(directoryData + "/" + fileParticipates)) {
            } else {
                fileParticipatesCreate();
            }
        }

        private static void fileSubscribersCreate() {
            File.Create(directoryData + "/" + fileSubscribers);
        }

        private static void fileCoursesCreate() {
            File.Create(directoryData + "/" + fileCourses);
        }

        private static void fileParticipatesCreate() {
            File.Create(directoryData + "/" + fileParticipates);
        }

        public static void deleteAllFile() {
            File.Delete(directoryData + "/" + fileSubscribers);
            File.Delete(directoryData + "/" + fileCourses);
            File.Delete(directoryData + "/" + fileParticipates);
        }

        public static void addSubscriber(string name, string surname, string dateofbirth, string address, string city, string country, string postcode, string telephone, string email) {
            using (StreamWriter outputFile = File.AppendText(directoryData + "/" + fileSubscribers)) {
                outputFile.WriteLine(name        + separator +
                                     surname     + separator +
                                     dateofbirth + separator +
                                     address     + separator +
                                     city        + separator +
                                     country     + separator +
                                     postcode    + separator +
                                     telephone   + separator +
                                     email       + separator
                                     );
            }
        }

        public static void editSubscriber(int id_subscriber, string name, string surname, string dateofbirth, string address, string city, string country, string postcode, string telephone, string email) {
            string[] arrLine = File.ReadAllLines(directoryData + "/" + fileSubscribers);
            arrLine[id_subscriber] = name        + separator +
                                     surname     + separator +
                                     dateofbirth + separator +
                                     address     + separator +
                                     city        + separator +
                                     country     + separator +
                                     postcode    + separator +
                                     telephone   + separator +
                                     email       + separator;
            File.WriteAllLines(directoryData + "/" + fileSubscribers, arrLine);
        }

        public static void deleteSubscriber(int row_subscriber) {
            string[] arrLine = File.ReadAllLines(directoryData + "/" + fileSubscribers);
            string[] arrLineNew = new string[arrLine.Length - 1];
            int y = 0;
            for (int i = 0; i < arrLineNew.Length; i++) {
                if (i == row_subscriber) {
                    
                }
                arrLineNew[i] = arrLine[y];
                /// SIAMO QUI NON VA NULLA.
            }
            File.WriteAllLines(directoryData + "/" + fileSubscribers, arrLineNew);
        }

        public static string[] loadSubsciber(int row_subscriber) {
            string[] subscriber_array = new string[8];
            using (StreamReader inputFile = File.OpenText(directoryData + "/" + fileSubscribers)) {
                string line = "";
                int count_rows = 0;
                while ((line = inputFile.ReadLine()) != null && row_subscriber != count_rows) {
                        count_rows = count_rows + 1; // count++;
                }
                subscriber_array = line.Split(separator);
            }
            return subscriber_array;
        }



        public static void showAllSubscribers() {
            using (StreamReader inputFile = File.OpenText(directoryData + "/" + fileSubscribers)) {
                string line = "";
                while ((line = inputFile.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
