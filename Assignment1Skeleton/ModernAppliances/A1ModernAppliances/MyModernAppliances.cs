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
      // Prompt the user to enter the item number of an appliance
      Console.WriteLine("Enter the item number of an appliance: ");
      // Create a variable to hold the item number
      long itemNum;
      // Get the user's input as a string
      string userIn = Console.ReadLine();
      // Convert the user's input from a string to a long integer
      itemNum = long.Parse(userIn);
      // Create a variable to hold the found appliance
      List<Appliance> foundAppliance = new List<Appliance>();
      // Loop through the list of appliances
      foreach (Appliance app in Appliances)
      {
          // Test if the appliance's item number matches the entered item number
          if (app.ItemNumber == itemNum)
          {
              // Assign the appliance to the foundAppliance variable
              foundAppliance.Add(app);
              // Break out of the loop
              break;
          }
      }
      // Test if no appliance was found
      if (foundAppliance.Count == 0)
      {
          // Write a message indicating that no appliances were found
          Console.WriteLine("No appliances found with that item number.");
      }
      else
      {
          // Get the first appliance from the foundAppliance list (since there should only be one)
          Appliance applianceToCheckout = foundAppliance[0];
          // Test if the appliance is available
          if (applianceToCheckout.IsAvailable == true)
          {
              // Check out the appliance
              applianceToCheckout.Checkout();

              // Write a message indicating that the appliance has been checked out
              Console.WriteLine("Appliance \"" + applianceToCheckout.ItemNumber.ToString() + "\" has been checked out.");
          }
          else
          {
              // Write a message indicating that the appliance is not available
              Console.WriteLine("The appliance is not available to be checked out.");
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
            // Get user input as string and assign to variable.
            string brand = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (Appliance app in Appliances) //Placeholder name
            {
                // Test current appliance brand matches what user entered
                if (app.Brand.Contains(brand))
                {
                    // Add current appliance in list to found list
                    found.Add(app);
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any\n2 - Double doors\n3 - Three doors\n4 - Four doors");
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors:");
            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int numOfDoors = Convert.ToInt32(Console.ReadLine());

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (Appliance app in Appliances) //List is place holder name
            {
                // Test that current appliance is a refrigerator
                if (app is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator fridge = (Refrigerator)app;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (numOfDoors == 0 | fridge.Doors == numOfDoors)
                    {
                        // Add current appliance in list to found list
                        found.Add(fridge);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any\n1 - Residential\n2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;

            switch (userInput)
            {
                // Test input is "0"
                case "0":
                    // Assign "Any" to grade
                    grade = "Any";
                    break;

                // Test input is "1"
                case "1":
                    // Assign "Residential" to grade
                    grade = "Residential";
                    break;

                // Test input is "2"
                case "2":
                    // Assign "Commercial" to grade
                    grade = "Commercial";
                    break;

                // Otherwise (input is something else)
                default:
                    // Write "Invalid option."
                    Console.WriteLine("Invalid option.");
                    // Return to calling (previous) method
                    return;
            }

            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any\n1 - 18 Volt\n2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");
            // Get user input as string
            userInput = Console.ReadLine();

            // Create variable to hold voltage
            int voltage;

            switch (userInput)
            {
                // Test input is "0"
                case "0":
                    // Assign 0 to voltage
                    voltage = 0;
                    break;

                // Test input is "1"
                case "1":
                    // Assign 18 to voltage
                    voltage = 18;
                    break;

                // Test input is "2"
                case "2":
                    // Assign 24 to voltage
                    voltage = 24;
                    break;

                // Otherwise
                default:
                    // Write "Invalid option."
                    Console.WriteLine("Invalid option.");
                    // Return to calling (previous) method
                    return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance app in Appliances) //Placeholder name
            {
                // Check if current appliance is vacuum
                if (app is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)app;

                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    if ((grade == "Any" | grade == vacuum.Grade) && (voltage == 0 | voltage == vacuum.BatteryVoltage))
                    {
                        // Add current appliance in list to found list
                        found.Add(vacuum);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any\n1 - Kitchen\n2 - Work site");
            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Create character variable that holds room type
            char roomType;

            switch (userInput)
            {
                // Test input is "0"
                case "0":
                    // Assign 'A' to room type variable
                    roomType = 'A';
                    break;

                // Test input is "1"
                case "1":
                    // Assign 'K' to room type variable
                    roomType = 'K';
                    break;

                // Test input is "2"
                case "2":
                    // Assign 'W' to room type variable
                    roomType = 'W';
                    break;

                // Otherwise (input is something else)
                default:
                    // Write "Invalid option."
                    Console.WriteLine("Invalid option.");
                    // Return to calling method
                    return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance app in Appliances) //Placeholder name
            {
                // Test current appliance is Microwave
                if (app is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)app;

                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' | roomType == microwave.RoomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(microwave);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("0 - Any\n1 - Quietest\n2 - Quieter\n3 - Quiet\n4 - Moderate");
            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Create variable that holds sound rating
            string sound;

            switch (userInput)
            {
                // Test input is "0"
                case "0":
                    // Assign "Any" to sound rating variable
                    sound = "Any";
                    break;

                // Test input is "1"
                case "1":
                    // Assign "Qt" to sound rating variable
                    sound = "Qt";
                    break;

                // Test input is "2"
                case "2":
                    // Assign "Qr" to sound rating variable
                    sound = "Qr";
                    break;

                // Test input is "3"
                case "3":
                    // Assign "Qu" to sound rating variable
                    sound = "Qu";
                    break;

                // Test input is "4"
                case "4":
                    // Assign "M" to sound rating variable
                    sound = "M";
                    break;

                // Otherwise (input is something else)
                default:
                    // Write "Invalid option."
                    Console.WriteLine("Invalid option.");
                    // Return to calling method
                    return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance app in Appliances) //Placeholder name
            {
                // Test if current appliance is dishwasher
                if (app is Dishwasher)
                {
                    // Down cast current Appliance to Dishwasher
                    Dishwasher washer = (Dishwasher)app;

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (sound == "Any" | sound == washer.SoundRating)
                    {
                        // Add current appliance in list to found list
                        found.Add(washer);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("0 - Any\n1 - Refrigerators\n2 - Vacuums\n3 - Microwaves\n4 - Dishwashers");
            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");
            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances:");
            // Get user input as string and assign to variable
            // Convert user input from string to int
            int num = Convert.ToInt32(Console.ReadLine());

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through appliances
            foreach (Appliance app in Appliances) //list name is placeholder
            {
                switch (applianceType)
                {
                    // Test inputted appliance type is "0"
                    case "0":
                        // Add current appliance in list to found list
                        found.Add(app);
                        break;

                    // Test inputted appliance type is "1"
                    case "1":
                        // Test current appliance type is Refrigerator
                        if (app is Refrigerator)
                        {
                            // Add current appliance in list to found list
                            found.Add(app); //will fix later
                        }
                        break;

                    // Test inputted appliance type is "2"
                    case "2":
                        // Test current appliance type is Vacuum
                        if (app is Vacuum)
                        {
                            // Add current appliance in list to found list
                            found.Add(app);
                        }
                        break;

                    // Test inputted appliance type is "3"
                    case "3":
                        // Test current appliance type is Microwave
                        if (app is Microwave)
                        {
                            // Add current appliance in list to found list
                            found.Add(app);
                        }
                        break;

                    // Test inputted appliance type is "4"
                    case "4":
                        // Test current appliance type is Dishwasher
                        if (app is Dishwasher)
                        {
                            // Add current appliance in list to found list
                            found.Add(app);
                        }
                        break;   
                }
            }
            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, num);
        }
    }
}
