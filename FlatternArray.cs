using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace flatternArrayProgram {

    class Program {

        static void Main(string[] args) {

            Data data = new Data();
            data.dataArray.Add(0);
            data.dataArray.Add(10);
            data.init();
            data.dataArray.Add(20);
            data.dataArray.Add(30);
            List<int> items = flatternHierarchyArray(data.dataArray);
            displayFlatternedData(items);
        }

        public static void displayFlatternedData(List<int> data) {
            foreach(var elem in data) {
                Console.WriteLine(elem);
            }
        }

        public static List<int> flatternHierarchyArray(ArrayList items) {

            List<int> flatternedItems = new List<int>();
            foreach (var elem in items) {
                if (elem is List<int>) {
                    List<int> item = (List<int>)elem;
                    foreach (int elem1 in item) {
                        flatternedItems.Add(elem1);
                    }
                } else {
                    flatternedItems.Add((int)elem);
                }
            }
            return flatternedItems;
        }
    }

    class Data {

        public ArrayList dataArray = new ArrayList();

        private bool isIntToFind(int number, int toFind) {
            if (number == toFind - 1) {
                return true;
            } return false;
        }

        public void init() {

            for (int i = 0; i < 10; i++) {

                List<int> partials = new List<int>();
                partials.Add(i);
                if (this.isIntToFind(i % 5, 5)) {
                    partials.Add(i);
                }
                dataArray.Add(partials);
            }
        }
    }
}