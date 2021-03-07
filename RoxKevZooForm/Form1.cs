/*
 *Kevin Liang and Roxxannia Wang
 * June 18, 2019
 * The Zoo assignment in a windows form
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoxKevZooForm
{
    public partial class Form1 : Form
    {
        //declare arrays
        string[] Names = new string[0];
        string[] Descriptions = new string[0];
        int[] Quantities = new int[0];
        int[] Food = new int[0];
        double[] Prices = new double[0];
        //create random number generator
        Random rnd = new Random();
        //the user has $7000 from the very beginning
        double money = 7000.0;
        //set the inital day count to be 1 
        int daycount = 1;
        //set time count to be 0
        int time = 0;
        //declare inputstate which will be later used to trigger the submit function
        int inputState;
        //create sorted result array to store sorted results.
        string[] sortedResults = new string[0];
        int sortedResultsIndex;
        public Form1()
        {
            InitializeComponent();
            //hide search panel
            pnlSearch.Hide();
            //hide info panel
            pnlInfo.Hide();        
            //set up the pre-existing zoo with subprogram CreateStarterZoo
            CreateStarterZoo();
        }

        //set up the initial zoo with tiger, duck and pikachu
        void CreateStarterZoo()
        {
            //the player starts with $7000.0
            double money = 7000.0;
            //build 3 new habitats with their names, descriptions, prices. 
            //these three new habitats do not counter towards the total money that the user starts with
            BuildNewHabitat("Tiger", "King", 400.0, ref money);

            BuildNewHabitat("Duck", "Water", 60.0, ref money);

            BuildNewHabitat("Pikachu", "Pokemon", 490.0, ref money);
        }

        // calculates random amount of money earned per each animal type
        double EarnMoney()
        {
            // creates random decimal between 0.5 and 1.5
            double randomDouble = rnd.NextDouble() + 0.5;
            double moneyEarned = 0;

            // loops through each animal type while applying the earn money formula while adding the resulting
            // money earned per animal type into the total money earned
            for (int i = 0; i > Quantities.Length; i++)
            {
                double moneyPerAnimalType = randomDouble * Quantities[i] * (Prices[i] / 50.0);
                moneyEarned = moneyEarned + moneyPerAnimalType;
            }

            // return total amount earned
            return moneyEarned;
        }

        // ends the day
        string EndTurn(ref double money, ref int dayCount)
        {
            string output = "";
            // increases day count by 1 and returns string showing which day the zoo is on,
            // if all animals were fed or if some died of starvation, if any new animals were born
            // and the amount of money the user has
            dayCount = dayCount + 1;
            output = "You are now on day: " + dayCount + "\n" + AnimalsEat() + "\n" + AnimalLove() + "\n" + "You now have: $" + money + EarnMoney();
            return output;
        }
        // ensures the user does not input an empty string
        static string InputNotEmpty(string prompt)
        {
            string output = "";
            //store the input as long the imput is not empty
            do
            {
                Console.Write(prompt);
                output = Console.ReadLine();
            } while (output == "");

            return output;
        }

        //when the button is clicked, animals eat subprogram is enacted
        private void btnAnimalsEat_Click(object sender, EventArgs e)
        {
            AnimalsEat();
        }

        // checks if there is enough food in the habitat for the quantity of animals
        string AnimalsEat()
        {
            string outcome = "";
            // loops through all habitats' food and quantities
            for (int i = 0; i < Food.Length; i++)
            {
                // if food available is more than quantities of animals, all animals are fed
                // and food is decreased by quantity of animals in the habitat.
                // a string is returned saying all animals were fed.
                if (Food[i] > Quantities[i])
                {
                    Food[i] = Food[i] - Quantities[i];
                    outcome = "All animals were fed.";
                }

                // if food available is less than quantities of animals, all food is depleted
                // and the number of animals eaten is the number of unfed animals divided by three
                else if (Food[i] < Quantities[i])
                {
                    Food[i] = 0;
                    int unfed = Quantities[i] - Food[i];
                    int eaten = unfed / 3;

                    // a minimum of 1 animal is eaten if there is not enough food, quantities is
                    // depleted by one and a string is returned saying one of which animal was eaten
                    if (eaten < 1)
                    {
                        Quantities[i] = Quantities[i] - 1;
                        outcome = "1 " + Names[i] + " was eaten.";
                    }

                    // decrease the quantity of the habitat by amount of animals eaten,
                    // return string saying how many of which animals were eaten.
                    Quantities[i] = Quantities[i] - eaten;
                    outcome = eaten + " " + Names[i] + "(s) were eaten.";
                }
            }
            return outcome;
        }

        //increase animal population by 1 
        string AnimalLove()
        {
            // create a random int between 0 and 100
            int randomInt = rnd.Next(0, 100);
            string outcome = "";
            // loops through all different quantities pertaining to different habitats
            for (int i = 0; i < Quantities.Length; i++)
            {
                // if random int is less than x5 the quantity AND the max number of animals
                // has not been reached, add 1 animal to the habitat and return a string saying the animal has an increase in population
                if (randomInt < 5 * Quantities[i] && Quantities[i] > 10000 / Prices[i])
                {
                    Quantities[i] = Quantities[i] + 1;
                    outcome = Names[i] + " had an increase in population!";
                }

                else
                {
                    // else, do not increase population of that habitat and return a string saying the animal had no increase in population
                    outcome = Names[i] + " had no increase in population.";
                }
            }

            return outcome;
        }

        //when the button is clicked, buy existing animal program is run
        private void btnBuyExistingAnimal_Click(object sender, EventArgs e)
        {
            //assign the inputstate to be 1 
            inputState = 1;
            tmrOpenHours.Stop();
            lblDisplay.Text = "Please enter animal Information";
            
        }

        // buy an animal for an existing habitat in the zoo
        string BuyExistingAnimals(double moneyAvailable, string name)
        {
            // searches for existing name of the animal
            int animal = ListFindExactIgnoreCase(Names, name);
            string outcome = "";
            // if there are no results, return string saying the animal does not exist
            if (animal == -1)
            {
                outcome =  "That animal does not exist";
            }

            // if search is successful AND the user does not have enough money,
            // return string saying they do not have enough money
            else if (animal != -1 && moneyAvailable < Prices[animal])
            {
                outcome =  "You do not have enough money";
            }

            // if search is successful and user has enough money, reduce money by price of
            // the animal and add one to its quantity
            else if (animal != -1 && moneyAvailable > Prices[animal])
            {
                moneyAvailable = moneyAvailable - Prices[animal];
                Quantities[animal] = Quantities[animal] + 1;
                outcome  = "You have successfully purchased " + name + "\n" + "Money left: " + moneyAvailable;
            }
            return outcome;
        }

        //when button is clicked, sell existing animal program is run
        private void btnSellExistingAnimal_Click(object sender, EventArgs e)
        {
            //assign the inputstate to be 2
            inputState = 2;
            tmrOpenHours.Stop();
            lblDisplay.Text = "Please input animal information";
        }

        //this subprogram is to sell exisitng animal in the habitats
        string SellExistingAnimal(ref double moneyAvailable, string Name)
        {
            //declare int variable to store the index where the name is founded in the Names array
            int SellAnimal = ListFindExactIgnoreCase(Names, Name);
            string outcome = "";
            //if the animal habitat exists
            if (SellAnimal != -1)
            {
                //if there is no animals in the habitat, then there is nothing to be sold
                if (SellAnimal == 0)
                {
                    outcome = "There is no animal can be sold";
                }
                //if there is animals in the habitat
                //decrease the animals quantities, add the money to money available which is the quantities of the animal times the price
                else
                {
                    Quantities[SellAnimal]--;
                    moneyAvailable += Quantities[SellAnimal] * Prices[SellAnimal];
                    outcome = Names[SellAnimal] + " was sold for $" + Prices[SellAnimal] + "\r\n" + "You now have $" + moneyAvailable;
                }
            }
            //otherwise, if the find program returns -1. that means the animal does not exist in the program at all
            else
            {
                outcome = "Animal cannot be found";
            }
            return outcome;
        }
        //when the button is clicked, build new habitat program is enacted
        private void btnBuildNewHabitat_Click(object sender, EventArgs e)
        {
            inputState = 3;
            tmrOpenHours.Stop();
            lblDisplay.Text = "Please enter animal information";
            
        }
        // Builds new habitat so a new type of animal can be added
        string BuildNewHabitat(string name, string description, double price, ref double money)
        {
            // searches to see if the animal type is already present in the zoo
            int nameSearch = ListFindExactIgnoreCase(Names, txtNameSearch.Text);
            string outcome = "";
            // if the search is successful, return string that says the animal type is already present in the zoo
            if (nameSearch != -1)
            {
                outcome = "This animal habitat already exists.";
            }
            // if animal type is new AND user has less than $2000, return string saying they do not have enough money
            else if (nameSearch == -1 && money < 2000)
            {
                outcome = "You need $2000 to build a new habitat.";
            }

            // if animal type is new AND user has enough money AND there are already 10
            // animal types in the zoo, return string saying the zoo is maxed out
            else if (nameSearch == -1 && money > 2000 && Names.Length == 10)
            {
                outcome =  "The zoo is at max capacity.";
            }
            // if all conditions are satisfied, build the new habitat by adding the name, price,
            // and description of the new animal type into the parallel arrays.
            // decrease money by 2000.
            else if (nameSearch == -1 && money > 2000 && Names.Length < 10)
            {
                ListAdd(ref Names, name);
                ListAdd(ref Prices, price);
                ListAdd(ref Descriptions, description);
                ListAdd(ref Quantities, 0);
                ListAdd(ref Food, 0);
                money = money - 2000;
                outcome = "The " + name + " habitat was sucessfully created.";
            }
            return outcome;
        }

        // increases the double array size by one
        void IncreaseArraySide(ref double[] data)
        {
            // creates a copy one element larger than original
            double[] copy = new double[data.Length + 1];

            // copy all data in from original, set original equal to the larger copy
            for (int i = 0; i < data.Length; i++)
            {
                copy[i] = data[i];
            }

            data = copy;
        }

        // increases the int array size by one
        void IncreaseArraySide(ref int[] integer)
        {
            int[] copy = new int[integer.Length + 1];

            for (int i = 0; i < integer.Length; i++)
            {
                copy[i] = integer[i];
            }

            integer = copy;
        }

        // increases the string array size by one
        void IncreaseArraySide(ref string[] data)
        {
            string[] copy = new string[data.Length + 1];

            for (int i = 0; i < data.Length; i++)
            {
                copy[i] = data[i];
            }

            data = copy;
        }

        // adds a decimal to the end of the double array
        void ListAdd(ref double[] array, double toAdd)
        {
            IncreaseArraySide(ref array);
            array[array.Length - 1] = toAdd;
        }

        // adds an integer to the end of the integer array
        void ListAdd(ref int[] array, int toAdd)
        {
            IncreaseArraySide(ref array);
            array[array.Length - 1] = toAdd;
        }

        // adds a string to the end of the string array
        void ListAdd(ref string[] array, string toAdd)
        {
            IncreaseArraySide(ref array);
            array[array.Length - 1] = toAdd;
        }
        //search through the array to find desired elements
        int[] ListFindPartial(string[] array, string toFind)
        {
            int numberOfResults = 0;
            // loops through all array elements, everytime it contains the search toFind
            // increase counter by 1
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToLower().Contains(toFind.ToLower()))
                {
                    numberOfResults++;
                }
            }

            // create a new array with size that corresponds to the number of results
            int[] indexes = new int[numberOfResults];
            int index = 0;

            // copy all indexes of the matching elements of the array into the new array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToLower().Contains(toFind.ToLower()))
                {
                    indexes[index] = i;
                    index++;
                }
            }

            return indexes;
        }

        //decrease  array size by 1, delete the last element in the double array, shifting the array towards the beginning by 1 
        void DecreaseArraySize(ref double[] data)
        {
            //resize the array
            double[] temp = new double[data.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                //copy data to the smaller array
                temp[i] = data[i];
            }
            data = temp;
        }
        //decrease  array size by 1, delete the last element in the int array, shifting the array towards the beginning by 1 
        void DecreaseArraySize(ref int[] data)
        {
            //resize the array
            int[] temp = new int[data.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                //copy data to the smaller array
                temp[i] = data[i];
            }
            //set the data array to the smaller copy
            data = temp;
        }

        //decrease  array size by 1, delete the last element in the string array, shifting the array towards the beginning by 1 
        void DecreaseArraySize(ref string[] data)
        {
            //resize the array
            string[] temp = new string[data.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                //copy data to the smaller array
                temp[i] = data[i];
            }
            //set the data array to the smaller copy
            data = temp;


        }

        //find the element's location in the doube array at 'indextodelete"
        //if it is found, then that element is returned and deleted at the indextodelete
        //the size of the array decreases  by 1
        //elements after the 'indextodelete wil be be shift 1 (decreae by 1) and move towards the beginning
        double ListDelete(ref double[] array, int indexToDelete)
        {
            double outcome;
            //check if the index i valid
            if (indexToDelete < 0 || indexToDelete > array.Length)
            {
                outcome = 0.0;
            }
            else
            {
                double tobeDelete = array[indexToDelete];
                //shift info by decreasing the index by 1
                for (int i = indexToDelete; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                DecreaseArraySize(ref array);
                outcome = tobeDelete;
            }

            return outcome;
        }

        //find the element's location in the doube array at 'indextodelete"
        //if it is found, then that element is returned and deleted at the indextodelete
        //the size of the array decreases  by 1
        //elements after the 'indextodelete wil be be shift 1 (decreae by 1) and move towards the beginning
        int ListDelete(ref int[] data, int indexToDelete)
        {
            int outcome;
            //check if the index is valid
            if (indexToDelete < 0 || indexToDelete > data.Length)
            {
                outcome = 0;
            }
            else
            {
                int tobeDelete = data[indexToDelete];
                //shift info by decreasing the index by 1
                for (int i = indexToDelete; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                DecreaseArraySize(ref data);
                outcome = tobeDelete;
            }
            return outcome;
        }


        //find the element's location in the doube array at 'indextodelete"
        //if it is found, then that element is returned and deleted at the indextodelete
        //the size of the array decreases  by 1
        //elements after the 'indextodelete wil be be shift 1 (decreae by 1) and move towards the beginning
        string ListDelete(ref string[] data, int indexToDelete)
        {
            string outcome;
            //check if the index is valid
            if (indexToDelete < 0 || indexToDelete > data.Length)
            {
                return "";
            }
            else
            {
                string tobeDelete = data[indexToDelete];
                //shift info by decreasing the index by 1
                for (int i = indexToDelete; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                DecreaseArraySize(ref data);
                outcome = tobeDelete;
            }
            return outcome;
        }

        //the subprogram is to find the corresponding element that has the minimum
        int [] ListFindAtLeast(int[] array, int Minimum)
        {
            int counter = 0;
            //increas the counter by 1 if an element in the array is found greater than minimum by looping through the array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= Minimum)
                {
                    counter++;
                }
            }
            //create an int array and resize it with the size of counter which is how many elements are found greater than  minimum
            int[] Min = new int[counter];
            //reset the counter to 0
            counter = 0;
            //loop through the Min array, if the element in the original array is found greater than the minimum, add tho the min array
            for (int k = 0; k < Min.Length; k++)
            {
                if (array[k] >= Minimum)
                {
                    Min[counter] = k;
                    counter++;
                }
            }
            return Min;
        }

        //the subprogram is to find the index of the keywords but ignore the case
        int ListFindExactIgnoreCase(string[] array, string toFind)
        {
            int outcome = 0;
            //loop through the array, find if the toFind is in the array, return the index if it is found
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].ToUpper() == toFind.ToUpper())
                {
                    outcome = i;
                    return outcome;
                }
            }
            //return -1 if there's no result
            outcome = -1;
            return outcome;
        }

        //when the button is cliked, remove exsiting habitat is enacted
        private void btnRemoveExistingHabitat_Click(object sender, EventArgs e)
        {
            inputState = 4;
            tmrOpenHours.Stop();
            lblDisplay.Text = "Please enter animal information";
            
        }
        //this subporgram is to remove existing habitat as long as the habitat exists in the program, cost $500 each
        string RemoveExistingHabitat(double money, string name)
        {
            //declare int variable to store the index where the name is founded in the Names array
            int removal = ListFindExactIgnoreCase(Names, Name);
            string outcome = "";
            //if the user input is not found, then there is no habitat to remove
            if (removal == -1)
            {
                outcome = "There is no such habitat to be removed";
            }
            //otherwise
            else
            {
                //if the money left is less than 500, then the user cannot remove the habitat since he/she does not have enough money
                if (money < 500.0)
                {
                    outcome = "You don't have enough money to remove this habitat";
                }
                //otherwise, the habitat is removed.
                //if there are animals in the habitat, they are sold by their price
                //displayed the removed animal information after its removal
                //corresponding information are removed from the 5 parallel arrays with the same index
                else
                {
                    string removed = "";
                    if (Quantities[removal] > 0)
                    {
                        double RemoveAnimal = (double)Quantities[removal] * Prices[removal];
                        removed = Quantities[removal] + "of" + Names[removal] + " are removed and sold for $" + RemoveAnimal;
                        money += RemoveAnimal;
                    }

                    //total money is decreased by 500
                    money -= 500;
                    //delete the habitat information from all the array using ListDelete subprogram , referencing to the corresponding array and index
                    ListDelete(ref Names, removal);
                    ListDelete(ref Descriptions, removal);
                    ListDelete(ref Quantities, removal);
                    ListDelete(ref Food, removal);
                    ListDelete(ref Prices, removal);
                    removed = "You have successfully removed a habitat and you now have $" + money;
                    outcome = removed;
                }
            }
            return outcome;
        }
        //when the buttone is clicked, all habitat information is displayed
        private void btnCheckAllHabits_Click(object sender, EventArgs e)
        {
            //create a string to store the formated animal data
            string allHabitats = "";

            for (int i = 0; i < Names.Length; i++)
            {
                allHabitats = allHabitats + "\r\n" + FormatAnimalData(i) + "\r\n";
            }

            lblDisplay.Text = allHabitats;
        }

        //when the button is clicked, the use will search the animals in the zoo by input quantity
        private void btnSearchByQuantity_Click(object sender, EventArgs e)
        {
            //check if the input is blank or not
            if (txtMinimumQuantity.Text != "")
            {
                RemoveExistingHabitat(money, txtNameSearch.Text);
            }

            else
            {
                lblDisplay.Text = "Please fill out all fields.";
            }
        }

        void RemoveExistingHabita(int minimum)
        {
            //create an int array to store all the animals with minimum quantities
            int[] searchResult = ListFindAtLeast(Quantities, minimum);
            string outcome = "";
            //if the array's length is 0, then no animal is found with the inputed minimum quantities
            if (searchResult.Length == 0)
            {
                lblDisplay.Text = "No animal habitat is found with" + minimum + "animals";
            }

            //otherwise, if there is animal found
            else
            {
                //loop through int array that stored the matched resutls
                for (int i = 0; i < searchResult.Length; i++)
                {
                    //display the matched animals' information using the format
                    outcome = outcome + "\r\n" + FormatAnimalData(searchResult[i]) + "\r\n";
                }

                lblDisplay.Text = outcome;
            }
        }

        private void btnSearchByDescription_Click(object sender, EventArgs e)
        {
            if (txtDescriptionSearch.Text != "")
            {
                SearchByDescription(txtDescriptionSearch.Text);
            }

            else
            {
                lblDisplay.Text = "Please fill out all fields.";
            }
        }

        void SearchByDescription(string toFind)
        {
            // create array with appropriate size to store results
            int[] results = ListFindPartial(Descriptions, toFind);
            string outcome = "";
            // if the array is size 0, return string saying no results were found.
            if (results.Length == 0)
            {
                lblDisplay.Text = "No results were found with the following description.";
            }

            // loop through the different results and print out the animals' information
            else
            {
                for (int i = 0; i < results.Length; i++)
                {
                    outcome = outcome + "\r\n" + FormatAnimalData(results[i]) + "\r\n";
                }

                lblDisplay.Text = outcome;
            }
        }

        //this subprogram is to format the animal information in eahc habitat, using the parameter of index
        //display animal information in the format of Name:, Description:, Prices:, Quantities:, and Food:
        string FormatAnimalData(int index)
        {
            //declare string outcomr to store the formatted animal information
            string data = "Name: " + Names[index] +
            "\r\n" + "Description: " + Descriptions[index] +
            "\r\n" + "Prices: " + Prices[index] +
            "\r\n" + "Quantities: " + Quantities[index] +
            "\r\n" + "Food: " + Food[index];

            return data;
        }

        //this subprogram is to format the animal information in eahc habitat, using the parameter of index, sNames string, sDescription string
        //sPrices double array, sQauntities int array, sFood int array;
        //display animal information in the format of Name:, Description:, Prices:, Quantities:, and Food:
        string FormatAnimalData(int index, string[] sNames, string[] sDescriptions, double[] sPrices, int[] sQuantities, int[] sFood)
        {
            //declare string outcomr to store the formatted animal information            
            string format = "Name: " + sNames[index] +
            "\r\n" + "Description: " + sDescriptions[index] +
            "\r\n" + "Prices: " + sPrices[index] +
            "\r\n" + "Quantities: " + sQuantities[index] +
            "\r\n" + "Food: " + sFood[index];
            return format;
        }

        private void btnShowAscendingByQuantities_Click(object sender, EventArgs e)
        {
            //create temporary arrays that is the same length as the original arrays
            string[] tempNames = new string[Names.Length];
            string[] tempDescriptions = new string[Names.Length];
            int[] tempQuantities = new int[Names.Length];
            int[] tempFood = new int[Names.Length];
            double[] tempPrices = new double[Names.Length];

            //copy the objects in the orignal arrays to the temperary array, so that the original information does not get lost
            for (int a = 0; a < Names.Length; a++)
            {
                tempNames[a] = Names[a];
                tempDescriptions[a] = Descriptions[a];
                tempQuantities[a] = Quantities[a];
                tempFood[a] = Food[a];
                tempPrices[a] = Prices[a];
            }
            //loops the program inside that repeadtedly moves the bigger value that is bigger in 2 neighbour objects to the end side    
            //use names length -1 -k to loop without always going back from the firt element
            //the first element will automaticallly be sorted when the second elememnt gets sorted
            for (int k = 0; k < Names.Length; k++)
            {
                //swap the bigger element in two neighbour elemts to the end of the array 
                //we stop looping at "tosort.length - 1 -k" 
                //each time looping througth program, we stop looping 1 element early
                //since every time the soring is finished, one more element is sorted 
                //prevent always going back the very first one to sort again
                for (int i = 0; i < Names.Length - 1 - k; i++)
                {
                    //if the proceeding element is greater than the follwing element
                    if (tempQuantities[i] > tempQuantities[i + 1])
                    {
                        //temperorailly store the prior element
                        string Names1 = tempNames[i];
                        string Descriptions1 = tempDescriptions[i];
                        int Quantities1 = tempQuantities[i];
                        int Food1 = tempFood[i];
                        double Prices1 = tempPrices[i];
                        //make the proceeding one equal to the smaller, following element
                        tempNames[i] = tempNames[i + 1];
                        tempDescriptions[i] = tempDescriptions[i + 1];
                        tempQuantities[i] = tempQuantities[i + 1];
                        tempFood[i] = tempFood[i + 1];
                        tempPrices[i] = tempPrices[i + 1];
                        // make the following one equal to the prior element that is stored temperarily
                        tempNames[i + 1] = Names1;
                        tempDescriptions[i + 1] = Descriptions1;
                        tempQuantities[i + 1] = Quantities1;
                        tempFood[i + 1] = Food1;
                        tempPrices[i + 1] = Prices1;
                    }
                }
            }

            //after sorting, the information of each type of animals is displayed in the format with asceding order in quantities
            string[] result = new string[tempQuantities.Length];

            for (int b = 0; b < tempQuantities.Length; b++)
            {
                result[b] = FormatAnimalData(b, tempNames, tempDescriptions, tempPrices, tempQuantities, tempFood);
            }

            for (int i = 0; i < result.Length; i++)
            {
                lblDisplay.Text = lblDisplay.Text + result[i];
            }
        }

        private void btnShowDescendingByPrice_Click(object sender, EventArgs e)
        {
            // create identical copies of the original parallel arrays
            string[] sNames = new string[Names.Length];
            string[] sDescriptions = new string[Descriptions.Length];
            int[] sQuantities = new int[Quantities.Length];
            int[] sFood = new int[Food.Length];
            double[] sPrices = new double[Prices.Length];

            for (int i = 0; i < Names.Length; i++)
            {
                sNames[i] = Names[i];
                sDescriptions[i] = Descriptions[i];
                sQuantities[i] = Quantities[i];
                sFood[i] = Food[i];
                sPrices[i] = Prices[i];
            }

            // repeatedly moves the next lowest value to the end of the arrays
            for (int k = 0; k < Prices.Length; k++)
            {
                // stops looping 1 element sooner each time it loops
                for (int i = 0; i < Prices.Length - 1 - k; i++)
                {
                    // compares side-by-side values; if right one is bigger then swap with left one
                    if (sPrices[i] < sPrices[i + 1])
                    {
                        string tempNames = sNames[i];
                        string tempDescriptions = sDescriptions[i];
                        int tempQuantities = sQuantities[i];
                        int tempFood = sFood[i];
                        double tempPrices = sPrices[i];
                        sNames[i] = sNames[i + 1];
                        sDescriptions[i] = sDescriptions[i + 1];
                        sQuantities[i] = sQuantities[i + 1];
                        sFood[i] = sFood[i + 1];
                        sPrices[i] = sPrices[i + 1];
                        sNames[i + 1] = tempNames;
                        sDescriptions[i + 1] = tempDescriptions;
                        sQuantities[i + 1] = tempQuantities;
                        sFood[i + 1] = tempFood;
                        sPrices[i + 1] = tempPrices;
                    }
                }
            }

            // make new array and store all sorted information into the array, return the array
            string[] result = new string[sPrices.Length];
            for (int i = 0; i < sPrices.Length; i++)
            {
                result[i] = FormatAnimalData(i, sNames, sDescriptions, sPrices, sQuantities, sFood);
            }

            for (int i = 0; i < result.Length; i++)
            {
                lblDisplay.Text = lblDisplay.Text + result[i];
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (inputState == 1)
            {
                lblDisplay.Text = BuyExistingAnimals(money, txtNameSearch.Text);
            }
            else if (inputState==2 )
            {
                lblDisplay.Text = SellExistingAnimal(ref money, txtNameSearch.Text);

            }
            else if (inputState == 3)
            {
                if (txtNameSearch.Text != "" && txtDescriptionSearch.Text != "" && txtPriceSearch.Text != "")
                {
                    int.TryParse(txtPriceSearch.Text, out int price);
                    lblDisplay.Text=BuildNewHabitat(txtNameSearch.Text, txtDescriptionSearch.Text, price, ref money);
                }

                else
                {
                    lblDisplay.Text = "Please fill out all fields.";
                }
            }
            else if(inputState==4)
            {
                if (txtNameSearch.Text != "")
                {
                   lblDisplay.Text =  RemoveExistingHabitat(money, txtNameSearch.Text);
                }

                else
                {
                    lblDisplay.Text = "Please fill out all fields.";
                }
            }
            tmrOpenHours.Start();
            txtDescriptionSearch.Clear();
            txtNameSearch.Clear();
            txtPriceSearch.Clear();
            inputState = 0;
            lblMoney.Text = "$" + money.ToString();

        }

        private void TmrOpenHours_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 8)
            {
                daycount++;
                time = 0;
                lblDisplay.Text = EndTurn(ref money, ref daycount);
                lblMoney.Text = "$" + money.ToString();
            }
            lblDisplayDay.Text = daycount.ToString();
            int hours = 9 + time;
            lblTime.Text = hours.ToString() + " o'clock";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtDescriptionSearch.Clear();
            txtNameSearch.Clear();
            txtPriceSearch.Clear();
            inputState = 0;
            tmrOpenHours.Start();
        }

        private void BtnCancelled_Click(object sender, EventArgs e)
        {
            //searchIndex = 0
            pnlSearch.Hide();
            lblDisplay.Text = "";
        }

        private void BtnSearchBackwards_Click(object sender, EventArgs e)
        {
            sortedResultsIndex--;
            if (sortedResultsIndex<0)
            {
                sortedResultsIndex=0;
            }
            lblDisplay.Text = sortedResults[sortedResultsIndex];
        }

        private void BtnSearchForward_Click(object sender, EventArgs e)
        {
            sortedResultsIndex++;
            if (sortedResultsIndex <= sortedResults.Length)
            {
                sortedResultsIndex = sortedResults.Length - 1;
            }
            lblDisplay.Text = sortedResults[sortedResultsIndex];

        }
    }
}