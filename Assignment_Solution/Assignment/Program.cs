using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment {
    class Program {
        static void Main(string[] args) {

            #region Setup
            //Console.WriteLine("Boob");
            //Console.ReadLine();
            int dt256StudensAmount = 12;
            Random rnd = new Random();
            #region SetClass A
            DataSet dt256A = new DataSet(); ;
            dt256A.fristNames = new string[dt256StudensAmount];
            dt256A.lastNames = new string[dt256StudensAmount];
            dt256A.studentNumbers = new string[dt256StudensAmount];
            dt256A.courseStatus= new string[dt256StudensAmount];
            dt256A.courseNumber = new string[dt256StudensAmount];
            string[] fristNamesMen = {"Adam", "Ben", "Conor","David" ,"Eoin", "Frank","Geoffery","Harry", "Ike","James", "Kevin",
                                    "Linkin", "Michael", "Nole", "Oliver", "Peter", "Roger", "Steve","Tom", "Victor", "William"};
            string[] fristNamesWoman = {"Aoife", "Bella", "Clare","Dora" ,"Elly", "Farncine","Gillian","Haley", "India","Janet", "Kaian",
                                    "Linda", "Monna", "Nora", "Olivia", "Paula", "Riliey", "Sharan","Tilli", "Victoria", "Wendy"};
            string[] lastNames = {"Anderson", "Brooks", "Cahill","Davision" ,"Earkison", "Franklin","Gripe","Harangson", "Ivor","Jacson", "Kains",
                                    "Landson", "Michaels", "Nnocks", "Okelly", "Patterson", "Rider", "Salt","Tipp", "Vagnor", "Williams"};
            int helpVal = 0;

            Assigen:
            if (rnd.Next(1, 9) < 5) {
                dt256A.fristNames[helpVal] = fristNamesMen[rnd.Next(1, 20)];
            } else {
                dt256A.fristNames[helpVal] = fristNamesWoman[rnd.Next(1, 20)];
            }
            dt256A.lastNames[helpVal] = lastNames[rnd.Next(0, 20)];
            dt256A.courseNumber[helpVal]= "DT256A";
            dt256A.courseStatus[helpVal] = "PartTime";

            dt256A.studentNumbers[helpVal] = "C" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            helpVal++;
            if (helpVal < dt256StudensAmount) {

                goto Assigen;
            }

    
            #endregion SetClass A

            #region SetClassC
            int dt256cStudensAmount = 10;
            DataSet dt256C = new DataSet();
            dt256C.fristNames = new string[dt256cStudensAmount];
            dt256C.lastNames = new string[dt256cStudensAmount];
            dt256C.studentNumbers = new string[dt256cStudensAmount];
            dt256C.courseStatus = new string[dt256cStudensAmount];
            dt256C.courseNumber = new string[dt256cStudensAmount];

            helpVal = 0;
            AssigenTwo:

            if (rnd.Next(1, 9) < 5) {
                dt256C.fristNames[helpVal] = fristNamesMen[rnd.Next(1, 20)];
            } else {
                dt256C.fristNames[helpVal] = fristNamesWoman[rnd.Next(1, 20)];
            }
            dt256C.lastNames[helpVal] = lastNames[rnd.Next(0, 20)];
            dt256C.courseNumber[helpVal] = "DT256C";
            dt256C.courseStatus[helpVal] = "PartTime";
            dt256C.studentNumbers[helpVal] = "C" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            helpVal++;
            if (helpVal < dt256cStudensAmount) {

                goto AssigenTwo;
            }

            #endregion SetClassC
            #region SetClass B
            int dt256bStudensAmount = 14;
            DataSet dt256B = new DataSet(); ;
            dt256B.fristNames = new string[dt256bStudensAmount];
            dt256B.lastNames = new string[dt256bStudensAmount];
            dt256B.studentNumbers = new string[dt256bStudensAmount];
            dt256B.courseStatus = new string[dt256bStudensAmount];
            dt256B.courseNumber = new string[dt256bStudensAmount];
            helpVal = 0;
            AssigenThree:

            if (rnd.Next(1, 9) < 5) {
                dt256B.fristNames[helpVal] = fristNamesMen[rnd.Next(0, 20)];
            } else {
                dt256B.fristNames[helpVal] = fristNamesWoman[rnd.Next(0, 20)];
            }
            dt256B.courseNumber[helpVal] = "DT256B";
            dt256B.courseStatus[helpVal] = "FullTime";
            dt256B.lastNames[helpVal] = lastNames[rnd.Next(1, 20)];
            dt256B.studentNumbers[helpVal] = "C" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            helpVal++;
            if (helpVal < dt256bStudensAmount) {

                goto AssigenThree;
            }


            #endregion SetClassB


            #region SetClass X
            int dt8900StudensAmount = 6;
            DataSet dt8900 = new DataSet();
            dt8900.fristNames = new string[dt8900StudensAmount];
            dt8900.lastNames = new string[dt8900StudensAmount];
            dt8900.studentNumbers = new string[dt8900StudensAmount];
            dt8900.courseStatus = new string[dt8900StudensAmount];
            dt8900.courseNumber = new string[dt8900StudensAmount];
            helpVal = 0;
            AssigenFour:

            if (rnd.Next(1, 9) < 5) {
                dt8900.fristNames[helpVal] = fristNamesMen[rnd.Next(1, 20)];
            } else {
                dt8900.fristNames[helpVal] = fristNamesWoman[rnd.Next(1, 20)];
            }
            dt8900.courseNumber[helpVal] = "DT9800";
            dt8900.courseStatus[helpVal] = "FullTime";
            dt8900.lastNames[helpVal] = lastNames[rnd.Next( 1, 20)];
            dt8900.studentNumbers[helpVal] = "C" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            helpVal++;
            if (helpVal < dt8900StudensAmount) {

                goto AssigenFour;
            }


            #endregion SetClassx
            #endregion Setup

            DataSet allData = new DataSet();
            int totalNumberOfStudents = dt256A.fristNames.Length + dt256B.fristNames.Length + dt256C.fristNames.Length + dt8900.fristNames.Length;
            allData = SortAlb(dt256A, dt256B, dt256C, dt8900, totalNumberOfStudents);
            
#region Active
            bool active = true;
            Console.WriteLine("Type help for all comands ");
            while (active) {
                Console.WriteLine("Input Command");
                string input = Console.ReadLine();

                if (input.ToLower() == "search all") {

                    for (int i = 0; i < allData.lastNames.Length; i++) {

                        Console.WriteLine(allData.courseNumber[i] + "| " + allData.lastNames[i] + " | " + allData.fristNames[i] + " | " + allData.studentNumbers[i] + " | " + allData.courseStatus[i]);

                    }


                }else if(input.ToLower() == "help"){
                    Console.WriteLine(" search all = returns all known students \n help = brings this information \n info = search by required info \n fulltime and parttime have no spaces when searching for them");

                }else {
                    
                    Search(allData, input);
                }
            
        

            }
            #endregion Active
        }

        public static void Search(DataSet A, string input) {

            //for (int i = 0; i < A.fristNames.Length; i++) {
               // Console.WriteLine(input);
            //}

            int[] restults = new int[41];
            int noFound = 0;
            for (int i = 0; i < A.lastNames.Length; i++) {
                if (input.ToLower() == A.courseNumber[i].ToLower() || input.ToLower() == A.lastNames[i].ToLower() || input.ToLower() == A.fristNames[i].ToLower() || input.ToLower() == A.courseStatus[i].ToLower()) {
                    restults[noFound] = i;
                    noFound++;

                }

            }
           // Console.WriteLine(noFound + "noFound");
            for (int i = 0; i < noFound; i++) {

                Console.WriteLine(A.courseNumber[restults[i]] + "| " + A.lastNames[restults[i]] + " | " + A.fristNames[restults[i]] + " | " + A.studentNumbers[restults[i]] + " | " + A.courseStatus[restults[i]]);

            }

        }

        public static DataSet MergeList(DataSet listOne, DataSet listTwo, DataSet listThree, DataSet listFour, int totalNumber) {
            DataSet mergedList = new DataSet();


            mergedList.fristNames = new string[totalNumber];
            mergedList.lastNames = new string[totalNumber];
            mergedList.studentNumbers = new string[totalNumber];
            mergedList.courseStatus = new string[totalNumber];
            mergedList.courseNumber = new string[totalNumber];


            for (int i = 0; i < listOne.fristNames.Length; i++) {
                mergedList.fristNames[i] = listOne.fristNames[i];
                mergedList.lastNames[i] = listOne.lastNames[i];
                mergedList.studentNumbers[i] = listOne.studentNumbers[i];
                mergedList.courseNumber[i] = listOne.courseNumber[i];
                mergedList.courseStatus[i] = listOne.courseStatus[i];
            }

            int offset = listOne.fristNames.Length;
            for (int i = 0; i < listTwo.fristNames.Length; i++) {
                mergedList.fristNames[i + offset] = listTwo.fristNames[i];
                mergedList.lastNames[i + offset] = listTwo.lastNames[i];
                mergedList.studentNumbers[i + offset] = listTwo.studentNumbers[i];
                mergedList.courseNumber[i + offset] = listTwo.courseNumber[i];
                mergedList.courseStatus[i + offset] = listTwo.courseStatus[i];
            }
            offset += listTwo.studentNumbers.Length;
            //IntertionSort(mergedList, offset, offset + listTwo.fristNames.Length-2);

            //offset += listTwo.studentNumbers.Length;
            for (int i = 0; i < listThree.fristNames.Length; i++) {
                mergedList.fristNames[i + offset] = listThree.fristNames[i];
                mergedList.lastNames[i + offset] = listThree.lastNames[i];
                mergedList.studentNumbers[i + offset] = listThree.studentNumbers[i];
                mergedList.courseNumber[i + offset] = listThree.courseNumber[i];
                mergedList.courseStatus[i + offset] = listThree.courseStatus[i];
            }
            offset += listThree.studentNumbers.Length;
            for (int i = 0; i < listFour.fristNames.Length; i++) {
                mergedList.fristNames[i + offset] = listFour.fristNames[i];
                mergedList.lastNames[i + offset] = listFour.lastNames[i];
                mergedList.studentNumbers[i + offset] = listFour.studentNumbers[i];
                mergedList.courseNumber[i + offset] = listFour.courseNumber[i];
                mergedList.courseStatus[i + offset] = listFour.courseStatus[i];
            }

            return mergedList; 

        }

        public static DataSet SortAlb(DataSet listOne, DataSet listTwo, DataSet listThree, DataSet listFour, int totalNumber) {

            DataSet mergedList = new DataSet();


            mergedList.fristNames = new string[totalNumber];
            mergedList.lastNames = new string[totalNumber];
            mergedList.studentNumbers = new string[totalNumber];
            mergedList.courseStatus = new string[totalNumber];
            mergedList.courseNumber = new string[totalNumber];
            mergedList = MergeList(listOne, listTwo, listThree, listFour, totalNumber);

            // BubbleSort

            for (int i = 0; i < (mergedList.fristNames.Length /2)-1; i++) {

                for (int x = 0; x < (mergedList.fristNames.Length/2)-1; x++) {

                    //if (mergedList.lastNames[x] != null && mergedList.lastNames[x + 1] != null) {
                    char[] one = mergedList.lastNames[x].ToCharArray();
                    char[] two = mergedList.lastNames[x + 1].ToCharArray();

                    if (one[0] != two[0] && one[0] > two[0]) {
                        //temp values
                        string tempName = mergedList.fristNames[x];
                        string tempLastName = mergedList.lastNames[x];
                        string tempStudentNumber = mergedList.studentNumbers[x];
                        string tempCourse = mergedList.courseNumber[x];
                        string tempCourseStat = mergedList.courseStatus[x];

                        //swaping
                        mergedList.fristNames[x] = mergedList.fristNames[x + 1];
                        mergedList.fristNames[x + 1] = tempName;
                        // swaping last name
                        mergedList.lastNames[x] = mergedList.lastNames[x + 1];
                        mergedList.lastNames[x + 1] = tempLastName;
                        // swaping student number
                        mergedList.studentNumbers[x] = mergedList.studentNumbers[x + 1];
                        mergedList.studentNumbers[x + 1] = tempStudentNumber;
                        // swapiing course
                        mergedList.courseNumber[x] = mergedList.courseNumber[x + 1];
                        mergedList.courseNumber[x + 1] = tempCourse;
                        // swapping part or full time
                        mergedList.courseStatus[x] = mergedList.courseStatus[x + 1];
                        mergedList.courseStatus[x + 1] = tempCourseStat;
                    } else if(one[0] == two[0]) {
                        one = mergedList.fristNames[x].ToCharArray();
                        two = mergedList.fristNames[x + 1].ToCharArray();
                        if (one[0] > two[0] ) {
                           // Console.WriteLine("Swap part two"  );
                            //temp values
                            string tempName = mergedList.fristNames[x];
                            string tempLastName = mergedList.lastNames[x];
                            string tempStudentNumber = mergedList.studentNumbers[x];
                            string tempCourse = mergedList.courseNumber[x];
                            string tempCourseStat = mergedList.courseStatus[x];

                            //swaping
                            mergedList.fristNames[x] = mergedList.fristNames[x + 1];
                            mergedList.fristNames[x + 1] = tempName;
                            // swaping last name
                            mergedList.lastNames[x] = mergedList.lastNames[x + 1];
                            mergedList.lastNames[x + 1] = tempLastName;
                            // swaping student number
                            mergedList.studentNumbers[x] = mergedList.studentNumbers[x + 1];
                            mergedList.studentNumbers[x + 1] = tempStudentNumber;
                            // swapiing course
                            mergedList.courseNumber[x] = mergedList.courseNumber[x + 1];
                            mergedList.courseNumber[x + 1] = tempCourse;
                            // swapping part or full time
                            mergedList.courseStatus[x] = mergedList.courseStatus[x + 1];
                            mergedList.courseStatus[x + 1] = tempCourseStat;
                        } 


                    }
                }
            }

            for (int i = mergedList.fristNames.Length/2; i < mergedList.fristNames.Length; i++) {
                string currentHeld = mergedList.lastNames[i];
                char[] currentTest = currentHeld.ToCharArray();
                int heldSpot = i;
                char[] A = mergedList.lastNames[heldSpot - 1].ToCharArray();
                while (heldSpot > 1 && A[0] >= currentTest[0]) {

                    if (A[0] != currentTest[0]) {
                        mergedList.lastNames[heldSpot] = mergedList.lastNames[heldSpot - 1];
                        mergedList.fristNames[heldSpot] = mergedList.fristNames[heldSpot - 1];
                        mergedList.studentNumbers[heldSpot] = mergedList.studentNumbers[heldSpot - 1];
                        mergedList.courseNumber[heldSpot] = mergedList.courseNumber[heldSpot - 1];
                        mergedList.courseStatus[heldSpot] = mergedList.courseStatus[heldSpot - 1];
                        heldSpot--;
                        A = mergedList.lastNames[heldSpot - 1].ToCharArray();
                    } else {
                        string heldFristName = mergedList.fristNames[i];
                        string testingfristName = mergedList.fristNames[heldSpot];
                        char[] heldFristNameChar = heldFristName.ToCharArray();
                        char[] heldTestNameChar = testingfristName.ToCharArray();

                        if(heldFristNameChar[0] > heldTestNameChar[0]) {
                            mergedList.lastNames[heldSpot] = mergedList.lastNames[heldSpot - 1];
                            mergedList.fristNames[heldSpot] = mergedList.fristNames[heldSpot - 1];
                            mergedList.studentNumbers[heldSpot] = mergedList.studentNumbers[heldSpot - 1];
                            mergedList.courseNumber[heldSpot] = mergedList.courseNumber[heldSpot - 1];
                            mergedList.courseStatus[heldSpot] = mergedList.courseStatus[heldSpot - 1];
                            heldSpot--;
                            A = mergedList.lastNames[heldSpot - 1].ToCharArray();


                        } else {
                            heldSpot--;
                            A = mergedList.lastNames[heldSpot - 1].ToCharArray();

                        }



                    }


                }

                mergedList.lastNames[heldSpot] = currentHeld;

            }
            Console.WriteLine(mergedList.lastNames.Length + " Students total");
                return mergedList;
         }

 
    }


}



public struct DataSet {
    public string[] fristNames , lastNames, studentNumbers;
    public string[] courseNumber, courseStatus;
}




