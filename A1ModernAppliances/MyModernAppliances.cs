using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance:\n");

            // Create long variable to hold item number
            long itemNumber;

            // Get user input as string and assign to variable.
            string enteredNum = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            itemNumber = long.Parse(enteredNum);

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            List<Appliance> foundAppliance = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == long.Parse(enteredNum))
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance.Add(appliance);

                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance.Count == 0)
            {

                // Write "No appliances found with that item number."
                Console.WriteLine("No Appliances found with that number.");
            }
            // Otherwise (appliance was found)
            else
            {
                Appliance applianceCheckout = foundAppliance[0];
                // Test found appliance is available
                if (applianceCheckout.IsAvailable == true)
                {
                    // Checkout found appliance
                    applianceCheckout.Checkout();

                    // Write "Appliance has been checked out."
                    Console.WriteLine($"Appliance \"{enteredNum}\" has been checked out.");
                }
                // Otherwise (appliance isn't available)
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance isn't available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            string enteredBrand = Console.ReadLine();


            // Create list to hold found Appliance objects
            List<Appliance> foundAppliancesList = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (Appliance appliance in Appliances) // assuming 'appliances' is a collection of all appliances
            {
                if (appliance.Brand.Contains(enteredBrand))
                {
                    // Add current appliance in list to found list
                    foundAppliancesList.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliancesList, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible Options:");

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any\n2 - Double doors\n3 - Three doors\n4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors:");

            // Create variable to hold entered number of doors
            int doorNum;

            // Get user input as string and assign to variable
            string enteredDoors = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            doorNum = Convert.ToInt32(enteredDoors);

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (doorNum == 0 | refrigerator.Doors == doorNum)
                    {
                        // Add current appliance in list to found list
                        foundAppliances.Add(refrigerator);

                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);

        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            Console.WriteLine("Possible options:\n0 - Any\n1 - Residential\n2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");

            // Get user input as string and assign to variable
            string enteredGrade = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string Grade = "";

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling (previous) method
            //return;

            if (enteredGrade == "0")
            {
                Grade = "Any";
            }
            else if (enteredGrade == "1")
            {
                Grade = "Residential";
            }
            else if (enteredGrade == "2")
            {
                Grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }

            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("Possible options:\n0 - Any\n1 - 18 Volt\n2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter Voltage");

            // Get user input as string
            string enteredVoltage = Console.ReadLine();

            // Create variable to hold voltage
            string voltage = "";

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            if (enteredVoltage == "0")
            {
                voltage = "0";
            }
            else if (enteredVoltage == "1")
            {
                voltage = "18";
            }
            else if (enteredVoltage == "2")
            {
                voltage = "24";
            }
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> foundAppliancesList = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum1 = (Vacuum)appliance;

                    bool gradeMatches = Grade == "Any" || Grade == vacuum.Grade;

                    bool voltageMatches = voltage == "0" || voltage == vacuum.BatteryVoltage.ToString();

                    if (gradeMatches && voltageMatches)
                    {
                        // Add current appliance in list to found list
                        foundAppliancesList.Add(vacuum1);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(foundAppliancesList, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("Possible options:\n0 - Any\n1 - Kitchen\n2 - Work Site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");

            // Get user input as string
            string enteredRoomType = Console.ReadLine();

            // Create character variable that holds room type
            char roomType;

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            switch (enteredRoomType)
            {
                case "0":
                    roomType = 'A';
                    break;
                case "1":
                    roomType = 'K';
                    break;
                case "2":
                    roomType = 'W';
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> foundAppliancesList = new List<Appliance>();

            // Loop through Appliances

            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list


            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave microwave)
                {
                    Microwave microwave1 = (Microwave)appliance;

                    if (roomType == microwave.RoomType)
                    {
                        foundAppliancesList.Add(appliance);
                    }
                }
                // Display found appliances
                DisplayAppliancesFromList(foundAppliancesList, 0);
            }
        }


        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            Console.WriteLine("Possible options:\n0 - Any\n1 - Quietest\n2 - Quieter\n3 - Quiet\n4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter room type: ");

            // Get user input as string and assign to variable
            string enteredSoundRating = Console.ReadLine();

            // Create variable that holds sound rating
            string soundRating = "";

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            switch (enteredSoundRating)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> foundAppliancesList = new List<Appliance>();

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher dishwasher)
                {
                    Dishwasher microwave1 = (Dishwasher)appliance;

                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        foundAppliancesList.Add(appliance);
                    }
                }
            }

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(foundAppliancesList, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("Appliance Types:\n0 - Any\n1 - Refridgerators\n2 - Vacuums\n3 - Microwaves\n4 - Dishwasher");

            // Write "Enter type of appliance: "
            Console.WriteLine("Enter type of appliance");

            // Get user input as string and assign to appliance type variable
            string enteredType = Console.ReadLine();

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances");

            // Get user input as string and assign to variable
            string enteredNumAppliances = Console.ReadLine();

            // Convert user input from string to int
            int applianceAmount = Int32.Parse(enteredNumAppliances);

            // Create variable to hold list of found appliances
            List<Appliance> foundAppliancesList = new List<Appliance>();

            // Loop through appliances

            // Test inputted appliance type is "0"
            // Add current appliance in list to found list

            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list

            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list

            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list

            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            foreach (Appliance appliance in Appliances)
            {
                if (enteredType == "0")
                {
                    foundAppliancesList.Add(appliance);
                }
                else if (enteredType == "1" && appliance is Refrigerator)
                {
                    foundAppliancesList.Add(appliance);
                }
                else if (enteredType == "2" && appliance is Vacuum)
                {
                    foundAppliancesList.Add(appliance);
                }
                else if (enteredType == "3" && appliance is Microwave)
                {
                    foundAppliancesList.Add(appliance);
                }
                else if (enteredType == "4" && appliance is Dishwasher)
                {
                    foundAppliancesList.Add(appliance);
                }
            }

            // Randomize list of found appliances
            foundAppliancesList.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(foundAppliancesList, applianceAmount);
        }
    }
}
