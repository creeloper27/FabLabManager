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



        public static void addNewSubscriber(string name, string surname, string dateofbirth, string address, string city, string country, string postcode, string telephone, string email) {
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

        public static string[] loadSubscibers(int row_subscriber) {
            string[] subscriber_array = new string[9];

            using (StreamReader inputFile = File.OpenText(directoryData + "/" + fileSubscribers)) {
                string line = "";
                int count_rows = 0;
                while ((line = inputFile.ReadLine()) != null || row_subscriber == count_rows) {
                    Console.WriteLine(line);
                    count_rows = count_rows + 1; // count++;

                    // Qui dobbiamo cercare di ottenere la nostra riga e restituirla come subscriber_array.
                }
            }

            return subscriber_array;
        }

        private void delSubscriber() {

        }

        private void editSubscriber() {

        }

        public static void showSubscriber() {

            using (StreamReader inputFile = File.OpenText(directoryData + "/" + fileSubscribers)) {
                string line = "";
                while ((line = inputFile.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
